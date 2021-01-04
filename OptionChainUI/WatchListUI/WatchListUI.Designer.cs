namespace DataMAN
{
    partial class WatchListUI
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
            this.components = new System.ComponentModel.Container();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelRecentList = new System.Windows.Forms.Panel();
            this.labelRecent = new System.Windows.Forms.Label();
            this.listBoxRecent = new System.Windows.Forms.ListBox();
            this.panelWatchList = new System.Windows.Forms.Panel();
            this.labelWatchLists = new System.Windows.Forms.Label();
            this.listBoxWatchList = new System.Windows.Forms.ListBox();
            this.comboBoxWatchLists = new System.Windows.Forms.ComboBox();
            this.contextMenuStripRemoveStock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxStockName = new System.Windows.Forms.ToolStripTextBox();
            this.addToolStripMenuItemAddStock = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripWatchList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxListName = new System.Windows.Forms.ToolStripTextBox();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            this.panelRecentList.SuspendLayout();
            this.panelWatchList.SuspendLayout();
            this.contextMenuStripRemoveStock.SuspendLayout();
            this.contextMenuStripWatchList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelMain.Controls.Add(this.panelRecentList);
            this.panelMain.Controls.Add(this.panelWatchList);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(197, 790);
            this.panelMain.TabIndex = 5;
            // 
            // panelRecentList
            // 
            this.panelRecentList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRecentList.Controls.Add(this.labelRecent);
            this.panelRecentList.Controls.Add(this.listBoxRecent);
            this.panelRecentList.Location = new System.Drawing.Point(1, 0);
            this.panelRecentList.Name = "panelRecentList";
            this.panelRecentList.Size = new System.Drawing.Size(193, 319);
            this.panelRecentList.TabIndex = 6;
            // 
            // labelRecent
            // 
            this.labelRecent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelRecent.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.labelRecent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelRecent.Location = new System.Drawing.Point(0, 0);
            this.labelRecent.Margin = new System.Windows.Forms.Padding(0);
            this.labelRecent.Name = "labelRecent";
            this.labelRecent.Size = new System.Drawing.Size(196, 19);
            this.labelRecent.TabIndex = 2;
            this.labelRecent.Text = "Recent                           ";
            // 
            // listBoxRecent
            // 
            this.listBoxRecent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRecent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listBoxRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxRecent.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRecent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxRecent.FormattingEnabled = true;
            this.listBoxRecent.ItemHeight = 25;
            this.listBoxRecent.Location = new System.Drawing.Point(0, 19);
            this.listBoxRecent.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxRecent.Name = "listBoxRecent";
            this.listBoxRecent.Size = new System.Drawing.Size(193, 300);
            this.listBoxRecent.Sorted = true;
            this.listBoxRecent.TabIndex = 0;
            this.listBoxRecent.Click += new System.EventHandler(this.listBoxRecent_Click);
            // 
            // panelWatchList
            // 
            this.panelWatchList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWatchList.Controls.Add(this.labelWatchLists);
            this.panelWatchList.Controls.Add(this.listBoxWatchList);
            this.panelWatchList.Controls.Add(this.comboBoxWatchLists);
            this.panelWatchList.Location = new System.Drawing.Point(0, 322);
            this.panelWatchList.Name = "panelWatchList";
            this.panelWatchList.Size = new System.Drawing.Size(197, 468);
            this.panelWatchList.TabIndex = 5;
            // 
            // labelWatchLists
            // 
            this.labelWatchLists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWatchLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelWatchLists.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.labelWatchLists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelWatchLists.Location = new System.Drawing.Point(0, 0);
            this.labelWatchLists.Margin = new System.Windows.Forms.Padding(0);
            this.labelWatchLists.Name = "labelWatchLists";
            this.labelWatchLists.Size = new System.Drawing.Size(197, 19);
            this.labelWatchLists.TabIndex = 3;
            this.labelWatchLists.Text = "WatchLists                     ";
            this.labelWatchLists.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelWatchLists_MouseUp);
            // 
            // listBoxWatchList
            // 
            this.listBoxWatchList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxWatchList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listBoxWatchList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxWatchList.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWatchList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxWatchList.FormattingEnabled = true;
            this.listBoxWatchList.ItemHeight = 25;
            this.listBoxWatchList.Location = new System.Drawing.Point(1, 44);
            this.listBoxWatchList.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxWatchList.Name = "listBoxWatchList";
            this.listBoxWatchList.Size = new System.Drawing.Size(194, 425);
            this.listBoxWatchList.Sorted = true;
            this.listBoxWatchList.TabIndex = 4;
            this.listBoxWatchList.Click += new System.EventHandler(this.listBoxWatchList_Click);
            this.listBoxWatchList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBoxWatchList_MouseUp);
            // 
            // comboBoxWatchLists
            // 
            this.comboBoxWatchLists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxWatchLists.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.comboBoxWatchLists.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxWatchLists.FormattingEnabled = true;
            this.comboBoxWatchLists.Location = new System.Drawing.Point(1, 19);
            this.comboBoxWatchLists.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxWatchLists.Name = "comboBoxWatchLists";
            this.comboBoxWatchLists.Size = new System.Drawing.Size(196, 25);
            this.comboBoxWatchLists.TabIndex = 1;
            this.comboBoxWatchLists.SelectedIndexChanged += new System.EventHandler(this.comboBoxWatchLists_SelectedIndexChanged);
            // 
            // contextMenuStripRemoveStock
            // 
            this.contextMenuStripRemoveStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStripRemoveStock.Name = "contextMenuStripRemoveStock";
            this.contextMenuStripRemoveStock.Size = new System.Drawing.Size(118, 48);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxStockName,
            this.addToolStripMenuItemAddStock});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // toolStripTextBoxStockName
            // 
            this.toolStripTextBoxStockName.Name = "toolStripTextBoxStockName";
            this.toolStripTextBoxStockName.Size = new System.Drawing.Size(100, 23);
            // 
            // addToolStripMenuItemAddStock
            // 
            this.addToolStripMenuItemAddStock.Name = "addToolStripMenuItemAddStock";
            this.addToolStripMenuItemAddStock.Size = new System.Drawing.Size(160, 22);
            this.addToolStripMenuItemAddStock.Text = "Add";
            this.addToolStripMenuItemAddStock.Click += new System.EventHandler(this.addToolStripMenuItemAddStock_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // contextMenuStripWatchList
            // 
            this.contextMenuStripWatchList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem1});
            this.contextMenuStripWatchList.Name = "contextMenuStripWatchList";
            this.contextMenuStripWatchList.Size = new System.Drawing.Size(118, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxListName,
            this.addToolStripMenuItem1});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "New";
            // 
            // toolStripTextBoxListName
            // 
            this.toolStripTextBoxListName.Name = "toolStripTextBoxListName";
            this.toolStripTextBoxListName.Size = new System.Drawing.Size(100, 23);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
            // 
            // WatchListUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "WatchListUI";
            this.Size = new System.Drawing.Size(197, 790);
            this.panelMain.ResumeLayout(false);
            this.panelRecentList.ResumeLayout(false);
            this.panelWatchList.ResumeLayout(false);
            this.contextMenuStripRemoveStock.ResumeLayout(false);
            this.contextMenuStripWatchList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ListBox listBoxWatchList;
        private System.Windows.Forms.Label labelWatchLists;
        private System.Windows.Forms.Label labelRecent;
        private System.Windows.Forms.ComboBox comboBoxWatchLists;
        private System.Windows.Forms.ListBox listBoxRecent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRemoveStock;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripWatchList;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxListName;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.Panel panelRecentList;
        private System.Windows.Forms.Panel panelWatchList;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxStockName;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItemAddStock;
    }
}
