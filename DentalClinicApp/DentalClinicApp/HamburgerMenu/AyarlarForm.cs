using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalClinicApp
{
    public partial class AyarlarForm : Form
    {
        public AyarlarForm()
        {
            InitializeComponent();
        }

        private void AyarlarForm_Load(object sender, EventArgs e)
        {
            // Eğer oturum bilgilerini göstermek istiyorsanız
            if (!string.IsNullOrEmpty(CurrentUser.Username))
            {
                labelCurrentUser.Text = $"Kullanıcı: {CurrentUser.Username}"; // Kullanıcı adını göstermek için
            }
        }

        // Şifre yenileme işlemi
        private void btnYenile_Click(object sender, EventArgs e)
        {
            string currentPassword = txtMevcutSİfre.Text.Trim();
            string newPassword = txtYeniSifre.Text.Trim();
            string confirmPassword = txtYeniSifreTekrar.Text.Trim();

            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Yeni şifreler birbiriyle uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "SELECT password FROM userlogin WHERE username = @username";
                var parameters = new Dictionary<string, object>
                {
                    { "@username", CurrentUser.Username }
                };

                var result = DatabaseHelper.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0 && result.Rows[0]["password"].ToString() == currentPassword)
                {
                    // Şifreyi güncelle
                    string updateQuery = "UPDATE userlogin SET password = @newPassword WHERE username = @username";
                    var updateParameters = new Dictionary<string, object>
                    {
                        { "@newPassword", newPassword },
                        { "@username", CurrentUser.Username }
                    };

                    DatabaseHelper.ExecuteNonQuery(updateQuery, updateParameters);

                    MessageBox.Show("Şifre başarıyla değiştirildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Alanları temizle
                    txtMevcutSİfre.Text = "";
                    txtYeniSifre.Text = "";
                    txtYeniSifreTekrar.Text = "";
                }
                else
                {
                    MessageBox.Show("Mevcut şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kullanıcı çıkış yapma işlemi
        private void pnlLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Çıkış yaparak giriş ekranına dönmek istediğinize emin misiniz?",
                "Çıkış Yap",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Oturum bilgilerini temizle
                CurrentUser.Username = null;
                CurrentUser.Role = null;

                // Şu anki formu gizle
                this.Hide();

                // Login formunu aç
                login_frm loginForm = new login_frm();
                loginForm.Show();
            }
        }

        
    }
}
