using MediaTekDocuments.view;
using System;
using System.Windows.Forms;

namespace MediaTekDocuments
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

            FrmAuth auth = new FrmAuth();

            if (auth.ShowDialog() == DialogResult.OK)
            {
                Utilisateur user = auth.user;
                Application.Run(new FrmMediatek(user));
            }
        }
    }
}
