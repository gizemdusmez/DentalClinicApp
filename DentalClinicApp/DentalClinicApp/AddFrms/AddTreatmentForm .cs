using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using DevExpress.XtraEditors; 
using System.Collections.Generic;


namespace DentalClinicApp
{
    public partial class AddTreatmentForm : Form
    {
        private bool _isEditMode; // Düzenleme modunda olup olmadığını kontrol eder.
        private string _treatmentId; // Düzenlenecek tedavinin ID'si.

        public AddTreatmentForm()
        {
            InitializeComponent();
            LoadAppointmentIds();
            LoadPaidOptions();
            Text = "Yeni Tedavi Ekle";
        }

        public AddTreatmentForm(string treatmentId, bool isEditMode)
        {
            InitializeComponent();
            _treatmentId = treatmentId;
            _isEditMode = isEditMode;

            LoadAppointmentIds();
            LoadPaidOptions();

            if (_isEditMode)
            {
                LoadTreatmentData();
                Text = "Tedavi Düzenle";
                btnSave.Text = "Güncelle";
            }
        }

        private void LoadAppointmentIds()
        {
            try
            {
                string query = "SELECT appointment_id FROM Appointment";
                var result = DatabaseHelper.ExecuteQuery(query);

                foreach (DataRow row in result.Rows)
                {
                    cmbAppointment_id.Properties.Items.Add(row["appointment_id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Randevu bilgileri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPaidOptions()
        {
            cmbPaid.Properties.Items.Add("Ödendi");
            cmbPaid.Properties.Items.Add("Ödenmedi");
        }

        private void LoadTreatmentData()
        {
            try
            {
                string query = "SELECT * FROM Treatment WHERE treatment_id = @treatment_id";
                var parameters = new Dictionary<string, object>
                {
                    { "@treatment_id", _treatmentId }
                };

                var result = DatabaseHelper.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    var row = result.Rows[0];
                    cmbAppointment_id.Text = row["appointment_id"].ToString();
                    txtTreatmentType.Text = row["treatment_type"].ToString();
                    txtCost.Text = Convert.ToDecimal(row["cost"]).ToString("F2");
                    dtDatePerformed.EditValue = Convert.ToDateTime(row["date_performed"]);
                    cmbPaid.Text = row["is_paid"].ToString() == "1" ? "Ödendi" : "Ödenmedi";
                    txtDescription.Text = row["description"]?.ToString() ?? string.Empty;
                }
                else
                {
                    MessageBox.Show("Tedavi bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tedavi bilgileri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbAppointment_id.Text) ||
                string.IsNullOrWhiteSpace(txtTreatmentType.Text) ||
                string.IsNullOrWhiteSpace(txtCost.Text) ||
                string.IsNullOrWhiteSpace(cmbPaid.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtCost.Text, out decimal cost))
            {
                MessageBox.Show("Lütfen geçerli bir maliyet giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtDatePerformed.EditValue == null || !DateTime.TryParse(dtDatePerformed.EditValue.ToString(), out DateTime datePerformed))
            {
                MessageBox.Show("Lütfen geçerli bir tarih seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_isEditMode)
                {
                    UpdateTreatment(cost, datePerformed);
                }
                else
                {
                    AddNewTreatment(cost, datePerformed);
                }

                MessageBox.Show(_isEditMode ? "Tedavi başarıyla güncellendi!" : "Tedavi başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewTreatment(decimal cost, DateTime datePerformed)
        {
            string query = @"
                INSERT INTO Treatment (appointment_id, treatment_type, description, cost, date_performed, is_paid)
                VALUES (@appointment_id, @treatment_type, @description, @cost, @date_performed, @is_paid)";

            var parameters = new Dictionary<string, object>
            {
                { "@appointment_id", cmbAppointment_id.Text },
                { "@treatment_type", txtTreatmentType.Text },
                { "@description", txtDescription.Text },
                { "@cost", cost },
                { "@date_performed", datePerformed },
                { "@is_paid", cmbPaid.Text == "Ödendi" ? 1 : 0 }
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        private void UpdateTreatment(decimal cost, DateTime datePerformed)
        {
            string query = @"
                UPDATE Treatment
                SET appointment_id = @appointment_id,
                    treatment_type = @treatment_type,
                    description = @description,
                    cost = @cost,
                    date_performed = @date_performed,
                    is_paid = @is_paid
                WHERE treatment_id = @treatment_id";

            var parameters = new Dictionary<string, object>
            {
                { "@treatment_id", _treatmentId },
                { "@appointment_id", cmbAppointment_id.Text },
                { "@treatment_type", txtTreatmentType.Text },
                { "@description", txtDescription.Text },
                { "@cost", cost },
                { "@date_performed", datePerformed },
                { "@is_paid", cmbPaid.Text == "Ödendi" ? 1 : 0 }
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }
    }
}





