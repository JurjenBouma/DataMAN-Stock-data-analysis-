namespace DataMAN
{
    partial class PluginControl
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
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelRightPercent = new System.Windows.Forms.Label();
            this.labelResultRightPercent = new System.Windows.Forms.Label();
            this.labelStockAlpha = new System.Windows.Forms.Label();
            this.labelResultAlpha = new System.Windows.Forms.Label();
            this.numericUpDownPeriod1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPeriod2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownRatioVola = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownRatioVolume = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownPeriodVolume2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPeriodVolume1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRatioVola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRatioVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriodVolume2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriodVolume1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(0, 0);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(100, 20);
            this.textBoxStock.TabIndex = 0;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(100, -3);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // labelRightPercent
            // 
            this.labelRightPercent.AutoSize = true;
            this.labelRightPercent.ForeColor = System.Drawing.SystemColors.Window;
            this.labelRightPercent.Location = new System.Drawing.Point(3, 20);
            this.labelRightPercent.Name = "labelRightPercent";
            this.labelRightPercent.Size = new System.Drawing.Size(52, 13);
            this.labelRightPercent.TabIndex = 2;
            this.labelRightPercent.Text = "% Right : ";
            // 
            // labelResultRightPercent
            // 
            this.labelResultRightPercent.AutoSize = true;
            this.labelResultRightPercent.ForeColor = System.Drawing.SystemColors.Window;
            this.labelResultRightPercent.Location = new System.Drawing.Point(83, 20);
            this.labelResultRightPercent.Name = "labelResultRightPercent";
            this.labelResultRightPercent.Size = new System.Drawing.Size(48, 13);
            this.labelResultRightPercent.TabIndex = 5;
            this.labelResultRightPercent.Text = "% Result";
            // 
            // labelStockAlpha
            // 
            this.labelStockAlpha.AutoSize = true;
            this.labelStockAlpha.ForeColor = System.Drawing.SystemColors.Window;
            this.labelStockAlpha.Location = new System.Drawing.Point(3, 33);
            this.labelStockAlpha.Name = "labelStockAlpha";
            this.labelStockAlpha.Size = new System.Drawing.Size(74, 13);
            this.labelStockAlpha.TabIndex = 6;
            this.labelStockAlpha.Text = "Stock Alpha : ";
            // 
            // labelResultAlpha
            // 
            this.labelResultAlpha.AutoSize = true;
            this.labelResultAlpha.ForeColor = System.Drawing.SystemColors.Window;
            this.labelResultAlpha.Location = new System.Drawing.Point(83, 33);
            this.labelResultAlpha.Name = "labelResultAlpha";
            this.labelResultAlpha.Size = new System.Drawing.Size(34, 13);
            this.labelResultAlpha.TabIndex = 7;
            this.labelResultAlpha.Text = "Alpha";
            // 
            // numericUpDownPeriod1
            // 
            this.numericUpDownPeriod1.Location = new System.Drawing.Point(261, 0);
            this.numericUpDownPeriod1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownPeriod1.Name = "numericUpDownPeriod1";
            this.numericUpDownPeriod1.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownPeriod1.TabIndex = 9;
            // 
            // numericUpDownPeriod2
            // 
            this.numericUpDownPeriod2.Location = new System.Drawing.Point(261, 26);
            this.numericUpDownPeriod2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownPeriod2.Name = "numericUpDownPeriod2";
            this.numericUpDownPeriod2.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownPeriod2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(209, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Period2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(209, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Period1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(209, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ratio";
            // 
            // numericUpDownRatioVola
            // 
            this.numericUpDownRatioVola.DecimalPlaces = 3;
            this.numericUpDownRatioVola.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownRatioVola.Location = new System.Drawing.Point(261, 54);
            this.numericUpDownRatioVola.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRatioVola.Name = "numericUpDownRatioVola";
            this.numericUpDownRatioVola.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownRatioVola.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(352, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ratio";
            // 
            // numericUpDownRatioVolume
            // 
            this.numericUpDownRatioVolume.DecimalPlaces = 3;
            this.numericUpDownRatioVolume.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownRatioVolume.Location = new System.Drawing.Point(404, 54);
            this.numericUpDownRatioVolume.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRatioVolume.Name = "numericUpDownRatioVolume";
            this.numericUpDownRatioVolume.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownRatioVolume.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(352, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Period2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(352, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Period1";
            // 
            // numericUpDownPeriodVolume2
            // 
            this.numericUpDownPeriodVolume2.Location = new System.Drawing.Point(404, 26);
            this.numericUpDownPeriodVolume2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownPeriodVolume2.Name = "numericUpDownPeriodVolume2";
            this.numericUpDownPeriodVolume2.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownPeriodVolume2.TabIndex = 16;
            // 
            // numericUpDownPeriodVolume1
            // 
            this.numericUpDownPeriodVolume1.Location = new System.Drawing.Point(404, 0);
            this.numericUpDownPeriodVolume1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownPeriodVolume1.Name = "numericUpDownPeriodVolume1";
            this.numericUpDownPeriodVolume1.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownPeriodVolume1.TabIndex = 15;
            // 
            // PluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownRatioVolume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownPeriodVolume2);
            this.Controls.Add(this.numericUpDownPeriodVolume1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownRatioVola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownPeriod2);
            this.Controls.Add(this.numericUpDownPeriod1);
            this.Controls.Add(this.labelResultAlpha);
            this.Controls.Add(this.labelStockAlpha);
            this.Controls.Add(this.labelResultRightPercent);
            this.Controls.Add(this.labelRightPercent);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBoxStock);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PluginControl";
            this.Size = new System.Drawing.Size(946, 129);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRatioVola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRatioVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriodVolume2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriodVolume1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelRightPercent;
        private System.Windows.Forms.Label labelResultRightPercent;
        private System.Windows.Forms.Label labelStockAlpha;
        private System.Windows.Forms.Label labelResultAlpha;
        private System.Windows.Forms.NumericUpDown numericUpDownPeriod1;
        private System.Windows.Forms.NumericUpDown numericUpDownPeriod2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownRatioVola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownRatioVolume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownPeriodVolume2;
        private System.Windows.Forms.NumericUpDown numericUpDownPeriodVolume1;
    }
}
