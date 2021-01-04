namespace DataMAN
{
    partial class ChainPanel
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
            this.panelBuy = new System.Windows.Forms.Panel();
            this.panelChain = new System.Windows.Forms.Panel();
            this.orderUI1 = new DataMAN.OrderUI();
            this.panelBuy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBuy
            // 
            this.panelBuy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelBuy.Controls.Add(this.orderUI1);
            this.panelBuy.Location = new System.Drawing.Point(3, 458);
            this.panelBuy.Name = "panelBuy";
            this.panelBuy.Size = new System.Drawing.Size(1046, 256);
            this.panelBuy.TabIndex = 1;
            // 
            // panelChain
            // 
            this.panelChain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChain.AutoScroll = true;
            this.panelChain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panelChain.Location = new System.Drawing.Point(3, 3);
            this.panelChain.Name = "panelChain";
            this.panelChain.Size = new System.Drawing.Size(1046, 449);
            this.panelChain.TabIndex = 0;
            // 
            // orderUI1
            // 
            this.orderUI1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderUI1.Location = new System.Drawing.Point(3, 2);
            this.orderUI1.Name = "orderUI1";
            this.orderUI1.Size = new System.Drawing.Size(1040, 251);
            this.orderUI1.TabIndex = 0;
            // 
            // ChainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.panelBuy);
            this.Controls.Add(this.panelChain);
            this.Name = "ChainPanel";
            this.Size = new System.Drawing.Size(1049, 717);
            this.panelBuy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuy;
        private System.Windows.Forms.Panel panelChain;
        private OrderUI orderUI1;
    }
}
