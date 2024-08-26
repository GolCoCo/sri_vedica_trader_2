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
    public partial class FormNewWorkMenuItem : MetroForm
    {
        private FormNewWorkMenuItem _form = null;
        public string _workname = "";
        public FormNewWorkMenuItem()
        {
            InitializeComponent();
            _form = this;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _workname = NameTextBox.Text;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (_workname == "") return;
            _form.DialogResult = DialogResult.OK;
            _form.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            _form.DialogResult = DialogResult.Cancel;
            _form.Close();
        }
    }
}
