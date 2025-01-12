namespace DentalClinicApp
{
    partial class AddDentistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDentistForm));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtSurname = new DevExpress.XtraEditors.TextEdit();
            this.cmbspecial = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.dtHideStrt = new DevExpress.XtraEditors.DateEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbspecial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHideStrt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHideStrt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(106, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(107, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(107, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 51);
            this.label3.TabIndex = 8;
            this.label3.Text = "Uzmanlık";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(107, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 51);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(107, 694);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 51);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(91, 838);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(397, 51);
            this.label6.TabIndex = 11;
            this.label6.Text = "İşe Başlama Tarihi";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(494, 119);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.NullText = "*";
            this.txtName.Size = new System.Drawing.Size(448, 50);
            this.txtName.TabIndex = 13;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(494, 254);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.txtSurname.Properties.Appearance.Options.UseFont = true;
            this.txtSurname.Properties.NullText = "*";
            this.txtSurname.Size = new System.Drawing.Size(448, 50);
            this.txtSurname.TabIndex = 14;
            // 
            // cmbspecial
            // 
            this.cmbspecial.Location = new System.Drawing.Point(494, 410);
            this.cmbspecial.Name = "cmbspecial";
            this.cmbspecial.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbspecial.Properties.Appearance.Options.UseFont = true;
            this.cmbspecial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbspecial.Properties.Items.AddRange(new object[] {
            "Ağız, Diş ve Çene Cerrahisi",
            "Ortodonti",
            "Protez",
            "Endodonti",
            "Periodontoloji",
            "Pedodonti",
            "Oral Diagnoz ve Radyoloji",
            "Restoratif Tedavileri",
            "İmplantoloji",
            "Gerodontoloji",
            "Estetik"});
            this.cmbspecial.Properties.NullText = "*";
            this.cmbspecial.Size = new System.Drawing.Size(448, 50);
            this.cmbspecial.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(494, 558);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Properties.NullText = "*";
            this.txtPhone.Size = new System.Drawing.Size(448, 50);
            this.txtPhone.TabIndex = 16;
            // 
            // dtHideStrt
            // 
            this.dtHideStrt.EditValue = null;
            this.dtHideStrt.Location = new System.Drawing.Point(494, 832);
            this.dtHideStrt.Name = "dtHideStrt";
            this.dtHideStrt.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.dtHideStrt.Properties.Appearance.Options.UseFont = true;
            this.dtHideStrt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHideStrt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtHideStrt.Properties.NullText = "*";
            this.dtHideStrt.Size = new System.Drawing.Size(448, 50);
            this.dtHideStrt.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(494, 688);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Properties.NullText = "*";
            this.txtEmail.Size = new System.Drawing.Size(448, 50);
            this.txtEmail.TabIndex = 18;
            // 
            // AddDentistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1016, 1274);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtHideStrt);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.cmbspecial);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDentistForm";
            this.Text = "Diş Hekimi Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbspecial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHideStrt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtHideStrt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtSurname;
        private DevExpress.XtraEditors.ComboBoxEdit cmbspecial;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.DateEdit dtHideStrt;
        private DevExpress.XtraEditors.TextEdit txtEmail;
    }
}