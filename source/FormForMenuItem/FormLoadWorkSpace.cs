using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VedicaTrader
{
    public partial class FormLoadWorkSpace : MetroForm
    {
        private FormLoadWorkSpace _form = null;
        public string _workname = "";
        public FormLoadWorkSpace()
        {
            InitializeComponent();
            _form = this;
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

        private void WorkNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _workname = this.WorkNameComboBox.SelectedItem.ToString();
        }

        private void FormLoadWorkSpace_Load(object sender, EventArgs e)
        {
            string[] allfiles = Directory.GetFiles(HardCode.STR_SAVE_FOLDER_PATH, "*.cfg", SearchOption.AllDirectories);
            foreach (string file in allfiles)
            {
                string name = Path.GetFileNameWithoutExtension(file);
                this.WorkNameComboBox.Items.Add(name);
            }
            if(allfiles.Length!=0) this.WorkNameComboBox.SelectedIndex = 0;
            GC.Collect();
        }
    }
}
