namespace VedicaSignals
{
    partial class FormTestAblyAPI
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.VersionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(12, 12);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(114, 24);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_ClickAsync);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(536, 282);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // VersionTypeComboBox
            // 
            this.VersionTypeComboBox.BackColor = System.Drawing.Color.AliceBlue;
            this.VersionTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VersionTypeComboBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionTypeComboBox.FormattingEnabled = true;
            this.VersionTypeComboBox.Location = new System.Drawing.Point(252, 12);
            this.VersionTypeComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.VersionTypeComboBox.MaxDropDownItems = 5;
            this.VersionTypeComboBox.Name = "VersionTypeComboBox";
            this.VersionTypeComboBox.Size = new System.Drawing.Size(207, 23);
            this.VersionTypeComboBox.TabIndex = 16;
            this.VersionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.VersionTypeComboBox_SelectedIndexChanged);
            // 
            // autoLabel3
            // 
            this.autoLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.autoLabel3.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.autoLabel3.Location = new System.Drawing.Point(148, 17);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(101, 14);
            this.autoLabel3.TabIndex = 15;
            this.autoLabel3.Text = "Version Type:";
            this.autoLabel3.ThemeName = "Default";
            // 
            // FormTestAblyAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 337);
            this.Controls.Add(this.VersionTypeComboBox);
            this.Controls.Add(this.autoLabel3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.StartBtn);
            this.Name = "FormTestAblyAPI";
            this.Text = "FormTestAblyMsg";
            this.Load += new System.EventHandler(this.FormTestPusherMsg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox VersionTypeComboBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
    }
}