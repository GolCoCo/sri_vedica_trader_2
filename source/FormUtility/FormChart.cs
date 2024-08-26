using Syncfusion.Drawing;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VedicaTrader;
using static VedicaTrader.Utils;
using TH = System.Threading;
using TM = System.Timers;

namespace VedicaTrader
{
    public partial class FormChart : MetroForm
    {
        bool IsShowValue = true;
        public bool IsSector = false;
        private int ChartKind = -1;
        private int date_index = 0;
        private int time_index = 0;
        private List<string> col_headers;

        private TM.Timer tmZoom = new TM.Timer();

        private List<Utils.ChartItem> DataList;
        private int CurrentDataCount = 0;
        private int NewAddedDataCount = 0;
        private int ColCount = 0;

        private GridBorder firstRefBorder;
        private GridBorder secondRefBorder;
        private GridBorder updateHighlighterBorder;
        private GridBorder thickBorder;
        private ZoomGrid zoom;

        private List<List<string>> _datas = null;
        private string _filename = null;
        private SettingChart _setting;
        public string _ID = "";
        public GridControl gridData = null;

        public FormChart(string filename, List<List<string>> datas, int ChartKind = -1)
        {
            _filename = filename;
            _datas = datas;
            this.ChartKind = ChartKind;
            InitializeComponent();
            this.Text = _filename;
            UpdateUIBySetting();
        }
       
        public GridControl GetGridControl()
        {

            GridBaseStyle gridBaseStyle1 = new GridBaseStyle();
            GridBaseStyle gridBaseStyle2 = new GridBaseStyle();
            GridBaseStyle gridBaseStyle3 = new GridBaseStyle();
            GridBaseStyle gridBaseStyle4 = new GridBaseStyle();
            GridCellInfo gridCellInfo1 = new GridCellInfo();
            GridControl gridcontrol = new GridControl();
            gridcontrol.AllowDragSelectedCols = true;

            gridBaseStyle1.Name = "Header";
            gridBaseStyle1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.CellType = "Header";
            gridBaseStyle1.StyleInfo.Font.Bold = true;
            gridBaseStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle1.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle2.Name = "Standard";
            gridBaseStyle2.StyleInfo.Font.Facename = "Tahoma";
            gridBaseStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle3.Name = "Column Header";
            gridBaseStyle3.StyleInfo.BaseStyle = "Header";
            gridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle4.Name = "Row Header";
            gridBaseStyle4.StyleInfo.BaseStyle = "Header";
            gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridcontrol.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            gridcontrol.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
            gridcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            gridcontrol.ForeColor = System.Drawing.SystemColors.ControlText;
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridcontrol.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1});
            gridcontrol.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            gridcontrol.HorizontalScrollTips = true;
            gridcontrol.HScrollBehavior = Syncfusion.Windows.Forms.Grid.GridScrollbarMode.Enabled;
            gridcontrol.HScrollPixel = true;
            gridcontrol.Location = new System.Drawing.Point(0, 0);
            gridcontrol.MetroScrollBars = true;
            gridcontrol.HScroll = true;
            gridcontrol.Name = "gridData";
            gridcontrol.Properties.ColHeaders = false;
            gridcontrol.Properties.RowHeaders = false;
            gridcontrol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            gridcontrol.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)});
            gridcontrol.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            gridcontrol.ShowColumnHeaders = false;
            gridcontrol.ShowRowHeaders = false;
            gridcontrol.Size = new System.Drawing.Size(538, 358);
            gridcontrol.SmartSizeBox = false;
            gridcontrol.TabIndex = 0;
            gridcontrol.UseRightToLeftCompatibleTextBox = true;
            gridcontrol.VScrollBehavior = Syncfusion.Windows.Forms.Grid.GridScrollbarMode.Enabled;
            gridcontrol.HScrollPixelPosChanged += new Syncfusion.Windows.Forms.Grid.GridScrollPositionChangedEventHandler(this.gridData_HScrollPixelPosChanged);
            gridcontrol.CellClick += new Syncfusion.Windows.Forms.Grid.GridCellClickEventHandler(this.gridData_CellClick);
            gridcontrol.CellMouseDown += new Syncfusion.Windows.Forms.Grid.GridCellMouseEventHandler(this.gridData_CellMouseDown);

            gridcontrol.DefaultColWidth = _setting.CellSize + 5;
            gridcontrol.DefaultRowHeight = _setting.CellSize + 5;

            gridcontrol.BackColor = Color.Black;
            gridcontrol.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            gridcontrol.Properties.GridLineColor = Color.Black;
            gridcontrol.MetroScrollBars = true;
            gridcontrol.GridOfficeScrollBars = OfficeScrollBars.Metro;
            gridcontrol.Properties.ForceImmediateRepaint = false;
            gridcontrol.VerticalScrollTips = true;
            gridcontrol.ScrollTipFeedback += new Syncfusion.Windows.Forms.ScrollTipFeedbackEventHandler(gridData_ScrollTipFeedback);
            gridcontrol.ResetVolatileData();
            loadMoreToolStripMenuItem.Text = loadMoreToolStripMenuItem.Text + string.Format("({0})", _setting.RowToLoadWhenClickLoadMore);
            gridcontrol.MouseWheelZoom += GridData_MouseWheelZoom;
            ZoomGrid.ZoomGridControlCell = false;
            zoom = new ZoomGrid(gridcontrol);
            gridcontrol.QueryCellInfo += new GridQueryCellInfoEventHandler(GridQueryCellInfo);
            return gridcontrol;
        }

        public void UpdateUIBySetting()
        {
            _setting = SettingChart.Load<SettingChart>();
            if (_setting == null)
            {
                _setting = new SettingChart();
            }
            firstRefBorder = new GridBorder(GridBorderStyle.Solid, _setting.ColorFirstRefColumn, GridBorderWeight.ExtraThin);
            secondRefBorder = new GridBorder(GridBorderStyle.Solid, _setting.ColorSecondRefColumn, GridBorderWeight.ExtraThin);
            updateHighlighterBorder = new GridBorder(GridBorderStyle.Solid, _setting.ColorUpdateHighlighter, GridBorderWeight.ExtraThin);
            thickBorder = new GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.ExtraExtraThick);

            gridData = GetGridControl();
            this.MainPanel.Controls.Add(gridData);
            trackBarEx1.Visible = _setting.EnabelZoom;
            placeOrderToolStripMenuItem.Visible = _setting.ChartEnableAlipacaTrading;
            this.Refresh();
        }

        public void UpdateUIBySettingByTime(string filename, List<List<string>> datas, bool isonlystyle)
        {
            if (!isonlystyle)
            {
                _filename = filename;
                _datas = datas;
            }
            _setting = SettingChart.Load<SettingChart>();
            if (_setting == null)
            {
                _setting = new SettingChart();
            }

            InitWhenLoad();
            firstRefBorder = new GridBorder(GridBorderStyle.Solid, _setting.ColorFirstRefColumn, GridBorderWeight.ExtraThin);
            secondRefBorder = new GridBorder(GridBorderStyle.Solid, _setting.ColorSecondRefColumn, GridBorderWeight.ExtraThin);
            updateHighlighterBorder = new GridBorder(GridBorderStyle.Solid, _setting.ColorUpdateHighlighter, GridBorderWeight.ExtraThin);
            thickBorder = new GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.ExtraExtraThick);

            this.MainPanel.Controls.Remove(gridData);
            gridData = GetGridControl();
            this.MainPanel.Controls.Add(gridData);
            trackBarEx1.Visible = _setting.EnabelZoom;
            placeOrderToolStripMenuItem.Visible = _setting.ChartEnableAlipacaTrading;
            this.Refresh();
            GC.Collect();

        }


        private void GridData_MouseWheelZoom(object sender, MouseWheelZoomEventArgs e)
        {
            tmZoom.Stop();
            gridData.MouseWheelZoom -= GridData_MouseWheelZoom;
            trackBarEx1.Value += (e.Delta > 0 ? 5 : -5);
            zoom.zoomGrid(trackBarEx1.Value.ToString());
            tmZoom.Start();
        }

        private void GridData_QueryColCount(object sender, GridRowColCountEventArgs e)
        {
            e.Count = ColCount;
            e.Handled = true;
        }

        void GridQueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            if (e.RowIndex > 0 && e.RowIndex <= CurrentDataCount)
            {

                if (e.ColIndex > 0)
                {

                    if (DataList.Count == 0)
                    {
                        e.Handled = true;
                        return;
                    }
                    try
                    {
                        if (ChartKind != 3)
                        {

                            Utils.ChartItem item = DataList[DataList.Count - CurrentDataCount + e.RowIndex - 1];
                            e.Style.CellType = "Static";
                            switch (e.ColIndex)
                            {
                                case 1:
                                    e.Style.VerticalAlignment = GridVerticalAlignment.Top;
                                    e.Style.Text = item.StringDateTime;
                                    e.Style.TextColor = Color.Yellow;
                                    //e.Style.Borders.All = normalBorder;
                                    e.Style.Font.Size = 8f;
                                    break;
                                case 2:
                                    e.Style.VerticalAlignment = GridVerticalAlignment.Top;
                                    e.Style.Text = item.ClosePrice;
                                    e.Style.TextColor = Color.Yellow;
                                    //e.Style.Borders.All = normalBorder;
                                    e.Style.Font.Size = 8f;
                                    break;
                                case 3:
                                    e.Style.VerticalAlignment = GridVerticalAlignment.Top;
                                    e.Style.Font.Size = 8f;
                                    if (item.DataSignal == "BUY")
                                    {
                                        e.Style.Text = "B";
                                        e.Style.BackColor = _setting.ColorPositive;
                                    }
                                    else if (item.DataSignal == "SELL")
                                    {

                                        e.Style.Text = "S";
                                        e.Style.BackColor = _setting.ColorNegative;
                                    }
                                    e.Style.CellTipText = item.DataSignal;
                                    e.Style.TextColor = Color.White;
                                    e.Style.Font.Bold = true;
                                    //e.Style.Borders.All = normalBorder;
                                    break;
                                case 4:
                                    //e.Style.Text = item.Lavg1;
                                    e.Style.CellValue = item.Trend;
                                    e.Style.VerticalAlignment = GridVerticalAlignment.Top;
                                    e.Style.HorizontalAlignment = GridHorizontalAlignment.Center;
                                    e.Style.CellTipText = "Trend: " + item.Trend
                                                              + ", Datetime: " + item.StringDateTime + ", Close Price: " + item.ClosePrice;
                                    setCellColor(item.Trend, e);
                                    break;
                                case 5:
                                    //e.Style.Text = item.Lavg1;
                                    e.Style.VerticalAlignment = GridVerticalAlignment.Top;
                                    e.Style.HorizontalAlignment = GridHorizontalAlignment.Center;
                                    e.Style.CellValue = item.Uppper;
                                    e.Style.CellTipText = "Upper: " + item.Uppper
                                                              + ", Datetime: " + item.StringDateTime + ", Close Price: " + item.ClosePrice;
                                    setCellColor(item.Uppper, e);
                                    break;
                                case 6:
                                    //e.Style.Text = item.Lavg1;
                                    e.Style.CellValue = item.Lower;
                                    e.Style.VerticalAlignment = GridVerticalAlignment.Top;
                                    e.Style.HorizontalAlignment = GridHorizontalAlignment.Center;
                                    e.Style.CellTipText = "Lower: " + item.Lower
                                                              + ", Datetime: " + item.StringDateTime + ", Close Price: " + item.ClosePrice;
                                    setCellColor(item.Lower, e);
                                    break;
                                case 7:
                                    //e.Style.Text = item.Lavg1;
                                    e.Style.CellValue = item.Midline;
                                    e.Style.VerticalAlignment = GridVerticalAlignment.Top;
                                    e.Style.HorizontalAlignment = GridHorizontalAlignment.Center;
                                    e.Style.CellTipText = "MidLine: " + item.Midline
                                                              + ", Datetime: " + item.StringDateTime + ", Close Price: " + item.ClosePrice;
                                    setCellColor(item.Midline, e);
                                    break;
                                case 8:
                                    //e.Style.Text = item.Lavg1;
                                    //e.Style.CellValue = item.Lavg1;
                                    e.Style.CellTipText = "Lavg1: " + item.Lavg1
                                                              + ", Datetime: " + item.StringDateTime + ", Close Price: " + item.ClosePrice;
                                    if (_setting.ShowLavg4 == false
                                        && _setting.ShowLavg3 == false
                                        && _setting.ShowLavg2 == false)
                                    {
                                        e.Style.Borders.Right = thickBorder;
                                    }
                                    setCellColor(item.Lavg1, e);
                                    break;
                                case 9:
                                    //e.Style.Text = item.Lavg2;
                                    //e.Style.CellValue = item.Lavg2;
                                    e.Style.CellTipText = "Lavg2: " + item.Lavg2
                                                              + ", Datetime: " + item.StringDateTime + ", Close Price: " + item.ClosePrice;
                                    if (_setting.ShowLavg4 == false && _setting.ShowLavg3 == false)
                                    {
                                        e.Style.Borders.Right = thickBorder;
                                    }
                                    setCellColor(item.Lavg2, e);
                                    break;
                                case 10:
                                    //e.Style.Text = item.Lavg3;
                                    //e.Style.CellValue = item.Lavg3;
                                    e.Style.CellTipText = "Lavg3: " + item.Lavg3
                                                              + ", Datetime: " + item.StringDateTime + ", Close Price: " + item.ClosePrice;
                                    if (_setting.ShowLavg4 == false)
                                    {
                                        e.Style.Borders.Right = thickBorder;
                                    }
                                    setCellColor(item.Lavg3, e);
                                    break;
                                case 11:
                                    //e.Style.Text = item.Lavg4;
                                    //e.Style.CellValue = item.Lavg4;
                                    e.Style.CellTipText = "Lavg4: " + item.Lavg4
                                                              + ", Datetime: " + item.StringDateTime + ", Close Price: " + item.ClosePrice;
                                    e.Style.Borders.Right = thickBorder;
                                    setCellColor(item.Lavg4, e);
                                    break;
                                default:
                                    if (e.ColIndex == _setting.FirstRefColumn + lavgColCount + 3 + 4)
                                    {

                                        e.Style.Borders.Right = firstRefBorder;
                                        e.Style.Borders.Left = firstRefBorder;
                                    }
                                    else if (e.ColIndex == _setting.SecondRefColumn + lavgColCount + 3 + 4)
                                    {
                                        e.Style.Borders.Right = secondRefBorder;
                                        e.Style.Borders.Left = secondRefBorder;

                                    }

                                    string lValue = item.DataList[e.ColIndex - lavgColCount - 4 - 4].Trim();
                                    e.Style.CellTipText = "L" + (e.ColIndex - lavgColCount - 3 - 4)
                                                            + ", Datetime: " + item.StringDateTime + ", Close Price: " + item.ClosePrice;

                                    setCellColor(lValue, e);
                                    break;
                            }
                        }
                        if (CurrentDataCount - e.RowIndex < NewAddedDataCount)
                        {
                            e.Style.Borders.Top = updateHighlighterBorder;
                            e.Style.Borders.Bottom = updateHighlighterBorder;
                        }
                    }
                    catch (Exception)
                    {
                        
                        //MessageBox.Show(String.Format("{0}\n{1}", e.RowIndex, e.ColIndex));
                    }
                }
                e.Handled = true;
            }
        }

        private void setCellColor(string value, GridQueryCellInfoEventArgs e)
        {
            if (ChartKind == 1)
            {
                if (value.StartsWith("-"))
                {
                    e.Style.BackColor = _setting.ColorNegative;
                }
                else if (value == "0")
                {

                    e.Style.BackColor = _setting.ColorZero;
                }
                else
                {
                    e.Style.BackColor = _setting.ColorPositive;
                }
            }
            else
            {
                double cv = 0;

                if (e.ColIndex == date_index || e.ColIndex == time_index)
                {
                    e.Style.BackColor = Color.Black;
                }
                else if (e.Style.CellTipText.Split(':')[0] == "Trend")
                {

                    Double.TryParse(e.Style.CellValue.ToString(), out cv);

                    if (cv >= HardCode._TrendBuy)
                    {
                        e.Style.BackColor = ColorTranslator.FromHtml(HardCode._TrendBuyColor);

                        if (!IsShowValue)
                        {
                            e.Style.TextColor = ColorTranslator.FromHtml(HardCode._TrendBuyColor);
                        }
                        else
                        {
                            e.Style.TextColor = Color.Yellow;
                        }


                    }
                    else if (cv <= HardCode._TrendSell)
                    {
                        e.Style.BackColor = ColorTranslator.FromHtml(HardCode._TrendSellColor);
                        if (!IsShowValue)
                        {
                            e.Style.TextColor = ColorTranslator.FromHtml(HardCode._TrendSellColor);
                        }
                        else
                        {
                            e.Style.TextColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        e.Style.BackColor = Color.Black;
                    }

                }
                else if (e.Style.CellTipText.Split(':')[0] == "Upper")
                {
                    Double.TryParse(e.Style.CellValue.ToString(), out cv);

                    if (cv >= HardCode._UpperBuy)
                    {
                        e.Style.BackColor = ColorTranslator.FromHtml(HardCode._UpperBuyColor);
                        if (!IsShowValue)
                        {
                            e.Style.TextColor = ColorTranslator.FromHtml(HardCode._UpperBuyColor);
                        }
                        else
                        {
                            e.Style.TextColor = Color.Yellow;
                        }

                    }
                    else if (cv <= HardCode._UpperSell)
                    {
                        e.Style.BackColor = ColorTranslator.FromHtml(HardCode._UpperSellColor);
                        if (!IsShowValue)
                        {
                            e.Style.TextColor = ColorTranslator.FromHtml(HardCode._UpperSellColor);
                        }
                        else
                        {
                            e.Style.TextColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        e.Style.BackColor = Color.Black;
                    }

                }
                else if (e.Style.CellTipText.Split(':')[0] == "Lower")
                {
                    Double.TryParse(e.Style.CellValue.ToString(), out cv);

                    if (cv >= HardCode._LowerBuy)
                    {
                        e.Style.BackColor = ColorTranslator.FromHtml(HardCode._LowerBuyColor);

                        if (!IsShowValue)
                        {
                            e.Style.TextColor = ColorTranslator.FromHtml(HardCode._LowerBuyColor);
                        }
                        else
                        {
                            e.Style.TextColor = Color.Yellow;
                        }

                    }
                    else if (cv <= HardCode._LowerSell)
                    {
                        e.Style.BackColor = ColorTranslator.FromHtml(HardCode._LowerSellColor);
                        if (!IsShowValue)
                        {
                            e.Style.TextColor = ColorTranslator.FromHtml(HardCode._LowerSellColor);
                        }
                        else
                        {
                            e.Style.TextColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        e.Style.BackColor = Color.Black;
                    }
                }
                else if (e.Style.CellTipText.Split(':')[0] == "MidLine")
                {
                    Double.TryParse(e.Style.CellValue.ToString(), out cv);

                    if (cv >= HardCode._MidLineBuy)
                    {
                        e.Style.BackColor = ColorTranslator.FromHtml(HardCode._MidLineBuyColor);
                        if (!IsShowValue)
                        {
                            e.Style.TextColor = ColorTranslator.FromHtml(HardCode._MidLineBuyColor);
                        }
                        else
                        {
                            e.Style.TextColor = Color.Yellow;
                        }

                    }
                    else if (cv <= HardCode._MidLineSell)
                    {
                        e.Style.BackColor = ColorTranslator.FromHtml(HardCode._MidLineSellColor);
                        if (!IsShowValue)
                        {
                            e.Style.TextColor = ColorTranslator.FromHtml(HardCode._MidLineSellColor);
                        }
                        else
                        {
                            e.Style.TextColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        e.Style.BackColor = Color.Black;
                    }
                }
                else
                {
                    if (Convert.ToDouble(value) < 0)
                    {
                        e.Style.BackColor = Color.DarkRed;
                    }
                    else if (Convert.ToDouble(value) == 0)
                    {
                        e.Style.BackColor = Color.Black;
                    }
                    else if (Convert.ToDouble(value) > 0)
                    {
                        e.Style.BackColor = Color.DarkGreen;
                    }
                }
            }
        }

        void GridQueryRowHeight(object sender, GridRowColSizeEventArgs e)
        {
            if (ChartKind != 3)
            {
                e.Size = _setting.CellSize + 5;
            }
            e.Handled = true;
        }
        void GridQueryRowCount(object sender, GridRowColCountEventArgs e)
        {
            e.Count = CurrentDataCount+1;
            e.Handled = true;
        }

        private int lavgColCount = 4;
        private int ShownLavgColCount = 0;

        private void frmChart_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => InitWhenLoad());
        }
        
        private void gridData_ScrollTipFeedback(object sender, ScrollTipFeedbackEventArgs e)
        {
            
            e.Size = this.gridData.ScrollTip.GetPreferredSize(e.Text);
        }

        private void InitWhenLoad()
        {
            DataList = new List<Utils.ChartItem>();
            col_headers = new List<string>();
            if (ChartKind != 3)
            {
                ShownLavgColCount = ShownLavgColCount + 4;
                if (_setting.ShowLavg1) ShownLavgColCount++;
                if (_setting.ShowLavg2) ShownLavgColCount++;
                if (_setting.ShowLavg3) ShownLavgColCount++;
                if (_setting.ShowLavg4) ShownLavgColCount++;
            }
            LoadData(true);

        }

        private void LoadData(bool init = false)
        {
            try
            {
                    NewAddedDataCount = 0;

                    int totalRowCount = _datas.Count;
                    int newAddFromIdx = 0;

                    if (totalRowCount <= 1)
                    {
                        return;
                    }

                    if (totalRowCount - 1 <= DataList.Count)
                    {
                        init = true;
                        CurrentDataCount = 0;
                        DataList.Clear();

                    }

                    if (init)
                    {
                        newAddFromIdx = totalRowCount - _setting.RowToLoad > 1 ? totalRowCount - _setting.RowToLoad : 1;
                        CurrentDataCount = totalRowCount - 1 > _setting.RowToLoad ? _setting.RowToLoad : totalRowCount - 1;
                        NewAddedDataCount = CurrentDataCount;
                    }
                    else
                    {
                        newAddFromIdx = DataList.Count + 1;
                        NewAddedDataCount = totalRowCount - DataList.Count - 1;
                        CurrentDataCount += NewAddedDataCount;
                    }
                    if (init)
                    {
                        NewAddedDataCount = 0;
                    }

                    int columnToLoad = -1;
                    bool isDefaultStyleChanged = false;

                    for (int idx = 1; idx < totalRowCount; idx++)
                    {
                        Utils.ChartItem item = new Utils.ChartItem();

                        List<string> datas = _datas[idx];

                        try
                        {
                            item.StringDateTime = String.Format("{0:MM/dd/yy HH:mm}", DateTime.Parse(datas[0] + " " + datas[1]));
                            item.ClosePrice = String.Format("{0}", Math.Round(Double.Parse(datas[5]), 3));
                        }
                        catch (Exception)
                        {
                            item.StringDateTime = datas[0] + " " + datas[1];
                            item.ClosePrice = datas[5];
                        }

                        double signValue;

                        if (isDefaultStyleChanged == false)
                        {
                            columnToLoad = datas.Count - 18;
                            if (_setting.LoadAllLColumns == false)
                            {
                                columnToLoad = columnToLoad < _setting.LColumnToLoad ? columnToLoad : _setting.LColumnToLoad;
                            }

                        }
                        if (double.TryParse(datas[7], out signValue))
                        {
                            if (signValue > 0)
                            {
                                item.DataSignal = "BUY";
                            }
                        }


                        if (double.TryParse(datas[8], out signValue))
                        {
                            if (signValue > 0)
                            {
                                item.DataSignal = "SELL";
                            }
                        }
                        item.Trend = datas[9].Trim();
                        item.Uppper = datas[10].Trim();
                        item.Lower = datas[11].Trim();
                        item.Midline = datas[12].Trim();
                        item.Lavg1 = datas[13].Trim();
                        item.Lavg2 = datas[14].Trim();
                        item.Lavg3 = datas[15].Trim();
                        item.Lavg4 = datas[16].Trim();

                        for (int colIdx = 18; colIdx < columnToLoad + 18; colIdx++)
                        {
                            item.DataList.Add(datas[colIdx].Trim());
                        }

                        if (init)
                        {
                            DataList.Add(item);
                        }
                        else
                        {

                            if (idx >= newAddFromIdx)
                            {
                                DataList.Add(item);
                            }
                        }
                    }

                    ColCount = columnToLoad + 3 + lavgColCount + 4;
                    this.gridData.InvokeIfRequired(p =>
                    {

                        p.BeginUpdate();
                        p.QueryCellInfo += new GridQueryCellInfoEventHandler(GridQueryCellInfo);
                        p.RowCount = CurrentDataCount + 1;
                        p.ColCount = ColCount;
                        p.ColStyles[1].WrapText = false;
                        p.ColStyles[1].AutoSize = true;
                        p.ColStyles[2].WrapText = false;
                        p.ColStyles[2].AutoSize = true;

                    if (!init && File.Exists(Path.Combine(Environment.CurrentDirectory, "sound.wav")))
                            using (SoundPlayer s = new SoundPlayer("sound.wav"))
                            {
                                s.Play();
                            }
                        p.EndUpdate();
                    });

                    this.gridData.InvokeIfRequired(p =>
                    {
                        p.BeginUpdate();
                        if (_setting.DoNotShowClose)
                            p.ColWidths.SetSize(2, 0);
                        else
                            p.ColWidths.ResizeToFit(GridRangeInfo.Col(2));


                        if (_setting.DoNotShowDate)
                            p.ColWidths.SetSize(1, 0);
                        else
                            p.ColWidths.ResizeToFit(GridRangeInfo.Col(1));

                        p.ColWidths.ResizeToFit(GridRangeInfo.Col(3));

                        if (true)
                        {
                            if (IsShowValue)
                            {
                                p.ColWidths.SetSize(4, _setting.CellSize + 30);
                            }
                            else
                            {
                                p.ColWidths.SetSize(4, _setting.CellSize + 8);
                            }
                        }
                        else
                        {
                            p.ColWidths.SetSize(4, 0);
                        }

                        if (true)
                        {
                            if (IsShowValue)
                            {
                                p.ColWidths.SetSize(5, _setting.CellSize + 30);
                            }
                            else
                            {
                                p.ColWidths.SetSize(5, _setting.CellSize + 8);
                            }
                        }
                        else
                        {
                            p.ColWidths.SetSize(5, 0);
                        }

                        if (true)
                        {
                            if (IsShowValue)
                            {
                                p.ColWidths.SetSize(6, _setting.CellSize + 30);
                            }
                            else
                            {
                                p.ColWidths.SetSize(6, _setting.CellSize + 8);
                            }
                        }
                        else
                        {
                            p.ColWidths.SetSize(6, 0);
                        }

                        if (true)
                        {
                            if (IsShowValue)
                            {
                                p.ColWidths.SetSize(7, _setting.CellSize + 30);
                            }
                            else
                            {
                                p.ColWidths.SetSize(7, _setting.CellSize + 8);
                            }

                        }
                        else
                        {
                            p.ColWidths.SetSize(7, 0);
                        }

                        if (_setting.ShowLavg1)
                        {
                            p.ColWidths.SetSize(8, _setting.CellSize + 5);
                        }
                        else
                        {
                            p.ColWidths.SetSize(8, 0);
                        }

                        if (_setting.ShowLavg2)
                        {
                            p.ColWidths.SetSize(9, _setting.CellSize + 5);
                        }
                        else
                        {
                            p.ColWidths.SetSize(9, 0);
                        }
                        if (_setting.ShowLavg3)
                        {
                            p.ColWidths.SetSize(10, _setting.CellSize + 5);
                        }
                        else
                        {
                            p.ColWidths.SetSize(10, 0);
                        }

                        if (_setting.ShowLavg4)
                        {
                            p.ColWidths.SetSize(11, _setting.CellSize + 8);
                        }
                        else
                        {
                            p.ColWidths.SetSize(11, 0);
                        }

                        p.ScrollCellInView(p.RowCount, 1);
                        p.Refresh();
                        p.QueryCellInfo -= new GridQueryCellInfoEventHandler(GridQueryCellInfo);
                        p.EndUpdate();
                    });
                    this.InvokeIfRequired(p => p.ResizeForm());
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            
        }

        private void ResizeForm()
        {
            this.Resize -= frmChart_Resize;

            if (isManualResized == false)
            {

                double width = 0;
                if (ChartKind != 3)
                {
                    width = ((double)(ColCount + ShownLavgColCount) - 3d) * ((double)_setting.CellSize + 5d);
                }


                if (!_setting.DoNotShowClose)
                {
                    width += gridData.ColWidths.GetSize(2);
                    width += 0.05d;
                }

                if (!_setting.DoNotShowDate)
                {
                    width += gridData.ColWidths.GetSize(1);
                    width += 0.05d;
                }


                double height = 0;
                if (ChartKind != 3)
                {
                    height = ((double)CurrentDataCount + 1d) * ((double)_setting.CellSize + 5d + 0.08d);
                }



                Rectangle ScreenArea = System.Windows.Forms.Screen.GetWorkingArea(this);

                if (width + 6 > ScreenArea.Width)
                {
                    width = ScreenArea.Width - 6;
                }

                if (height + 42 > ScreenArea.Height)
                {
                    height = ScreenArea.Height - 42;
                }
                this.Height = (int)height + 42;
                this.Width = (int)width + 6;

                this.Location = new Point((ScreenArea.Width - this.Width) / 2, (ScreenArea.Height - this.Height) / 2);
            }

            this.Resize += frmChart_Resize;
        }

        private void gridData_HScrollPixelPosChanged(object sender, GridScrollPositionChangedEventArgs e)
        {

        }

        private void gridData_CellMouseDown(object sender, GridCellMouseEventArgs e)
        {

        }

        private void loadMoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lock (DataList)
            {
                if (CurrentDataCount == DataList.Count)
                {
                    MessageBoxAdv.Show("No more data to be loaded!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    NewAddedDataCount = 0;
                    if (CurrentDataCount+_setting.RowToLoadWhenClickLoadMore> DataList.Count)
                    {
                        CurrentDataCount += DataList.Count - CurrentDataCount;
                    }
                    else
                    {
                        CurrentDataCount += _setting.RowToLoadWhenClickLoadMore;
                    }

                    this.gridData.InvokeIfRequired(p => {

                        p.BeginUpdate();
                        //p.QueryCellInfo += new GridQueryCellInfoEventHandler(GridQueryCellInfo);
                        p.RowCount = CurrentDataCount+1;
                        p.ColCount = ColCount;
                        p.ColStyles[1].WrapText = false;
                        p.ColStyles[1].AutoSize = true;
                        p.ColStyles[2].WrapText = false;
                        p.ColStyles[2].AutoSize = true;
                        p.EndUpdate();
                    });
                    
                    this.gridData.InvokeIfRequired(p =>
                    {
                        p.BeginUpdate();
                        p.ScrollCellInView(1, 1);
                        p.Refresh();
                        //p.QueryCellInfo -= new GridQueryCellInfoEventHandler(GridQueryCellInfo);
                        p.EndUpdate();
                    });
                    this.InvokeIfRequired(p => p.ResizeForm());
                }
            }
        }

        private void gridData_CellClick(object sender, GridCellClickEventArgs e)
        {
            if(e.MouseEventArgs.Button ==  MouseButtons.Right)
                contextMenuStripEx1.Show(MousePosition.X, MousePosition.Y);
        }

        private bool isManualResized = false;
        private void frmChart_Resize(object sender, EventArgs e)
        {
            isManualResized = true;
        }

        private void trackBarEx1_ValueChanged(object sender, EventArgs e)
        {
            zoom.zoomGrid(trackBarEx1.Value.ToString());
        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FormChart_Deactivate(object sender, EventArgs e)
        {
        }
    }
}
