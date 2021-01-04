namespace DataMAN
{
    partial class TrainerWindow
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
            this.panelOptionTrade = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelPositions = new System.Windows.Forms.Panel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonPositions = new System.Windows.Forms.Button();
            this.buttonNextDay = new System.Windows.Forms.Button();
            this.buttonChain = new System.Windows.Forms.Button();
            this.buttonChart = new System.Windows.Forms.Button();
            this.panelWatchList = new System.Windows.Forms.Panel();
            this.stockInfoUI1 = new DataMAN.StockInfoUI.StockInfoUI();
            this.portofolioUI1 = new DataMAN.PortofolioUI.PortofolioUI();
            this.watchListUI1 = new DataMAN.WatchListUI();
            this.positionsPanel1 = new DataMAN.PositionsPanel();
            this.chainPanel1 = new DataMAN.ChainPanel();
            this.chartPanel1 = new DataMAN.ChartPanel();
            this.buttonPrevDay = new System.Windows.Forms.Button();
            this.panelOptionTrade.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelPositions.SuspendLayout();
            this.panelChart.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOptionTrade
            // 
            this.panelOptionTrade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOptionTrade.AutoScroll = true;
            this.panelOptionTrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelOptionTrade.Controls.Add(this.chainPanel1);
            this.panelOptionTrade.Location = new System.Drawing.Point(223, 44);
            this.panelOptionTrade.Name = "panelOptionTrade";
            this.panelOptionTrade.Size = new System.Drawing.Size(1036, 678);
            this.panelOptionTrade.TabIndex = 1;
            this.panelOptionTrade.Visible = false;
            // 
            // panelCenter
            // 
            this.panelCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCenter.Controls.Add(this.panelLeft);
            this.panelCenter.Controls.Add(this.panelPositions);
            this.panelCenter.Controls.Add(this.panelOptionTrade);
            this.panelCenter.Controls.Add(this.panelChart);
            this.panelCenter.Location = new System.Drawing.Point(2, 3);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1259, 722);
            this.panelCenter.TabIndex = 2;
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.Controls.Add(this.watchListUI1);
            this.panelLeft.Location = new System.Drawing.Point(3, 44);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(217, 678);
            this.panelLeft.TabIndex = 4;
            // 
            // panelPositions
            // 
            this.panelPositions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPositions.Controls.Add(this.positionsPanel1);
            this.panelPositions.Location = new System.Drawing.Point(223, 44);
            this.panelPositions.Name = "panelPositions";
            this.panelPositions.Size = new System.Drawing.Size(1036, 678);
            this.panelPositions.TabIndex = 1;
            // 
            // panelChart
            // 
            this.panelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChart.Controls.Add(this.chartPanel1);
            this.panelChart.Location = new System.Drawing.Point(223, 44);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(1036, 678);
            this.panelChart.TabIndex = 2;
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.Controls.Add(this.buttonPrevDay);
            this.panelTop.Controls.Add(this.stockInfoUI1);
            this.panelTop.Controls.Add(this.portofolioUI1);
            this.panelTop.Controls.Add(this.buttonPositions);
            this.panelTop.Controls.Add(this.buttonNextDay);
            this.panelTop.Controls.Add(this.buttonChain);
            this.panelTop.Controls.Add(this.buttonChart);
            this.panelTop.Controls.Add(this.panelWatchList);
            this.panelTop.Location = new System.Drawing.Point(2, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1259, 41);
            this.panelTop.TabIndex = 3;
            // 
            // buttonPositions
            // 
            this.buttonPositions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPositions.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPositions.Location = new System.Drawing.Point(133, 3);
            this.buttonPositions.Name = "buttonPositions";
            this.buttonPositions.Size = new System.Drawing.Size(72, 35);
            this.buttonPositions.TabIndex = 7;
            this.buttonPositions.Text = "Positions";
            this.buttonPositions.UseVisualStyleBackColor = true;
            this.buttonPositions.Click += new System.EventHandler(this.buttonPositions_Click);
            // 
            // buttonNextDay
            // 
            this.buttonNextDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextDay.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonNextDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNextDay.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextDay.Location = new System.Drawing.Point(1147, 3);
            this.buttonNextDay.Name = "buttonNextDay";
            this.buttonNextDay.Size = new System.Drawing.Size(109, 35);
            this.buttonNextDay.TabIndex = 6;
            this.buttonNextDay.Text = "Next Day";
            this.buttonNextDay.UseVisualStyleBackColor = false;
            this.buttonNextDay.Click += new System.EventHandler(this.buttonNextDay_Click);
            // 
            // buttonChain
            // 
            this.buttonChain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChain.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChain.Location = new System.Drawing.Point(68, 3);
            this.buttonChain.Name = "buttonChain";
            this.buttonChain.Size = new System.Drawing.Size(59, 35);
            this.buttonChain.TabIndex = 5;
            this.buttonChain.Text = "Trade";
            this.buttonChain.UseVisualStyleBackColor = true;
            this.buttonChain.Click += new System.EventHandler(this.buttonChain_Click);
            // 
            // buttonChart
            // 
            this.buttonChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonChart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChart.Location = new System.Drawing.Point(3, 3);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(59, 35);
            this.buttonChart.TabIndex = 4;
            this.buttonChart.Text = "Chart";
            this.buttonChart.UseVisualStyleBackColor = true;
            this.buttonChart.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // panelWatchList
            // 
            this.panelWatchList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelWatchList.Location = new System.Drawing.Point(3, 44);
            this.panelWatchList.Name = "panelWatchList";
            this.panelWatchList.Size = new System.Drawing.Size(217, 882);
            this.panelWatchList.TabIndex = 3;
            // 
            // stockInfoUI1
            // 
            this.stockInfoUI1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.stockInfoUI1.Location = new System.Drawing.Point(416, 0);
            this.stockInfoUI1.Name = "stockInfoUI1";
            this.stockInfoUI1.Size = new System.Drawing.Size(205, 41);
            this.stockInfoUI1.TabIndex = 9;
            // 
            // portofolioUI1
            // 
            this.portofolioUI1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.portofolioUI1.Location = new System.Drawing.Point(223, 0);
            this.portofolioUI1.Name = "portofolioUI1";
            this.portofolioUI1.Size = new System.Drawing.Size(187, 41);
            this.portofolioUI1.TabIndex = 8;
            // 
            // watchListUI1
            // 
            this.watchListUI1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.watchListUI1.Location = new System.Drawing.Point(3, 3);
            this.watchListUI1.Name = "watchListUI1";
            this.watchListUI1.ShowRecent = true;
            this.watchListUI1.Size = new System.Drawing.Size(211, 667);
            this.watchListUI1.TabIndex = 3;
            // 
            // positionsPanel1
            // 
            this.positionsPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.positionsPanel1.Location = new System.Drawing.Point(0, 0);
            this.positionsPanel1.Name = "positionsPanel1";
            this.positionsPanel1.Size = new System.Drawing.Size(1036, 678);
            this.positionsPanel1.TabIndex = 0;
            // 
            // chainPanel1
            // 
            this.chainPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chainPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chainPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.chainPanel1.Location = new System.Drawing.Point(0, 0);
            this.chainPanel1.Name = "chainPanel1";
            this.chainPanel1.Size = new System.Drawing.Size(1036, 678);
            this.chainPanel1.TabIndex = 0;
            // 
            // chartPanel1
            // 
            this.chartPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.chartPanel1.Location = new System.Drawing.Point(0, 0);
            this.chartPanel1.Name = "chartPanel1";
            this.chartPanel1.Size = new System.Drawing.Size(1036, 678);
            this.chartPanel1.TabIndex = 1;
            // 
            // buttonPrevDay
            // 
            this.buttonPrevDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrevDay.BackColor = System.Drawing.Color.Maroon;
            this.buttonPrevDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrevDay.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevDay.Location = new System.Drawing.Point(627, 3);
            this.buttonPrevDay.Name = "buttonPrevDay";
            this.buttonPrevDay.Size = new System.Drawing.Size(142, 35);
            this.buttonPrevDay.TabIndex = 10;
            this.buttonPrevDay.Text = "Previous Day";
            this.buttonPrevDay.UseVisualStyleBackColor = false;
            this.buttonPrevDay.Click += new System.EventHandler(this.buttonPrevDay_Click);
            // 
            // TrainerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelCenter);
            this.MinimumSize = new System.Drawing.Size(1280, 768);
            this.Name = "TrainerWindow";
            this.Text = "TrainerWindow";
            this.Activated += new System.EventHandler(this.TrainerWindow_Activated);
            this.SizeChanged += new System.EventHandler(this.TrainerWindow_SizeChanged);
            this.panelOptionTrade.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelPositions.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelOptionTrade;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelWatchList;
        private DataMAN.WatchListUI watchListUI1;
        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.Button buttonChain;
        private System.Windows.Forms.Button buttonNextDay;
        private System.Windows.Forms.Button buttonPositions;
        private System.Windows.Forms.Panel panelLeft;
        private ChainPanel chainPanel1;
        private ChartPanel chartPanel1;
        private System.Windows.Forms.Panel panelPositions;
        private PositionsPanel positionsPanel1;
        private PortofolioUI.PortofolioUI portofolioUI1;
        private StockInfoUI.StockInfoUI stockInfoUI1;
        private System.Windows.Forms.Button buttonPrevDay;
    }
}