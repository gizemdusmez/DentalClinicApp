using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using DentalClinicApp;
using DevExpress.XtraEditors;

namespace DentalClinicApp
{
    public partial class login_frm : DevExpress.XtraEditors.XtraForm
    {
        public login_frm()
        {
            InitializeComponent();
            TestDatabaseConnection();
        }

        private void TestDatabaseConnection()
        {
            try
            {
                string query = "SELECT 1"; // Veritabanı bağlantısını test etmek için sorgu
                MessageBox.Show("Veritabanı bağlantısı başarılı!", "Bağlantı Testi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı bağlantısı başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // DevExpress tema ayarları
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            // Formun köşelerini yuvarlama
            GraphicsPath path = new GraphicsPath();
            int radius = 300; // Yuvarlaklık derecesi
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius - 1, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(this.Width - radius - 1, this.Height - radius - 1, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius - 1, radius, radius), 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(79, 79, 98);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(39, 39, 58);
        }

        // Panel arka planında gradyan renk geçişi
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                panelControl1.ClientRectangle,
                Color.FromArgb(39, 39, 58),
                Color.FromArgb(59, 59, 108),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, panelControl1.ClientRectangle);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kullanıcı giriş sorgusu
                string query = "SELECT role FROM userlogin WHERE username = @username AND password = @password";
                var parameters = new Dictionary<string, object>
                {
                    { "@username", username },
                    { "@password", password }
                };

                DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    string role = result.Rows[0]["role"].ToString(); // Kullanıcının rolü

                    // Kullanıcı oturum bilgilerini sakla
                    CurrentUser.Username = username;
                    CurrentUser.Role = role;

                    MessageBox.Show($"Hoşgeldiniz, {username}! Rolünüz: {role}.", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Kullanıcı rolüne göre yönlendirme
                    this.Hide();
                    switch (role)
                    {
                        case "Admin":
                            AdminPanel adminPanel = new AdminPanel();
                            adminPanel.ShowDialog();
                            break;

                        case "User":
                            FluentDesignForm1 userForm = new FluentDesignForm1();
                            userForm.ShowDialog();
                            break;

                        default:
                            MessageBox.Show("Tanımsız rol! Lütfen yöneticinizle iletişime geçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Show();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }

    // Kullanıcı oturum bilgilerini saklama
    public static class CurrentUser
    {
        public static string Username { get; set; }
        public static string Role { get; set; }
    }
}


