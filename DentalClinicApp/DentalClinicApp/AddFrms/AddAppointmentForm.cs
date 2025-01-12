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
    public partial class AddAppointmentForm : Form
    {
        private readonly string _appointmentId; // Düzenlenecek randevunun ID'si.
        private readonly bool _isEditMode; // Düzenleme modunda olup olmadığını kontrol eder.

        public AddAppointmentForm()
        {
            InitializeComponent();
            LoadPatients();
            LoadDentists();
            Text = "Yeni Randevu Ekle";
        }

        public AddAppointmentForm(string appointmentId, bool isEditMode)
        {
            InitializeComponent();
            _appointmentId = appointmentId;
            _isEditMode = isEditMode;

            LoadPatients();
            LoadDentists();

            if (_isEditMode)
            {
                LoadAppointmentData();
                Text = "Randevu Düzenle";
                btnSave.Text = "Güncelle";
            }
        }

        private void LoadPatients()
        {
            try
            {
                string query = "SELECT patient_id, name || ' ' || surname AS full_name FROM Patient";
                var result = DatabaseHelper.ExecuteQuery(query);

                foreach (DataRow row in result.Rows)
                {
                    cmbPatient.Properties.Items.Add(new KeyValuePair<int, string>(
                        Convert.ToInt32(row["patient_id"]),
                        row["full_name"].ToString()
                    ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hasta bilgileri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDentists()
        {
            try
            {
                string query = "SELECT dentist_id, name || ' ' || surname AS full_name FROM Dentist";
                var result = DatabaseHelper.ExecuteQuery(query);

                foreach (DataRow row in result.Rows)
                {
                    cmbDentist.Properties.Items.Add(new KeyValuePair<int, string>(
                        Convert.ToInt32(row["dentist_id"]),
                        row["full_name"].ToString()
                    ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Diş hekimi bilgileri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAppointmentData()
        {
            try
            {
                string query = "SELECT * FROM Appointment WHERE appointment_id = @appointment_id";
                var parameters = new Dictionary<string, object>
        {
            { "@appointment_id", _appointmentId }
        };

                var result = DatabaseHelper.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    var row = result.Rows[0];

                    // Hasta ve diş hekimi seçimleri
                    int patientId = Convert.ToInt32(row["patient_id"]);
                    int dentistId = Convert.ToInt32(row["dentist_id"]);

                    foreach (var item in cmbPatient.Properties.Items)
                    {
                        if (item is KeyValuePair<int, string> pair && pair.Key == patientId)
                        {
                            cmbPatient.SelectedItem = item;
                            break;
                        }
                    }

                    foreach (var item in cmbDentist.Properties.Items)
                    {
                        if (item is KeyValuePair<int, string> pair && pair.Key == dentistId)
                        {
                            cmbDentist.SelectedItem = item;
                            break;
                        }
                    }

                    // Tarih
                    dteAppointmentDate.EditValue = Convert.ToDateTime(row["appointment_date"]);

                    // Saat
                    string appointmentTime = row["appointment_time"].ToString();
                    if (TimeSpan.TryParse(appointmentTime, out TimeSpan parsedTime))
                    {
                        timeEdit1.EditValue = parsedTime;
                    }
                    else if (DateTime.TryParse(appointmentTime, out DateTime dateTime))
                    {
                        timeEdit1.EditValue = dateTime.TimeOfDay;
                    }
                    else
                    {
                        MessageBox.Show("Randevu saat bilgisi hatalı: " + appointmentTime, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Durum ve notlar
                    comboBoxEdit1.Text = row["status"].ToString();
                    textEdit1.Text = row["notes"].ToString();
                }
                else
                {
                    MessageBox.Show("Randevu bilgisi bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedItem == null || cmbDentist.SelectedItem == null || dteAppointmentDate.EditValue == null ||
                timeEdit1.EditValue == null || string.IsNullOrEmpty(comboBoxEdit1.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedPatient = (KeyValuePair<int, string>)cmbPatient.SelectedItem;
            var selectedDentist = (KeyValuePair<int, string>)cmbDentist.SelectedItem;

            try
            {
                if (_isEditMode)
                {
                    UpdateAppointment(selectedPatient.Key, selectedDentist.Key);
                }
                else
                {
                    AddNewAppointment(selectedPatient.Key, selectedDentist.Key);
                }

                MessageBox.Show(_isEditMode ? "Randevu başarıyla güncellendi." : "Randevu başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewAppointment(int patientId, int dentistId)
        {
            string query = @"
                INSERT INTO Appointment (patient_id, dentist_id, appointment_date, appointment_time, status, notes)
                VALUES (@patient_id, @dentist_id, @appointment_date, @appointment_time, @status, @notes)";

            var parameters = new Dictionary<string, object>
            {
                { "@patient_id", patientId },
                { "@dentist_id", dentistId },
                { "@appointment_date", dteAppointmentDate.DateTime.ToString("yyyy-MM-dd") },
                { "@appointment_time", timeEdit1.Time.ToString(@"hh\:mm\:ss") },
                { "@status", comboBoxEdit1.Text },
                { "@notes", textEdit1.Text }
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        private void UpdateAppointment(int patientId, int dentistId)
        {
            string query = @"
                UPDATE Appointment
                SET patient_id = @patient_id, dentist_id = @dentist_id,
                    appointment_date = @appointment_date, appointment_time = @appointment_time,
                    status = @status, notes = @notes
                WHERE appointment_id = @appointment_id";

            var parameters = new Dictionary<string, object>
            {
                { "@appointment_id", _appointmentId },
                { "@patient_id", patientId },
                { "@dentist_id", dentistId },
                { "@appointment_date", dteAppointmentDate.DateTime.ToString("yyyy-MM-dd") },
                { "@appointment_time", timeEdit1.Time.ToString(@"hh\:mm\:ss") },
                { "@status", comboBoxEdit1.Text },
                { "@notes", textEdit1.Text }
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        //Greedy Algorithm
        private string FindAvailableTime(int doctorId, DateTime selectedDate)
        {
            string availableTime = "";
            List<string> busyTimes = new List<string>();

            try
            {
                // Mevcut randevuları al
                string query = @"
            SELECT appointment_time 
            FROM Appointment 
            WHERE dentist_id = @doctorId AND appointment_date = @selectedDate";
                var parameters = new Dictionary<string, object>
        {
            { "@doctorId", doctorId },
            { "@selectedDate", selectedDate.ToString("yyyy-MM-dd") }
        };

                DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

                foreach (DataRow row in result.Rows)
                {
                    busyTimes.Add(Convert.ToDateTime(row["appointment_time"]).ToString("HH:mm"));
                }

                // Mesai saatlerini kontrol et (08:00 - 17:00)
                DateTime startTime = selectedDate.Date.AddHours(8);
                DateTime endTime = selectedDate.Date.AddHours(17);

                while (startTime < endTime)
                {
                    string timeSlot = startTime.ToString("HH:mm");

                    // Eğer bu zaman dilimi dolu değilse
                    if (!busyTimes.Contains(timeSlot))
                    {
                        availableTime = timeSlot;
                        break;
                    }

                    startTime = startTime.AddMinutes(15); // 15 dakika ileri git
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return availableTime;
        }



        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {

        }

        // Uygun saat kontrol butonu
        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            if (cmbDentist.SelectedItem is KeyValuePair<int, string> selectedDoctor)
            {
                int doctorId = selectedDoctor.Key;
                DateTime selectedDate = dteAppointmentDate.DateTime;

                string suggestedTime = FindAvailableTime(doctorId, selectedDate);

                if (!string.IsNullOrEmpty(suggestedTime))
                {
                    MessageBox.Show($"Önerilen Randevu Saati: {suggestedTime}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timeEdit1.Time = DateTime.Today.Add(TimeSpan.Parse(suggestedTime));
                }
                else
                {
                    MessageBox.Show("Seçilen tarihte uygun zaman yok.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir doktor seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}













