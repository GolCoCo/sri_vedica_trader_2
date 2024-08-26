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
using System.Timers;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace VedicaTrader
{
    public partial class FormWorkSpaceTest : Office2010Form
    {
        Manager.SymbolWasabiAPI _msa = null;
        private Dictionary<string, List<List<string>>> _symboldatas = new Dictionary<string, List<List<string>>>();
        private List<Models.WorkspaceConfig> _workconfigs = new List<Models.WorkspaceConfig>();
        private System.Timers.Timer _stimer = null;
        public List<string> _recentworks = new List<string>();
        private FormWorkSpaceTest _form;
        private System.Timers.Timer _idvtimer = null;
        private Manager.DeviceIDWasabiAPI _deviceWasabi;
        private FormVedicaSector _market_sector_form;
        private FormSignalScanner _market_signal_form;
        private FormVedicaIndustry _market_industry_form;
        private Dictionary<string, List<List<string>>> _marketdatas = new Dictionary<string, List<List<string>>>();


        private System.Timers.Timer _testMarkettimer = null;

        public FormWorkSpaceTest(Manager.DeviceIDWasabiAPI deviceWasabi)
        {
            InitializeComponent();
            _form = this;
            _deviceWasabi = deviceWasabi;
            this.ColorScheme = Office2010Theme.Black;
        }

        public void RunTimerForTestMarketAPI()
        {
            _testMarkettimer = new System.Timers.Timer();
            _testMarkettimer.Elapsed += new ElapsedEventHandler(OnTestMarketAPI);
            _testMarkettimer.Interval = 40000;
            _testMarkettimer.Enabled = true;
            _testMarkettimer.Start();
        }

        private void OnTestMarketAPI(object sender, ElapsedEventArgs e)
        {
            _marketdatas.Clear();
            string filepath = "D:\\";
            Dictionary<string, List<List<string>>> tmps = Utils.GetAllDatasFromStream(new MemoryStream(File.ReadAllBytes(@filepath + "MarketView1.zip")));
            foreach (KeyValuePair<string, List<List<string>>> tmp in tmps)
            {
                if (Utils.MARKET_FILE_LIST.Contains(tmp.Key))
                {
                    _marketdatas.Add(tmp.Key, tmp.Value);
                }
            }
            UpdateAllMarketForms();
            GC.Collect();
        }

        public void RunTimerForValidateID()
        {
            _idvtimer = new System.Timers.Timer();
            _idvtimer.Elapsed += new ElapsedEventHandler(OnValidationDeviceID);
            _idvtimer.Interval = 200000;
            _idvtimer.Enabled = true;
            _idvtimer.Start();
        }

        private void OnValidationDeviceID(object sender, ElapsedEventArgs e)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_DoValidation);
            bw.RunWorkerAsync();
        }

        private void bw_DoValidation(object sender, DoWorkEventArgs e)
        {
            DoValidateDeviceID();
        }
        private void DoValidateDeviceID()
        {
            //string device_id = _deviceWasabi.DownloadDeviceInfoAsync().Result;
            string device_id = "asd";
            string mine_id = Utils.GetDeviceID();
            if (device_id == mine_id)
            {
                return;
            }
            else
            {
                if (MessageBox.Show(_form, Utils.MSGB_NEW_DEVICE_DETECTED,
                    "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    return;
                    //_deviceWasabi.UploadDeviceInfoAsync(device_id);
                }
                else
                {
                    _form.Close();
                }
            }
        }

        private void FormWorkSpace_Load(object sender, EventArgs e)
        {
            UpdateUI();
            //RunTimerForPCDateTime();
            //RunTimerForValidateID();
            //DownloadMarketDatasAsyncByMsg();
            FormLoading form = new FormLoading(_msa, _symboldatas);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                AddDefaultWorkSpace();
            }
            LoadRecentInfos();
            //if (HardCode.CURRENT_VERSION_TYPE._wsbChartFeature)
            //{
            //    FormLoading form = new FormLoading(_msa, _symboldatas);
            //    if (form.ShowDialog() == DialogResult.OK)
            //    {
            //        AddDefaultWorkSpace();
            //    }
            //    LoadRecentInfos();
            //}

            //RunTimerForTestMarketAPI();
        }

        private void FormWorkSpace_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_idvtimer != null) Close();
            Utils.WriteRecentData(_recentworks);
            _form.Close();
        }


        /// <summary>
        /// //////////////////////
        /// </summary>
        ///

        private void RunDownloadMarketZipFileAsync()
        {
            _marketdatas.Clear();
            string filepath = "D:\\";
            Dictionary<string, List<List<string>>> tmps = Utils.GetAllDatasFromStream(new MemoryStream(File.ReadAllBytes(@filepath + HardCode.WAS_MARKET_FILE_NAME)));
            //Dictionary<string, List<List<string>>> tmps = await _msa_market.DownloadAndGetAllDatasFileNameByZIPAsync();
            foreach (KeyValuePair<string, List<List<string>>> tmp in tmps)
            {
                if (Utils.MARKET_FILE_LIST.Contains(tmp.Key))
                {
                    _marketdatas.Add(tmp.Key, tmp.Value);
                }
            }
        }
        private void DownloadMarketDatasAsyncByMsg()
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_DoMarketWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_DoMarketWorkCompleted);
            bw.RunWorkerAsync();
        }

        private void bw_DoMarketWork(object sender, DoWorkEventArgs e)
        {
            RunDownloadMarketZipFileAsync();
        }
        private void bw_DoMarketWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //SaveAllChartInfo();
            //ReLoadAllChart();
        }
        private void LoadRecentInfos()
        {
            List<string> recents = Utils.GetRecentsData();
            if (recents != null)
            {
                _recentworks = recents;
            }
            UpdateRecentMenuItem();
        }

        private void UpdateAllMarketForms()
        {
            if(_market_industry_form != null)
            {
                _market_industry_form.UpdateDataGridView(GetMarketDataByName(1));
            }
            if (_market_sector_form != null)
            {
                _market_sector_form.UpdateDataGridView(GetMarketDataByName(2));
            }
            if (_market_signal_form != null)
            {
                _market_signal_form.UpdateDataGridView(GetMarketDataByName(0));
            }
        }

        private void UpdateRecentMenuItem()
        {
            this.recentWorkSpaceToolStripMenuItem.DropDownItems.Clear();
            int index = 0;

            for (int i = _recentworks.Count - 1; i >= 0; i--)
            {
                if (index > 5)
                {
                    break;
                }
                else
                {
                    this.recentWorkSpaceToolStripMenuItem.DropDownItems.Add(_recentworks[i]);
                }
                index++;
            }
        }

        private List<List<string>> GetSymbolData(string symbol)
        {
            String filename1 = String.Format("{0}.csv", symbol);
            String filename2 = String.Format("{0}-R.csv", symbol);
            foreach (string key in _symboldatas.Keys)
            {
                if (filename1 == key || filename2 == key)
                {
                    return _symboldatas[key];
                }
            }
            return null;
        }

        // Add WorkSpace
        private void AddNewWorkSpace(string workname)
        {
            TabPageAdv newpage = GetTabPageAdv(workname, true);
            this.MainTabControl.Controls.Add(newpage);
            this.MainTabControl.SelectedIndex = this.MainTabControl.TabPages.Count - 1;
        }

        private void AddOpenWorkSpace(string workname)
        {
            Models.WorkspaceConfig config = Utils.LoadWorkspaceInfo(workname);
            TabPageAdv newpage = GetTabPageAdv(workname, true);
            this.MainTabControl.Controls.Add(newpage);
            this.MainTabControl.SelectedIndex = this.MainTabControl.TabPages.Count - 1;
            foreach (Models.ChartInfo chart in config._symbols)
            {
                AddNewChartByChartInfo(chart);
            }

        }

        private void AddDefaultWorkSpace()
        {
            Models.WorkspaceConfig config = new Models.WorkspaceConfig(true);
            this.MainTabControl.Controls.Add(GetTabPageAdv(config._name, false));

            foreach (Models.ChartInfo chartinfo in config._symbols)
            {
                AddNewChartByChartInfo(chartinfo);
            }
        }


        // Add ChartForm
        private bool AddNewChartByChartInfoInPage(Models.ChartInfo chartinfo, TabPageAdv page)
        {
            try
            {

                List<List<string>> datas = GetSymbolData(chartinfo._symbol);
                if (datas == null)
                {
                    return false;
                }

                FormChart frm = new FormChart(chartinfo._symbol, datas);
                frm.Size = chartinfo._size;
                frm.TopLevel = false;
                frm.TopMost = true;
                frm.AutoScroll = true;
                frm.SetDesktopLocation(chartinfo._pos.X, chartinfo._pos.Y);
                frm.Top = chartinfo._pos.X;
                frm.Left = chartinfo._pos.Y;
                page.Controls.Add(frm);
                frm.Activate();
                frm.Show();
                frm.BringToFront();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return true;
        }

        // Add ChartForm
        private bool AddNewChartByChartInfo(Models.ChartInfo chartinfo)
        {
            try
            {

                List<List<string>> datas = GetSymbolData(chartinfo._symbol);
                if (datas == null)
                {
                    return false;
                }

                FormChart frm = new FormChart(chartinfo._symbol, datas);
                frm.Size = chartinfo._size;
                frm.TopLevel = false;
                frm.TopMost = true;
                frm.AutoScroll = true;
                frm.SetDesktopLocation(chartinfo._pos.X, chartinfo._pos.Y);
                frm.Top = chartinfo._pos.X;
                frm.Left = chartinfo._pos.Y;
                this.MainTabControl.SelectedTab.Controls.Add(frm);
                frm.Show();
                frm.BringToFront();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return true;
        }

        private void UpdateUI()
        {
            if (HardCode.RT_UPDATE_YES)
            {
                this.ConnectStatusLabel.Text = Utils.STR_CONNECTED;
                this.ConnectStatusLabel.BackColor = Utils.CLR_GREEN;
            }
            else
            {
                this.ConnectStatusLabel.Text = Utils.STR_DISCONNECTED;
                this.ConnectStatusLabel.BackColor = Utils.CLR_RED;
            }

            //if (HardCode.CURRENT_VERSION_TYPE._wsbChartFeature)
            //{
            //    this.StatusChartLabel.Text = Utils.STR_CONNECTED;
            //    this.StatusChartLabel.BackColor = Utils.CLR_GREEN;
            //    this.MainMenuStrip.Items["Chart"].Visible = true;
            //}
            //else
            //{
            //    this.StatusChartLabel.Text = Utils.STR_CONNECTED;
            //    this.StatusChartLabel.BackColor = Utils.CLR_RED;
            //    this.MainMenuStrip.Items["Chart"].Visible = false;
            //}

            //if (HardCode.CURRENT_VERSION_TYPE._wsbMarketFeature)
            //{
            //    this.StatusMarketLabel.Text = Utils.STR_CONNECTED;
            //    this.StatusMarketLabel.BackColor = Utils.CLR_GREEN;
            //    this.MainMenuStrip.Items["Market"].Visible = true;
            //}
            //else
            //{
            //    this.StatusMarketLabel.Text = Utils.STR_CONNECTED;
            //    this.StatusMarketLabel.BackColor = Utils.CLR_RED;
            //    this.MainMenuStrip.Items["Market"].Visible = false;
            //}
        }


        public void RunTimerForPCDateTime()
        {
            _stimer = new System.Timers.Timer();
            _stimer.Elapsed += new ElapsedEventHandler(OnPCTimeUpdate);
            _stimer.Interval = 1000;
            _stimer.Enabled = true;
            _stimer.Start();
        }

        private void OnPCTimeUpdate(object sender, ElapsedEventArgs e)
        {
            //this.Invoke((MethodInvoker)delegate
            //{
            //    this.PCDateTimeLabel.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            //});
        }

        private TabPageAdv GetTabPageAdv(string workname, bool isshowclosebtn)
        {
            TabPageAdv page = new TabPageAdv();
            page.BackColor = Color.SkyBlue;
            page.BorderStyle = BorderStyle.Fixed3D;
            page.Cursor = Cursors.Arrow;
            page.Image = null;
            page.ImageSize = new Size(16, 16);
            page.Location = new Point(0, 1);
            page.Margin = new Padding(0);
            page.Name = workname;
            page.Size = new Size(798, 346);
            page.TabFont = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            page.TabIndex = 1;
            page.Text = workname;
            page.ThemesEnabled = false;
            page.Closing += onPage_Closing_Click;
            page.ShowCloseButton = isshowclosebtn;
            return page;
        }

        private void onPage_Closing_Click(object sender, TabPageAdvClosingEventArgs args)
        {
            if (args.TabPageAdv.Text == Utils.STR_DEFAULT)
            {
                args.Cancel = true;
            }
        }

        private void VedicaChartSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void RefreshChartForm()
        {
            SaveAllChartInfo();
            ReLoadAllChart();
        }

        private void SaveAllChartInfo()
        {
            _workconfigs.Clear();
            _workconfigs.Add(new Models.WorkspaceConfig(true));
            int count = this.MainTabControl.TabPages.Count;
            for (int i = 1; i < count; i++)
            {
                Models.WorkspaceConfig config = new Models.WorkspaceConfig(false);
                config._name = this.MainTabControl.TabPages[i].Text;
                foreach (FormChart chart in this.MainTabControl.TabPages[i].Controls)
                {
                    Models.ChartInfo chartinfo = new Models.ChartInfo();
                    chartinfo._symbol = chart.Text;
                    chartinfo._pos = new Point(chart.Top, chart.Left);
                    chartinfo._size = chart.Size;
                    config._symbols.Add(chartinfo);
                }
                _workconfigs.Add(config);
            }
        }
        private Models.WorkspaceConfig GetWorkspaceLConfig(string workname)
        {
            foreach (Models.WorkspaceConfig config in _workconfigs)
            {
                if (config._name == workname)
                {
                    return config;
                }
            }
            return null;
        }

        private void ReLoadAllChart()
        {
            foreach (TabPageAdv page in this.MainTabControl.TabPages)
            {

                Models.WorkspaceConfig config = GetWorkspaceLConfig(page.Text);
                if (config == null) continue;
                page.Controls.Clear();
                foreach (Models.ChartInfo chartinfo in config._symbols)
                {
                    AddNewChartByChartInfoInPage(chartinfo, page);
                }
            }
        }

        private void HelpTopicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Utils.URL_HELP_TOPIC);
        }

        private void SupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Utils.URL_SUPPORT);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.TopMost = true;
            form.Show(_form);
        }

        // Workspace Menu Listener
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewWorkMenuItem form = new FormNewWorkMenuItem();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (IsExitenceWorkSpace(form._workname)) return;
                AddNewWorkSpace(form._workname);
                AddNewRecent(form._workname);
                int select = this.MainTabControl.TabPages.Count - 1;
                this.MainTabControl.SelectedIndex = select;
            }
        }

        private void AddNewRecent(string workname)
        {
            string recent = Path.GetFileNameWithoutExtension(Utils.GetSaveFilePath(workname));
            if (_recentworks.IndexOf(recent) == -1) return;
            _recentworks.RemoveAt(_recentworks.IndexOf(recent));
            _recentworks.Add(recent);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoadWorkSpace form = new FormLoadWorkSpace();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (IsExitenceWorkSpace(form._workname)) return;
                AddOpenWorkSpace(form._workname);

                AddNewRecent(form._workname);
                int select = this.MainTabControl.TabPages.Count - 1;
                this.MainTabControl.SelectedIndex = select;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.MainTabControl.SelectedIndex;
            if (this.MainTabControl.SelectedIndex != 0)
            {
                SaveWorkSpace(this.MainTabControl.TabPages[index]);
                MessageBox.Show(Utils.MSGB_SAVE);
            }
        }

        private void SaveWorkSpace(TabPageAdv selected_page)
        {
            Models.WorkspaceConfig config = new Models.WorkspaceConfig(false);
            config._name = selected_page.Text;
            config._datetime = DateTime.Now;
            foreach (FormChart chart in selected_page.Controls)
            {
                Models.ChartInfo chartinfo = new Models.ChartInfo();
                chartinfo._symbol = chart.Text;
                chartinfo._pos = new Point(chart.Top, chart.Left);
                chartinfo._size = chart.Size;
                config._symbols.Add(chartinfo);
            }
            config.Save();
        }

        private void SaveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = this.MainTabControl.TabPages.Count;
            for (int i = 1; i < count; i++)
            {
                SaveWorkSpace(this.MainTabControl.TabPages[i]);
            }
            MessageBox.Show(Utils.MSGB_SAVE);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.MainTabControl.SelectedIndex;

            if (this.MainTabControl.SelectedIndex != 0)
            {
                TabPageAdv selectedPage = this.MainTabControl.TabPages[index];
                string workname = selectedPage.Text;
                selectedPage.Close();
                string filepathForDel = Utils.GetSaveFilePath(workname);
                if (File.Exists(filepathForDel))
                {
                    File.Delete(filepathForDel);
                }
                MessageBox.Show(Utils.MSGB_DELETE);
            }

        }

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int index = this.MainTabControl.SelectedIndex;
            if (this.MainTabControl.SelectedIndex != 0)
            {
                TabPageAdv selected_page = this.MainTabControl.TabPages[index];
                FormRenameWorkMenuItem form = new FormRenameWorkMenuItem(selected_page.Text);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (IsExitenceWorkSpace(form._workname)) return;
                    selected_page.Text = form._workname;
                }
            }
        }

        private bool IsExitenceWorkSpace(string workname)
        {
            foreach (TabPageAdv page in this.MainTabControl.TabPages)
            {
                if (workname == page.Text)
                {
                    MessageBox.Show(Utils.MSGB_WORK_EXISTENCE);
                    return true;
                }
            }
            return false;
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = this.MainTabControl.SelectedIndex;
            if (this.MainTabControl.SelectedIndex != 0)
            {
                this.MainTabControl.TabPages[index].Close();
            }
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = this.MainTabControl.TabPages.Count;
            for (int i = 1; i < count; i++)
            {
                this.MainTabControl.SelectedTab.Close();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _form.Close();
        }

        private void RecentWorkSpaceToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string workname = e.ClickedItem.Text;

            if (IsExitenceWorkSpace(workname)) return;
            AddOpenWorkSpace(workname);
            int select = this.MainTabControl.TabPages.Count - 1;
            this.MainTabControl.SelectedIndex = select;
        }
        private bool IsExistenceSymbol(string symbol)
        {
            foreach (FormChart chart in this.MainTabControl.SelectedTab.Controls)
            {
                if (symbol == chart.Text)
                {
                    MessageBox.Show(Utils.MSGB_CHART_EXISTENCE);
                    return true;
                }
            }
            return false;
        }
        private void NewChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewChartMenuItem form = new FormNewChartMenuItem();
            if (form.ShowDialog() == DialogResult.OK)
            {
                string symbol = form._symbol;
                if (IsExistenceSymbol(symbol))
                {
                    return;
                }
                if (this.MainTabControl.SelectedTab.Controls.Count == 0)
                {
                    Models.ChartInfo chartinfo = new Models.ChartInfo(symbol, new Point(10, 10));
                    if (!AddNewChartByChartInfo(chartinfo))
                    {
                        MessageBox.Show(Utils.MSGB_SYMBOL_NO_EXISTENCE);
                    }
                }
                else
                {
                    FormChart chart = (FormChart)this.MainTabControl.SelectedTab.Controls[0];
                    Models.ChartInfo chartinfo = new Models.ChartInfo(symbol, new Point(chart.Top + 20, chart.Left + 20));
                    if (!AddNewChartByChartInfo(chartinfo))
                    {
                        MessageBox.Show(Utils.MSGB_SYMBOL_NO_EXISTENCE);
                    }
                }
            }
        }
        private List<List<string>> GetMarketDataByName(int index){
            string name = Utils.MARKET_FILE_LIST[index];
            if (_marketdatas.Count == 0) return null;
            foreach (KeyValuePair<string, List<List<string>>> tmp in _marketdatas)
            {
                if (name == tmp.Key)
                {
                    return tmp.Value;
                }
            }
            return null;
        }

        private void VedicaSectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _market_sector_form = new FormVedicaSector(GetMarketDataByName(2));
            _market_sector_form.Show();
        }

        private void VedicaIndustryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _market_industry_form = new FormVedicaIndustry(GetMarketDataByName(1));
            _market_industry_form.Show();
        }

        private void SignalsScannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _market_signal_form = new FormSignalScanner(GetMarketDataByName(0));
            _market_signal_form.Show();
        }

        private void ShriInvestcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Utils.URL_SHRI_INVEST);
        }

        private void YahooFinanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Utils.URL_YAHOO_FINANCE);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ChartSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChartsSetting form = new FormChartsSetting();
            form.TopMost = true;
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshChartForm();
                this.Refresh();
            }
        }

        private void SettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ASignalAlertsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ASignalAlertsSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
