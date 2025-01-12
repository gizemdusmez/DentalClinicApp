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
    public partial class HastaForm : Form
    {
        public HastaForm()
        {
            InitializeComponent();
        }

        private void HastaForm_Load(object sender, EventArgs e)
        {
            LoadData();
            SetColumnEditableSettings();
        }


        //Veritabanından hasta verilerini çekme
        private void LoadData()
        {
            try
            {
                string query = "SELECT patient_id, tc_no, name, surname, gender, birth_date, allergies, created_at FROM Patient";
                gridControl1.DataSource = DatabaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hasta ekleme butonu
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.ShowDialog();
            LoadData(); // Yeni hasta eklendikten sonra verileri yenileyelim.
        }

        // Düzenleme butonu
        private void repositoryItemButtonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle >= 0)
                {
                    string patientId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "patient_id")?.ToString();

                    if (!string.IsNullOrEmpty(patientId))
                    {
                        AddPatientForm editForm = new AddPatientForm(patientId, true);
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
                    string patientId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "patient_id")?.ToString();

                    if (!string.IsNullOrEmpty(patientId))
                    {
                        DialogResult dialogResult = MessageBox.Show(
                            "Bu kaydı silmek istediğinizden emin misiniz?",
                            "Onay",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (dialogResult == DialogResult.Yes)
                        {
                            string query = "DELETE FROM Patient WHERE patient_id = @patient_id";
                            DatabaseHelper.ExecuteNonQuery(query, new Dictionary<string, object>
                            {
                                { "@patient_id", patientId }
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

