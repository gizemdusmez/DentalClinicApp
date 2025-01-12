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
    public partial class AddPatientForm : Form
    {
        private bool _isEditMode; // Düzenleme modunda olup olmadığını kontrol eder.
        private string _patientId; // Düzenlenecek hastanın ID'si.

        public AddPatientForm()
        {
            InitializeComponent();
            Text = "Yeni Hasta Ekle";
        }

        public AddPatientForm(string patientId, bool isEditMode)
        {
            InitializeComponent();
            _patientId = patientId;
            _isEditMode = isEditMode;

            if (_isEditMode)
            {
                LoadPatientData();
                Text = "Hasta Düzenle";
                btnSave.Text = "Güncelle";
            }
        }

        private void LoadPatientData()
        {
            try
            {
                string query = "SELECT * FROM Patient WHERE patient_id = @patient_id";
                var parameters = new Dictionary<string, object>
                {
                    { "@patient_id", _patientId }
                };

                var result = DatabaseHelper.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    var row = result.Rows[0];
                    txtTcNo.Text = row["tc_no"].ToString();
                    txtName.Text = row["name"].ToString();
                    txtSurname.Text = row["surname"].ToString();
                    cmbGender.Text = row["gender"].ToString();
                    dtBirthDate.EditValue = Convert.ToDateTime(row["birth_date"]);
                    textEdit1.Text = row["allergies"].ToString();
                }
                else
                {
                    MessageBox.Show("Hasta bilgisi bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string tcNo = txtTcNo.Text.Trim();
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string gender = cmbGender.Text.Trim();
            DateTime? birthDate = dtBirthDate.EditValue as DateTime?;
            string allergies = textEdit1.Text.Trim();

            if (string.IsNullOrEmpty(tcNo) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(gender) || birthDate == null)
            {
                MessageBox.Show("Lütfen tüm zorunlu alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_isEditMode)
                {
                    UpdatePatient(tcNo, name, surname, gender, birthDate.Value, allergies);
                }
                else
                {
                    AddNewPatient(tcNo, name, surname, gender, birthDate.Value, allergies);
                }

                MessageBox.Show(_isEditMode ? "Hasta başarıyla güncellendi." : "Hasta başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewPatient(string tcNo, string name, string surname, string gender, DateTime birthDate, string allergies)
        {
            string query = @"
                INSERT INTO Patient (tc_no, name, surname, gender, birth_date, allergies)
                VALUES (@tc_no, @name, @surname, @gender, @birth_date, @allergies)";

            var parameters = new Dictionary<string, object>
            {
                { "@tc_no", tcNo },
                { "@name", name },
                { "@surname", surname },
                { "@gender", gender },
                { "@birth_date", birthDate },
                { "@allergies", allergies }
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        private void UpdatePatient(string tcNo, string name, string surname, string gender, DateTime birthDate, string allergies)
        {
            string query = @"
                UPDATE Patient
                SET tc_no = @tc_no, name = @name, surname = @surname, gender = @gender, birth_date = @birth_date, allergies = @allergies
                WHERE patient_id = @patient_id";

            var parameters = new Dictionary<string, object>
            {
                { "@patient_id", _patientId },
                { "@tc_no", tcNo },
                { "@name", name },
                { "@surname", surname },
                { "@gender", gender },
                { "@birth_date", birthDate },
                { "@allergies", allergies }
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }
    }
}

