namespace VedicaTrader
{
    partial class FormSignalScanner
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ProgressBar = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.RetDataGridView = new System.Windows.Forms.DataGridView();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Industry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Signal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndustrySignal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectorSignal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 513);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 511);
            this.panel2.TabIndex = 1;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 509);
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
            this.ProgressBar.Size = new System.Drawing.Size(801, 20);
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
            this.Symbol,
            this.Company,
            this.Sector,
            this.Industry,
            this.SignalDate,
            this.SignalTime,
            this.Signal,
            this.IndustrySignal,
            this.SectorSignal,
            this.SignalPrice});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RetDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.RetDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RetDataGridView.GridColor = System.Drawing.Color.Gray;
            this.RetDataGridView.Location = new System.Drawing.Point(2, 24);
            this.RetDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.RetDataGridView.MultiSelect = false;
            this.RetDataGridView.Name = "RetDataGridView";
            this.RetDataGridView.ReadOnly = true;
            this.RetDataGridView.RowHeadersVisible = false;
            this.RetDataGridView.Size = new System.Drawing.Size(801, 483);
            this.RetDataGridView.TabIndex = 1;
            // 
            // Symbol
            // 
            this.Symbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Symbol.FillWeight = 50F;
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            this.Symbol.ReadOnly = true;
            // 
            // Company
            // 
            this.Company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Company.FillWeight = 120F;
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            // 
            // Sector
            // 
            this.Sector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sector.FillWeight = 120F;
            this.Sector.HeaderText = "Sector";
            this.Sector.Name = "Sector";
            this.Sector.ReadOnly = true;
            // 
            // Industry
            // 
            this.Industry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Industry.FillWeight = 120F;
            this.Industry.HeaderText = "Industry";
            this.Industry.Name = "Industry";
            this.Industry.ReadOnly = true;
            // 
            // SignalDate
            // 
            this.SignalDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SignalDate.FillWeight = 70F;
            this.SignalDate.HeaderText = "Signal Date";
            this.SignalDate.Name = "SignalDate";
            this.SignalDate.ReadOnly = true;
            // 
            // SignalTime
            // 
            this.SignalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SignalTime.FillWeight = 70F;
            this.SignalTime.HeaderText = "Signal Time";
            this.SignalTime.Name = "SignalTime";
            this.SignalTime.ReadOnly = true;
            // 
            // Signal
            // 
            this.Signal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Signal.FillWeight = 50F;
            this.Signal.HeaderText = "Signal";
            this.Signal.Name = "Signal";
            this.Signal.ReadOnly = true;
            // 
            // IndustrySignal
            // 
            this.IndustrySignal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IndustrySignal.FillWeight = 50F;
            this.IndustrySignal.HeaderText = "Industry Signal";
            this.IndustrySignal.Name = "IndustrySignal";
            this.IndustrySignal.ReadOnly = true;
            // 
            // SectorSignal
            // 
            this.SectorSignal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SectorSignal.FillWeight = 50F;
            this.SectorSignal.HeaderText = "Sector Signal";
            this.SectorSignal.Name = "SectorSignal";
            this.SectorSignal.ReadOnly = true;
            // 
            // SignalPrice
            // 
            this.SignalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SignalPrice.FillWeight = 50F;
            this.SignalPrice.HeaderText = "Signal Price";
            this.SignalPrice.Name = "SignalPrice";
            this.SignalPrice.ReadOnly = true;
            // 
            // FormSignalScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionBarColor = System.Drawing.SystemColors.Control;
            this.CaptionButtonColor = System.Drawing.Color.Gray;
            this.CaptionButtonHoverColor = System.Drawing.Color.Black;
            this.CaptionFont = new System.Drawing.Font("Copperplate Gothic Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(809, 513);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormSignalScanner";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signal Scanner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSignalScanner_FormClosed);
            this.Load += new System.EventHandler(this.FormSignalScanner_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv ProgressBar;
        private System.Windows.Forms.DataGridView RetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Industry;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Signal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndustrySignal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectorSignal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalPrice;
    }
}