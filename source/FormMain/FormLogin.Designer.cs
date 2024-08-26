namespace VedicaTrader
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.ForgotLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PasswordTextBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LoginBtn = new Syncfusion.WinForms.Controls.SfButton();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.SignUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpLabel.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.SignUpLabel.Location = new System.Drawing.Point(375, 175);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(146, 15);
            this.SignUpLabel.TabIndex = 21;
            this.SignUpLabel.Text = "SignUp Here For Free Trial";
            this.SignUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
            // 
            // ForgotLabel
            // 
            this.ForgotLabel.AutoSize = true;
            this.ForgotLabel.BackColor = System.Drawing.Color.Transparent;
            this.ForgotLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotLabel.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.ForgotLabel.Location = new System.Drawing.Point(375, 150);
            this.ForgotLabel.Name = "ForgotLabel";
            this.ForgotLabel.Size = new System.Drawing.Size(102, 15);
            this.ForgotLabel.TabIndex = 20;
            this.ForgotLabel.Text = "Forget password?";
            this.ForgotLabel.Click += new System.EventHandler(this.ForgotLabel_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.UsernameTextBox.BeforeTouchSize = new System.Drawing.Size(243, 23);
            this.UsernameTextBox.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.UsernameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.CanOverrideStyle = true;
            this.UsernameTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UsernameTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.UsernameTextBox.Location = new System.Drawing.Point(173, 35);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.NearImage = global::VedicaTrader.Resource1.username;
            this.UsernameTextBox.Size = new System.Drawing.Size(243, 23);
            this.UsernameTextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016DarkGray;
            this.UsernameTextBox.TabIndex = 18;
            this.UsernameTextBox.ThemeName = "Office2016DarkGray";
            this.UsernameTextBox.UseBorderColorOnFocus = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.PasswordTextBox.BeforeTouchSize = new System.Drawing.Size(243, 23);
            this.PasswordTextBox.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.CanOverrideStyle = true;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PasswordTextBox.FarImage = global::VedicaTrader.Resource1.icon_showPassword_scale_200;
            this.PasswordTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(173, 71);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.NearImage = global::VedicaTrader.Resource1.password;
            this.PasswordTextBox.Size = new System.Drawing.Size(243, 23);
            this.PasswordTextBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016DarkGray;
            this.PasswordTextBox.TabIndex = 17;
            this.PasswordTextBox.ThemeName = "Office2016DarkGray";
            this.PasswordTextBox.UseBorderColorOnFocus = true;
            this.PasswordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PasswordTextBox_MouseClick);
            // 
            // LoginBtn
            // 
            this.LoginBtn.AccessibleName = "Button";
            this.LoginBtn.BackColor = System.Drawing.Color.DimGray;
            this.LoginBtn.CanApplyTheme = false;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.FocusRectangleVisible = true;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoginBtn.Location = new System.Drawing.Point(176, 142);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(176, 32);
            this.LoginBtn.Style.BackColor = System.Drawing.Color.DimGray;
            this.LoginBtn.Style.DisabledBackColor = System.Drawing.Color.DimGray;
            this.LoginBtn.Style.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoginBtn.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginBtn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.LoginBtn.Style.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoginBtn.Style.HoverBackColor = System.Drawing.Color.Gray;
            this.LoginBtn.Style.HoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoginBtn.Style.PressedBackColor = System.Drawing.Color.Gray;
            this.LoginBtn.Style.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoginBtn.TabIndex = 16;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.ThemeName = "";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_ClickAsync);
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BeforeTouchSize = new System.Drawing.Size(120, 24);
            this.checkBoxAdv1.CanOverrideStyle = true;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxAdv1.Location = new System.Drawing.Point(352, 105);
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(120, 24);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007;
            this.checkBoxAdv1.TabIndex = 15;
            this.checkBoxAdv1.Text = "Remember Me";
            this.checkBoxAdv1.ThemeName = "Office2007";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "Username:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CaptionFont = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUpLabel);
            this.Controls.Add(this.ForgotLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.checkBoxAdv1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(541, 244);
            this.MinimumSize = new System.Drawing.Size(541, 244);
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vedica Trader Stocks";
            this.UseOffice2010SchemeBackColor = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsernameTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Label ForgotLabel;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt UsernameTextBox;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt PasswordTextBox;
        private Syncfusion.WinForms.Controls.SfButton LoginBtn;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}