using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DentalClinicApp
{
    public partial class FluentDesignForm1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FluentDesignForm1()
        {
            InitializeComponent();
        }

        private void LoadFormIntoContainer(Form form)
        {
            fluentDesignFormContainer1.Controls.Clear(); 
            form.TopLevel = false; // Form'u container'a gömülebilir hale getir
            form.FormBorderStyle = FormBorderStyle.None; 
            form.Dock = DockStyle.Fill; // Container'a tam oturmasını sağla
            fluentDesignFormContainer1.Controls.Add(form); 
            form.Show(); 
        }

        private void LoadUserControlIntoContainer(UserControl userControl)
        {
            fluentDesignFormContainer1.Controls.Clear(); 
            userControl.Dock = DockStyle.Fill; // UserControl'ü container'a tam oturt
            fluentDesignFormContainer1.Controls.Add(userControl); 
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            // Gösterge Paneli (Dashboard) yükle
            LoadUserControlIntoContainer(new HamburgerMenu.Dashboard());
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            // Hasta Formu
            LoadFormIntoContainer(new HastaForm());
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            // Diş Hekimi Formu
            LoadFormIntoContainer(new DoktorForm());
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            // Randevu Formu
            LoadFormIntoContainer(new RandevuForm());
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            // Tedavi Formu
            LoadFormIntoContainer(new TedaviForm());
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            // Ayarlar Formu
            LoadFormIntoContainer(new AyarlarForm());
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            //Oneri ve Uyarılar Formu
            LoadFormIntoContainer(new OneriForm());
        }

        private void FluentDesignForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
