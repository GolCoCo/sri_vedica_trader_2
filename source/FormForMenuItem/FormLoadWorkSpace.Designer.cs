namespace VedicaTrader
{
    partial class FormLoadWorkSpace
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.WorkNameComboBox = new System.Windows.Forms.ComboBox();
            this.CancelBtn = new Syncfusion.WinForms.Controls.SfButton();
            this.CreateBtn = new Syncfusion.WinForms.Controls.SfButton();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.WorkNameComboBox);
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.CreateBtn);
            this.panel1.Controls.Add(this.autoLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 92);
            this.panel1.TabIndex = 0;
            // 
            // WorkNameComboBox
            // 
            this.WorkNameComboBox.FormattingEnabled = true;
            this.WorkNameComboBox.Location = new System.Drawing.Point(152, 18);
            this.WorkNameComboBox.Name = "WorkNameComboBox";
            this.WorkNameComboBox.Size = new System.Drawing.Size(339, 22);
            this.WorkNameComboBox.TabIndex = 9;
            this.WorkNameComboBox.SelectedIndexChanged += new System.EventHandler(this.WorkNameComboBox_SelectedIndexChanged);
            // 
            // CancelBtn
            // 
            this.CancelBtn.AccessibleName = "Button";
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CancelBtn.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.Black;
            this.CancelBtn.Location = new System.Drawing.Point(384, 55);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(88, 24);
            this.CancelBtn.Style.ForeColor = System.Drawing.Color.Black;
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.ThemeName = "";
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.AccessibleName = "Button";
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CreateBtn.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.ForeColor = System.Drawing.Color.Black;
            this.CreateBtn.Location = new System.Drawing.Point(253, 55);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(88, 24);
            this.CreateBtn.Style.ForeColor = System.Drawing.Color.Black;
            this.CreateBtn.TabIndex = 7;
            this.CreateBtn.Text = "Open";
            this.CreateBtn.ThemeName = "";
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // autoLabel1
            // 
            this.autoLabel1.Location = new System.Drawing.Point(18, 22);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(119, 14);
            this.autoLabel1.TabIndex = 0;
            this.autoLabel1.Text = "WorkSpace Names:";
            // 
            // FormLoadWorkSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionBarColor = System.Drawing.SystemColors.Control;
            this.CaptionButtonHoverColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(504, 92);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(516, 128);
            this.MinimumSize = new System.Drawing.Size(516, 128);
            this.Name = "FormLoadWorkSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vedica Trader 2.01";
            this.Load += new System.EventHandler(this.FormLoadWorkSpace_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.WinForms.Controls.SfButton CancelBtn;
        private Syncfusion.WinForms.Controls.SfButton CreateBtn;
        private System.Windows.Forms.ComboBox WorkNameComboBox;
    }
}