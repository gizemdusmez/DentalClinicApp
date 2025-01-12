namespace DentalClinicApp
{
    partial class AddPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientForm));
            this.txtTcNo = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtSurname = new DevExpress.XtraEditors.TextEdit();
            this.cmbGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtBirthDate = new DevExpress.XtraEditors.DateEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTcNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(494, 119);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTcNo.Properties.Appearance.Options.UseFont = true;
            this.txtTcNo.Properties.Name = "txtTcNo";
            this.txtTcNo.Properties.NullText = "*";
            this.txtTcNo.Size = new System.Drawing.Size(448, 50);
            this.txtTcNo.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(494, 261);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.NullText = "*";
            this.txtName.Size = new System.Drawing.Size(448, 50);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(494, 410);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSurname.Properties.Appearance.Options.UseFont = true;
            this.txtSurname.Properties.NullText = "*";
            this.txtSurname.Size = new System.Drawing.Size(448, 50);
            this.txtSurname.TabIndex = 2;
            // 
            // cmbGender
            // 
            this.cmbGender.Location = new System.Drawing.Point(494, 558);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbGender.Properties.Appearance.Options.UseFont = true;
            this.cmbGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGender.Properties.Items.AddRange(new object[] {
            "Kadın",
            "Erkek",
            "Diğer"});
            this.cmbGender.Properties.NullText = "*";
            this.cmbGender.Size = new System.Drawing.Size(448, 50);
            this.cmbGender.TabIndex = 3;
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.EditValue = null;
            this.dtBirthDate.Location = new System.Drawing.Point(494, 688);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.dtBirthDate.Properties.Appearance.Options.UseFont = true;
            this.dtBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBirthDate.Properties.NullText = "*";
            this.dtBirthDate.Size = new System.Drawing.Size(448, 50);
            this.dtBirthDate.TabIndex = 4;
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
            this.label1.Size = new System.Drawing.Size(172, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "T.C NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(107, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "İsim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(107, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 51);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyisim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(107, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 51);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cinsiyet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(107, 694);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 51);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doğum Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(107, 834);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 51);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alerjiler";
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
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 1274);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtBirthDate);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtTcNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPatientForm";
            this.Text = "Hasta Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.txtTcNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTcNo;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtSurname;
        private DevExpress.XtraEditors.ComboBoxEdit cmbGender;
        private DevExpress.XtraEditors.DateEdit dtBirthDate;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}