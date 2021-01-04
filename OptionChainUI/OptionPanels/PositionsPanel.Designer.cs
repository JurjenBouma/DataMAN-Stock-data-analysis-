namespace DataMAN
{
    partial class PositionsPanel
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
            this.positionListUI1 = new DataMAN.PositionListUI();
            this.SuspendLayout();
            // 
            // positionListUI1
            // 
            this.positionListUI1.AutoSize = true;
            this.positionListUI1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.positionListUI1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.positionListUI1.Location = new System.Drawing.Point(3, 3);
            this.positionListUI1.Name = "positionListUI1";
            this.positionListUI1.Size = new System.Drawing.Size(1020, 30);
            this.positionListUI1.TabIndex = 0;
            // 
            // PositionsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.positionListUI1);
            this.Name = "PositionsPanel";
            this.Size = new System.Drawing.Size(1036, 678);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PositionListUI positionListUI1;
    }
}
