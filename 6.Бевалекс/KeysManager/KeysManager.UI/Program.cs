using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeysManager.UI;
using KeysManager.UI.MainForms;

namespace KeysManager.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fmLoginForm a = new fmLoginForm();
            int i = 0;
            /*Автоматический вызов главной формы*/
            //Application.Run(new MainForm());
            //i = 4;
            /*Автоматический вызов главной формы*/
            while (i < 10)
            {
                a.ShowDialog();
                i++;
                if (a.DialogResult == DialogResult.OK)
                {
                    Application.Run(new fmMain());
                    break;
                }
                else
                    if (a.DialogResult == DialogResult.Cancel)
                    {
                        break;
                    }
            }
            //Application.Run(new fmMain());
        }
    }
}
