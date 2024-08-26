namespace VedicaTrader
{
    partial class FormChart
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
            this.contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.loadMoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBarEx1 = new Syncfusion.Windows.Forms.Tools.TrackBarEx(50, 200);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.contextMenuStripEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripEx1
            // 
            this.contextMenuStripEx1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMoreToolStripMenuItem,
            this.placeOrderToolStripMenuItem});
            this.contextMenuStripEx1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(249)))));
            this.contextMenuStripEx1.Name = "contextMenuStripEx1";
            this.contextMenuStripEx1.Size = new System.Drawing.Size(207, 48);
            this.contextMenuStripEx1.Style = Syncfusion.Windows.Forms.Tools.ContextMenuStripEx.ContextMenuStyle.Default;
            this.contextMenuStripEx1.ThemeName = "Default";
            // 
            // loadMoreToolStripMenuItem
            // 
            this.loadMoreToolStripMenuItem.Name = "loadMoreToolStripMenuItem";
            this.loadMoreToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.loadMoreToolStripMenuItem.Text = "Load More Previous Data";
            this.loadMoreToolStripMenuItem.Click += new System.EventHandler(this.loadMoreToolStripMenuItem_Click);
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.placeOrderToolStripMenuItem.Text = "Place Order";
            this.placeOrderToolStripMenuItem.Click += new System.EventHandler(this.placeOrderToolStripMenuItem_Click);
            // 
            // trackBarEx1
            // 
            this.trackBarEx1.BackColor = System.Drawing.Color.Transparent;
            this.trackBarEx1.BeforeTouchSize = new System.Drawing.Size(538, 20);
            this.trackBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarEx1.LargeChange = 2;
            this.trackBarEx1.Location = new System.Drawing.Point(0, 358);
            this.trackBarEx1.Name = "trackBarEx1";
            this.trackBarEx1.Size = new System.Drawing.Size(538, 20);
            this.trackBarEx1.SmallChange = 2;
            this.trackBarEx1.TabIndex = 1;
            this.trackBarEx1.Text = "trackBarEx1";
            this.trackBarEx1.ThemeName = "Default";
            this.trackBarEx1.TimerInterval = 100;
            this.trackBarEx1.Value = 100;
            this.trackBarEx1.ValueChanged += new System.EventHandler(this.trackBarEx1_ValueChanged);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(538, 358);
            this.MainPanel.TabIndex = 2;
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionBarColor = System.Drawing.Color.LightGray;
            this.CaptionButtonColor = System.Drawing.Color.Gray;
            this.CaptionButtonHoverColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(538, 378);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.trackBarEx1);
            this.DropShadow = true;
            this.Name = "FormChart";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SriChart";
            this.Load += new System.EventHandler(this.frmChart_Load);
            this.Resize += new System.EventHandler(this.frmChart_Resize);
            this.contextMenuStripEx1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStripEx1;
        private System.Windows.Forms.ToolStripMenuItem loadMoreToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.TrackBarEx trackBarEx1;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
    }
}