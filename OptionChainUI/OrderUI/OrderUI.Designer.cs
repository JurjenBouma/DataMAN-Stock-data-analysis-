namespace DataMAN
{
    partial class OrderUI
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
            this.panelOrder = new System.Windows.Forms.Panel();
            this.panelBuyAdjustments = new System.Windows.Forms.Panel();
            this.labelClear = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelSwap = new System.Windows.Forms.Label();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.buttonQuantityMore = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonQuantityLess = new System.Windows.Forms.Button();
            this.buttonStrikesDown = new System.Windows.Forms.Button();
            this.labelStrikes = new System.Windows.Forms.Label();
            this.buttonStrikesUp = new System.Windows.Forms.Button();
            this.labelMaxProf = new System.Windows.Forms.Label();
            this.labelMaxLoss = new System.Windows.Forms.Label();
            this.labelMaxGainValue = new System.Windows.Forms.Label();
            this.labelMaxLossValue = new System.Windows.Forms.Label();
            this.orderBuyUI1 = new DataMAN.OrderBuyUI();
            this.orderListUI1 = new DataMAN.OrderListUI();
            this.panelBuy.SuspendLayout();
            this.panelOrder.SuspendLayout();
            this.panelBuyAdjustments.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBuy
            // 
            this.panelBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelBuy.Controls.Add(this.orderBuyUI1);
            this.panelBuy.Controls.Add(this.panelOrder);
            this.panelBuy.Controls.Add(this.panelBuyAdjustments);
            this.panelBuy.Location = new System.Drawing.Point(0, 0);
            this.panelBuy.Name = "panelBuy";
            this.panelBuy.Size = new System.Drawing.Size(862, 251);
            this.panelBuy.TabIndex = 2;
            // 
            // panelOrder
            // 
            this.panelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelOrder.Controls.Add(this.orderListUI1);
            this.panelOrder.Location = new System.Drawing.Point(0, 67);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(354, 181);
            this.panelOrder.TabIndex = 9;
            // 
            // panelBuyAdjustments
            // 
            this.panelBuyAdjustments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBuyAdjustments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelBuyAdjustments.Controls.Add(this.labelMaxLossValue);
            this.panelBuyAdjustments.Controls.Add(this.labelMaxGainValue);
            this.panelBuyAdjustments.Controls.Add(this.labelMaxLoss);
            this.panelBuyAdjustments.Controls.Add(this.labelMaxProf);
            this.panelBuyAdjustments.Controls.Add(this.labelClear);
            this.panelBuyAdjustments.Controls.Add(this.buttonClear);
            this.panelBuyAdjustments.Controls.Add(this.labelSwap);
            this.panelBuyAdjustments.Controls.Add(this.buttonSwap);
            this.panelBuyAdjustments.Controls.Add(this.buttonQuantityMore);
            this.panelBuyAdjustments.Controls.Add(this.labelQuantity);
            this.panelBuyAdjustments.Controls.Add(this.buttonQuantityLess);
            this.panelBuyAdjustments.Controls.Add(this.buttonStrikesDown);
            this.panelBuyAdjustments.Controls.Add(this.labelStrikes);
            this.panelBuyAdjustments.Controls.Add(this.buttonStrikesUp);
            this.panelBuyAdjustments.Location = new System.Drawing.Point(0, 0);
            this.panelBuyAdjustments.Margin = new System.Windows.Forms.Padding(0);
            this.panelBuyAdjustments.Name = "panelBuyAdjustments";
            this.panelBuyAdjustments.Size = new System.Drawing.Size(862, 64);
            this.panelBuyAdjustments.TabIndex = 8;
            // 
            // labelClear
            // 
            this.labelClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelClear.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClear.Location = new System.Drawing.Point(370, 2);
            this.labelClear.Margin = new System.Windows.Forms.Padding(0);
            this.labelClear.Name = "labelClear";
            this.labelClear.Size = new System.Drawing.Size(70, 30);
            this.labelClear.TabIndex = 14;
            this.labelClear.Text = "Clear";
            this.labelClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.Maroon;
            this.buttonClear.Location = new System.Drawing.Point(370, 32);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 30);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.TabStop = false;
            this.buttonClear.Text = "\"\"";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelSwap
            // 
            this.labelSwap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelSwap.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSwap.Location = new System.Drawing.Point(300, 2);
            this.labelSwap.Margin = new System.Windows.Forms.Padding(0);
            this.labelSwap.Name = "labelSwap";
            this.labelSwap.Size = new System.Drawing.Size(70, 30);
            this.labelSwap.TabIndex = 12;
            this.labelSwap.Text = "Swap";
            this.labelSwap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSwap
            // 
            this.buttonSwap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.buttonSwap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSwap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonSwap.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonSwap.Location = new System.Drawing.Point(300, 32);
            this.buttonSwap.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(70, 30);
            this.buttonSwap.TabIndex = 11;
            this.buttonSwap.Text = "><";
            this.buttonSwap.UseVisualStyleBackColor = false;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // buttonQuantityMore
            // 
            this.buttonQuantityMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.buttonQuantityMore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuantityMore.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuantityMore.Location = new System.Drawing.Point(220, 32);
            this.buttonQuantityMore.Margin = new System.Windows.Forms.Padding(0);
            this.buttonQuantityMore.Name = "buttonQuantityMore";
            this.buttonQuantityMore.Size = new System.Drawing.Size(70, 30);
            this.buttonQuantityMore.TabIndex = 10;
            this.buttonQuantityMore.Text = ">";
            this.buttonQuantityMore.UseVisualStyleBackColor = false;
            this.buttonQuantityMore.Click += new System.EventHandler(this.buttonQuantityMore_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(150, 2);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(140, 30);
            this.labelQuantity.TabIndex = 9;
            this.labelQuantity.Text = "Quantity";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonQuantityLess
            // 
            this.buttonQuantityLess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.buttonQuantityLess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuantityLess.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuantityLess.Location = new System.Drawing.Point(150, 32);
            this.buttonQuantityLess.Margin = new System.Windows.Forms.Padding(0);
            this.buttonQuantityLess.Name = "buttonQuantityLess";
            this.buttonQuantityLess.Size = new System.Drawing.Size(70, 30);
            this.buttonQuantityLess.TabIndex = 8;
            this.buttonQuantityLess.Text = "<";
            this.buttonQuantityLess.UseVisualStyleBackColor = false;
            this.buttonQuantityLess.Click += new System.EventHandler(this.buttonQuantityLess_Click);
            // 
            // buttonStrikesDown
            // 
            this.buttonStrikesDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.buttonStrikesDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStrikesDown.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStrikesDown.Location = new System.Drawing.Point(70, 32);
            this.buttonStrikesDown.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStrikesDown.Name = "buttonStrikesDown";
            this.buttonStrikesDown.Size = new System.Drawing.Size(70, 30);
            this.buttonStrikesDown.TabIndex = 7;
            this.buttonStrikesDown.Text = "/\\";
            this.buttonStrikesDown.UseVisualStyleBackColor = false;
            this.buttonStrikesDown.Click += new System.EventHandler(this.buttonStrikesDown_Click);
            // 
            // labelStrikes
            // 
            this.labelStrikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelStrikes.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrikes.Location = new System.Drawing.Point(0, 2);
            this.labelStrikes.Margin = new System.Windows.Forms.Padding(0);
            this.labelStrikes.Name = "labelStrikes";
            this.labelStrikes.Size = new System.Drawing.Size(140, 30);
            this.labelStrikes.TabIndex = 6;
            this.labelStrikes.Text = "Strikes";
            this.labelStrikes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStrikesUp
            // 
            this.buttonStrikesUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.buttonStrikesUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStrikesUp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStrikesUp.Location = new System.Drawing.Point(0, 32);
            this.buttonStrikesUp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStrikesUp.Name = "buttonStrikesUp";
            this.buttonStrikesUp.Size = new System.Drawing.Size(70, 30);
            this.buttonStrikesUp.TabIndex = 5;
            this.buttonStrikesUp.Text = "\\/";
            this.buttonStrikesUp.UseVisualStyleBackColor = false;
            this.buttonStrikesUp.Click += new System.EventHandler(this.buttonStrikesUp_Click);
            // 
            // labelMaxProf
            // 
            this.labelMaxProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelMaxProf.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxProf.Location = new System.Drawing.Point(450, 2);
            this.labelMaxProf.Margin = new System.Windows.Forms.Padding(0);
            this.labelMaxProf.Name = "labelMaxProf";
            this.labelMaxProf.Size = new System.Drawing.Size(107, 30);
            this.labelMaxProf.TabIndex = 15;
            this.labelMaxProf.Text = "Max Prof";
            this.labelMaxProf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxLoss
            // 
            this.labelMaxLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelMaxLoss.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxLoss.Location = new System.Drawing.Point(557, 2);
            this.labelMaxLoss.Margin = new System.Windows.Forms.Padding(0);
            this.labelMaxLoss.Name = "labelMaxLoss";
            this.labelMaxLoss.Size = new System.Drawing.Size(107, 30);
            this.labelMaxLoss.TabIndex = 16;
            this.labelMaxLoss.Text = "Max Loss";
            this.labelMaxLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxGainValue
            // 
            this.labelMaxGainValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.labelMaxGainValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxGainValue.Location = new System.Drawing.Point(450, 30);
            this.labelMaxGainValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelMaxGainValue.Name = "labelMaxGainValue";
            this.labelMaxGainValue.Size = new System.Drawing.Size(107, 30);
            this.labelMaxGainValue.TabIndex = 17;
            this.labelMaxGainValue.Text = "0";
            this.labelMaxGainValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMaxLossValue
            // 
            this.labelMaxLossValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.labelMaxLossValue.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxLossValue.Location = new System.Drawing.Point(557, 30);
            this.labelMaxLossValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelMaxLossValue.Name = "labelMaxLossValue";
            this.labelMaxLossValue.Size = new System.Drawing.Size(107, 30);
            this.labelMaxLossValue.TabIndex = 18;
            this.labelMaxLossValue.Text = "0";
            this.labelMaxLossValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderBuyUI1
            // 
            this.orderBuyUI1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderBuyUI1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.orderBuyUI1.Location = new System.Drawing.Point(562, 67);
            this.orderBuyUI1.Margin = new System.Windows.Forms.Padding(0);
            this.orderBuyUI1.Name = "orderBuyUI1";
            this.orderBuyUI1.Size = new System.Drawing.Size(300, 178);
            this.orderBuyUI1.TabIndex = 0;
            // 
            // orderListUI1
            // 
            this.orderListUI1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderListUI1.Location = new System.Drawing.Point(0, 3);
            this.orderListUI1.Name = "orderListUI1";
            this.orderListUI1.Size = new System.Drawing.Size(352, 178);
            this.orderListUI1.TabIndex = 0;
            // 
            // OrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBuy);
            this.Name = "OrderUI";
            this.Size = new System.Drawing.Size(862, 251);
            this.panelBuy.ResumeLayout(false);
            this.panelOrder.ResumeLayout(false);
            this.panelBuyAdjustments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuy;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Panel panelBuyAdjustments;
        private System.Windows.Forms.Label labelClear;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelSwap;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.Button buttonQuantityMore;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonQuantityLess;
        private System.Windows.Forms.Button buttonStrikesDown;
        private System.Windows.Forms.Label labelStrikes;
        private System.Windows.Forms.Button buttonStrikesUp;
        private DataMAN.OrderListUI orderListUI1;
        private OrderBuyUI orderBuyUI1;
        private System.Windows.Forms.Label labelMaxLossValue;
        private System.Windows.Forms.Label labelMaxGainValue;
        private System.Windows.Forms.Label labelMaxLoss;
        private System.Windows.Forms.Label labelMaxProf;
    }
}
