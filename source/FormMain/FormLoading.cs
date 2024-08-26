using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VedicaTrader
{
    public partial class FormLoading : Office2010Form
    {
        private FormLoading _form = null;
        public string _workname = "";
        private Manager.SymbolWasabiAPI _api = null;
        public Dictionary<string, List<List<string>>> _symboldatas = null;
        public FormLoading(Manager.SymbolWasabiAPI api, Dictionary<string, List<List<string>>> symboldatas)
        {
            FormSplash frm = new FormSplash();
            frm.ShowDialog();
            frm.InvokeIfRequired(p => p.Close());

            InitializeComponent();
            _form = this;
            _api = api;
            _symboldatas = symboldatas;
            this.ProgressBar.Value = 0;
            this.ColorScheme = Office2010Theme.Black;

        }

        private async void RunDownloadZipFileAsync()
        {
            Thread.Sleep(100);
            this.ProgressBar.Value = 15;
            for (int i = 1; i < 30; i++)
            {
                try
                {

                    this.ProgressBar.Value = 15 + (i / 30) * 80;

                    String filename = String.Format("Folder{0}.zip", i);
                    Dictionary<string, List<List<string>>> tmps = await _api.DownloadAndGetAllDatasFileNameByZIPAsync(filename);
                    if (tmps == null) continue;
                    foreach (KeyValuePair<string, List<List<string>>> tmp in tmps)
                    {

                        if (_symboldatas.Keys.ToList<string>().IndexOf(tmp.Key) != -1)
                        {
                            _symboldatas.Remove(tmp.Key);
                        }
                        _symboldatas.Add(tmp.Key, tmp.Value);
                    }
                }
                catch (Exception)
                {

                }
            }

            GC.Collect();
            Thread.Sleep(500);

             this.ProgressBar.Value = 100;
            _form.DialogResult = DialogResult.OK;
            _form.Close();

        }


        private void RunDownloadZipFileAsyncTest()
        {
            Thread.Sleep(100);
            this.ProgressBar.Value = 15;
            for (int i = 1; i < 2; i++)
            {
                try
                {
                    String filename = String.Format("Folder{0}.zip", i);
                    Dictionary<string, List<List<string>>> tmps = Utils.GetAllDatasFromStream(new FileStream("D://Folder.zip", FileMode.Open));
                    //Dictionary<string, List<List<string>>> tmps = await _api.DownloadAndGetAllDatasFileNameByZIPAsync(filename);
                    if (tmps == null) continue;
                    foreach (KeyValuePair<string, List<List<string>>> tmp in tmps)
                    {

                        if (_symboldatas.Keys.ToList<string>().IndexOf(tmp.Key) != -1)
                        {
                            _symboldatas.Remove(tmp.Key);
                        }
                        _symboldatas.Add(tmp.Key, tmp.Value);

                    }
                    this.ProgressBar.Value = 50;
                }
                catch (Exception)
                {

                }
            }

            GC.Collect();

            this.ProgressBar.Value = 100;
            _form.DialogResult = DialogResult.OK;
            Thread.Sleep(500);
            _form.Close();

        }

        private void FormLoading_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void FormLoading_Load(object sender, EventArgs e)
        {


            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_DoWorkByLoading);
            bw.RunWorkerAsync();
        }

        private void bw_DoWorkByLoading(object sender, DoWorkEventArgs e)
        {
            //RunDownloadZipFileAsync();
            RunDownloadZipFileAsyncTest();
        }
    }
}
