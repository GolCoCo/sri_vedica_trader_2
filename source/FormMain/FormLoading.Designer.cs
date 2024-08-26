namespace VedicaTrader
{
    partial class FormLoading
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
            this.ProgressBar = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ProgressBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 43);
            this.panel1.TabIndex = 0;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.ProgressBar.BackSegments = false;
            this.ProgressBar.Border3DStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.ProgressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ProgressBar.CustomText = null;
            this.ProgressBar.CustomWaitingRender = true;
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgressBar.ForegroundImage = null;
            this.ProgressBar.Location = new System.Drawing.Point(0, 0);
            this.ProgressBar.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            this.ProgressBar.SegmentWidth = 10;
            this.ProgressBar.Size = new System.Drawing.Size(684, 39);
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.ThemeName = "Tube";
            this.ProgressBar.TubeEndColor = System.Drawing.Color.WhiteSmoke;
            this.ProgressBar.TubeStartColor = System.Drawing.Color.DarkSlateGray;
            this.ProgressBar.WaitingGradientWidth = 400;
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionFont = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 43);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormLoading";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download in Progress, Please Wait";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoading_FormClosing);
            this.Load += new System.EventHandler(this.FormLoading_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv ProgressBar;
    }
}