namespace DentalClinicApp
{
    partial class AddAppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAppointmentForm));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.dteAppointmentDate = new DevExpress.XtraEditors.DateEdit();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbDentist = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbPatient = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAppointmentDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAppointmentDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDentist.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPatient.Properties)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(140, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(107, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Diş Hekimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(107, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 51);
            this.label3.TabIndex = 8;
            this.label3.Text = "Randevu Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(107, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 51);
            this.label4.TabIndex = 9;
            this.label4.Text = "Randevu Saati";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(107, 694);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 51);
            this.label5.TabIndex = 10;
            this.label5.Text = "Durum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(107, 834);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 51);
            this.label6.TabIndex = 11;
            this.label6.Text = "Notlar";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(494, 839);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(448, 50);
            this.textEdit1.TabIndex = 12;
            // 
            // dteAppointmentDate
            // 
            this.dteAppointmentDate.EditValue = null;
            this.dteAppointmentDate.Location = new System.Drawing.Point(494, 410);
            this.dteAppointmentDate.Name = "dteAppointmentDate";
            this.dteAppointmentDate.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.dteAppointmentDate.Properties.Appearance.Options.UseFont = true;
            this.dteAppointmentDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteAppointmentDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteAppointmentDate.Properties.NullText = "*";
            this.dteAppointmentDate.Size = new System.Drawing.Size(448, 50);
            this.dteAppointmentDate.TabIndex = 15;
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2025, 1, 4, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(494, 558);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Properties.Mask.EditMask = "HH:mm:ss";
            this.timeEdit1.Size = new System.Drawing.Size(304, 40);
            this.timeEdit1.TabIndex = 16;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(494, 688);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Aktif",
            "İptal Edildi",
            "Tamamlandı"});
            this.comboBoxEdit1.Properties.NullText = "*";
            this.comboBoxEdit1.Size = new System.Drawing.Size(448, 50);
            this.comboBoxEdit1.TabIndex = 17;
            // 
            // cmbDentist
            // 
            this.cmbDentist.Location = new System.Drawing.Point(494, 261);
            this.cmbDentist.Name = "cmbDentist";
            this.cmbDentist.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbDentist.Properties.Appearance.Options.UseFont = true;
            this.cmbDentist.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDentist.Properties.NullText = "*";
            this.cmbDentist.Size = new System.Drawing.Size(448, 50);
            this.cmbDentist.TabIndex = 14;
            // 
            // cmbPatient
            // 
            this.cmbPatient.Location = new System.Drawing.Point(494, 119);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbPatient.Properties.Appearance.Options.UseFont = true;
            this.cmbPatient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPatient.Properties.NullText = "*";
            this.cmbPatient.Size = new System.Drawing.Size(448, 50);
            this.cmbPatient.TabIndex = 13;
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCheckAvailability.Font = new System.Drawing.Font("Palatino Linotype", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAvailability.ForeColor = System.Drawing.Color.White;
            this.btnCheckAvailability.Location = new System.Drawing.Point(66, 1018);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(280, 68);
            this.btnCheckAvailability.TabIndex = 18;
            this.btnCheckAvailability.Text = "Uygun Saat Öner";
            this.btnCheckAvailability.UseVisualStyleBackColor = false;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1016, 1274);
            this.Controls.Add(this.btnCheckAvailability);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.timeEdit1);
            this.Controls.Add(this.dteAppointmentDate);
            this.Controls.Add(this.cmbDentist);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAppointmentForm";
            this.Text = "Randevu Kayıt";
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAppointmentDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteAppointmentDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDentist.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPatient.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.DateEdit dteAppointmentDate;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDentist;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPatient;
        private System.Windows.Forms.Button btnCheckAvailability;
    }
}