namespace Editor
{
    partial class StringsFileContentListViewControl
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
            if(disposing && (components != null)) {
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
            this.ContentsListView = new System.Windows.Forms.ListView();
            this.EntryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditEntryTextBox = new System.Windows.Forms.TextBox();
            this.CountContentLinesLabel = new System.Windows.Forms.Label();
            this.ContentListViewMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.ContentListViewMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentsListView
            // 
            this.ContentsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EntryColumnHeader});
            this.ContentsListView.ContextMenuStrip = this.ContentListViewMenuStrip;
            this.ContentsListView.FullRowSelect = true;
            this.ContentsListView.GridLines = true;
            this.ContentsListView.HideSelection = false;
            this.ContentsListView.Location = new System.Drawing.Point(2, 0);
            this.ContentsListView.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ContentsListView.Name = "ContentsListView";
            this.ContentsListView.Size = new System.Drawing.Size(356, 426);
            this.ContentsListView.TabIndex = 0;
            this.ContentsListView.UseCompatibleStateImageBehavior = false;
            this.ContentsListView.View = System.Windows.Forms.View.Details;
            this.ContentsListView.VirtualMode = true;
            this.ContentsListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.ListViewContents_RetrieveVirtualItem);
            this.ContentsListView.SelectedIndexChanged += new System.EventHandler(this.ListViewContents_SelectedIndexChanged);
            // 
            // EntryColumnHeader
            // 
            this.EntryColumnHeader.Text = "Content";
            this.EntryColumnHeader.Width = 332;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.EditEntryTextBox);
            this.groupBox1.Location = new System.Drawing.Point(-4, 447);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // EditEntryTextBox
            // 
            this.EditEntryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditEntryTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEntryTextBox.Location = new System.Drawing.Point(6, 19);
            this.EditEntryTextBox.Name = "EditEntryTextBox";
            this.EditEntryTextBox.Size = new System.Drawing.Size(356, 21);
            this.EditEntryTextBox.TabIndex = 0;
            this.EditEntryTextBox.Enter += new System.EventHandler(this.EditEntryTextBox_Enter);
            this.EditEntryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditEntryTextBox_KeyDown);
            this.EditEntryTextBox.Leave += new System.EventHandler(this.EditEntryTextBox_Leave);
            // 
            // CountContentLinesLabel
            // 
            this.CountContentLinesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CountContentLinesLabel.AutoSize = true;
            this.CountContentLinesLabel.Location = new System.Drawing.Point(0, 429);
            this.CountContentLinesLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.CountContentLinesLabel.Name = "CountContentLinesLabel";
            this.CountContentLinesLabel.Size = new System.Drawing.Size(40, 13);
            this.CountContentLinesLabel.TabIndex = 2;
            this.CountContentLinesLabel.Text = "0 items";
            // 
            // ContentListViewMenuStrip
            // 
            this.ContentListViewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveMenuItem});
            this.ContentListViewMenuStrip.Name = "ContentListViewMenuStrip";
            this.ContentListViewMenuStrip.Size = new System.Drawing.Size(142, 26);
            // 
            // RemoveMenuItem
            // 
            this.RemoveMenuItem.Name = "RemoveMenuItem";
            this.RemoveMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.RemoveMenuItem.Size = new System.Drawing.Size(141, 22);
            this.RemoveMenuItem.Text = "Remove";
            this.RemoveMenuItem.Click += new System.EventHandler(this.RemoveMenuItem_Click);
            // 
            // StringsFileContentListViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CountContentLinesLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ContentsListView);
            this.Name = "StringsFileContentListViewControl";
            this.Size = new System.Drawing.Size(360, 500);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ContentListViewMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ContentsListView;
        private System.Windows.Forms.ColumnHeader EntryColumnHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EditEntryTextBox;
        private System.Windows.Forms.Label CountContentLinesLabel;
        private System.Windows.Forms.ContextMenuStrip ContentListViewMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem RemoveMenuItem;
    }
}
