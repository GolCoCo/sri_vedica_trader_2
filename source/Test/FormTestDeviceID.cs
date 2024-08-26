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
    public partial class FormTestDeviceID : Form
    {
        public Manager.DeviceIDWasabiAPI msa;
        public FormTestDeviceID()
        {
            InitializeComponent();
            msa = new Manager.DeviceIDWasabiAPI();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            HardCode.USERNAME = this.textBox1.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (msa.CheckIfNewUser())
            {
                MessageBox.Show(HardCode.USERNAME + "\n New User. The subfolder has been created");
            }
            else
            {
                MessageBox.Show(HardCode.USERNAME + "\n Registed User. The subfolder has been exited");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!msa.CheckIfNewUser())
            {
                UploadDeviceIDAsync();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UploadDeviceIDAsync();
        }
        private void UploadDeviceIDAsync()
        {
            msa.UploadDeviceInfoAsync(Utils.GetDeviceID());
        }
        private async void DownLoadDeviceIDAsync()
        {
            MessageBox.Show("Downloading.. device ID");
            string retlist = await msa.DownloadDeviceInfoAsync();
            MessageBox.Show(retlist);
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            if (msa.CheckIfNewUser())
            {
                MessageBox.Show("New user!");
                msa.UploadDeviceInfoAsync(Utils.GetDeviceID());
                MessageBox.Show("Uploaded!");

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Utils.GetDeviceID());
        }



        private async void Button1_Click_1Async(object sender, EventArgs e)
        {
            MessageBox.Show("Downloading.. device ID");                
            string auth_id = await msa.DownloadDeviceInfoAsync();
            MessageBox.Show($"{auth_id}");
        }
        private void FormTestDeviceID_Load(object sender, EventArgs e)
        {



        }


    }
}
