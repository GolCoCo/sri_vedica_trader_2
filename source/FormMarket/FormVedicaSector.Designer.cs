namespace VedicaTrader
{
    partial class FormVedicaSector
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RetDataGridView = new System.Windows.Forms.DataGridView();
            this.Sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_BuyP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_SellP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgressBar = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.AllMarketTLP = new System.Windows.Forms.TableLayoutPanel();
            this.TotalSellPLabel = new System.Windows.Forms.Label();
            this.TotalSellLabel = new System.Windows.Forms.Label();
            this.TotalBuyPLabel = new System.Windows.Forms.Label();
            this.TotalBuyLabel = new System.Windows.Forms.Label();
            this.StockLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).BeginInit();
            this.AllMarketTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 272);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.RetDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProgressBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AllMarketTLP, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 272);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // RetDataGridView
            // 
            this.RetDataGridView.AllowUserToAddRows = false;
            this.RetDataGridView.AllowUserToDeleteRows = false;
            this.RetDataGridView.AllowUserToResizeColumns = false;
            this.RetDataGridView.AllowUserToResizeRows = false;
            this.RetDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.RetDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sector,
            this.Total_Stocks,
            this.Total_Buy,
            this.Total_BuyP,
            this.Total_Sell,
            this.Total_SellP});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RetDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.RetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RetDataGridView.GridColor = System.Drawing.Color.Silver;
            this.RetDataGridView.Location = new System.Drawing.Point(2, 24);
            this.RetDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.RetDataGridView.MultiSelect = false;
            this.RetDataGridView.Name = "RetDataGridView";
            this.RetDataGridView.ReadOnly = true;
            this.RetDataGridView.RowHeadersVisible = false;
            this.RetDataGridView.Size = new System.Drawing.Size(805, 210);
            this.RetDataGridView.TabIndex = 3;
            // 
            // Sector
            // 
            this.Sector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Sector.DefaultCellStyle = dataGridViewCellStyle3;
            this.Sector.HeaderText = "Sector";
            this.Sector.Name = "Sector";
            this.Sector.ReadOnly = true;
            // 
            // Total_Stocks
            // 
            this.Total_Stocks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_Stocks.FillWeight = 50F;
            this.Total_Stocks.HeaderText = "Total Stocks";
            this.Total_Stocks.Name = "Total_Stocks";
            this.Total_Stocks.ReadOnly = true;
            // 
            // Total_Buy
            // 
            this.Total_Buy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_Buy.FillWeight = 50F;
            this.Total_Buy.HeaderText = "Total Buy";
            this.Total_Buy.Name = "Total_Buy";
            this.Total_Buy.ReadOnly = true;
            // 
            // Total_BuyP
            // 
            this.Total_BuyP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_BuyP.FillWeight = 50F;
            this.Total_BuyP.HeaderText = "Total Buy%";
            this.Total_BuyP.Name = "Total_BuyP";
            this.Total_BuyP.ReadOnly = true;
            // 
            // Total_Sell
            // 
            this.Total_Sell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_Sell.FillWeight = 50F;
            this.Total_Sell.HeaderText = "Total Sell";
            this.Total_Sell.Name = "Total_Sell";
            this.Total_Sell.ReadOnly = true;
            // 
            // Total_SellP
            // 
            this.Total_SellP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_SellP.FillWeight = 50F;
            this.Total_SellP.HeaderText = "Total Sell%";
            this.Total_SellP.Name = "Total_SellP";
            this.Total_SellP.ReadOnly = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.ProgressBar.BackSegments = false;
            this.ProgressBar.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.ProgressBar.CustomText = null;
            this.ProgressBar.CustomWaitingRender = false;
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgressBar.ForegroundImage = null;
            this.ProgressBar.Location = new System.Drawing.Point(2, 2);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressBar.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            this.ProgressBar.SegmentWidth = 12;
            this.ProgressBar.Size = new System.Drawing.Size(805, 20);
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.Text = "Listening...";
            this.ProgressBar.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            this.ProgressBar.ThemeName = "Tube";
            this.ProgressBar.TubeStartColor = System.Drawing.Color.Pink;
            this.ProgressBar.Value = 100;
            this.ProgressBar.WaitingGradientWidth = 400;
            // 
            // AllMarketTLP
            // 
            this.AllMarketTLP.BackColor = System.Drawing.Color.Black;
            this.AllMarketTLP.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.AllMarketTLP.ColumnCount = 6;
            this.AllMarketTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.AllMarketTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AllMarketTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AllMarketTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AllMarketTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AllMarketTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.AllMarketTLP.Controls.Add(this.TotalSellPLabel, 5, 0);
            this.AllMarketTLP.Controls.Add(this.TotalSellLabel, 4, 0);
            this.AllMarketTLP.Controls.Add(this.TotalBuyPLabel, 3, 0);
            this.AllMarketTLP.Controls.Add(this.TotalBuyLabel, 2, 0);
            this.AllMarketTLP.Controls.Add(this.StockLabel, 1, 0);
            this.AllMarketTLP.Controls.Add(this.label1, 0, 0);
            this.AllMarketTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllMarketTLP.Location = new System.Drawing.Point(2, 236);
            this.AllMarketTLP.Margin = new System.Windows.Forms.Padding(0);
            this.AllMarketTLP.Name = "AllMarketTLP";
            this.AllMarketTLP.RowCount = 1;
            this.AllMarketTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AllMarketTLP.Size = new System.Drawing.Size(805, 34);
            this.AllMarketTLP.TabIndex = 4;
            // 
            // TotalSellPLabel
            // 
            this.TotalSellPLabel.AutoSize = true;
            this.TotalSellPLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalSellPLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalSellPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSellPLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TotalSellPLabel.Location = new System.Drawing.Point(689, 3);
            this.TotalSellPLabel.Name = "TotalSellPLabel";
            this.TotalSellPLabel.Size = new System.Drawing.Size(110, 28);
            this.TotalSellPLabel.TabIndex = 5;
            this.TotalSellPLabel.Text = "123";
            this.TotalSellPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalSellLabel
            // 
            this.TotalSellLabel.AutoSize = true;
            this.TotalSellLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalSellLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalSellLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSellLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TotalSellLabel.Location = new System.Drawing.Point(575, 3);
            this.TotalSellLabel.Name = "TotalSellLabel";
            this.TotalSellLabel.Size = new System.Drawing.Size(105, 28);
            this.TotalSellLabel.TabIndex = 4;
            this.TotalSellLabel.Text = "123";
            this.TotalSellLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalBuyPLabel
            // 
            this.TotalBuyPLabel.AutoSize = true;
            this.TotalBuyPLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalBuyPLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalBuyPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBuyPLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TotalBuyPLabel.Location = new System.Drawing.Point(461, 3);
            this.TotalBuyPLabel.Name = "TotalBuyPLabel";
            this.TotalBuyPLabel.Size = new System.Drawing.Size(105, 28);
            this.TotalBuyPLabel.TabIndex = 3;
            this.TotalBuyPLabel.Text = "123";
            this.TotalBuyPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalBuyLabel
            // 
            this.TotalBuyLabel.AutoSize = true;
            this.TotalBuyLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalBuyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalBuyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBuyLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TotalBuyLabel.Location = new System.Drawing.Point(347, 3);
            this.TotalBuyLabel.Name = "TotalBuyLabel";
            this.TotalBuyLabel.Size = new System.Drawing.Size(105, 28);
            this.TotalBuyLabel.TabIndex = 2;
            this.TotalBuyLabel.Text = "1234";
            this.TotalBuyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.BackColor = System.Drawing.Color.Transparent;
            this.StockLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StockLabel.Location = new System.Drawing.Point(233, 3);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(105, 28);
            this.StockLabel.TabIndex = 1;
            this.StockLabel.Text = "1296";
            this.StockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALL MARKET:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormVedicaSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionBarColor = System.Drawing.SystemColors.Control;
            this.CaptionButtonColor = System.Drawing.Color.Gray;
            this.CaptionButtonHoverColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(809, 272);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormVedicaSector";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vedica Sector";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVedicaSector_FormClosed);
            this.Load += new System.EventHandler(this.FormVedicaSector_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).EndInit();
            this.AllMarketTLP.ResumeLayout(false);
            this.AllMarketTLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv ProgressBar;
        private System.Windows.Forms.DataGridView RetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Stocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_BuyP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_SellP;
        private System.Windows.Forms.TableLayoutPanel AllMarketTLP;
        private System.Windows.Forms.Label TotalSellPLabel;
        private System.Windows.Forms.Label TotalSellLabel;
        private System.Windows.Forms.Label TotalBuyPLabel;
        private System.Windows.Forms.Label TotalBuyLabel;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.Label label1;
    }
}