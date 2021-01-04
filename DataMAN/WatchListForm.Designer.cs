namespace DataMAN
{
    partial class WatchListForm
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
            this.components = new System.ComponentModel.Container();
            this.listBoxWatchLists = new System.Windows.Forms.ListBox();
            this.listBoxStocks = new System.Windows.Forms.ListBox();
            this.textBoxWatchListName = new System.Windows.Forms.TextBox();
            this.buttonAddNewList = new System.Windows.Forms.Button();
            this.labelStocks = new System.Windows.Forms.Label();
            this.labelWatchLists = new System.Windows.Forms.Label();
            this.buttonAddStock = new System.Windows.Forms.Button();
            this.textBoxStockName = new System.Windows.Forms.TextBox();
            this.contextMenuStripList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripStock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripList.SuspendLayout();
            this.contextMenuStripStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxWatchLists
            // 
            this.listBoxWatchLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listBoxWatchLists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxWatchLists.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWatchLists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxWatchLists.FormattingEnabled = true;
            this.listBoxWatchLists.ItemHeight = 25;
            this.listBoxWatchLists.Location = new System.Drawing.Point(0, 50);
            this.listBoxWatchLists.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxWatchLists.Name = "listBoxWatchLists";
            this.listBoxWatchLists.Size = new System.Drawing.Size(228, 500);
            this.listBoxWatchLists.Sorted = true;
            this.listBoxWatchLists.TabIndex = 5;
            this.listBoxWatchLists.Click += new System.EventHandler(this.listBoxWatchLists_Click);
            this.listBoxWatchLists.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBoxWatchLists_RightClick);
            // 
            // listBoxStocks
            // 
            this.listBoxStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listBoxStocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxStocks.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listBoxStocks.FormattingEnabled = true;
            this.listBoxStocks.ItemHeight = 25;
            this.listBoxStocks.Location = new System.Drawing.Point(228, 50);
            this.listBoxStocks.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxStocks.Name = "listBoxStocks";
            this.listBoxStocks.Size = new System.Drawing.Size(228, 500);
            this.listBoxStocks.Sorted = true;
            this.listBoxStocks.TabIndex = 6;
            this.listBoxStocks.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBoxStocks_RightClick);
            // 
            // textBoxWatchListName
            // 
            this.textBoxWatchListName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.textBoxWatchListName.Location = new System.Drawing.Point(0, 25);
            this.textBoxWatchListName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxWatchListName.Name = "textBoxWatchListName";
            this.textBoxWatchListName.Size = new System.Drawing.Size(152, 25);
            this.textBoxWatchListName.TabIndex = 7;
            // 
            // buttonAddNewList
            // 
            this.buttonAddNewList.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.buttonAddNewList.Location = new System.Drawing.Point(152, 25);
            this.buttonAddNewList.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddNewList.Name = "buttonAddNewList";
            this.buttonAddNewList.Size = new System.Drawing.Size(76, 25);
            this.buttonAddNewList.TabIndex = 8;
            this.buttonAddNewList.Text = "Add New";
            this.buttonAddNewList.UseVisualStyleBackColor = true;
            this.buttonAddNewList.Click += new System.EventHandler(this.buttonAddNewList_Click);
            // 
            // labelStocks
            // 
            this.labelStocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStocks.AutoSize = true;
            this.labelStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelStocks.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.labelStocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelStocks.Location = new System.Drawing.Point(228, 0);
            this.labelStocks.Margin = new System.Windows.Forms.Padding(0);
            this.labelStocks.Name = "labelStocks";
            this.labelStocks.Size = new System.Drawing.Size(231, 25);
            this.labelStocks.TabIndex = 9;
            this.labelStocks.Text = "Stocks                                 ";
            // 
            // labelWatchLists
            // 
            this.labelWatchLists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWatchLists.AutoSize = true;
            this.labelWatchLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelWatchLists.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.labelWatchLists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelWatchLists.Location = new System.Drawing.Point(-3, 0);
            this.labelWatchLists.Margin = new System.Windows.Forms.Padding(0);
            this.labelWatchLists.Name = "labelWatchLists";
            this.labelWatchLists.Size = new System.Drawing.Size(233, 25);
            this.labelWatchLists.TabIndex = 10;
            this.labelWatchLists.Text = "WatchLists                          ";
            // 
            // buttonAddStock
            // 
            this.buttonAddStock.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.buttonAddStock.Location = new System.Drawing.Point(383, 26);
            this.buttonAddStock.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddStock.Name = "buttonAddStock";
            this.buttonAddStock.Size = new System.Drawing.Size(76, 25);
            this.buttonAddStock.TabIndex = 12;
            this.buttonAddStock.Text = "Add New";
            this.buttonAddStock.UseVisualStyleBackColor = true;
            this.buttonAddStock.Click += new System.EventHandler(this.buttonAddStock_Click);
            // 
            // textBoxStockName
            // 
            this.textBoxStockName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.textBoxStockName.Location = new System.Drawing.Point(228, 26);
            this.textBoxStockName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxStockName.Name = "textBoxStockName";
            this.textBoxStockName.Size = new System.Drawing.Size(155, 25);
            this.textBoxStockName.TabIndex = 11;
            // 
            // contextMenuStripList
            // 
            this.contextMenuStripList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStripList.Name = "contextMenuStripRemoveList";
            this.contextMenuStripList.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeListToolStripMenuItem_Click);
            // 
            // contextMenuStripStock
            // 
            this.contextMenuStripStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStripStock.Name = "contextMenuStripRemoveList";
            this.contextMenuStripStock.Size = new System.Drawing.Size(118, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem1.Text = "Remove";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.removeStockToolStripMenuItem_Click);
            // 
            // WatchListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(459, 561);
            this.Controls.Add(this.buttonAddStock);
            this.Controls.Add(this.textBoxStockName);
            this.Controls.Add(this.labelWatchLists);
            this.Controls.Add(this.labelStocks);
            this.Controls.Add(this.buttonAddNewList);
            this.Controls.Add(this.textBoxWatchListName);
            this.Controls.Add(this.listBoxStocks);
            this.Controls.Add(this.listBoxWatchLists);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WatchListForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WatchListForm";
            this.contextMenuStripList.ResumeLayout(false);
            this.contextMenuStripStock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWatchLists;
        private System.Windows.Forms.ListBox listBoxStocks;
        private System.Windows.Forms.TextBox textBoxWatchListName;
        private System.Windows.Forms.Button buttonAddNewList;
        private System.Windows.Forms.Label labelStocks;
        private System.Windows.Forms.Label labelWatchLists;
        private System.Windows.Forms.Button buttonAddStock;
        private System.Windows.Forms.TextBox textBoxStockName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripList;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripStock;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}