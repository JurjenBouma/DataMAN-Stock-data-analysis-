namespace DataMAN
{
    partial class ChartControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelChart = new System.Windows.Forms.Panel();
            this.panelChartControls = new System.Windows.Forms.Panel();
            this.labelChartInterval = new System.Windows.Forms.Label();
            this.comboBoxTimeChart = new System.Windows.Forms.ComboBox();
            this.textBoxVolatility2M = new System.Windows.Forms.TextBox();
            this.labelVolatility2M = new System.Windows.Forms.Label();
            this.textBoxVolatility4W = new System.Windows.Forms.TextBox();
            this.labelVolatility4W = new System.Windows.Forms.Label();
            this.textBoxVolatility2W = new System.Windows.Forms.TextBox();
            this.labelVoletility2W = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.panelChartGraphicBorder = new System.Windows.Forms.Panel();
            this.panelChartGraphics = new System.Windows.Forms.Panel();
            this.labelGraphData = new System.Windows.Forms.Label();
            this.labelStockData = new System.Windows.Forms.Label();
            this.pictureBoxRender = new System.Windows.Forms.PictureBox();
            this.hScrollBarChart = new System.Windows.Forms.HScrollBar();
            this.contextMenuStripStock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToWatchlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelChart.SuspendLayout();
            this.panelChartControls.SuspendLayout();
            this.panelChartGraphicBorder.SuspendLayout();
            this.panelChartGraphics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRender)).BeginInit();
            this.contextMenuStripStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChart
            // 
            this.panelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChart.BackColor = System.Drawing.Color.White;
            this.panelChart.Controls.Add(this.panelChartControls);
            this.panelChart.Controls.Add(this.panelChartGraphicBorder);
            this.panelChart.Location = new System.Drawing.Point(0, 0);
            this.panelChart.Margin = new System.Windows.Forms.Padding(0);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(946, 729);
            this.panelChart.TabIndex = 5;
            // 
            // panelChartControls
            // 
            this.panelChartControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChartControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelChartControls.Controls.Add(this.labelChartInterval);
            this.panelChartControls.Controls.Add(this.comboBoxTimeChart);
            this.panelChartControls.Controls.Add(this.textBoxVolatility2M);
            this.panelChartControls.Controls.Add(this.labelVolatility2M);
            this.panelChartControls.Controls.Add(this.textBoxVolatility4W);
            this.panelChartControls.Controls.Add(this.labelVolatility4W);
            this.panelChartControls.Controls.Add(this.textBoxVolatility2W);
            this.panelChartControls.Controls.Add(this.labelVoletility2W);
            this.panelChartControls.Controls.Add(this.textBoxValue);
            this.panelChartControls.Controls.Add(this.labelValue);
            this.panelChartControls.Controls.Add(this.labelStock);
            this.panelChartControls.Controls.Add(this.textBoxStock);
            this.panelChartControls.Location = new System.Drawing.Point(0, 0);
            this.panelChartControls.Margin = new System.Windows.Forms.Padding(0);
            this.panelChartControls.Name = "panelChartControls";
            this.panelChartControls.Size = new System.Drawing.Size(946, 120);
            this.panelChartControls.TabIndex = 4;
            // 
            // labelChartInterval
            // 
            this.labelChartInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChartInterval.AutoSize = true;
            this.labelChartInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelChartInterval.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.labelChartInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelChartInterval.Location = new System.Drawing.Point(0, 80);
            this.labelChartInterval.Margin = new System.Windows.Forms.Padding(0);
            this.labelChartInterval.Name = "labelChartInterval";
            this.labelChartInterval.Size = new System.Drawing.Size(127, 19);
            this.labelChartInterval.TabIndex = 13;
            this.labelChartInterval.Text = "Chart interval        ";
            // 
            // comboBoxTimeChart
            // 
            this.comboBoxTimeChart.FormattingEnabled = true;
            this.comboBoxTimeChart.Location = new System.Drawing.Point(0, 99);
            this.comboBoxTimeChart.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxTimeChart.Name = "comboBoxTimeChart";
            this.comboBoxTimeChart.Size = new System.Drawing.Size(127, 21);
            this.comboBoxTimeChart.TabIndex = 12;
            this.comboBoxTimeChart.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeChart_SelectedIndexChanged);
            // 
            // textBoxVolatility2M
            // 
            this.textBoxVolatility2M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBoxVolatility2M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVolatility2M.Enabled = false;
            this.textBoxVolatility2M.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.textBoxVolatility2M.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxVolatility2M.Location = new System.Drawing.Point(375, 19);
            this.textBoxVolatility2M.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxVolatility2M.Name = "textBoxVolatility2M";
            this.textBoxVolatility2M.ReadOnly = true;
            this.textBoxVolatility2M.Size = new System.Drawing.Size(93, 25);
            this.textBoxVolatility2M.TabIndex = 11;
            // 
            // labelVolatility2M
            // 
            this.labelVolatility2M.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolatility2M.AutoSize = true;
            this.labelVolatility2M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelVolatility2M.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.labelVolatility2M.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelVolatility2M.Location = new System.Drawing.Point(374, 0);
            this.labelVolatility2M.Margin = new System.Windows.Forms.Padding(0);
            this.labelVolatility2M.Name = "labelVolatility2M";
            this.labelVolatility2M.Size = new System.Drawing.Size(94, 19);
            this.labelVolatility2M.TabIndex = 10;
            this.labelVolatility2M.Text = "Volatility 2M ";
            // 
            // textBoxVolatility4W
            // 
            this.textBoxVolatility4W.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBoxVolatility4W.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVolatility4W.Enabled = false;
            this.textBoxVolatility4W.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.textBoxVolatility4W.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxVolatility4W.Location = new System.Drawing.Point(280, 19);
            this.textBoxVolatility4W.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxVolatility4W.Name = "textBoxVolatility4W";
            this.textBoxVolatility4W.ReadOnly = true;
            this.textBoxVolatility4W.Size = new System.Drawing.Size(93, 25);
            this.textBoxVolatility4W.TabIndex = 9;
            // 
            // labelVolatility4W
            // 
            this.labelVolatility4W.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolatility4W.AutoSize = true;
            this.labelVolatility4W.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelVolatility4W.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.labelVolatility4W.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelVolatility4W.Location = new System.Drawing.Point(278, 0);
            this.labelVolatility4W.Margin = new System.Windows.Forms.Padding(0);
            this.labelVolatility4W.Name = "labelVolatility4W";
            this.labelVolatility4W.Size = new System.Drawing.Size(96, 19);
            this.labelVolatility4W.TabIndex = 8;
            this.labelVolatility4W.Text = "Volatility 1M  ";
            // 
            // textBoxVolatility2W
            // 
            this.textBoxVolatility2W.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBoxVolatility2W.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVolatility2W.Enabled = false;
            this.textBoxVolatility2W.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.textBoxVolatility2W.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxVolatility2W.Location = new System.Drawing.Point(185, 19);
            this.textBoxVolatility2W.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxVolatility2W.Name = "textBoxVolatility2W";
            this.textBoxVolatility2W.ReadOnly = true;
            this.textBoxVolatility2W.Size = new System.Drawing.Size(93, 25);
            this.textBoxVolatility2W.TabIndex = 7;
            // 
            // labelVoletility2W
            // 
            this.labelVoletility2W.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVoletility2W.AutoSize = true;
            this.labelVoletility2W.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelVoletility2W.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.labelVoletility2W.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelVoletility2W.Location = new System.Drawing.Point(183, 0);
            this.labelVoletility2W.Margin = new System.Windows.Forms.Padding(0);
            this.labelVoletility2W.Name = "labelVoletility2W";
            this.labelVoletility2W.Size = new System.Drawing.Size(95, 19);
            this.labelVoletility2W.TabIndex = 6;
            this.labelVoletility2W.Text = "Volatility 2W ";
            // 
            // textBoxValue
            // 
            this.textBoxValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBoxValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValue.Enabled = false;
            this.textBoxValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.textBoxValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxValue.Location = new System.Drawing.Point(92, 19);
            this.textBoxValue.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.ReadOnly = true;
            this.textBoxValue.Size = new System.Drawing.Size(91, 25);
            this.textBoxValue.TabIndex = 5;
            // 
            // labelValue
            // 
            this.labelValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValue.AutoSize = true;
            this.labelValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelValue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.labelValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelValue.Location = new System.Drawing.Point(92, 0);
            this.labelValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(91, 19);
            this.labelValue.TabIndex = 4;
            this.labelValue.Text = "Value            ";
            // 
            // labelStock
            // 
            this.labelStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStock.AutoSize = true;
            this.labelStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelStock.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.labelStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelStock.Location = new System.Drawing.Point(0, 0);
            this.labelStock.Margin = new System.Windows.Forms.Padding(0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(92, 19);
            this.labelStock.TabIndex = 3;
            this.labelStock.Text = "Stock            ";
            // 
            // textBoxStock
            // 
            this.textBoxStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBoxStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxStock.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.textBoxStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxStock.Location = new System.Drawing.Point(0, 19);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(90, 25);
            this.textBoxStock.TabIndex = 0;
            this.textBoxStock.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxStock_KeyUp);
            // 
            // panelChartGraphicBorder
            // 
            this.panelChartGraphicBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChartGraphicBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelChartGraphicBorder.Controls.Add(this.panelChartGraphics);
            this.panelChartGraphicBorder.Location = new System.Drawing.Point(0, 120);
            this.panelChartGraphicBorder.Margin = new System.Windows.Forms.Padding(0);
            this.panelChartGraphicBorder.Name = "panelChartGraphicBorder";
            this.panelChartGraphicBorder.Size = new System.Drawing.Size(946, 609);
            this.panelChartGraphicBorder.TabIndex = 5;
            // 
            // panelChartGraphics
            // 
            this.panelChartGraphics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChartGraphics.AutoScroll = true;
            this.panelChartGraphics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelChartGraphics.Controls.Add(this.labelGraphData);
            this.panelChartGraphics.Controls.Add(this.labelStockData);
            this.panelChartGraphics.Controls.Add(this.pictureBoxRender);
            this.panelChartGraphics.Controls.Add(this.hScrollBarChart);
            this.panelChartGraphics.Location = new System.Drawing.Point(2, 2);
            this.panelChartGraphics.Margin = new System.Windows.Forms.Padding(2);
            this.panelChartGraphics.Name = "panelChartGraphics";
            this.panelChartGraphics.Size = new System.Drawing.Size(942, 605);
            this.panelChartGraphics.TabIndex = 3;
            // 
            // labelGraphData
            // 
            this.labelGraphData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGraphData.AutoSize = true;
            this.labelGraphData.BackColor = System.Drawing.Color.Transparent;
            this.labelGraphData.Font = new System.Drawing.Font("Segoe UI Semibold", 7F);
            this.labelGraphData.ForeColor = System.Drawing.SystemColors.Window;
            this.labelGraphData.Location = new System.Drawing.Point(817, 483);
            this.labelGraphData.Name = "labelGraphData";
            this.labelGraphData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGraphData.Size = new System.Drawing.Size(76, 12);
            this.labelGraphData.TabIndex = 1;
            this.labelGraphData.Text = "labelGraphData";
            this.labelGraphData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelGraphData.Visible = false;
            // 
            // labelStockData
            // 
            this.labelStockData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStockData.AutoSize = true;
            this.labelStockData.BackColor = System.Drawing.Color.Transparent;
            this.labelStockData.Font = new System.Drawing.Font("Segoe UI Semibold", 7F);
            this.labelStockData.ForeColor = System.Drawing.SystemColors.Window;
            this.labelStockData.Location = new System.Drawing.Point(817, 531);
            this.labelStockData.Name = "labelStockData";
            this.labelStockData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStockData.Size = new System.Drawing.Size(73, 12);
            this.labelStockData.TabIndex = 0;
            this.labelStockData.Text = "labelStockData";
            this.labelStockData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelStockData.Visible = false;
            // 
            // pictureBoxRender
            // 
            this.pictureBoxRender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxRender.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRender.Name = "pictureBoxRender";
            this.pictureBoxRender.Size = new System.Drawing.Size(944, 588);
            this.pictureBoxRender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRender.TabIndex = 4;
            this.pictureBoxRender.TabStop = false;
            this.pictureBoxRender.MouseEnter += new System.EventHandler(this.pictureBoxRender_MouseEnter);
            this.pictureBoxRender.MouseLeave += new System.EventHandler(this.pictureBoxRender_MouseLeave);
            this.pictureBoxRender.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRender_MouseMove);
            this.pictureBoxRender.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRender_MouseUp);
            this.pictureBoxRender.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chartMouseWheel);
            // 
            // hScrollBarChart
            // 
            this.hScrollBarChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBarChart.LargeChange = 1;
            this.hScrollBarChart.Location = new System.Drawing.Point(0, 588);
            this.hScrollBarChart.Maximum = 0;
            this.hScrollBarChart.Name = "hScrollBarChart";
            this.hScrollBarChart.Size = new System.Drawing.Size(942, 17);
            this.hScrollBarChart.TabIndex = 3;
            this.hScrollBarChart.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarChart_Scroll);
            // 
            // contextMenuStripStock
            // 
            this.contextMenuStripStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToWatchlistToolStripMenuItem});
            this.contextMenuStripStock.Name = "contextMenuStripStock";
            this.contextMenuStripStock.Size = new System.Drawing.Size(164, 26);
            // 
            // addToWatchlistToolStripMenuItem
            // 
            this.addToWatchlistToolStripMenuItem.Name = "addToWatchlistToolStripMenuItem";
            this.addToWatchlistToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addToWatchlistToolStripMenuItem.Text = "Add To Watchlist";
            // 
            // ChartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelChart);
            this.Name = "ChartControl";
            this.Size = new System.Drawing.Size(946, 729);
            this.panelChart.ResumeLayout(false);
            this.panelChartControls.ResumeLayout(false);
            this.panelChartControls.PerformLayout();
            this.panelChartGraphicBorder.ResumeLayout(false);
            this.panelChartGraphics.ResumeLayout(false);
            this.panelChartGraphics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRender)).EndInit();
            this.contextMenuStripStock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Panel panelChartControls;
        private System.Windows.Forms.Panel panelChartGraphicBorder;
        private System.Windows.Forms.Panel panelChartGraphics;
        private System.Windows.Forms.HScrollBar hScrollBarChart;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripStock;
        private System.Windows.Forms.ToolStripMenuItem addToWatchlistToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxVolatility2W;
        private System.Windows.Forms.Label labelVoletility2W;
        private System.Windows.Forms.TextBox textBoxVolatility4W;
        private System.Windows.Forms.Label labelVolatility4W;
        private System.Windows.Forms.TextBox textBoxVolatility2M;
        private System.Windows.Forms.Label labelVolatility2M;
        private System.Windows.Forms.ComboBox comboBoxTimeChart;
        private System.Windows.Forms.Label labelChartInterval;
        private System.Windows.Forms.Label labelStockData;
        private System.Windows.Forms.Label labelGraphData;
        private System.Windows.Forms.PictureBox pictureBoxRender;
    }
}
