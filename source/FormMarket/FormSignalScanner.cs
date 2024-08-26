using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace VedicaTrader
{
    public partial class FormSignalScanner : MetroForm
    {
        private FormSignalScanner _form = null;
        private List<List<string>> _datas = null;
        System.Timers.Timer _testMarkettimer = null;
        public FormSignalScanner(List<List<string>> datas)
        {
            InitializeComponent();
            _form = this;
            _datas = datas;
        }
       

        private void FormSignalScanner_Load(object sender, EventArgs e)
        {
            try
            {
                //UpdateProgressBar();
                SetStyleDataGridView();
                UpdateDataGridView();
            }
            catch (Exception)
            {

            }

        }
        public void UpdateDataGridView()
        {
            if (_datas == null) return;

            this.Invoke((MethodInvoker)delegate
            {
                int index = 0;
                this.RetDataGridView.Rows.Clear();
                foreach(List<string> rowdata in _datas)
                {
                    if (index == 0) {
                        index++;
                        continue;
                    } 
                    AddDataGridViewRow(rowdata);
                }
                index++;
            });
            this.RetDataGridView.Sort(new CustomComparer(SortOrder.Descending));
        }

        public void UpdateDataGridView(List<List<string>> datas)
        {
            _datas = datas;
            if (_datas == null) return;

            this.Invoke((MethodInvoker)delegate
            {
                int index = 0;
                this.RetDataGridView.Rows.Clear();
                foreach (List<string> rowdata in _datas)
                {
                    if (index == 0)
                    {
                        index++;
                        continue;
                    }
                    AddDataGridViewRow(rowdata);
                }
                index++;
            });
            this.RetDataGridView.Sort(new CustomComparer(SortOrder.Descending));
        }

        private void AddDataGridViewRow(List<string> rowdata)
        {
            DataGridViewRow row = new DataGridViewRow();
            int index = 0;
            foreach (string data in rowdata)
            {

                row.Cells.Add(GetDataGridViewTextBoxCell(data));
                index++;
            }
            this.RetDataGridView.Rows.Add(row);
        }

        private DataGridViewTextBoxCell GetDataGridViewTextBoxCell(String text)
        {
            DataGridViewTextBoxCell cell;
            cell = new DataGridViewTextBoxCell() { Value = text };
            if (text.ToUpper() == "BUY")
            {
                cell.Style.BackColor = Color.Green;
            }
            else if (text.ToUpper() == "SELL")
            {
                cell.Style.BackColor = Color.DarkRed;
            }
            else
            {

            }
            cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            return cell;
        }

        private void SetStyleDataGridView()
        {
            this.RetDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.RetDataGridView.ColumnHeadersDefaultCellStyle.Font = Utils.FONT_CAPTION_GRIDVIEW;
            this.RetDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            this.RetDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.RetDataGridView.EnableHeadersVisualStyles = false;
        }

        private void FormSignalScanner_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(_testMarkettimer != null)
            {
                _testMarkettimer.Close();
            }
        }

        int value = 5;
        public void UpdateProgressBar()
        {
            _testMarkettimer = new System.Timers.Timer();
            _testMarkettimer.Elapsed += new ElapsedEventHandler(OnTestMarketAPI);
            _testMarkettimer.Interval = 100;
            _testMarkettimer.Enabled = true;
            _testMarkettimer.Start();
        }

        private void OnTestMarketAPI(object sender, ElapsedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.ProgressBar.Value = (value) % 100;
                value = value + 5;
            });
        }
    }
}
