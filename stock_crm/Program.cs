using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_crm
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
            identificationForm ident = new identificationForm();
            ident.ShowDialog();
            if (identificationForm.isOK)
            {
                Application.Run(new menu());
            }
        }
    }
}
