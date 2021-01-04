namespace DataMAN.StockInfoUI
{
    partial class StockInfoUI
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
            this.labelSymbol = new System.Windows.Forms.Label();
            this.labelStockPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSymbol
            // 
            this.labelSymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.labelSymbol.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSymbol.ForeColor = System.Drawing.Color.Black;
            this.labelSymbol.Location = new System.Drawing.Point(1, 1);
            this.labelSymbol.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSymbol.Name = "labelSymbol";
            this.labelSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSymbol.Size = new System.Drawing.Size(100, 39);
            this.labelSymbol.TabIndex = 14;
            this.labelSymbol.Text = "Symbol";
            this.labelSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStockPrice
            // 
            this.labelStockPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.labelStockPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockPrice.ForeColor = System.Drawing.Color.Black;
            this.labelStockPrice.Location = new System.Drawing.Point(103, 1);
            this.labelStockPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelStockPrice.Name = "labelStockPrice";
            this.labelStockPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStockPrice.Size = new System.Drawing.Size(100, 39);
            this.labelStockPrice.TabIndex = 15;
            this.labelStockPrice.Text = "Price";
            this.labelStockPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StockInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.labelStockPrice);
            this.Controls.Add(this.labelSymbol);
            this.Name = "StockInfoUI";
            this.Size = new System.Drawing.Size(205, 41);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSymbol;
        private System.Windows.Forms.Label labelStockPrice;
    }
}
