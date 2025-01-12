namespace DentalClinicApp
{
    partial class AddTreatmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTreatmentForm));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTreatmentType = new DevExpress.XtraEditors.TextEdit();
            this.txtCost = new DevExpress.XtraEditors.TextEdit();
            this.dtDatePerformed = new DevExpress.XtraEditors.DateEdit();
            this.cmbAppointment_id = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.cmbPaid = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTreatmentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDatePerformed.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDatePerformed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAppointment_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPaid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.AppearanceDisabled.BackColor = System.Drawing.Color.Gray;
            this.btnSave.AppearanceDisabled.Options.UseBackColor = true;
            this.btnSave.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSave.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnSave.AppearanceHovered.Options.UseBackColor = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSave.Location = new System.Drawing.Point(632, 1006);
            this.btnSave.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(300, 80);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(107, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "Randevu ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(107, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tedavi Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(107, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 51);
            this.label3.TabIndex = 8;
            this.label3.Text = "Açıklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(107, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 51);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ücret";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(107, 694);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 51);
            this.label5.TabIndex = 10;
            this.label5.Text = "İşlem Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(91, 838);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 51);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ödeme Bilgisi";
            // 
            // txtTreatmentType
            // 
            this.txtTreatmentType.Location = new System.Drawing.Point(494, 254);
            this.txtTreatmentType.Name = "txtTreatmentType";
            this.txtTreatmentType.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTreatmentType.Properties.Appearance.Options.UseFont = true;
            this.txtTreatmentType.Properties.NullText = "*";
            this.txtTreatmentType.Size = new System.Drawing.Size(448, 50);
            this.txtTreatmentType.TabIndex = 14;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(494, 558);
            this.txtCost.Name = "txtCost";
            this.txtCost.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCost.Properties.Appearance.Options.UseFont = true;
            this.txtCost.Properties.NullText = "*";
            this.txtCost.Size = new System.Drawing.Size(448, 50);
            this.txtCost.TabIndex = 16;
            // 
            // dtDatePerformed
            // 
            this.dtDatePerformed.EditValue = null;
            this.dtDatePerformed.Location = new System.Drawing.Point(494, 688);
            this.dtDatePerformed.Name = "dtDatePerformed";
            this.dtDatePerformed.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.dtDatePerformed.Properties.Appearance.Options.UseFont = true;
            this.dtDatePerformed.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDatePerformed.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDatePerformed.Properties.NullText = "*";
            this.dtDatePerformed.Size = new System.Drawing.Size(448, 50);
            this.dtDatePerformed.TabIndex = 17;
            // 
            // cmbAppointment_id
            // 
            this.cmbAppointment_id.Location = new System.Drawing.Point(494, 119);
            this.cmbAppointment_id.Name = "cmbAppointment_id";
            this.cmbAppointment_id.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbAppointment_id.Properties.Appearance.Options.UseFont = true;
            this.cmbAppointment_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAppointment_id.Properties.NullText = "*";
            this.cmbAppointment_id.Size = new System.Drawing.Size(448, 50);
            this.cmbAppointment_id.TabIndex = 19;
            // 
            // txtDescription
            // 
            this.txtDescription.EditValue = "";
            this.txtDescription.Location = new System.Drawing.Point(494, 410);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.NullText = "*";
            this.txtDescription.Size = new System.Drawing.Size(448, 50);
            this.txtDescription.TabIndex = 20;
            // 
            // cmbPaid
            // 
            this.cmbPaid.Location = new System.Drawing.Point(494, 832);
            this.cmbPaid.Name = "cmbPaid";
            this.cmbPaid.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbPaid.Properties.Appearance.Options.UseFont = true;
            this.cmbPaid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPaid.Properties.NullText = "*";
            this.cmbPaid.Size = new System.Drawing.Size(448, 50);
            this.cmbPaid.TabIndex = 21;
            // 
            // AddTreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 1274);
            this.Controls.Add(this.cmbPaid);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbAppointment_id);
            this.Controls.Add(this.dtDatePerformed);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtTreatmentType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTreatmentForm";
            this.Text = "Tedavi Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.txtTreatmentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDatePerformed.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDatePerformed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAppointment_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPaid.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtTreatmentType;
        private DevExpress.XtraEditors.TextEdit txtCost;
        private DevExpress.XtraEditors.DateEdit dtDatePerformed;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAppointment_id;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPaid;
    }
}