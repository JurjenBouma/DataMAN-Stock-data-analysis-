namespace DataMAN.PortofolioUI
{
    partial class PortofolioUI
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
            this.labelCash = new System.Windows.Forms.Label();
            this.labelPortfolio = new System.Windows.Forms.Label();
            this.labelPortfolioValue = new System.Windows.Forms.Label();
            this.labelCashValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCash
            // 
            this.labelCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.labelCash.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCash.ForeColor = System.Drawing.Color.Black;
            this.labelCash.Location = new System.Drawing.Point(0, 0);
            this.labelCash.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCash.Name = "labelCash";
            this.labelCash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCash.Size = new System.Drawing.Size(92, 20);
            this.labelCash.TabIndex = 10;
            this.labelCash.Text = "Cash";
            this.labelCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPortfolio
            // 
            this.labelPortfolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.labelPortfolio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortfolio.ForeColor = System.Drawing.Color.Black;
            this.labelPortfolio.Location = new System.Drawing.Point(94, 0);
            this.labelPortfolio.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPortfolio.Name = "labelPortfolio";
            this.labelPortfolio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPortfolio.Size = new System.Drawing.Size(92, 20);
            this.labelPortfolio.TabIndex = 11;
            this.labelPortfolio.Text = "Portfolio";
            this.labelPortfolio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPortfolioValue
            // 
            this.labelPortfolioValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPortfolioValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortfolioValue.ForeColor = System.Drawing.Color.Black;
            this.labelPortfolioValue.Location = new System.Drawing.Point(94, 21);
            this.labelPortfolioValue.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPortfolioValue.Name = "labelPortfolioValue";
            this.labelPortfolioValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPortfolioValue.Size = new System.Drawing.Size(92, 20);
            this.labelPortfolioValue.TabIndex = 13;
            this.labelPortfolioValue.Text = "Portfolio";
            this.labelPortfolioValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCashValue
            // 
            this.labelCashValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCashValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCashValue.ForeColor = System.Drawing.Color.Black;
            this.labelCashValue.Location = new System.Drawing.Point(0, 21);
            this.labelCashValue.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCashValue.Name = "labelCashValue";
            this.labelCashValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCashValue.Size = new System.Drawing.Size(92, 20);
            this.labelCashValue.TabIndex = 12;
            this.labelCashValue.Text = "Cash";
            this.labelCashValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortofolioUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.labelPortfolioValue);
            this.Controls.Add(this.labelCashValue);
            this.Controls.Add(this.labelPortfolio);
            this.Controls.Add(this.labelCash);
            this.Name = "PortofolioUI";
            this.Size = new System.Drawing.Size(187, 41);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.Label labelPortfolio;
        private System.Windows.Forms.Label labelPortfolioValue;
        private System.Windows.Forms.Label labelCashValue;
    }
}
