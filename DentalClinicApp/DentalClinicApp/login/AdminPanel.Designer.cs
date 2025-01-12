namespace DentalClinicApp
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddUser = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteUser = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControl1.Location = new System.Drawing.Point(45, 109);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(900, 469);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUsername,
            this.colRole});
            this.gridView1.DetailHeight = 547;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colUsername
            // 
            this.colUsername.Caption = "Kullanıcı Adı";
            this.colUsername.FieldName = "Kullanıcı Adı";
            this.colUsername.MinWidth = 30;
            this.colUsername.Name = "colUsername";
            this.colUsername.Visible = true;
            this.colUsername.VisibleIndex = 0;
            this.colUsername.Width = 112;
            // 
            // colRole
            // 
            this.colRole.Caption = "Rol";
            this.colRole.FieldName = "Rol";
            this.colRole.MinWidth = 30;
            this.colRole.Name = "colRole";
            this.colRole.Visible = true;
            this.colRole.VisibleIndex = 1;
            this.colRole.Width = 112;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(45, 31);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(180, 47);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Kullanıcı Ekle";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(240, 31);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(180, 47);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Kullanıcı Sil";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 625);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminPanel";
            this.Text = "Admin Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPanel_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUsername;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraEditors.SimpleButton btnAddUser;
        private DevExpress.XtraEditors.SimpleButton btnDeleteUser;
    }
}
