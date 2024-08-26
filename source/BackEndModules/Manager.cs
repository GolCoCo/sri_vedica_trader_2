using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon.S3;
using Amazon.S3.Transfer;
using PusherClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using Amazon.S3.IO;
using System.Threading;

namespace VedicaTrader
{
    public class Manager
    {
        // Manager wasabi for downloading symbol zip files
        public class SymbolWasabiAPI
        {

            private AmazonS3Client _client = null;

            public SymbolWasabiAPI()
            {
                try
                {
                    var awsCredentials = new Amazon.Runtime.BasicAWSCredentials(HardCode.WAS_ACCESS_KEY, HardCode.WAS_SECRET_KEY);
                    var awsConfig = new AmazonS3Config { ServiceURL = HardCode.WAS_ENDPOINT_URL };

                    _client = new AmazonS3Client(awsCredentials, awsConfig);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            public async Task<Dictionary<string, List<List<string>>>> DownloadAndGetAllDatasFileNameByZIPAsync(string filename)
            {
                try
                {
                    string _filename = HardCode.WAS_SUB_FOLDER + filename;
                    if (_client == null) return null;

                    TransferUtility utility = new TransferUtility(_client);
                    TransferUtilityOpenStreamRequest streamrequest = new TransferUtilityOpenStreamRequest();
                    streamrequest.BucketName = HardCode.WAS_BUCKET_NAME;
                    streamrequest.Key = _filename;
                    Stream stream = await utility.OpenStreamAsync(streamrequest);
                    if (stream.CanRead)
                    {
                        MemoryStream memorySteam = new MemoryStream();
                        stream.CopyTo(memorySteam);
                        Dictionary<string, List<List<string>>> ret = Utils.GetAllDatasFromStream(memorySteam);
                        stream.Close();
                        return ret;
                    }
                    else
                    {
                        stream.Close();
                        return null;
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }

            public void Close()
            {
                _client.Dispose();
            }
        }


        // Manager wasabi for downloading market zip files
        public class MarketWasabiAPI
        {

            private AmazonS3Client _client = null;

            public MarketWasabiAPI()
            {
                try
                {
                    var awsCredentials = new Amazon.Runtime.BasicAWSCredentials(HardCode.WAS_MARKET_ACCESS_KEY, HardCode.WAS_MARKET_SECRET_KEY);
                    var awsConfig = new AmazonS3Config { ServiceURL = HardCode.WAS_ENDPOINT_URL };

                    _client = new AmazonS3Client(awsCredentials, awsConfig);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            public async Task<Dictionary<string, List<List<string>>>> DownloadAndGetAllDatasFileNameByZIPAsync()
            {
                try
                {
                    string _filename = HardCode.WAS_MARKET_SUB_FOLDER + HardCode.WAS_MARKET_FILE_NAME;
                    if (_client == null) return null;

                    TransferUtility utility = new TransferUtility(_client);


                    TransferUtilityOpenStreamRequest streamrequest = new TransferUtilityOpenStreamRequest();
                    streamrequest.BucketName = HardCode.WAS_MARKET_BUCKET_NAME;
                    streamrequest.Key = _filename;
                    Stream stream = await utility.OpenStreamAsync(streamrequest);
                    if (stream.CanRead)
                    {
                        MemoryStream memorySteam = new MemoryStream();
                        stream.CopyTo(memorySteam);
                        Dictionary<string, List<List<string>>> ret = Utils.GetAllDatasFromStream(memorySteam);
                        stream.Close();
                        return ret;
                    }
                    else
                    {
                        stream.Close();
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    return null;
                }
            }

            public void Close()
            {
                _client.Dispose();
            }
        }


        // Manager wasabi for downloading and uploading the deviceid.txt 
        public class DeviceIDWasabiAPI
        {

            private AmazonS3Client _client = null;

            public DeviceIDWasabiAPI()
            {
                try
                {
                    var awsCredentials = new Amazon.Runtime.BasicAWSCredentials(HardCode.WAS_DEVICEID_ACCESS_KEY, HardCode.WAS_DEVICEID_SECRET_KEY);
                    var awsConfig = new AmazonS3Config { ServiceURL = HardCode.WAS_ENDPOINT_URL };

                    _client = new AmazonS3Client(awsCredentials, awsConfig);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            public bool CheckIfNewUser()
            {
                bool ret = true;
                try
                {
                    if (_client == null || HardCode.USERNAME == "") return false;
                    string folderPath = @String.Format("{0}{1}/", HardCode.WAS_DEVICEID_SUB_FOLDER, HardCode.USERNAME);
                    S3DirectoryInfo directory = new S3DirectoryInfo(_client, HardCode.WAS_DEVICEID_BUCKET_NAME, folderPath);
                    if (directory.Exists)
                    {
                        string filePath = @String.Format("{0}{1}", folderPath, HardCode.WAS_DEVICEID_FILE_NAME);
                        S3FileInfo s3File = new S3FileInfo(_client, HardCode.WAS_DEVICEID_BUCKET_NAME, filePath);
                        if (s3File.Exists)
                        {
                            ret = false;
                        }
                    }
                    else
                    {
                        directory.Create();
                    }
                    return ret;

                }
                catch (Exception)
                {
                    return ret;
                }
            }
            public async Task<string> DownloadDeviceInfoAsync()
            {
                try
                {
                    if (_client == null || HardCode.USERNAME == "") return null;
                    string filePath = String.Format("{0}{1}/{2}", HardCode.WAS_DEVICEID_SUB_FOLDER, HardCode.USERNAME, HardCode.WAS_DEVICEID_FILE_NAME);
                    S3FileInfo s3File = new S3FileInfo(_client, HardCode.WAS_DEVICEID_BUCKET_NAME, filePath);
                    if (!s3File.Exists)
                    {
                        return null;
                    }
                    TransferUtility utility = new TransferUtility(_client);

                    TransferUtilityOpenStreamRequest streamrequest = new TransferUtilityOpenStreamRequest();
                    streamrequest.BucketName = HardCode.WAS_DEVICEID_BUCKET_NAME;
                    streamrequest.Key = filePath;
                    Stream stream = await utility.OpenStreamAsync(streamrequest);

                    if (stream.CanRead) {
                        StreamReader reader = new StreamReader(stream);
                        string deviceid = reader.ReadToEnd();
                        stream.Close();
                        return deviceid;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception)
                {
                    return null;
                }

            }

            public async void UploadDeviceInfoAsync(string DeviceID)
            {
                try
                {
                    if (_client == null || HardCode.USERNAME == "") return;
                    string filePath = @String.Format("{0}{1}/{2}", HardCode.WAS_DEVICEID_SUB_FOLDER, HardCode.USERNAME, HardCode.WAS_DEVICEID_FILE_NAME);
                    S3FileInfo s3File = new S3FileInfo(_client, HardCode.WAS_DEVICEID_BUCKET_NAME, filePath);

                    if (s3File.Exists)
                    {
                        s3File.Delete();
                    }

                    TransferUtility utility = new TransferUtility(_client);

                    TransferUtilityUploadRequest request = new TransferUtilityUploadRequest();
                    request.BucketName = HardCode.WAS_DEVICEID_BUCKET_NAME;
                    request.Key = filePath;
                    request.InputStream = Utils.GenerateStreamFromString(DeviceID);
                    await utility.UploadAsync(request);
                }
                catch (Exception)
                {
                }

            }

            public void Close()
            {
                _client.Dispose();
            }
        }


        // Manager pushser for listening msg
        public class PusherListener
        {
            public delegate void MessageProcDelegate(string message);
            public MessageProcDelegate MessageProc;

            public delegate void MessageMarketProcDelegate(string message);
            public MessageMarketProcDelegate MessageMarketProc;

            private string _channel = HardCode.PUHSER_CHANNEL;
            private string _event;
            private string _marketEvent;

            private string _key = "e41d885484a981712eb7";
            private string _cluster = "mt1";
            private string _appid = HardCode.PUSHER_APPID;

            public Pusher _pusher;
            private Channel _subscriber;

            // constructor
            public PusherListener()
            {
                _event = "NewSignal";
                _marketEvent = HardCode.PUSHER_MARKET_EVENT;
            }
            // start
            public async void StartAsync()
            {
                try
                {
                    // init pusherclient
                    _pusher = new Pusher(HardCode.PUHSER_APPKEY, new PusherOptions()
                    {
                        Cluster = HardCode.PUSHER_CLUSTER,
                        Encrypted = true
                    });

                    _pusher.ConnectionStateChanged += _pusher_ConnectionStateChanged;
                    _pusher.Error += _pusher_Error;
                    _pusher.Connected += _pusher_Connected;

                    // Setup private channel
                    _subscriber = await _pusher.SubscribeAsync(_channel);
                    _pusher.Subscribed += DayChannel_Subscribed;
                    await _pusher.ConnectAsync();
                    await Task.Run(() => ReceiveMessage());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            private void DayChannel_Subscribed(object sender, Channel channel)
            {
                MessageBox.Show("DayChannel_Subscribed");
            }

            private void _pusher_Error(object sender, PusherException error)
            {
                MessageBox.Show("_pusher_Error");
            }

            private void _pusher_ConnectionStateChanged(object sender, ConnectionState state)
            {
                MessageBox.Show("_pusher_ConnectionStateChanged");
            }

            private void _pusher_Subscribed(object sender, Channel channel)
            {
                MessageBox.Show("Subscribed");
            }

            private void _pusher_Connected(object sender)
            {
                MessageBox.Show("Connected");
            }

            // listener
            void ReceiveMessage()
            {
                if (_subscriber == null) return;
                _subscriber.Bind(_event, delegate (dynamic data)
                {
                    string response = Convert.ToString(data);
                    MessageProc?.Invoke(response);
                });
                //Thread.Sleep(100);
                //_subscriber.Bind(_marketEvent, delegate (dynamic data)
                //{
                //    string response = Convert.ToString(data);
                //    MessageMarketProc?.Invoke(response);
                //});
            }

            public void Close()
            {
                _pusher.DisconnectAsync();
            }
        }

        // Manager Login API
        public class LoginValidationAPI
        {
            private string _key = HardCode.LOGIN_APIKEY;
            private string _username = "";
            private string _password = "";
            private HttpClient _client = null;
            private const string _baseurl = "https://shriinvest.com/srimember/api/check-access/";
            private string _requesturl = "";
            public LoginValidationAPI(string username, string password)
            {
                _username = username;
                _password = password;
                _requesturl = String.Format("by-login-pass?_key={0}&login={1}&pass={2}", _key, _username, _password);
                _client = new HttpClient();
                _client.BaseAddress = new Uri(_baseurl);
                // Add and Accept header for JSON format
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }

            public bool GetValidExpired(JToken attr)
            {
                string date = attr.ToString();
                DateTime curdatetime = DateTime.Now;
                DateTime exdatetime = Utils.GetDateTimeFromString(date);
                if (curdatetime.CompareTo(exdatetime) < 0 || curdatetime.CompareTo(exdatetime) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public string LoginAppAsync()
            {
                string ret = "";
                HttpResponseMessage response = _client.GetAsync(_requesturl).Result;
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body.
                    var contents = response.Content.ReadAsStringAsync().Result;
                    JObject jocontents = JObject.Parse(contents);
                    if (jocontents.GetValue("ok").ToString() == "True")
                    {
                        List<JToken> tokens = jocontents["subscriptions"].ToList<JToken>();
                        JToken attr2 = jocontents["subscriptions"]["2"];
                        JToken attr5 = jocontents["subscriptions"]["5"];
                        if (tokens.Count != 0)
                        {
                            int valid = 0;
                            if (attr2 != null)
                            {
                                if (GetValidExpired(attr2))
                                {
                                    valid++;
                                }
                            }
                            if (valid == 0)
                            {
                                if (attr5 != null)
                                {
                                    if (GetValidExpired(attr5))
                                    {
                                        valid++;
                                    }
                                }
                            }

                            if (valid > 0)
                            {
                                ret = Utils.RES_SUCCESS;
                            }
                            else
                            {
                                ret = Utils.RES_EXPIRED;
                            }
                        }
                        else
                        {
                            ret = Utils.RES_NO_SUBS;
                        }

                    }
                    else
                    {
                        ret = Utils.RES_WRONG_CRED;
                    }
                }
                else
                {
                    ret = Utils.RES_FAIL_CON;
                }

                _client.Dispose();
                return ret;
            }

            public string GetRealURL()
            {
                return _client.ToString();
            }
        }
    }
}
