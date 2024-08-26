using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VedicaSignals
{
    public partial class FormTestAblyAPI : Form
    {
        Manager.SymbolMsgAblyAPI _ably;
        private List<Models.VersionType> types = HardCode.GetVersionTypes();
        
        public FormTestAblyAPI()
        {
            InitializeComponent();
            _soundplayer_sell = new Utils.ManagerSoundPlayer(Utils.SIGNAL_TYPE.SELL);
            _soundplayer_buy = new Utils.ManagerSoundPlayer(Utils.SIGNAL_TYPE.BUY);


        }

        private Utils.ManagerSoundPlayer _soundplayer_sell;
        private Utils.ManagerSoundPlayer _soundplayer_buy;
        private bool is_sell = true;

        private void StartBtn_ClickAsync(object sender, EventArgs e)
        {
            if (is_sell)
            {
                _soundplayer_buy.Play();
                is_sell = false;
            }
            else
            {

                _soundplayer_sell.Play();
                is_sell = true;
            }
            //DateTime datetime = DateTime.Parse("7/15/2022 1:39:56 PM +00:00");
            //MessageBox.Show(datetime.ToString("MM/dd/yyyy HH:mm:ss"));
            //this.StartBtn.Text = "Listening...";
            //String msg = $"Key - {HardCode.CURRENT_VERSION_TYPE._ablyKey}\n" +
            //    $"Channel - {HardCode.CURRENT_VERSION_TYPE._ablyChannel}\n" +
            //    $"History-Msg - {HardCode.CURRENT_VERSION_TYPE._ablyHistoryMsg}\n";
            //MessageBox.Show(msg);
            //try
            //{
            //    _ably = new Manager.SymbolMsgAblyAPI();
            //    //List<string> msgs = _ably.GetHistoryMessages();

            //    //foreach (string tmsg in msgs)
            //    //{
            //    //    this.richTextBox1.AppendText(tmsg);
            //    //    this.richTextBox1.AppendText("\n");
            //    //}

            //    _ably.StartHistoryAsync();
            //    _ably.MessageHistoryProc = MessageProc;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        void MessageProc(dynamic msg)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.richTextBox1.AppendText(msg);
                        this.richTextBox1.AppendText("\n");
                    });
                }));
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void FormTestPusherMsg_Load(object sender, EventArgs e)
        {
            foreach (Models.VersionType type in types)
            {
                if (type._versionStatus)
                {
                    this.VersionTypeComboBox.Items.Add(type._versionName);
                }
            }
            if (this.VersionTypeComboBox.Items.Count != 0)
            {
                this.VersionTypeComboBox.SelectedIndex = 0;
                HardCode.CURRENT_VERSION_TYPE = types[0];
            }
        }

        private void VersionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HardCode.CURRENT_VERSION_TYPE = types[this.VersionTypeComboBox.SelectedIndex];
        }
    }
}
