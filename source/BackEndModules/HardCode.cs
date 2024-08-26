using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VedicaTrader
{
    public class HardCode
    {
        public static string CRYPTO_KEY = "l123l12l";
        public static string USERNAME = "";

        // Login Info
        public static string LOGIN_APIKEY = "LNgKiTfuZL8rCAcwJehD";

        // Puhser Info
        public static string PUHSER_APPKEY = "e41d885484a981712eb7";
        public static string PUSHER_EVENT = "Gzip Upload Complete";

        public static string PUHSER_CHANNEL_EOD = "EOD";
        public static string PUHSER_CHANNEL = "DayTrading";
        public static string PUSHER_APPID = "1040056";
        public static string PUSHER_CLUSTER = "mt1";
        public static string PUSHER_MARKET_EVENT = "MarketView Update";
        public static bool RT_UPDATE_YES = false;
        public static bool IS_EOD = false;
        public static string STR_SAVE_FOLDER_PATH = "C:\\Users";

        // Wasabi Info for symbol zip
        public static string WAS_ACCESS_KEY = "I575EK9RFAERXVXSSMS5";
        public static string WAS_SECRET_KEY = "dO7RioU7aVf9h8cAZj8AYhrCnSY07YZ967Q4JOhq";
        public static string WAS_ENDPOINT_URL = "https://s3.us-east-1.wasabisys.com";
        public static string WAS_BUCKET_NAME = "VedicaTraderRT1";
        public static string WAS_FILE_NAME = "Folder1.zip";
        public static string WAS_SUB_FOLDER = "sri/Primary/";

        // wasabi Info for market zip
        public static string WAS_MARKET_ACCESS_KEY = "I575EK9RFAERXVXSSMS5";
        public static string WAS_MARKET_SECRET_KEY = "dO7RioU7aVf9h8cAZj8AYhrCnSY07YZ967Q4JOhq";
        public static string WAS_MARKET_BUCKET_NAME = "VedicaTraderRT1";
        public static string WAS_MARKET_FILE_NAME = "MarketView.zip";
        public static string WAS_MARKET_SUB_FOLDER = "";


        // wasabi Info for deviceId
        public static string WAS_DEVICEID_ACCESS_KEY = "I575EK9RFAERXVXSSMS5";
        public static string WAS_DEVICEID_SECRET_KEY = "dO7RioU7aVf9h8cAZj8AYhrCnSY07YZ967Q4JOhq";
        public static string WAS_DEVICEID_BUCKET_NAME = "VedicaTraderRT1";
        public static string WAS_DEVICEID_FILE_NAME = "device_id.txt";
        public static string WAS_DEVICEID_SUB_FOLDER = "users/";

        // VedicaCharts Settings
        public static int CHART_SET_PIXEL_SIZE = 9;
        public static int CHART_REF_LINE1 = 10;
        public static int CHART_REF_LINE2 = 30;
        public static bool CHART_ENABLE_ZOOM = true;
        public static bool CHART_PLAY_SOUND = false;

        public static int CHART_ROW_TO_LOAD = 1000;
        public static bool CHART_SHOW_LAVG1TOLAVG4 = true;
        public static string CHART_IGNORE_FILE_NAME = "-R";
        public static int CHART_LOAD_MORE_COUNT = 500;
        public static bool CHART_LOAD_ALL_L_COLUMNS = true;
        public static bool CHART_SHOW_CLOSE_DATE = true;
        public static bool CHART_SHOW_DATETIME_FOR_ONLY_SIGNAL = true;

        public static double _UpperBuy = 10;
        public static double _UpperSell = -10;
        public static string _UpperBuyColor = "#ef019a";
        public static string _UpperSellColor = "#ff9015";

        public static double _LowerBuy = 11;
        public static double _LowerSell = -11;
        public static string _LowerBuyColor = "#ef0191";
        public static string _LowerSellColor = "#ff901a";

        public static double _TrendBuy = 12;
        public static double _TrendSell = -12;
        public static string _TrendBuyColor = "#ef0101";
        public static string _TrendSellColor = "#ff9095";

        public static double _MidLineBuy = 13;
        public static double _MidLineSell = -13;
        public static string _MidLineBuyColor = "#ef559a";
        public static string _MidLineSellColor = "#ff9a15";

        // workspace 

    }
}
