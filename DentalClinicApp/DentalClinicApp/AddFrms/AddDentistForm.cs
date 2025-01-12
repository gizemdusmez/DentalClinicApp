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
    public partial class AddDentistForm : Form
    {
        private bool _isEditMode; // Düzenleme modunda olup olmadığını kontrol eder.
        private string _dentistId; // Düzenlenecek diş hekiminin ID'si.

        public AddDentistForm()
        {
            InitializeComponent();
            Text = "Yeni Diş Hekimi Ekle";
        }

        public AddDentistForm(string dentistId, bool isEditMode)
        {
            InitializeComponent();
            _dentistId = dentistId;
            _isEditMode = isEditMode;

            if (_isEditMode)
            {
                LoadDentistData();
                Text = "Diş Hekimi Düzenle";
                btnSave.Text = "Güncelle";
            }
        }

        private void LoadDentistData()
        {
            try
            {
                string query = "SELECT * FROM Dentist WHERE dentist_id = @dentist_id";
                var parameters = new Dictionary<string, object>
                {
                    { "@dentist_id", _dentistId }
                };

                var result = DatabaseHelper.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    var row = result.Rows[0];
                    txtName.Text = row["name"].ToString();
                    txtSurname.Text = row["surname"].ToString();
                    cmbspecial.Text = row["specialization"].ToString();
                    txtPhone.Text = row["phone"].ToString();
                    txtEmail.Text = row["email"].ToString();
                    dtHideStrt.EditValue = Convert.ToDateTime(row["hire_date"]);
                }
                else
                {
                    MessageBox.Show("Diş hekimi bilgisi bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string specialization = cmbspecial.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            DateTime? hireDate = dtHideStrt.EditValue as DateTime?;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(specialization) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) || hireDate == null)
            {
                MessageBox.Show("Lütfen tüm zorunlu alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_isEditMode)
                {
                    UpdateDentist(name, surname, specialization, phone, email, hireDate.Value);
                }
                else
                {
                    AddNewDentist(name, surname, specialization, phone, email, hireDate.Value);
                }

                MessageBox.Show(_isEditMode ? "Diş hekimi başarıyla güncellendi." : "Diş hekimi başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewDentist(string name, string surname, string specialization, string phone, string email, DateTime hireDate)
        {
            string query = @"
                INSERT INTO Dentist (name, surname, specialization, phone, email, hire_date)
                VALUES (@name, @surname, @specialization, @phone, @email, @hire_date)";

            var parameters = new Dictionary<string, object>
            {
                { "@name", name },
                { "@surname", surname },
                { "@specialization", specialization },
                { "@phone", phone },
                { "@email", email },
                { "@hire_date", hireDate }
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        private void UpdateDentist(string name, string surname, string specialization, string phone, string email, DateTime hireDate)
        {
            string query = @"
                UPDATE Dentist
                SET name = @name, surname = @surname, specialization = @specialization,
                    phone = @phone, email = @email, hire_date = @hire_date
                WHERE dentist_id = @dentist_id";

            var parameters = new Dictionary<string, object>
            {
                { "@dentist_id", _dentistId },
                { "@name", name },
                { "@surname", surname },
                { "@specialization", specialization },
                { "@phone", phone },
                { "@email", email },
                { "@hire_date", hireDate }
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }
    }
}

