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
    public partial class TedaviForm : Form
    {
        public TedaviForm()
        {
            InitializeComponent();
        }

        private void TedaviForm_Load(object sender, EventArgs e)
        {
            LoadData();
            SetColumnEditableSettings();
            CustomizePaidColumn();
        }

        private void LoadData()
        {
            try
            {
                string query = @"
                SELECT 
                    treatment_id, 
                    appointment_id, 
                    treatment_type, 
                    description, 
                    cost, 
                    date_performed, 
                    is_paid 
                FROM Treatment";
                gridControl1.DataSource = DatabaseHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // "is_paid" kolonunu özelleştiren metot
        private void CustomizePaidColumn()
        {
            gridView1.CustomColumnDisplayText += (s, evt) =>
            {
                if (evt.Column.FieldName == "is_paid")
                {
                    if (evt.Value == null)
                    {
                        evt.DisplayText = "Bilinmiyor";
                    }
                    else
                    {
                        evt.DisplayText = evt.Value.ToString() == "1" ? "Ödendi" : "Ödenmedi";
                    }
                }
            };
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddTreatmentForm addTreatmentForm = new AddTreatmentForm();
            addTreatmentForm.ShowDialog();
            LoadData(); // Yeni tedavi eklendikten sonra verileri yenileyelim.
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle >= 0)
                {
                    string treatmentId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "treatment_id")?.ToString();

                    if (!string.IsNullOrEmpty(treatmentId))
                    {
                        AddTreatmentForm editForm = new AddTreatmentForm(treatmentId, true);
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

        private void repositoryItemButtonEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle >= 0)
                {
                    string treatmentId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "treatment_id")?.ToString();

                    if (!string.IsNullOrEmpty(treatmentId))
                    {
                        DialogResult dialogResult = MessageBox.Show(
                            "Bu kaydı silmek istediğinizden emin misiniz?",
                            "Onay",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (dialogResult == DialogResult.Yes)
                        {
                            string query = "DELETE FROM Treatment WHERE treatment_id = @treatment_id";
                            DatabaseHelper.ExecuteNonQuery(query, new Dictionary<string, object>
                            {
                                { "@treatment_id", treatmentId }
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

