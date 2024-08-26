using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VedicaTrader
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            SkinManager.ApplicationVisualTheme = "Office2019Colourful";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form frm = new FormSplash(false);
            frm.ShowDialog();
            frm.InvokeIfRequired(p => p.Close());
            Application.Run(new FormLogin());
        }
    }
}
