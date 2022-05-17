using System;
using System.Windows.Forms;
using WindowsFormsGestionCommandes.utils;
using WindowsFormsGestionCommandes.views.security;

namespace WindowsFormsGestionCommandes
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
