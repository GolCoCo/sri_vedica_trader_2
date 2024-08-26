using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace VedicaTrader
{
    public class SettingChart : SettingsBase
    {

        //public static int CHART_LOAD_MORE_COUNT = 500;

        public SettingChart()
        {
            BackRowsToScan = 1;
            DisplayTopCount = 1;
            IgnoreFileNameValue = HardCode.CHART_IGNORE_FILE_NAME;
            RowToLoad = HardCode.CHART_ROW_TO_LOAD;
            FirstRefColumn = HardCode.CHART_REF_LINE1;
            SecondRefColumn = HardCode.CHART_REF_LINE2;
            ShowLavg1 = HardCode.CHART_SHOW_LAVG1TOLAVG4;
            ShowLavg2 = HardCode.CHART_SHOW_LAVG1TOLAVG4;
            ShowLavg3 = HardCode.CHART_SHOW_LAVG1TOLAVG4;
            ShowLavg4 = HardCode.CHART_SHOW_LAVG1TOLAVG4;
            DoNotShowDate = !HardCode.CHART_SHOW_CLOSE_DATE;
            LoadAllLColumns = HardCode.CHART_LOAD_ALL_L_COLUMNS;
            CellSize = HardCode.CHART_SET_PIXEL_SIZE;
            EnabelZoom = HardCode.CHART_ENABLE_ZOOM;

            LColumnToLoad = 1;
            RowToLoadWhenClickLoadMore = 10;
            UpdateHighlighterInterval = 2;
            IgnoreFileNameValue = string.Empty;
            SignalScanMode = SignalScanModeEnum.Both;

            ShowSignalDate = HardCode.CHART_SHOW_DATETIME_FOR_ONLY_SIGNAL;

        }

        public string StockFolder { get; set; }
        public string IgnoreFileNameValue { get; set; }

        public int BackRowsToScan { get; set; }

        public decimal DisplayCorrelation { get; set; }

        public bool AlterWhenChanges { get; set; }

        public bool PushOverAlert { get; set; }

        public string PushOverAPIKey { get; set; }

        public string PushOverUserKey { get; set; }

        public string RefFileSaveFolder { get; set; }
        public int SaveCorr { get; set; }

        public bool DisplayByCorrPercentage { get; set; }

        public bool DispalyByTopCount { get; set; }


        public bool LoadAllLColumns { get; set; }

        public int DisplayTopCount { get; set; }
        public int RowToLoad { get; set; }

        public int FirstRefColumn { get; set; }
        public int SecondRefColumn { get; set; }
        public int RowToLoadWhenClickLoadMore { get; set; }

        public int CellSize { get; set; }
        public int LColumnToLoad { get; set; }
        public bool DoNotShowClose { get; set; }

        public bool DoNotShowDate { get; set; }
        public bool PlaySoundOnUpdate { get; set; }

        public Color ColorPositive { get { return _PositiveColor; } }
        private Color _PositiveColor = Color.FromArgb(20, 100, 20);
        public string PositiveColor
        {
            get
            {
                return string.Join(",", _PositiveColor.R, _PositiveColor.G, _PositiveColor.B)
;
            }
            set
            {
                string[] rgb = value.Split(',');
                if (rgb.Length != 3)
                {
                    return;
                }

                int R, G, B;
                if (int.TryParse(rgb[0], out R) == false)
                {
                    return;
                }

                if (int.TryParse(rgb[1], out G) == false)
                {
                    return;
                }

                if (int.TryParse(rgb[2], out B) == false)
                {
                    return;
                }

                _PositiveColor = Color.FromArgb(R, G, B);
            }
        }



        public Color ColorNegative { get { return _NegativeColor; } }
        private Color _NegativeColor = Color.FromArgb(100, 20, 20);
        public string NegativeColor
        {
            get
            {
                return string.Join(",", _NegativeColor.R, _NegativeColor.G, _NegativeColor.B)
;
            }
            set
            {
                string[] rgb = value.Split(',');
                if (rgb.Length != 3)
                {
                    return;
                }

                int R, G, B;
                if (int.TryParse(rgb[0], out R) == false)
                {
                    return;
                }

                if (int.TryParse(rgb[1], out G) == false)
                {
                    return;
                }

                if (int.TryParse(rgb[2], out B) == false)
                {
                    return;
                }

                _NegativeColor = Color.FromArgb(R, G, B);
            }
        }


        public Color ColorZero { get { return _ZeroColor; } }
        public Color _ZeroColor = Color.FromArgb(0, 0, 0);
        public string ZeroColor
        {
            get
            {
                return string.Join(",", _ZeroColor.R, _ZeroColor.G, _ZeroColor.B)
;
            }
            set
            {
                string[] rgb = value.Split(',');
                if (rgb.Length != 3)
                {
                    return;
                }

                int R, G, B;
                if (int.TryParse(rgb[0], out R) == false)
                {
                    return;
                }

                if (int.TryParse(rgb[1], out G) == false)
                {
                    return;
                }

                if (int.TryParse(rgb[2], out B) == false)
                {
                    return;
                }

                _ZeroColor = Color.FromArgb(R, G, B);
            }
        }



        public Color ColorFirstRefColumn { get { return _FirstRefColumnColor; } }
        public Color _FirstRefColumnColor = Color.FromArgb(255, 255, 0);
        public string FirstRefColumnColor
        {
            get
            {
                return string.Join(",", _FirstRefColumnColor.R, _FirstRefColumnColor.G, _FirstRefColumnColor.B)
;
            }
            set
            {
                string[] rgb = value.Split(',');
                if (rgb.Length != 3)
                {
                    return;
                }

                int R, G, B;
                if (int.TryParse(rgb[0], out R) == false)
                {
                    return;
                }

                if (int.TryParse(rgb[1], out G) == false)
                {
                    return;
                }

                if (int.TryParse(rgb[2], out B) == false)
                {
                    return;
                }

                _FirstRefColumnColor = Color.FromArgb(R, G, B);
            }
        }

        public Color ColorSecondRefColumn { get { return _SecondRefColumnColor; } }
        public Color _SecondRefColumnColor = Color.FromArgb(255, 255, 0);
        public string SecondRefColumnColor
        {
            get
            {
                return string.Join(",", _SecondRefColumnColor.R, _SecondRefColumnColor.G, _SecondRefColumnColor.B)
;
            }
            set
            {
                string[] rgb = value.Split(',');
                if (rgb.Length != 3)
                {
                    return;
                }

                int R, G, B;
                if (int.TryParse(rgb[0], out R) == false)
                {
                    return;
                }

                if (int.TryParse(rgb[1], out G) == false)
                {
                    return;
                }

                if (int.TryParse(rgb[2], out B) == false)
                {
                    return;
                }

                _SecondRefColumnColor = Color.FromArgb(R, G, B);
            }
        }


        public Color ColorUpdateHighlighter { get { return _SecondRefColumnColor; } }
        public Color _UpdateHighlighterColor = Color.FromArgb(255, 255, 0);
        public string UpdateHighlighterColor
        {
            get
            {
                return string.Join(",", _UpdateHighlighterColor.R, _UpdateHighlighterColor.G, _UpdateHighlighterColor.B)
;
            }
            set
            {
                string[] rgb = value.Split(',');
                if (rgb.Length != 3)
                {
                    return;
                }

                int R, G, B;
                if (int.TryParse(rgb[0], out R) == false)
                {
                    return;
                }

                if (int.TryParse(rgb[1], out G) == false)
                {
                    return;
                }

                if (int.TryParse(rgb[2], out B) == false)
                {
                    return;
                }

                _UpdateHighlighterColor = Color.FromArgb(R, G, B);
            }
        }


        public int UpdateHighlighterInterval { get; set; }



        public bool ShowLavg1 { get; set; }
        public bool ShowLavg2 { get; set; }
        public bool ShowLavg3 { get; set; }
        public bool ShowLavg4 { get; set; }

        public string StockRChartsTreeViewDataFolder { get; set; }
        public string OptionsRChartsTreeViewDataFolder { get; set; }
        public string OptionsATChartsTreeViewDataFolder { get; set; }
        public string ReportChartsTreeViewDataFolder { get; set; }

        public double TradeSizeFactor { get; set; }
        public double StopLossPriceFactor { get; set; }
        public double TakeProfitPriceFactor { get; set; }

        public bool UseFxSecGain { get; set; }
        public bool EnabelZoom { get; set; }
        public bool ShowSignalDate { get; set; }


        public int TradingAPI { get; set; }

        public int AlipacaActiveAccount { get; set; }

        public string AlipacaPaperAPIKeyID { get; set; }
        public string AlipacaPaperAPISecretKey { get; set; }

        public string AlipacaLiveAPIKeyID { get; set; }
        public string AlipacaLiveAPISecretKey { get; set; }



        public bool ChartEnableAlipacaTrading { get; set; }
        public bool SignalScanEnableAlipacaTrading { get; set; }

        public bool SignalScanTakeProfitPrice { get; set; }
        public bool SignalScanStopLossPrice { get; set; }
        public bool SignalScanSameTimeStamp { get; set; }
        public bool SignalScanTradeSize { get; set; }
        public bool SignalScanAvgBarAge { get; set; }
        public bool SignalScanTrendStrength { get; set; }
        public bool SignalScanSameTimeStamPercentage { get; set; }
        public bool SignalScanBarsSinceSignal { get; set; }
        public bool SignalScanTimeSinceLastUpdate { get; set; }
        public bool SignalScanSignalAge { get; set; }
        public bool SignalScanSignalTriggerTime { get; set; }



        public int AplacaDataSyncInterval { get; set; }


        public bool AplacaShowOrders { get; set; }

        public SignalScanModeEnum SignalScanMode { get; set; }


        public int DashboardActiveAcount { get; set; }



        public double AnalysisStopLoss { get; set; }
        public double AnalysisTakeProfit { get; set; }

        public string AnalysisPolygonAPIKey { get; set; }
        public string AnalysisOrderPriceHistory { get; set; }

        public bool ZeroMQOrdersEnabled { get; set; }
        public string ZeroMQIP { get; set; }

        public int ZeroMQIncommingPort { get; set; }
        public int ZeroMQOutgoingPort { get; set; }


        public bool DisableTradeConfirm { get; set; }


    }

    public enum SignalScanModeEnum
    {
        Both,
        Buy,
        Sell
    }
}
