using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using log4net;
using log4net.Config;
using ICSharpCode.SharpZipLib.Zip;
using System.Media;
using System.Runtime.InteropServices;
using Standart.Hash.xxHash;
using DeviceId;
using System.Collections;

namespace VedicaTrader
{
    public class Utils
    {
        // SQLite filename
        public static string SQLITE_FILENAME_WPCONFIG = "wpconfigs.db";
        public static string SQLITE_TABLENAME_WPCONFIG = "WPCONFIGS";
        public static List<string> MARKET_FILE_LIST = new List<string>() {
            "All_Signals_Report.csv",
            "Industry_Report.csv",
            "Sector_Report.csv"};
        // Constants
        public enum PUSER_TYPE { EOD, RT, MARKET_RT };

        public static string RES_SUCCESS = "success";
        public static string RES_EXPIRED = "expired_date";
        public static string RES_NO_SUBS = "no_subscriptions";
        public static string RES_FAIL_CON = "failed for connection";
        public static string RES_WRONG_CRED = "wrong_credential";

        public static string URL_HELP_TOPIC = "https://www.xyz.com/VedicaTraderRT/help/";
        public static string URL_SUPPORT = "https://www.xyz.com/VedicaTraderRT/support/";

        public static string URL_SHRI_INVEST = "https://shriinvest.com/";
        public static string URL_YAHOO_FINANCE = "https://finance.yahoo.com/";
        public static string URL_FORGOT_PASSWORD = "https://shriinvest.com/srimember/login?sendpass";
        public static string URL_SIGNUP = "https://shriinvest.com/srimember/signup";

        public static string STR_CONNECTED = "CONNECTED";
        public static string STR_DISCONNECTED = "DISCONNECTED";
        public static string STR_DEFAULT = "Default";
        public static string STR_RECENT_NAME = "recent.ini";

        // Messagebox
        public static string MSGB_ALERT = "ALERT!";
        public static string MSGB_WARNING = "WARNING!";
        public static string MSGB_LOGIN_EMPTY = "Please enter your username and password!";
        public static string MSGB_EXPIRED_DATE = "This user is expired now. \n Please confirm it again";
        public static string MSGB_NO_SUBSCRIPTION = "You do not have a valid subscription for this server.\n Please visit www.proxmox.com to get list available options.";
        public static string MSGB_FAILED_CONNECTION = "The connection for login failed. \n Please confirm it again";
        public static string MSGB_WRONG_CRED = "WRONG CREDENTIALS \n Invaild username or password\nPlease confirm it again";
        public static string MSGB_SAVE = "Successful to save!";
        public static string MSGB_UPDATE = "Successful to update!";
        public static string MSGB_DELETE = "Successful to delete!";
        public static string MSGB_ERROR = "Erorr occured!";
        public static string MSGB_SYMBOL_NO_EXISTENCE = "The CSV file matched by the symbol is no existed.";
        public static string MSGB_WORK_EXISTENCE = "The workspace is already existed.";
        public static string MSGB_WORK_NO_EXISTENCE = "The workspace is no existed.";
        public static string MSGB_CHART_EXISTENCE = "The chart is already showed.";
        public static string MSGB_NEW_DEVICE_DETECTED = "New Device ID was Detected.\n Would you activate with this ID now?";

        public static Color CLR_RED = Color.DarkRed;
        public static Color CLR_GREEN = Color.Green;
        public static Font FONT_CAPTION_GRIDVIEW = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public static DateTime GetDateTimeFromString(string value)
        {
            DateTime d = DateTime.ParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            return d;
        }

        public static string GetSaveFilePath(string workname)
        {
            if(workname== STR_RECENT_NAME)
            {
                return Path.Combine(HardCode.STR_SAVE_FOLDER_PATH, String.Format("{0}", workname));
            }
            else
            {
                return Path.Combine(HardCode.STR_SAVE_FOLDER_PATH, String.Format("{0}.cfg", workname));
            }
            
        }

        public static string GetSaveFolderPath()
        {
            string documentpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\VedicaTraderRT";
            if(!Directory.Exists(@documentpath))
{
                Directory.CreateDirectory(@documentpath);
            }
            return documentpath;
        }
        public static void WriteRecentData(List<string> recents)
        {
            if (recents.Count == 0) return;
            if (File.Exists(HardCode.STR_SAVE_FOLDER_PATH+"\\"+STR_RECENT_NAME))
            {
                File.Delete(HardCode.STR_SAVE_FOLDER_PATH + "\\" + STR_RECENT_NAME);
            }
            StringBuilder sb = new StringBuilder();

            int index = 0;

            for (int i = recents.Count - 1; i >= 0; i--)
            {
                if (index > 5)
                {
                    break;
                }
                else
                {
                    sb.AppendLine(recents[i]);
                }
                index++;
            }
            File.WriteAllText(@GetSaveFilePath(STR_RECENT_NAME), sb.ToString());
        }

        public static List<string> GetRecentsData()
        {
            if (File.Exists(@GetSaveFilePath(STR_RECENT_NAME)))
            {
                string[] recents = File.ReadAllLines(@GetSaveFilePath(STR_RECENT_NAME));
                return new List<string>(recents);
            }
            return null;
        }


        public static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public static Dictionary<string, List<List<string>>> GetAllDatasFromStream(Stream fs)
        {
            Dictionary<string, List<List<string>>> datas = new Dictionary<string, List<List<string>>>();

            ZipFile zipArchive = new ZipFile(fs);
            foreach (ZipEntry elementInsideZip in zipArchive)
            {
                String ZipArchiveName = elementInsideZip.Name;
                Stream zipStream = zipArchive.GetInputStream(elementInsideZip);
                List<List<string>> csvdatas = GetValuesFromCSV(new StreamReader(zipStream));
                datas.Add(ZipArchiveName, csvdatas);
            }

            return datas;
        }
        public static List<string> GetEndPointAndBusketAndFileName(String url)
        {
            List<string> retlist = new List<string>();
            Uri myUri = new Uri(url);
            string[] seg = myUri.Segments;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < seg.Length - 1; i++)
            {
                sb.Append(seg[i]);
            }
            string endpoint = myUri.Authority;
            string tmpbusket = sb.ToString();
            string busket = tmpbusket.Substring(1, tmpbusket.Length - 2);
            string filename = seg.Last<string>();
            retlist.Add(endpoint);
            retlist.Add(busket);
            retlist.Add(filename);
            return retlist;
        }

        public static string GetDeviceID()
        {
            DeviceIdBuilder deviceId = new DeviceIdBuilder();
            return deviceId.AddMachineName().AddMacAddress().ToString();
        }

        public static string GenerateHashValueForDeviceID(string data)
        {
            byte[] data1 = Encoding.UTF8.GetBytes(data);

            ulong h64 = xxHash64.ComputeHash(data1, data1.Length);

            return longToHex(h64);
        }
        private static string longToHex(ulong l)
        {

            return String.Format("{0:X}", l);

        }

        public static List<List<String>> GetValuesFromCSV(StreamReader reader)
        {
            string line;
            List<List<String>> datasByRow = new List<List<String>>();
            while ((line = reader.ReadLine()) != null)
            {
                List<string> row = new List<string>();
                string[] X = line.Split(',');
                for (int i = 0; i < X.Length; i++)
                {
                    row.Add(X[i]);
                }
                datasByRow.Add(new List<string>(row));
                row.Clear();
            }
            return datasByRow;
        }

        public static Models.WorkspaceConfig LoadWorkspaceInfo(string workanme)
        {
            try
            {
                Models.WorkspaceConfig config = new Models.WorkspaceConfig(false);
                String cyber = File.ReadAllText(GetSaveFilePath(workanme));
                string[] lines = Decrypt(cyber, HardCode.CRYPTO_KEY).Split('\n');
                int index = 0;
                foreach (string line in lines)
                {
                    if (line == "") continue;
                    if (index == 0)
                    {
                        config._name = line;

                    }
                    else if (index == 1)
                    {
                        config._datetime = DateTime.Parse(line);
                    }
                    else
                    {
                        Models.ChartInfo ch = new Models.ChartInfo();
                        string[] infos = line.Split(',');
                        ch._symbol = infos[0];
                        ch._pos = new Point(Int32.Parse(infos[1]), Int32.Parse(infos[2]));
                        ch._size = new Size(Int32.Parse(infos[3]), Int32.Parse(infos[4]));
                        config._symbols.Add(ch);
                    }

                    index++;
                }
                return config;
            }
            catch (Exception)
            {
                MessageBox.Show(Utils.MSGB_WORK_NO_EXISTENCE);
            }

            return null;
        }

        public static string Decrypt(string stringToDecrypt, string key)
        {
            string result = null;

            if (string.IsNullOrEmpty(stringToDecrypt))
            {
                throw new ArgumentException("An empty string value cannot be encrypted.");
            }

            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("Cannot decrypt using an empty key. Please supply a decryption key.");
            }

            try
            {
                System.Security.Cryptography.CspParameters cspp = new System.Security.Cryptography.CspParameters();
                cspp.KeyContainerName = key;

                System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider(cspp);
                rsa.PersistKeyInCsp = true;

                string[] decryptArray = stringToDecrypt.Split(new string[] { "-" }, StringSplitOptions.None);
                byte[] decryptByteArray = Array.ConvertAll<string, byte>(decryptArray, (s => Convert.ToByte(byte.Parse(s, System.Globalization.NumberStyles.HexNumber))));

                byte[] bytes = rsa.Decrypt(decryptByteArray, true);

                result = System.Text.UTF8Encoding.UTF8.GetString(bytes);
            }
            finally
            {
                // no need for further processing
            }

            return result;
        }

        public static string Encrypt(string stringToEncrypt, string key)
        {
            if (string.IsNullOrEmpty(stringToEncrypt))
            {
                throw new ArgumentException("An empty string value cannot be encrypted.");
            }

            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("Cannot encrypt using an empty key. Please supply an encryption key.");
            }

            System.Security.Cryptography.CspParameters cspp = new System.Security.Cryptography.CspParameters();
            cspp.KeyContainerName = key;

            System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;

            byte[] bytes = rsa.Encrypt(System.Text.UTF8Encoding.UTF8.GetBytes(stringToEncrypt), true);

            return BitConverter.ToString(bytes);
        }

        public class ManagerSoundPlayer
        {
            public SoundPlayer _soundplayer;
            public ManagerSoundPlayer()
            {
                this._soundplayer = new SoundPlayer(global::VedicaTrader.Resource1.close);
            }
            public void Play()
            {
                this._soundplayer.Play();
            }
        }

        public class ChartItem
        {
            public ChartItem()
            {
                DataList = new List<string>();
            }
            public string DataSignal { get; set; }
            public string ClosePrice { get; set; }
            public string Gain { get; set; }
            public string Lavg1 { get; set; }
            public string Lavg2 { get; set; }
            public string Lavg3 { get; set; }
            public string Lavg4 { get; set; }
            public string Trend { get; set; }
            public string Uppper { get; set; }
            public string Lower { get; set; }
            public string Midline { get; set; }
            public string StringDateTime { get; set; }
            public List<string> DataList { get; set; }
        }

        public class DynamicColor : IComparable<DynamicColor>
        {
            public DynamicColor(double value, string color)
            {
                _value = value;
                _color = ColorTranslator.FromHtml(color);
            }

            public double _value { get; set; }
            public Color _color { get; set; }

            public int CompareTo(DynamicColor y)
            {
                if (this._value > y._value)
                {
                    return 1;
                }
                else if (this._value < y._value)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public class LoginInfo : SettingsBase
        {
            public string _username { get; set; }
            public string _password { get; set; }
            public bool _rememeber { get; set; }

            public LoginInfo()
            {
                _username = "";
                _password = "";
                _rememeber = false;
            }

            public bool IsEmpty()
            {
                if (_username == "" || _password == "")
                {
                    return true;
                }
                return false;
            }
        }

    }

    public static class ControlExtensions
    {
        public static T InvokeIfRequired<T>(this T source, Action<T> action)
            where T : Control
        {
            try
            {
                if (!source.InvokeRequired)
                    action(source);
                else
                    source.Invoke(new Action(() => action(source)));
            }
            catch (Exception ex)
            {
                Debug.Write("Error on 'InvokeIfRequired': {0}", ex.Message);
            }
            return source;
        }


    }

    public static class Logger
    {
        private static ILog logger;
        static Logger()
        {
            XmlConfigurator.Configure();
            logger = LogManager.GetLogger("");
        }

        public static void WriteLog(string log)
        {
            logger.Info(log);
        }


    }

    public class CustomComparer : IComparer
    {
        private static int SortOrder1 = 1;

        public CustomComparer(SortOrder sortOrder)
        {
            SortOrder1 = sortOrder == SortOrder.Ascending ? 1 : -1;
        }

        public int Compare(object x, object y)
        {
            DataGridViewRow row1 = (DataGridViewRow)x;
            DataGridViewRow row2 = (DataGridViewRow)y;
            string datetime1 = row1.Cells[4].Value.ToString() + " " + row1.Cells[5].Value.ToString();
            string datetime2 = row2.Cells[4].Value.ToString() + " " + row2.Cells[5].Value.ToString();
            DateTime dt1 = DateTime.ParseExact(datetime1, "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
            DateTime dt2 = DateTime.ParseExact(datetime2, "yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);

            int result = dt1.CompareTo(dt2);

            return result * SortOrder1;
        }
    }

    public class SettingsBase
    {
        public void Save()
        {

            using (StreamWriter writer = new StreamWriter(HardCode.STR_SAVE_FOLDER_PATH + "\\" + this.GetType().Name + ".xml"))
            {
                System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
                xmlSerializer.Serialize(writer, this);
            }
        }

        public static T Load<T>() where T : SettingsBase
        {
            T result = null;
            if (File.Exists(HardCode.STR_SAVE_FOLDER_PATH + "\\" + typeof(T).Name + ".xml"))
            {
                using (StreamReader reader = new StreamReader(HardCode.STR_SAVE_FOLDER_PATH + "\\" + typeof(T).Name + ".xml"))
                {
                    System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                    result = (T)xmlSerializer.Deserialize(reader);
                }
            }
            return result;
        }
    }
}
