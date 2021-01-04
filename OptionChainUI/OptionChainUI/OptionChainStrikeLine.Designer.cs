namespace DataMAN
{
    partial class OptionChainStrikeLine
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
            this.labelStrike = new System.Windows.Forms.Label();
            this.labelVolumeCall = new System.Windows.Forms.Label();
            this.labelAskCall = new System.Windows.Forms.Label();
            this.labelBidCall = new System.Windows.Forms.Label();
            this.labelOpenInterestCall = new System.Windows.Forms.Label();
            this.labelOpenInterestPut = new System.Windows.Forms.Label();
            this.labelBidPut = new System.Windows.Forms.Label();
            this.labelAskPut = new System.Windows.Forms.Label();
            this.labelVolumePut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStrike
            // 
            this.labelStrike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.labelStrike.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrike.ForeColor = System.Drawing.Color.Black;
            this.labelStrike.Location = new System.Drawing.Point(409, 0);
            this.labelStrike.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelStrike.Name = "labelStrike";
            this.labelStrike.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStrike.Size = new System.Drawing.Size(100, 30);
            this.labelStrike.TabIndex = 0;
            this.labelStrike.Text = "0000.00";
            this.labelStrike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVolumeCall
            // 
            this.labelVolumeCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelVolumeCall.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolumeCall.ForeColor = System.Drawing.Color.Black;
            this.labelVolumeCall.Location = new System.Drawing.Point(1, 0);
            this.labelVolumeCall.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelVolumeCall.Name = "labelVolumeCall";
            this.labelVolumeCall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelVolumeCall.Size = new System.Drawing.Size(100, 30);
            this.labelVolumeCall.TabIndex = 1;
            this.labelVolumeCall.Text = "Volm.";
            this.labelVolumeCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVolumeCall.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FireCallDoubleClickEvent);
            this.labelVolumeCall.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FireCallClickEvent);
            this.labelVolumeCall.MouseEnter += new System.EventHandler(this.FireCallEnteredEvent);
            this.labelVolumeCall.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FireCallMouseMoveEvent);
            this.labelVolumeCall.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FireCallMouseUpEvent);
            // 
            // labelAskCall
            // 
            this.labelAskCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAskCall.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAskCall.ForeColor = System.Drawing.Color.Black;
            this.labelAskCall.Location = new System.Drawing.Point(307, 0);
            this.labelAskCall.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAskCall.Name = "labelAskCall";
            this.labelAskCall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAskCall.Size = new System.Drawing.Size(100, 30);
            this.labelAskCall.TabIndex = 2;
            this.labelAskCall.Text = "Ask.";
            this.labelAskCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAskCall.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FireCallDoubleClickEvent);
            this.labelAskCall.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FireCallClickEvent);
            this.labelAskCall.MouseEnter += new System.EventHandler(this.FireCallEnteredEvent);
            this.labelAskCall.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FireCallMouseMoveEvent);
            this.labelAskCall.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FireCallMouseUpEvent);
            // 
            // labelBidCall
            // 
            this.labelBidCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelBidCall.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBidCall.ForeColor = System.Drawing.Color.Black;
            this.labelBidCall.Location = new System.Drawing.Point(205, 0);
            this.labelBidCall.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelBidCall.Name = "labelBidCall";
            this.labelBidCall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBidCall.Size = new System.Drawing.Size(100, 30);
            this.labelBidCall.TabIndex = 3;
            this.labelBidCall.Text = "Bid.";
            this.labelBidCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBidCall.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FireCallDoubleClickEvent);
            this.labelBidCall.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FireCallClickEvent);
            this.labelBidCall.MouseEnter += new System.EventHandler(this.FireCallEnteredEvent);
            this.labelBidCall.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FireCallMouseMoveEvent);
            this.labelBidCall.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FireCallMouseUpEvent);
            // 
            // labelOpenInterestCall
            // 
            this.labelOpenInterestCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelOpenInterestCall.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenInterestCall.ForeColor = System.Drawing.Color.Black;
            this.labelOpenInterestCall.Location = new System.Drawing.Point(103, 0);
            this.labelOpenInterestCall.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelOpenInterestCall.Name = "labelOpenInterestCall";
            this.labelOpenInterestCall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelOpenInterestCall.Size = new System.Drawing.Size(100, 30);
            this.labelOpenInterestCall.TabIndex = 4;
            this.labelOpenInterestCall.Text = "Open Int.";
            this.labelOpenInterestCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOpenInterestCall.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FireCallDoubleClickEvent);
            this.labelOpenInterestCall.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FireCallClickEvent);
            this.labelOpenInterestCall.MouseEnter += new System.EventHandler(this.FireCallEnteredEvent);
            this.labelOpenInterestCall.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FireCallMouseMoveEvent);
            this.labelOpenInterestCall.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FireCallMouseUpEvent);
            // 
            // labelOpenInterestPut
            // 
            this.labelOpenInterestPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelOpenInterestPut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenInterestPut.ForeColor = System.Drawing.Color.Black;
            this.labelOpenInterestPut.Location = new System.Drawing.Point(715, 0);
            this.labelOpenInterestPut.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelOpenInterestPut.Name = "labelOpenInterestPut";
            this.labelOpenInterestPut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelOpenInterestPut.Size = new System.Drawing.Size(100, 30);
            this.labelOpenInterestPut.TabIndex = 9;
            this.labelOpenInterestPut.Text = "Open Int.";
            this.labelOpenInterestPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOpenInterestPut.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FirePutDoubleClickEvent);
            this.labelOpenInterestPut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FirePutClickEvent);
            this.labelOpenInterestPut.MouseEnter += new System.EventHandler(this.FirePutEnteredEvent);
            this.labelOpenInterestPut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FirePutMouseMoveEvent);
            this.labelOpenInterestPut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FirePutMouseUpEvent);
            // 
            // labelBidPut
            // 
            this.labelBidPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelBidPut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBidPut.ForeColor = System.Drawing.Color.Black;
            this.labelBidPut.Location = new System.Drawing.Point(511, 0);
            this.labelBidPut.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelBidPut.Name = "labelBidPut";
            this.labelBidPut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBidPut.Size = new System.Drawing.Size(100, 30);
            this.labelBidPut.TabIndex = 8;
            this.labelBidPut.Text = "Bid.";
            this.labelBidPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBidPut.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FirePutDoubleClickEvent);
            this.labelBidPut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FirePutClickEvent);
            this.labelBidPut.MouseEnter += new System.EventHandler(this.FirePutEnteredEvent);
            this.labelBidPut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FirePutMouseMoveEvent);
            this.labelBidPut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FirePutMouseUpEvent);
            // 
            // labelAskPut
            // 
            this.labelAskPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAskPut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAskPut.ForeColor = System.Drawing.Color.Black;
            this.labelAskPut.Location = new System.Drawing.Point(613, 0);
            this.labelAskPut.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAskPut.Name = "labelAskPut";
            this.labelAskPut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAskPut.Size = new System.Drawing.Size(100, 30);
            this.labelAskPut.TabIndex = 7;
            this.labelAskPut.Text = "Ask.";
            this.labelAskPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAskPut.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FirePutDoubleClickEvent);
            this.labelAskPut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FirePutClickEvent);
            this.labelAskPut.MouseEnter += new System.EventHandler(this.FirePutEnteredEvent);
            this.labelAskPut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FirePutMouseMoveEvent);
            this.labelAskPut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FirePutMouseUpEvent);
            // 
            // labelVolumePut
            // 
            this.labelVolumePut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelVolumePut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolumePut.ForeColor = System.Drawing.Color.Black;
            this.labelVolumePut.Location = new System.Drawing.Point(817, 0);
            this.labelVolumePut.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelVolumePut.Name = "labelVolumePut";
            this.labelVolumePut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelVolumePut.Size = new System.Drawing.Size(100, 30);
            this.labelVolumePut.TabIndex = 6;
            this.labelVolumePut.Text = "Volm.";
            this.labelVolumePut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVolumePut.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FirePutDoubleClickEvent);
            this.labelVolumePut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FirePutClickEvent);
            this.labelVolumePut.MouseEnter += new System.EventHandler(this.FirePutEnteredEvent);
            this.labelVolumePut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FirePutMouseMoveEvent);
            this.labelVolumePut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FirePutMouseUpEvent);
            // 
            // OptionChainStrikeLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.labelOpenInterestPut);
            this.Controls.Add(this.labelBidPut);
            this.Controls.Add(this.labelAskPut);
            this.Controls.Add(this.labelVolumePut);
            this.Controls.Add(this.labelOpenInterestCall);
            this.Controls.Add(this.labelBidCall);
            this.Controls.Add(this.labelAskCall);
            this.Controls.Add(this.labelVolumeCall);
            this.Controls.Add(this.labelStrike);
            this.Name = "OptionChainStrikeLine";
            this.Size = new System.Drawing.Size(920, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelStrike;
        private System.Windows.Forms.Label labelVolumeCall;
        private System.Windows.Forms.Label labelAskCall;
        private System.Windows.Forms.Label labelBidCall;
        private System.Windows.Forms.Label labelOpenInterestCall;
        private System.Windows.Forms.Label labelOpenInterestPut;
        private System.Windows.Forms.Label labelBidPut;
        private System.Windows.Forms.Label labelAskPut;
        private System.Windows.Forms.Label labelVolumePut;
    }
}
