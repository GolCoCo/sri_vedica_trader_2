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
    public partial class FormVedicaIndustry : MetroForm
    {
        private FormVedicaIndustry _form = null;
        private List<List<string>> _datas = null;

        public FormVedicaIndustry(List<List<string>> datas)
        {
            InitializeComponent();
            _form = this;
            _datas = datas;
        }

        private void FormVedicaIndustry_Load(object sender, EventArgs e)
        {
            try
            {
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
                foreach (List<string> rowdata in _datas)
                {
                    if (index == 0)
                    {
                        index++;
                        continue;
                    }
                    AddDataGridViewRow(rowdata);
                    index++;
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
                    if (index == 0)
                    {
                        index++;
                        continue;
                    }
                    AddDataGridViewRow(rowdata);
                    index++;
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
            if(sell > 0.5)
            {
                backcolor = Color.DarkRed;
            }
            foreach (string data in rowdata)
            {
                row.Cells.Add(GetDataGridViewTextBoxCell(data, backcolor));
            }
            this.RetDataGridView.Rows.Add(row);
        }

        private DataGridViewTextBoxCell GetDataGridViewTextBoxCell(String text, Color backcolor)
        {
            DataGridViewTextBoxCell cell;
            cell = new DataGridViewTextBoxCell() { Value = text };
            cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cell.Style.BackColor = backcolor;
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

        private void FormVedicaIndustry_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
