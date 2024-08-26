﻿namespace VedicaTrader
{
    partial class FormVedicaIndustry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ProgressBar = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.RetDataGridView = new System.Windows.Forms.DataGridView();
            this.Industry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_BuyP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_SellP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 513);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ProgressBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RetDataGridView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(828, 511);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.ProgressBar.Size = new System.Drawing.Size(824, 20);
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.Text = "Listening...";
            this.ProgressBar.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            this.ProgressBar.ThemeName = "Tube";
            this.ProgressBar.TubeStartColor = System.Drawing.Color.Pink;
            this.ProgressBar.Value = 100;
            this.ProgressBar.WaitingGradientWidth = 400;
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
            this.Industry,
            this.Total_Stocks,
            this.Total_Buy,
            this.Total_BuyP,
            this.Total_Sell,
            this.Total_SellP});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RetDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.RetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RetDataGridView.GridColor = System.Drawing.Color.Silver;
            this.RetDataGridView.Location = new System.Drawing.Point(2, 24);
            this.RetDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.RetDataGridView.MultiSelect = false;
            this.RetDataGridView.Name = "RetDataGridView";
            this.RetDataGridView.ReadOnly = true;
            this.RetDataGridView.RowHeadersVisible = false;
            this.RetDataGridView.Size = new System.Drawing.Size(824, 485);
            this.RetDataGridView.TabIndex = 1;
            // 
            // Industry
            // 
            this.Industry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Industry.DefaultCellStyle = dataGridViewCellStyle1;
            this.Industry.HeaderText = "Industry";
            this.Industry.Name = "Industry";
            this.Industry.ReadOnly = true;
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
            // FormVedicaIndustry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionBarColor = System.Drawing.SystemColors.Control;
            this.CaptionButtonColor = System.Drawing.Color.Gray;
            this.CaptionButtonHoverColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(830, 513);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormVedicaIndustry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vedica Industry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVedicaIndustry_FormClosing);
            this.Load += new System.EventHandler(this.FormVedicaIndustry_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv ProgressBar;
        private System.Windows.Forms.DataGridView RetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Industry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Stocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_BuyP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_SellP;
    }
}