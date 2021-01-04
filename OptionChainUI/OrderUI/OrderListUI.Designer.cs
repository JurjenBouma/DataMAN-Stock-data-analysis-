namespace DataMAN
{
    partial class OrderListUI
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
            this.panelOrder = new System.Windows.Forms.Panel();
            this.orderLineUI1 = new DataMAN.OrderLineUI();
            this.orderLineUI2 = new DataMAN.OrderLineUI();
            this.orderLineUI3 = new DataMAN.OrderLineUI();
            this.orderLineUI4 = new DataMAN.OrderLineUI();
            this.panelOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOrder
            // 
            this.panelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelOrder.Controls.Add(this.orderLineUI4);
            this.panelOrder.Controls.Add(this.orderLineUI3);
            this.panelOrder.Controls.Add(this.orderLineUI2);
            this.panelOrder.Controls.Add(this.orderLineUI1);
            this.panelOrder.Location = new System.Drawing.Point(0, 0);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(352, 178);
            this.panelOrder.TabIndex = 10;
            // 
            // orderLineUI1
            // 
            this.orderLineUI1.Location = new System.Drawing.Point(16, 16);
            this.orderLineUI1.Margin = new System.Windows.Forms.Padding(0);
            this.orderLineUI1.Name = "orderLineUI1";
            this.orderLineUI1.Size = new System.Drawing.Size(320, 30);
            this.orderLineUI1.TabIndex = 0;
            // 
            // orderLineUI2
            // 
            this.orderLineUI2.Location = new System.Drawing.Point(16, 54);
            this.orderLineUI2.Margin = new System.Windows.Forms.Padding(16, 8, 0, 0);
            this.orderLineUI2.Name = "orderLineUI2";
            this.orderLineUI2.Size = new System.Drawing.Size(320, 30);
            this.orderLineUI2.TabIndex = 1;
            // 
            // orderLineUI3
            // 
            this.orderLineUI3.Location = new System.Drawing.Point(16, 92);
            this.orderLineUI3.Margin = new System.Windows.Forms.Padding(16, 8, 0, 0);
            this.orderLineUI3.Name = "orderLineUI3";
            this.orderLineUI3.Size = new System.Drawing.Size(320, 30);
            this.orderLineUI3.TabIndex = 2;
            // 
            // orderLineUI4
            // 
            this.orderLineUI4.Location = new System.Drawing.Point(16, 130);
            this.orderLineUI4.Margin = new System.Windows.Forms.Padding(16, 8, 0, 0);
            this.orderLineUI4.Name = "orderLineUI4";
            this.orderLineUI4.Size = new System.Drawing.Size(320, 30);
            this.orderLineUI4.TabIndex = 3;
            // 
            // OrderListUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelOrder);
            this.Name = "OrderListUI";
            this.Size = new System.Drawing.Size(352, 178);
            this.panelOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOrder;
        private OrderLineUI orderLineUI4;
        private OrderLineUI orderLineUI3;
        private OrderLineUI orderLineUI2;
        private OrderLineUI orderLineUI1;
    }
}
