namespace DataMAN
{
    partial class OrderBuyUI
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
            this.buttonBuy = new System.Windows.Forms.Button();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelCostValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBuy
            // 
            this.buttonBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.buttonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBuy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.Location = new System.Drawing.Point(187, 115);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(104, 39);
            this.buttonBuy.TabIndex = 9;
            this.buttonBuy.Text = "Place Order";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // labelCost
            // 
            this.labelCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCost.Location = new System.Drawing.Point(9, 9);
            this.labelCost.Margin = new System.Windows.Forms.Padding(0);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(282, 37);
            this.labelCost.TabIndex = 13;
            this.labelCost.Text = "Spread Cost";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCostValue
            // 
            this.labelCostValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCostValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCostValue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCostValue.Location = new System.Drawing.Point(9, 57);
            this.labelCostValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelCostValue.Name = "labelCostValue";
            this.labelCostValue.Size = new System.Drawing.Size(282, 37);
            this.labelCostValue.TabIndex = 14;
            this.labelCostValue.Text = "0";
            this.labelCostValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderBuyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.labelCostValue);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.buttonBuy);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "OrderBuyUI";
            this.Size = new System.Drawing.Size(300, 178);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelCostValue;
    }
}
