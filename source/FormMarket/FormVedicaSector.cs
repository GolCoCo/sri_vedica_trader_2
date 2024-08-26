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
    public partial class FormVedicaSector : MetroForm
    {
        private FormVedicaSector _form = null;
        public string _symbol = "";
        private List<List<string>> _datas;
        public FormVedicaSector(List<List<string>> datas)
        {
            InitializeComponent();
            _form = this;
            _datas = datas;
        }

        private void FormVedicaSector_Load(object sender, EventArgs e)
        {
            SetStyleDataGridView();
            UpdateDataGridView();
        }

        public void UpdateDataGridView()
        {
            if (_datas == null) return;
            this.Invoke((MethodInvoker)delegate
            {
                int index = 0;
                this.RetDataGridView.Rows.Clear();
                foreach (List<string> rowdata in _datas)
                {
                    if (index == 0 || index == _datas.Count-1)
                    {
                        index++;
                        continue;
                    }
                    AddDataGridViewRow(rowdata);
                    index++;
                }

                this.StockLabel.Text = _datas[_datas.Count - 1][1];
                this.TotalBuyLabel.Text = _datas[_datas.Count - 1][2];
                this.TotalBuyPLabel.Text = _datas[_datas.Count - 1][3];
                this.TotalSellLabel.Text = _datas[_datas.Count - 1][4];
                this.TotalSellPLabel.Text = _datas[_datas.Count - 1][5];
                if (Double.Parse(_datas[_datas.Count - 1][3]) > 0.5) 
                {
                    AllMarketTLP.BackColor = Color.Green;
                }
                if (Double.Parse(_datas[_datas.Count - 1][5]) > 0.5)
                {
                    AllMarketTLP.BackColor = Color.DarkRed;
                }
            });
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
                    if (index == 0 || index == _datas.Count - 1)
                    {
                        index++;
                        continue;
                    }
                    AddDataGridViewRow(rowdata);
                    index++;
                }

                this.StockLabel.Text = _datas[_datas.Count - 1][1];
                this.StockLabel.Text = _datas[_datas.Count - 1][1];
                this.TotalBuyLabel.Text = _datas[_datas.Count - 1][2];
                this.TotalBuyPLabel.Text = _datas[_datas.Count - 1][3];
                this.TotalSellLabel.Text = _datas[_datas.Count - 1][4];
                this.TotalSellPLabel.Text = _datas[_datas.Count - 1][5];

                if (Double.Parse(_datas[_datas.Count - 1][3]) > 0.5)
                {
                    AllMarketTLP.BackColor = Color.Green;
                }
                if (Double.Parse(_datas[_datas.Count - 1][5]) > 0.5)
                {
                    AllMarketTLP.BackColor = Color.DarkRed;
                }

            });
        }


        private void AddDataGridViewRow(List<string> rowdata)
        {
            DataGridViewRow row = new DataGridViewRow();
            double buy = Double.Parse(rowdata[3]);
            double sell = Double.Parse(rowdata[5]);
            Color backcolor = Color.DimGray;
            if (buy > 0.5)
            {
                backcolor = Color.Green;
            }
            if (sell > 0.5)
            {
                backcolor = Color.DarkRed;
            }

            for (int i = 0; i < rowdata.Count; i++) {

                row.Cells.Add(GetDataGridViewTextBoxCell(rowdata[i], backcolor));
            }
            this.RetDataGridView.Rows.Add(row);
        }

        private DataGridViewTextBoxCell GetDataGridViewTextBoxCell(String text, Color backcolor)
        {
            DataGridViewTextBoxCell cell;
            cell = new DataGridViewTextBoxCell() { Value = text };
            cell.Style.BackColor = backcolor;
            cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            return cell;
        }

        private void SetStyleDataGridView()
        {
            this.RetDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.RetDataGridView.ColumnHeadersDefaultCellStyle.Font = Utils.FONT_CAPTION_GRIDVIEW;
            this.RetDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            this.RetDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.RetDataGridView.EnableHeadersVisualStyles = false;
        }

        private void FormVedicaSector_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
