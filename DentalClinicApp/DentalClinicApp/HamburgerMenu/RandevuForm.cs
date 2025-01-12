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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;

namespace DentalClinicApp
{
    public partial class RandevuForm : Form
    {
        public RandevuForm()
        {
            InitializeComponent();
        }

        private void RandevuForm_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            SetColumnEditableSettings();
        }

        // Veritabanından randevuları çekme
        private void LoadAppointments()
        {
            try
            {
                string query = @"
                    SELECT 
                        A.appointment_id, 
                        P.name || ' ' || P.surname AS patient_name, 
                        D.name || ' ' || D.surname AS dentist_name, 
                        A.appointment_date, 
                        A.appointment_time, 
                        A.status, 
                        A.notes, 
                        A.created_at 
                    FROM Appointment A
                    INNER JOIN Patient P ON A.patient_id = P.patient_id
                    INNER JOIN Dentist D ON A.dentist_id = D.dentist_id";
                gridControl1.DataSource = DatabaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Randevular yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Yeni randevu ekleme butonu
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm();
            addAppointmentForm.ShowDialog();
            LoadAppointments(); // Yeni randevu eklendikten sonra listeyi yenileyelim.
        }

        // Randevu düzenleme butonu
        private void repositoryItemButtonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle >= 0)
                {
                    string appointmentId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "appointment_id")?.ToString();

                    if (!string.IsNullOrEmpty(appointmentId))
                    {
                        AddAppointmentForm editForm = new AddAppointmentForm(appointmentId, true);
                        editForm.ShowDialog();
                        LoadAppointments(); // Güncellenmiş verileri yükle.
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir ID seçili değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir satır seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Randevu silme butonu
        private void repositoryItemButtonEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle >= 0)
                {
                    string appointmentId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "appointment_id")?.ToString();

                    if (!string.IsNullOrEmpty(appointmentId))
                    {
                        DialogResult dialogResult = MessageBox.Show(
                            "Bu randevuyu silmek istediğinizden emin misiniz?",
                            "Onay",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (dialogResult == DialogResult.Yes)
                        {
                            string query = "DELETE FROM Appointment WHERE appointment_id = @appointment_id";
                            DatabaseHelper.ExecuteNonQuery(query, new Dictionary<string, object>
                            {
                                { "@appointment_id", appointmentId }
                            });

                            MessageBox.Show("Randevu başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAppointments(); // Verileri yenile.
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçerli bir ID seçili değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir satır seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetColumnEditableSettings()
        {
            gridView1.OptionsBehavior.Editable = true;

            foreach (GridColumn column in gridView1.Columns)
            {
                if (column.Name != "editColumn" && column.Name != "deleteColumn")
                {
                    column.OptionsColumn.AllowEdit = false;
                }
            }
        }


        // Bubble Sort ile belirli bir duruma göre sıralama
        private DataTable BubbleSortByStatus(DataTable table, string status)
        {
            var rows = table.Select(); // DataTable'deki tüm satırları al
            for (int i = 0; i < rows.Length - 1; i++)
            {
                for (int j = 0; j < rows.Length - i - 1; j++)
                {
                    string status1 = rows[j]["status"].ToString();
                    string status2 = rows[j + 1]["status"].ToString();

                    // Eğer statü eşleşmiyorsa yer değiştir
                    if (status1 != status && status2 == status)
                    {
                        var temp = rows[j];
                        rows[j] = rows[j + 1];
                        rows[j + 1] = temp;
                    }
                }
            }

            // Sıralanan satırları yeni bir DataTable'a ekle
            DataTable sortedTable = table.Clone();
            foreach (var row in rows)
            {
                sortedTable.ImportRow(row);
            }

            return sortedTable;
        }

        // "Aktif" randevuları sıralar
        private void pictureBoxActive_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"
            SELECT 
                A.appointment_id, 
                P.name || ' ' || P.surname AS patient_name, 
                D.name || ' ' || D.surname AS dentist_name, 
                A.appointment_date, 
                A.appointment_time, 
                A.status, 
                A.notes, 
                A.created_at 
            FROM Appointment A
            INNER JOIN Patient P ON A.patient_id = P.patient_id
            INNER JOIN Dentist D ON A.dentist_id = D.dentist_id";

                DataTable data = DatabaseHelper.ExecuteQuery(query);

                // Bubble Sort ile "Aktif" durumdaki randevuları sıralayın
                DataTable sortedData = BubbleSortByStatus(data, "Aktif");
                gridControl1.DataSource = sortedData; // Sıralanan veriyi GridView'e yükleyin
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // "İptal Edildi" randevularını sıralar
        private void pictureBoxCancelled_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"
            SELECT 
                A.appointment_id, 
                P.name || ' ' || P.surname AS patient_name, 
                D.name || ' ' || D.surname AS dentist_name, 
                A.appointment_date, 
                A.appointment_time, 
                A.status, 
                A.notes, 
                A.created_at 
            FROM Appointment A
            INNER JOIN Patient P ON A.patient_id = P.patient_id
            INNER JOIN Dentist D ON A.dentist_id = D.dentist_id";

                DataTable data = DatabaseHelper.ExecuteQuery(query);

                // Bubble Sort ile "İptal" durumdaki randevuları sıralayın
                DataTable sortedData = BubbleSortByStatus(data, "İptal Edildi");
                gridControl1.DataSource = sortedData; // Sıralanan veriyi GridView'e yükleyin
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}





















