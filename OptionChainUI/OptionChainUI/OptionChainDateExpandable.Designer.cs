namespace DataMAN
{
    partial class OptionChainDateExpandable
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
            this.panelChain = new System.Windows.Forms.Panel();
            this.panelDateLine = new System.Windows.Forms.Panel();
            this.labelPut = new System.Windows.Forms.Label();
            this.labelCall = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelExpandArrow = new System.Windows.Forms.Label();
            this.labelDaysOut = new System.Windows.Forms.Label();
            this.panelDateLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChain
            // 
            this.panelChain.AutoSize = true;
            this.panelChain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelChain.Location = new System.Drawing.Point(0, 30);
            this.panelChain.Margin = new System.Windows.Forms.Padding(0);
            this.panelChain.Name = "panelChain";
            this.panelChain.Size = new System.Drawing.Size(0, 0);
            this.panelChain.TabIndex = 0;
            this.panelChain.Visible = false;
            // 
            // panelDateLine
            // 
            this.panelDateLine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDateLine.Controls.Add(this.labelPut);
            this.panelDateLine.Controls.Add(this.labelCall);
            this.panelDateLine.Controls.Add(this.labelDate);
            this.panelDateLine.Controls.Add(this.labelExpandArrow);
            this.panelDateLine.Controls.Add(this.labelDaysOut);
            this.panelDateLine.Location = new System.Drawing.Point(0, 0);
            this.panelDateLine.Margin = new System.Windows.Forms.Padding(0);
            this.panelDateLine.Name = "panelDateLine";
            this.panelDateLine.Size = new System.Drawing.Size(920, 30);
            this.panelDateLine.TabIndex = 1;
            // 
            // labelPut
            // 
            this.labelPut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPut.Location = new System.Drawing.Point(512, 0);
            this.labelPut.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPut.Name = "labelPut";
            this.labelPut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPut.Size = new System.Drawing.Size(60, 30);
            this.labelPut.TabIndex = 6;
            this.labelPut.Text = "Put";
            this.labelPut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPut.Visible = false;
            // 
            // labelCall
            // 
            this.labelCall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCall.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCall.Location = new System.Drawing.Point(348, 0);
            this.labelCall.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCall.Name = "labelCall";
            this.labelCall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCall.Size = new System.Drawing.Size(60, 30);
            this.labelCall.TabIndex = 5;
            this.labelCall.Text = "Call";
            this.labelCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCall.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Black;
            this.labelDate.Location = new System.Drawing.Point(43, 0);
            this.labelDate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDate.Size = new System.Drawing.Size(245, 30);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Exp Date.";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelExpandArrow
            // 
            this.labelExpandArrow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelExpandArrow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpandArrow.ForeColor = System.Drawing.Color.Black;
            this.labelExpandArrow.Location = new System.Drawing.Point(1, 0);
            this.labelExpandArrow.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelExpandArrow.Name = "labelExpandArrow";
            this.labelExpandArrow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelExpandArrow.Size = new System.Drawing.Size(40, 30);
            this.labelExpandArrow.TabIndex = 3;
            this.labelExpandArrow.Text = "\\/";
            this.labelExpandArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExpandArrow.Click += new System.EventHandler(this.labelExpandArrow_Click);
            // 
            // labelDaysOut
            // 
            this.labelDaysOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelDaysOut.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaysOut.ForeColor = System.Drawing.Color.Black;
            this.labelDaysOut.Location = new System.Drawing.Point(410, 0);
            this.labelDaysOut.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelDaysOut.Name = "labelDaysOut";
            this.labelDaysOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDaysOut.Size = new System.Drawing.Size(100, 30);
            this.labelDaysOut.TabIndex = 1;
            this.labelDaysOut.Text = "DaysOut";
            this.labelDaysOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OptionChainDateExpandable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.panelDateLine);
            this.Controls.Add(this.panelChain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "OptionChainDateExpandable";
            this.Size = new System.Drawing.Size(920, 30);
            this.panelDateLine.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelChain;
        private System.Windows.Forms.Panel panelDateLine;
        private System.Windows.Forms.Label labelDaysOut;
        private System.Windows.Forms.Label labelPut;
        private System.Windows.Forms.Label labelCall;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelExpandArrow;
    }
}
