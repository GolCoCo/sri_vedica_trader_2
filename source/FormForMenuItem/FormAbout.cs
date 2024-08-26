using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VedicaTrader
{
    public partial class FormAbout : MetroForm
    {
        private FormAbout _form = null;
        public string _workname = "";
        public FormAbout()
        {
            InitializeComponent();
            _form = this;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            _form.Close();
        }
    }
}
