namespace DataMAN
{
    partial class PositionLine
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
            this.labelSymbol = new System.Windows.Forms.Label();
            this.labelStockPrice = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPosType = new System.Windows.Forms.Label();
            this.labelQuanitity = new System.Windows.Forms.Label();
            this.labelTotalValue = new System.Windows.Forms.Label();
            this.contextMenuStripSell = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelStrikes = new System.Windows.Forms.Label();
            this.labelProfit = new System.Windows.Forms.Label();
            this.labelBreakEven = new System.Windows.Forms.Label();
            this.contextMenuStripSell.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSymbol
            // 
            this.labelSymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.labelSymbol.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSymbol.ForeColor = System.Drawing.Color.Black;
            this.labelSymbol.Location = new System.Drawing.Point(1, 0);
            this.labelSymbol.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSymbol.Name = "labelSymbol";
            this.labelSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSymbol.Size = new System.Drawing.Size(100, 30);
            this.labelSymbol.TabIndex = 2;
            this.labelSymbol.Text = "Symbol";
            this.labelSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSymbol.Click += new System.EventHandler(this.labelSymbol_Click);
            this.labelSymbol.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PositionLine_MouseClick);
            // 
            // labelStockPrice
            // 
            this.labelStockPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelStockPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockPrice.ForeColor = System.Drawing.Color.Black;
            this.labelStockPrice.Location = new System.Drawing.Point(919, 0);
            this.labelStockPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelStockPrice.Name = "labelStockPrice";
            this.labelStockPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStockPrice.Size = new System.Drawing.Size(100, 30);
            this.labelStockPrice.TabIndex = 3;
            this.labelStockPrice.Text = "StockPrice";
            this.labelStockPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStockPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PositionLine_MouseClick);
            // 
            // labelPrice
            // 
            this.labelPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Black;
            this.labelPrice.Location = new System.Drawing.Point(511, 0);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPrice.Size = new System.Drawing.Size(100, 30);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PositionLine_MouseClick);
            // 
            // labelPosType
            // 
            this.labelPosType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPosType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosType.ForeColor = System.Drawing.Color.Black;
            this.labelPosType.Location = new System.Drawing.Point(103, 0);
            this.labelPosType.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPosType.Name = "labelPosType";
            this.labelPosType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPosType.Size = new System.Drawing.Size(100, 30);
            this.labelPosType.TabIndex = 6;
            this.labelPosType.Text = "PosType";
            this.labelPosType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPosType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PositionLine_MouseClick);
            // 
            // labelQuanitity
            // 
            this.labelQuanitity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelQuanitity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuanitity.ForeColor = System.Drawing.Color.Black;
            this.labelQuanitity.Location = new System.Drawing.Point(307, 0);
            this.labelQuanitity.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelQuanitity.Name = "labelQuanitity";
            this.labelQuanitity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelQuanitity.Size = new System.Drawing.Size(100, 30);
            this.labelQuanitity.TabIndex = 7;
            this.labelQuanitity.Text = "Quantity";
            this.labelQuanitity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuanitity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PositionLine_MouseClick);
            // 
            // labelTotalValue
            // 
            this.labelTotalValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTotalValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalValue.ForeColor = System.Drawing.Color.Black;
            this.labelTotalValue.Location = new System.Drawing.Point(613, 0);
            this.labelTotalValue.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelTotalValue.Name = "labelTotalValue";
            this.labelTotalValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotalValue.Size = new System.Drawing.Size(100, 30);
            this.labelTotalValue.TabIndex = 8;
            this.labelTotalValue.Text = "TotalValue";
            this.labelTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTotalValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PositionLine_MouseClick);
            // 
            // contextMenuStripSell
            // 
            this.contextMenuStripSell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellToolStripMenuItem});
            this.contextMenuStripSell.Name = "contextMenuStripSell";
            this.contextMenuStripSell.Size = new System.Drawing.Size(93, 26);
            // 
            // sellToolStripMenuItem
            // 
            this.sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            this.sellToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.sellToolStripMenuItem.Text = "Sell";
            this.sellToolStripMenuItem.Click += new System.EventHandler(this.sellToolStripMenuItem_Click);
            // 
            // labelCost
            // 
            this.labelCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.ForeColor = System.Drawing.Color.Black;
            this.labelCost.Location = new System.Drawing.Point(409, 0);
            this.labelCost.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCost.Name = "labelCost";
            this.labelCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCost.Size = new System.Drawing.Size(100, 30);
            this.labelCost.TabIndex = 9;
            this.labelCost.Text = "Cost";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCost.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PositionLine_MouseClick);
            // 
            // labelStrikes
            // 
            this.labelStrikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelStrikes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrikes.ForeColor = System.Drawing.Color.Black;
            this.labelStrikes.Location = new System.Drawing.Point(205, 0);
            this.labelStrikes.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelStrikes.Name = "labelStrikes";
            this.labelStrikes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStrikes.Size = new System.Drawing.Size(100, 30);
            this.labelStrikes.TabIndex = 10;
            this.labelStrikes.Text = "Strikes";
            this.labelStrikes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStrikes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PositionLine_MouseClick);
            // 
            // labelProfit
            // 
            this.labelProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelProfit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfit.ForeColor = System.Drawing.Color.Black;
            this.labelProfit.Location = new System.Drawing.Point(715, 0);
            this.labelProfit.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelProfit.Size = new System.Drawing.Size(100, 30);
            this.labelProfit.TabIndex = 11;
            this.labelProfit.Text = "Profit";
            this.labelProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProfit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PositionLine_MouseClick);
            // 
            // labelBreakEven
            // 
            this.labelBreakEven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelBreakEven.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBreakEven.ForeColor = System.Drawing.Color.Black;
            this.labelBreakEven.Location = new System.Drawing.Point(817, 0);
            this.labelBreakEven.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelBreakEven.Name = "labelBreakEven";
            this.labelBreakEven.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBreakEven.Size = new System.Drawing.Size(100, 30);
            this.labelBreakEven.TabIndex = 12;
            this.labelBreakEven.Text = "Break Even";
            this.labelBreakEven.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBreakEven.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PositionLine_MouseClick);
            // 
            // PositionLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.labelBreakEven);
            this.Controls.Add(this.labelProfit);
            this.Controls.Add(this.labelStrikes);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelTotalValue);
            this.Controls.Add(this.labelQuanitity);
            this.Controls.Add(this.labelPosType);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelStockPrice);
            this.Controls.Add(this.labelSymbol);
            this.Name = "PositionLine";
            this.Size = new System.Drawing.Size(1020, 30);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PositionLine_MouseClick);
            this.contextMenuStripSell.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSymbol;
        private System.Windows.Forms.Label labelStockPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelPosType;
        private System.Windows.Forms.Label labelQuanitity;
        private System.Windows.Forms.Label labelTotalValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSell;
        private System.Windows.Forms.ToolStripMenuItem sellToolStripMenuItem;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelStrikes;
        private System.Windows.Forms.Label labelProfit;
        private System.Windows.Forms.Label labelBreakEven;
    }
}
