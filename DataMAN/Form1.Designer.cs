namespace DataMAN
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.watchListUI = new DataMAN.WatchListUI();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelVariables = new System.Windows.Forms.Panel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.panelScriptControls = new System.Windows.Forms.Panel();
            this.chartControl = new DataMAN.ChartControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogPlugin = new System.Windows.Forms.OpenFileDialog();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelChart.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelLeft.Controls.Add(this.watchListUI);
            this.panelLeft.Location = new System.Drawing.Point(0, 24);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(216, 705);
            this.panelLeft.TabIndex = 4;
            // 
            // watchListUI
            // 
            this.watchListUI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.watchListUI.Location = new System.Drawing.Point(0, 1);
            this.watchListUI.Name = "watchListUI";
            this.watchListUI.ShowRecent = true;
            this.watchListUI.Size = new System.Drawing.Size(216, 701);
            this.watchListUI.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BackColor = System.Drawing.Color.Red;
            this.panelRight.Controls.Add(this.panelVariables);
            this.panelRight.Controls.Add(this.panelChart);
            this.panelRight.Location = new System.Drawing.Point(216, 24);
            this.panelRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1050, 705);
            this.panelRight.TabIndex = 5;
            // 
            // panelVariables
            // 
            this.panelVariables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVariables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelVariables.Location = new System.Drawing.Point(890, 0);
            this.panelVariables.Margin = new System.Windows.Forms.Padding(0);
            this.panelVariables.Name = "panelVariables";
            this.panelVariables.Size = new System.Drawing.Size(160, 705);
            this.panelVariables.TabIndex = 5;
            // 
            // panelChart
            // 
            this.panelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChart.BackColor = System.Drawing.Color.White;
            this.panelChart.Controls.Add(this.panelScriptControls);
            this.panelChart.Controls.Add(this.chartControl);
            this.panelChart.Location = new System.Drawing.Point(0, 0);
            this.panelChart.Margin = new System.Windows.Forms.Padding(0);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(890, 705);
            this.panelChart.TabIndex = 4;
            // 
            // panelScriptControls
            // 
            this.panelScriptControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelScriptControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panelScriptControls.Location = new System.Drawing.Point(0, 576);
            this.panelScriptControls.Margin = new System.Windows.Forms.Padding(0);
            this.panelScriptControls.Name = "panelScriptControls";
            this.panelScriptControls.Size = new System.Drawing.Size(890, 129);
            this.panelScriptControls.TabIndex = 1;
            // 
            // chartControl
            // 
            this.chartControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl.Location = new System.Drawing.Point(0, 0);
            this.chartControl.Margin = new System.Windows.Forms.Padding(0);
            this.chartControl.Name = "chartControl";
            this.chartControl.Size = new System.Drawing.Size(890, 576);
            this.chartControl.TabIndex = 0;
            this.chartControl.ViewControls = true;
            this.chartControl.ViewIntervalSelector = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 6;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPluginToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadPluginToolStripMenuItem
            // 
            this.loadPluginToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.loadPluginToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.loadPluginToolStripMenuItem.Name = "loadPluginToolStripMenuItem";
            this.loadPluginToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.loadPluginToolStripMenuItem.Text = "Load Plugin";
            this.loadPluginToolStripMenuItem.Click += new System.EventHandler(this.loadPluginToolStripMenuItem_Click);
            // 
            // openFileDialogPlugin
            // 
            this.openFileDialogPlugin.FileName = "openFileDialog1";
            this.openFileDialogPlugin.Filter = "DLL | *.dll";
            this.openFileDialogPlugin.Title = "Load a plugin";
            this.openFileDialogPlugin.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogPlugin_FileOk);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1280, 768);
            this.Name = "FormMain";
            this.Text = "DataMAN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelVariables;
        private System.Windows.Forms.Panel panelChart;
        private ChartControl chartControl;
        private System.Windows.Forms.Panel panelScriptControls;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPluginToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogPlugin;
        private WatchListUI watchListUI;
    }
}

