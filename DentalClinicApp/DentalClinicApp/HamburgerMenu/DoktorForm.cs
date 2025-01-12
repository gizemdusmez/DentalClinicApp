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

namespace DentalClinicApp
{
    public partial class DoktorForm : Form
    {
        public DoktorForm()
        {
            InitializeComponent();
        }

        private void DoktorForm_Load(object sender, EventArgs e)
        {
            LoadData();
            SetColumnEditableSettings();
        }

        // Veritabanından doktor verilerini çekme
        private void LoadData()
        {
            try
            {
                string query = "SELECT dentist_id, name, surname, specialization, phone, email, hire_date FROM Dentist";
                gridControl1.DataSource = DatabaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Doktor ekleme butonu
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddDentistForm addDentistForm = new AddDentistForm();
            addDentistForm.ShowDialog();
            LoadData(); // Yeni doktor eklendikten sonra verileri yenileyelim.
        }

        // Düzenleme butonu
        private void repositoryItemButtonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle >= 0)
                {
                    string dentistId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "dentist_id")?.ToString();

                    if (!string.IsNullOrEmpty(dentistId))
                    {
                        AddDentistForm editForm = new AddDentistForm(dentistId, true);
                        editForm.ShowDialog();
                        LoadData(); // Güncellenmiş verileri yükle.
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

        // Silme butonu
        private void repositoryItemButtonEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle >= 0)
                {
                    string dentistId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "dentist_id")?.ToString();

                    if (!string.IsNullOrEmpty(dentistId))
                    {
                        DialogResult dialogResult = MessageBox.Show(
                            "Bu kaydı silmek istediğinizden emin misiniz?",
                            "Onay",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (dialogResult == DialogResult.Yes)
                        {
                            string query = "DELETE FROM Dentist WHERE dentist_id = @dentist_id";
                            DatabaseHelper.ExecuteNonQuery(query, new Dictionary<string, object>
                            {
                                { "@dentist_id", dentistId }
                            });

                            MessageBox.Show("Kayıt başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Verileri yenile.
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
    }
}

