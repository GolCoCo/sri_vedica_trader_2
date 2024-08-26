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
    public partial class FormTestWasabi : Form
    {
        public string WAS_ACCESS_KEY = "";
        public string WAS_SECRET_KEY = "";
        public string WAS_FILENAME = "";
        public FormTestWasabi()
        {
            InitializeComponent();
        }

        private void FormTestWasabi_Load(object sender, EventArgs e)
        {

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DownLoadZipFileAsync();
            }
            catch(Exception ex)
            {
                ex.ToString();
            }

        }

        private async void DownLoadZipFileAsync()
        {
            Manager.MarketWasabiAPI msa = new Manager.MarketWasabiAPI();
            Dictionary<string, List<List<string>>> retlist = await msa.DownloadAndGetAllDatasFileNameByZIPAsync();
            if (retlist == null)
            {
                MessageBox.Show("There is no file");
            }
            foreach (string ret in retlist.Keys)
            {
                this.ResultTextBox.AppendText(ret + "\n");
            }
        }
    }
}
