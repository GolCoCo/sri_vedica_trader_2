using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VedicaTrader
{
    public class Models
    {
        public class WorkspaceConfig
        {
            public WorkspaceConfig(bool isdefault)
            {
                if (isdefault)
                {
                    _isdefault = true;
                    _name = "Default";
                    _symbols = new List<ChartInfo>();
                    _symbols.Add(new ChartInfo("AAPL", new Point(10, 10)));
                    _symbols.Add(new ChartInfo("FB", new Point(30, 30)));
                    _symbols.Add(new ChartInfo("NVDA", new Point(50, 50)));
                    _symbols.Add(new ChartInfo("TSLA", new Point(70, 70)));
                    _datetime = DateTime.Now;
                }
                else
                {
                    _isdefault = false;
                    _name = "";
                    _symbols = new List<ChartInfo>();
                    _datetime = DateTime.Now;
                }
            }

            public string _WPID { get; set; }

            public bool _isdefault { get; set; }

            public string _name { get;  set; }
            public List<ChartInfo> _symbols { get;  set; }
            public DateTime _datetime { get;  set; }

            public void Save()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(_name);
                sb.AppendLine(_datetime.ToString());
                foreach(ChartInfo ch in _symbols)
                {
                    StringBuilder tsb = new StringBuilder();
                    tsb.Append(String.Format("{0}", ch._symbol));
                    tsb.Append(String.Format(",{0},{1}", ch._pos.X, ch._pos.Y));
                    tsb.Append(String.Format(",{0},{1}", ch._size.Width, ch._size.Height));
                    sb.AppendLine(tsb.ToString());
                }
                File.WriteAllText(Utils.GetSaveFilePath(this._name), Utils.Encrypt(sb.ToString(), HardCode.CRYPTO_KEY));
            }
        }


        public class ChartInfo
        {
            public ChartInfo(string symbol, Point pos)
            {
                _symbol = symbol;
                _size = new Size(400, 400);
                _pos = pos;
            }

            public ChartInfo()
            {

            }

            public string _symbol { get;  set; }
            public Size _size { get;  set; }
            public Point _pos { get;  set; }
        }
    }


}
