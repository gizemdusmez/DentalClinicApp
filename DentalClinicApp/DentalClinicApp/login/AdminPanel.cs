using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace DentalClinicApp
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            LoadUsers(); 
        }

        // Kullanıcı listesini yükler ve GridControl'e bağlar
        private void LoadUsers()
        {
            try
            {
                string query = "SELECT username AS 'Kullanıcı Adı', role AS 'Rol' FROM userlogin WHERE role IN ('User', 'Admin')";
                DataTable usersTable = DatabaseHelper.ExecuteQuery(query);

                gridControl1.DataSource = usersTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kullanıcılar yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.FormClosed += (s, args) => LoadUsers(); // Kullanıcı eklendikten sonra listeyi yenile
            addUserForm.ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // GridView'de seçili satırdan "Kullanıcı Adı" hücresini al
            if (gridView1.GetFocusedRowCellValue("Kullanıcı Adı") is string username)
            {
                DialogResult result = MessageBox.Show(
                    $"{username} adlı kullanıcıyı silmek istediğinize emin misiniz?",
                    "Kullanıcı Sil",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = "DELETE FROM userlogin WHERE username = @username AND role IN ('User', 'Admin')";
                        var parameters = new Dictionary<string, object>
                        {
                            { "@username", username }
                        };

                        DatabaseHelper.ExecuteNonQuery(query, parameters);
                        MessageBox.Show("Kullanıcı başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers(); // Listeyi yenile
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Admin paneli kapandığında kullanıcı formuna geri dön
        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            FluentDesignForm1 userForm = new FluentDesignForm1();
            userForm.Show();
        }
    }
}







