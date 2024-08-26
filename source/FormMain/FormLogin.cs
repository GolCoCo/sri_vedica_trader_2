using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VedicaTrader
{
    public partial class FormLogin : Syncfusion.Windows.Forms.Office2010Form
    {
        //
        private FormLogin _form;
        private Utils.LoginInfo _loginInfo = null;
        private Manager.DeviceIDWasabiAPI _idWasabiAPI;
        public FormLogin()
        {

            InitializeComponent();
            _form = this;
            //_idWasabiAPI = new Manager.DeviceIDWasabiAPI();
            this.ColorScheme = Office2010Theme.Black;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            HardCode.STR_SAVE_FOLDER_PATH = Utils.GetSaveFolderPath();
            _loginInfo = Utils.LoginInfo.Load<Utils.LoginInfo>();
            if(_loginInfo == null)
            {
                _loginInfo = new Utils.LoginInfo();
            }
            this.UsernameTextBox.Text = _loginInfo._username;
            HardCode.USERNAME = _loginInfo._username;
            this.PasswordTextBox.Text = _loginInfo._password;
            this.checkBoxAdv1.Checked =  _loginInfo._rememeber;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.FarImage = this.PasswordTextBox.FarImage = Resource1.icon_hidePassword_scale_200;

            //this.PasswordTextBox.Office2007ColorScheme = Office2007Theme.Black;
            //this.UsernameTextBox.Office2007ColorScheme = Office2007Theme.Black;

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            _loginInfo._username = this.UsernameTextBox.Text;
            HardCode.USERNAME = this.UsernameTextBox.Text;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            _loginInfo._password = this.PasswordTextBox.Text;
        }

        private void CheckBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            _loginInfo._rememeber = this.checkBoxAdv1.Checked;
        }
        private async void LoginBtn_ClickAsync(object sender, EventArgs e)
        {
            //MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Office2016;
            //if (_loginInfo.IsEmpty())
            //{
            //    MessageBoxAdv.Show(Utils.MSGB_LOGIN_EMPTY, Utils.MSGB_ALERT, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //    return;
            //}
            //try
            //{
            //    string mine_id = Utils.GetDeviceID();
            //    if (ValidateApp())
            //    {
            //        if (_idWasabiAPI.CheckIfNewUser())
            //        {
            //            _idWasabiAPI.UploadDeviceInfoAsync(mine_id);
            //            RunWorkSpace();

            //        }
            //        else
            //        {
            //            string auth_id = await _idWasabiAPI.DownloadDeviceInfoAsync();
            //            if (mine_id == auth_id)
            //            {
            //                RunWorkSpace();
            //            }
            //            else
            //            {
            //                if (MessageBox.Show(_form, "New Device ID was Detected.\n Would you activate with this ID now?",
            //                    "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //                {
            //                    _idWasabiAPI.UploadDeviceInfoAsync(mine_id);
            //                    RunWorkSpace();
            //                }
            //            }
            //        }
            //        return;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBoxAdv.Show("ERROR!", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            _form.Hide();
            FormWorkSpaceTest form = new FormWorkSpaceTest(_idWasabiAPI);
            form.Size = new System.Drawing.Size(1200, 700);
            form.ShowDialog();
            form.SetDesktopLocation(50, 10);
            _form.Close();


        }
        private void RunWorkSpace()
        {
            _form.Hide();

            FormWorkSpace form = new FormWorkSpace(_idWasabiAPI);
            form.Size = new System.Drawing.Size(1200, 700);
            form.SetDesktopLocation(50, 10);
            form.ShowDialog();
            _form.Close();
        }

        private bool ValidateApp()
        {
            bool isvalid = false;
            Manager.LoginValidationAPI mlv = new Manager.LoginValidationAPI(_loginInfo._username, _loginInfo._password);
            string ret = mlv.LoginAppAsync();
            if(ret == Utils.RES_SUCCESS)
            {
                return true;
            }
            else if(ret == Utils.RES_EXPIRED)
            {
                MessageBoxAdv.Show(Utils.MSGB_EXPIRED_DATE, Utils.MSGB_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if(ret == Utils.RES_NO_SUBS)
            {
                MessageBoxAdv.Show(Utils.MSGB_NO_SUBSCRIPTION, Utils.MSGB_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(ret == Utils.RES_WRONG_CRED)
            {
                MessageBoxAdv.Show(Utils.MSGB_WRONG_CRED, Utils.MSGB_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBoxAdv.Show(Utils.MSGB_FAILED_CONNECTION, Utils.MSGB_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return isvalid;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            _form.Close();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_loginInfo._rememeber)
            {
                _loginInfo.Save();
            }
            else
            {
                _loginInfo._username = "";
                _loginInfo._password = "";
                _loginInfo.Save();
            }
        }

        bool isshow = true;
        private void PasswordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            this.PasswordTextBox.Cursor = Cursors.Default;
            if ((e.X > 305 && e.X <316) && (e.Y > 2 && e.Y < 14))
            {
                if (isshow)
                {
                    this.PasswordTextBox.UseSystemPasswordChar = false;
                    this.PasswordTextBox.Refresh();
                    this.PasswordTextBox.FarImage = this.PasswordTextBox.FarImage = Resource1.icon_showPassword_scale_200;

                    isshow = false;
                }
                else
                {
                    this.PasswordTextBox.UseSystemPasswordChar = true;
                    this.PasswordTextBox.Refresh();
                    this.PasswordTextBox.FarImage = this.PasswordTextBox.FarImage = Resource1.icon_hidePassword_scale_200;
                    isshow = true;
                }
            }
            else
            {
                this.PasswordTextBox.Cursor = Cursors.IBeam;
            }
        }

        private void ForgotLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Utils.URL_YAHOO_FINANCE);
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Utils.URL_YAHOO_FINANCE);
        }
    }
}
