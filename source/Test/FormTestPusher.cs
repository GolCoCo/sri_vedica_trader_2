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

namespace VedicaTrader
{
    public partial class FormTestPusher : Form
    {

        public FormTestPusher()
        {
            InitializeComponent();

        }

        Manager.PusherListener _mpl;
        private void StartBtn_ClickAsync(object sender, EventArgs e)
        {

            _mpl = new Manager.PusherListener();
            StartPusherMsgListnerAsync();

        }

        private void StartPusherMsgListnerAsync()
        {
            try
            {
                _mpl.StartAsync();
                _mpl.MessageProc = MessageProc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
        }
    }
}
