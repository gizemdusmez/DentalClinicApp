using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;
using DevExpress.XtraGrid;

namespace DentalClinicApp.HamburgerMenu
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            InitializeDashboard();
        }

        private void InitializeDashboard()
        {
            LoadStatistics();
            LoadGridData("SELECT tc_no, name, surname, created_at FROM Patient", gridControl1);
            LoadGridData("SELECT treatment_type, description, cost, date_performed FROM Treatment", gridControl2);
        }

        private void LoadStatistics()
        {
            try
            {
                label2.Text = ExecuteScalar("SELECT COUNT(*) FROM Appointment").ToString();
                label4.Text = ExecuteScalar("SELECT COUNT(*) FROM Patient").ToString();
                label6.Text = ExecuteScalar("SELECT COUNT(*) FROM Dentist").ToString();
                label15.Text = ExecuteScalar("SELECT COUNT(*) FROM Appointment WHERE Status = 'Aktif'").ToString();
                label13.Text = ExecuteScalar("SELECT COUNT(*) FROM Appointment WHERE Status = 'Tamamlandı'").ToString();
                label11.Text = ExecuteScalar("SELECT COUNT(*) FROM Appointment WHERE Status = 'İptal Edildi'").ToString();
                label8.Text = GetTotalPaidCost().ToString("C", new CultureInfo("tr-TR"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yüklenirken hata oluştu: {ex.Message}");
            }
        }

        // Günlük toplam ödeme
        private double GetTotalPaidCost()
        {
            string query = @"
                SELECT SUM(cost) 
                FROM Treatment 
                WHERE is_paid = 1 AND date_performed BETWEEN @startDate AND @endDate";

            var parameters = new Dictionary<string, object>
            {
                { "@startDate", DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss") },
                { "@endDate", DateTime.Today.AddDays(1).AddTicks(-1).ToString("yyyy-MM-dd HH:mm:ss") }
            };

            object result = ExecuteScalar(query, parameters);
            return result != DBNull.Value ? Convert.ToDouble(result) : 0.0;
        }

        private object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
        {
            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);
            return result.Rows.Count > 0 ? result.Rows[0][0] : null;
        }

        private void LoadGridData(string query, GridControl gridControl)
        {
            try
            {
                gridControl.DataSource = DatabaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
}

