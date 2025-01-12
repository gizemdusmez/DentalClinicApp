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
    public partial class AddUserForm : Form
    {
        private bool _isEditMode; // Kullanıcının düzenleme modunda olup olmadığını kontrol eder.
        private string _username; // Düzenlenecek kullanıcının adı.

        public AddUserForm()
        {
            InitializeComponent();
            Text = "Yeni Kullanıcı Ekle";
            InitializeRoleComboBox(); // Rolleri yükle
        }

        public AddUserForm(string username, bool isEditMode)
        {
            InitializeComponent();
            _username = username;
            _isEditMode = isEditMode;

            InitializeRoleComboBox(); // Rolleri yükle

            if (_isEditMode)
            {
                LoadUserData();
                Text = "Kullanıcı Düzenle";
                btnSave.Text = "Güncelle";
            }
        }

        private void InitializeRoleComboBox()
        {
            // Role seçim kutusuna sadece User ve Admin değerlerini ekle
            cmbRole.Items.Clear();
            cmbRole.Items.Add("User");
            cmbRole.Items.Add("Admin");
            cmbRole.SelectedIndex = 0; // Varsayılan olarak ilk rolü seç
        }

        private void LoadUserData()
        {
            try
            {
                string query = "SELECT username, role FROM userlogin WHERE username = @username";
                var parameters = new Dictionary<string, object>
                {
                    { "@username", _username }
                };

                var result = DatabaseHelper.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    txtUsername.Text = result.Rows[0]["username"].ToString();
                    cmbRole.Text = result.Rows[0]["role"].ToString();
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.Text.Trim();

            if (string.IsNullOrEmpty(username) || (!_isEditMode && string.IsNullOrEmpty(password)) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (role != "User" && role != "Admin")
            {
                MessageBox.Show("Geçersiz rol. Lütfen sadece 'User' veya 'Admin' seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_isEditMode)
                {
                    UpdateUser(username, role);
                }
                else
                {
                    AddNewUser(username, password, role);
                }

                MessageBox.Show(_isEditMode ? "Kullanıcı başarıyla güncellendi." : "Kullanıcı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewUser(string username, string password, string role)
        {
            string query = "INSERT INTO userlogin (username, password, role) VALUES (@username, @password, @role)";
            var parameters = new Dictionary<string, object>
            {
                { "@username", username },
                { "@password", password },
                { "@role", role }
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        // Kullanıcı bilgilerini güncelleme 
        private void UpdateUser(string username, string role)
        {
            string query = "UPDATE userlogin SET role = @role WHERE username = @username";
            var parameters = new Dictionary<string, object>
            {
                { "@username", username },
                { "@role", role }
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }
    }
}





