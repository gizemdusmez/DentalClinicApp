using System;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace DentalClinicApp
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana giriş noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
  
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login_frm()); // Form1'i başlat
        }
    }
}