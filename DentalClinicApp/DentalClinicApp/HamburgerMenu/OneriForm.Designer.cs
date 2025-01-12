namespace DentalClinicApp
{
    partial class OneriForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnCheckDensity = new System.Windows.Forms.Button();
            this.listBoxDensity = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCancelRate = new System.Windows.Forms.Label();
            this.progressBarCancelRate = new System.Windows.Forms.ProgressBar();
            this.btnCalculateCancelRate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DentalClinicApp.Properties.Resources.istockphoto_1332714143_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1844, 1328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblHeader.Location = new System.Drawing.Point(117, 77);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(623, 50);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Randevu Yoğunluğu Ve Öneriler";
            // 
            // btnCheckDensity
            // 
            this.btnCheckDensity.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCheckDensity.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCheckDensity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckDensity.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckDensity.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnCheckDensity.Location = new System.Drawing.Point(126, 150);
            this.btnCheckDensity.Name = "btnCheckDensity";
            this.btnCheckDensity.Size = new System.Drawing.Size(454, 56);
            this.btnCheckDensity.TabIndex = 5;
            this.btnCheckDensity.Text = "Yoğun Günleri Kontrol Et";
            this.btnCheckDensity.UseVisualStyleBackColor = false;
            this.btnCheckDensity.Click += new System.EventHandler(this.btnCheckDensity_Click);
            // 
            // listBoxDensity
            // 
            this.listBoxDensity.FormattingEnabled = true;
            this.listBoxDensity.ItemHeight = 25;
            this.listBoxDensity.Location = new System.Drawing.Point(126, 242);
            this.listBoxDensity.Name = "listBoxDensity";
            this.listBoxDensity.Size = new System.Drawing.Size(650, 329);
            this.listBoxDensity.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitle.Location = new System.Drawing.Point(1133, 77);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(529, 50);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Randevu İptal Oranı Analizi";
            // 
            // lblCancelRate
            // 
            this.lblCancelRate.AutoSize = true;
            this.lblCancelRate.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelRate.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCancelRate.Location = new System.Drawing.Point(1256, 360);
            this.lblCancelRate.Name = "lblCancelRate";
            this.lblCancelRate.Size = new System.Drawing.Size(266, 48);
            this.lblCancelRate.TabIndex = 9;
            this.lblCancelRate.Text = "İptal Oranı: %0";
            // 
            // progressBarCancelRate
            // 
            this.progressBarCancelRate.Location = new System.Drawing.Point(1142, 242);
            this.progressBarCancelRate.Name = "progressBarCancelRate";
            this.progressBarCancelRate.Size = new System.Drawing.Size(519, 60);
            this.progressBarCancelRate.TabIndex = 10;
            // 
            // btnCalculateCancelRate
            // 
            this.btnCalculateCancelRate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCalculateCancelRate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalculateCancelRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateCancelRate.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateCancelRate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnCalculateCancelRate.Location = new System.Drawing.Point(1142, 150);
            this.btnCalculateCancelRate.Name = "btnCalculateCancelRate";
            this.btnCalculateCancelRate.Size = new System.Drawing.Size(454, 56);
            this.btnCalculateCancelRate.TabIndex = 11;
            this.btnCalculateCancelRate.Text = "İptal Oranını Hesapla";
            this.btnCalculateCancelRate.UseVisualStyleBackColor = false;
            this.btnCalculateCancelRate.Click += new System.EventHandler(this.btnCalculateCancelRate_Click);
            // 
            // Oneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1844, 1328);
            this.Controls.Add(this.btnCalculateCancelRate);
            this.Controls.Add(this.progressBarCancelRate);
            this.Controls.Add(this.lblCancelRate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.listBoxDensity);
            this.Controls.Add(this.btnCheckDensity);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Oneri";
            this.Text = "Öneri";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnCheckDensity;
        private System.Windows.Forms.ListBox listBoxDensity;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCancelRate;
        private System.Windows.Forms.ProgressBar progressBarCancelRate;
        private System.Windows.Forms.Button btnCalculateCancelRate;
    }
}