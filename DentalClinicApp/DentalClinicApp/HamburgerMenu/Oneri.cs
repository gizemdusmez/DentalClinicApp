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
    public partial class Oneri : Form
    {
        public Oneri()
        {
            InitializeComponent();
        }

        private void btnCheckDensity_Click(object sender, EventArgs e)
        {
            CheckAppointmentDensity();
        }

        private void CheckAppointmentDensity()
        {
            try
            {
                // Appointment tablosundan yoğun günleri bulmak için sorgu
                string query = @"
            SELECT 
                appointment_date, 
                COUNT(*) AS total_appointments 
            FROM 
                Appointment 
            GROUP BY 
                appointment_date 
            ORDER BY 
                total_appointments DESC;";

                // DatabaseHelper sınıfını kullanarak sorguyu çalıştır
                DataTable result = DatabaseHelper.ExecuteQuery(query);

                // ListBox'u temizle
                listBoxDensity.Items.Clear();

                // Sonuçları işleme
                foreach (DataRow row in result.Rows)
                {
                    string date = Convert.ToString(row["appointment_date"]);
                    int totalAppointments = Convert.ToInt32(row["total_appointments"]);

                    // Yoğunluğu ListBox'a ekle
                    listBoxDensity.Items.Add($"Tarih: {date} | Randevular: {totalAppointments}");

                    // Öneri ekle
                    if (totalAppointments > 10)
                    {
                        listBoxDensity.Items.Add("-> Öneri: Ek doktor çağırmayı düşünün.");
                    }
                    else
                    {
                        listBoxDensity.Items.Add("-> Durum: Yoğunluk normal.");
                    }
                }

                // Eğer sonuç yoksa kullanıcıya bilgi ver
                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Yoğun gün bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda hata mesajı göster
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculateCancelRate_Click(object sender, EventArgs e)
        {
            try
            {
                // SQL sorgusu
                string query = @"
            SELECT 
                COUNT(*) AS total_appointments, 
                SUM(CASE WHEN status = 'İptal Edildi' THEN 1 ELSE 0 END) AS cancelled_appointments 
            FROM 
                Appointment;";

                // Veritabanı sorgusunu çalıştır
                DataTable result = DatabaseHelper.ExecuteQuery(query);

                // Sonuçları al
                if (result.Rows.Count > 0)
                {
                    int totalAppointments = Convert.ToInt32(result.Rows[0]["total_appointments"]);
                    int cancelledAppointments = Convert.ToInt32(result.Rows[0]["cancelled_appointments"]);

                    // İptal oranını hesapla
                    double cancelRate = (double)cancelledAppointments / totalAppointments * 100;

                    // Sonuçları UI'de göster
                    lblCancelRate.Text = $"İptal Oranı: %{cancelRate:F2}";
                    progressBarCancelRate.Value = (int)cancelRate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
