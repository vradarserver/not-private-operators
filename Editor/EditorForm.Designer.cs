﻿namespace Editor
{
    partial class EditorForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.BaseStationSqbFileNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AircraftListView = new System.Windows.Forms.ListView();
            this.OperatorNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CategoryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CountAircraftColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OperatorNameContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToNotPrivateNamesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToPrivateNamesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveFromNotPrivateNamesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveFromPrivateNamesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadPrivateAircraftButton = new System.Windows.Forms.Button();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartsWithRadio = new System.Windows.Forms.RadioButton();
            this.ContainsRadio = new System.Windows.Forms.RadioButton();
            this.EndsWithRadio = new System.Windows.Forms.RadioButton();
            this.ListViewCountLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CategoryNoneCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryNotPrivateCheckBox = new System.Windows.Forms.CheckBox();
            this.CategoryPrivateCheckBox = new System.Windows.Forms.CheckBox();
            this.OperatorNameContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseStationSqbFileNameTextBox
            // 
            this.BaseStationSqbFileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseStationSqbFileNameTextBox.Location = new System.Drawing.Point(105, 13);
            this.BaseStationSqbFileNameTextBox.Name = "BaseStationSqbFileNameTextBox";
            this.BaseStationSqbFileNameTextBox.Size = new System.Drawing.Size(402, 20);
            this.BaseStationSqbFileNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BaseStation.sqb:";
            // 
            // AircraftListView
            // 
            this.AircraftListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AircraftListView.AutoArrange = false;
            this.AircraftListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OperatorNameColumn,
            this.CategoryColumn,
            this.CountAircraftColumn});
            this.AircraftListView.ContextMenuStrip = this.OperatorNameContextMenu;
            this.AircraftListView.FullRowSelect = true;
            this.AircraftListView.GridLines = true;
            this.AircraftListView.HideSelection = false;
            this.AircraftListView.Location = new System.Drawing.Point(15, 113);
            this.AircraftListView.Name = "AircraftListView";
            this.AircraftListView.Size = new System.Drawing.Size(573, 405);
            this.AircraftListView.TabIndex = 8;
            this.AircraftListView.UseCompatibleStateImageBehavior = false;
            this.AircraftListView.View = System.Windows.Forms.View.Details;
            this.AircraftListView.VirtualMode = true;
            this.AircraftListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.AircraftListView_RetrieveVirtualItem);
            // 
            // OperatorNameColumn
            // 
            this.OperatorNameColumn.Text = "Operator Name";
            this.OperatorNameColumn.Width = 344;
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.Text = "Category";
            this.CategoryColumn.Width = 140;
            // 
            // CountAircraftColumn
            // 
            this.CountAircraftColumn.Text = "Count";
            this.CountAircraftColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OperatorNameContextMenu
            // 
            this.OperatorNameContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToNotPrivateNamesMenuItem,
            this.AddToPrivateNamesMenuItem,
            this.toolStripMenuItem1,
            this.RemoveFromNotPrivateNamesMenuItem,
            this.RemoveFromPrivateNamesMenuItem});
            this.OperatorNameContextMenu.Name = "OperatorNameContextMenu";
            this.OperatorNameContextMenu.Size = new System.Drawing.Size(256, 98);
            // 
            // AddToNotPrivateNamesMenuItem
            // 
            this.AddToNotPrivateNamesMenuItem.Name = "AddToNotPrivateNamesMenuItem";
            this.AddToNotPrivateNamesMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.AddToNotPrivateNamesMenuItem.Size = new System.Drawing.Size(255, 22);
            this.AddToNotPrivateNamesMenuItem.Text = "Add to Not Private Names";
            this.AddToNotPrivateNamesMenuItem.Click += new System.EventHandler(this.AddToNotPrivateNamesMenuItem_Click);
            // 
            // AddToPrivateNamesMenuItem
            // 
            this.AddToPrivateNamesMenuItem.Name = "AddToPrivateNamesMenuItem";
            this.AddToPrivateNamesMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.AddToPrivateNamesMenuItem.Size = new System.Drawing.Size(255, 22);
            this.AddToPrivateNamesMenuItem.Text = "Add to Private Names";
            this.AddToPrivateNamesMenuItem.Click += new System.EventHandler(this.AddToPrivateNamesMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(252, 6);
            // 
            // RemoveFromNotPrivateNamesMenuItem
            // 
            this.RemoveFromNotPrivateNamesMenuItem.Name = "RemoveFromNotPrivateNamesMenuItem";
            this.RemoveFromNotPrivateNamesMenuItem.Size = new System.Drawing.Size(255, 22);
            this.RemoveFromNotPrivateNamesMenuItem.Text = "Remove from Not Private Names";
            this.RemoveFromNotPrivateNamesMenuItem.Click += new System.EventHandler(this.RemoveFromNotPrivateNamesMenuItem_Click);
            // 
            // RemoveFromPrivateNamesMenuItem
            // 
            this.RemoveFromPrivateNamesMenuItem.Name = "RemoveFromPrivateNamesMenuItem";
            this.RemoveFromPrivateNamesMenuItem.Size = new System.Drawing.Size(255, 22);
            this.RemoveFromPrivateNamesMenuItem.Text = "Remove from Private Names";
            this.RemoveFromPrivateNamesMenuItem.Click += new System.EventHandler(this.RemoveFromPrivateNamesMenuItem_Click);
            // 
            // LoadPrivateAircraftButton
            // 
            this.LoadPrivateAircraftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadPrivateAircraftButton.Location = new System.Drawing.Point(513, 12);
            this.LoadPrivateAircraftButton.Name = "LoadPrivateAircraftButton";
            this.LoadPrivateAircraftButton.Size = new System.Drawing.Size(75, 23);
            this.LoadPrivateAircraftButton.TabIndex = 2;
            this.LoadPrivateAircraftButton.Text = "Load";
            this.LoadPrivateAircraftButton.UseVisualStyleBackColor = true;
            this.LoadPrivateAircraftButton.Click += new System.EventHandler(this.LoadPrivateAircraftButton_Click);
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTextBox.Location = new System.Drawing.Point(105, 39);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(251, 20);
            this.FilterTextBox.TabIndex = 4;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter:";
            // 
            // StartsWithRadio
            // 
            this.StartsWithRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartsWithRadio.AutoSize = true;
            this.StartsWithRadio.Checked = true;
            this.StartsWithRadio.Location = new System.Drawing.Point(362, 40);
            this.StartsWithRadio.Name = "StartsWithRadio";
            this.StartsWithRadio.Size = new System.Drawing.Size(74, 17);
            this.StartsWithRadio.TabIndex = 5;
            this.StartsWithRadio.TabStop = true;
            this.StartsWithRadio.Text = "Starts with";
            this.StartsWithRadio.UseVisualStyleBackColor = true;
            this.StartsWithRadio.CheckedChanged += new System.EventHandler(this.FilterRadioButtons_CheckedChanged);
            // 
            // ContainsRadio
            // 
            this.ContainsRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ContainsRadio.AutoSize = true;
            this.ContainsRadio.Location = new System.Drawing.Point(442, 40);
            this.ContainsRadio.Name = "ContainsRadio";
            this.ContainsRadio.Size = new System.Drawing.Size(66, 17);
            this.ContainsRadio.TabIndex = 6;
            this.ContainsRadio.Text = "Contains";
            this.ContainsRadio.UseVisualStyleBackColor = true;
            this.ContainsRadio.CheckedChanged += new System.EventHandler(this.FilterRadioButtons_CheckedChanged);
            // 
            // EndsWithRadio
            // 
            this.EndsWithRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndsWithRadio.AutoSize = true;
            this.EndsWithRadio.Location = new System.Drawing.Point(514, 40);
            this.EndsWithRadio.Name = "EndsWithRadio";
            this.EndsWithRadio.Size = new System.Drawing.Size(71, 17);
            this.EndsWithRadio.TabIndex = 7;
            this.EndsWithRadio.Text = "Ends with";
            this.EndsWithRadio.UseVisualStyleBackColor = true;
            this.EndsWithRadio.CheckedChanged += new System.EventHandler(this.FilterRadioButtons_CheckedChanged);
            // 
            // ListViewCountLabel
            // 
            this.ListViewCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ListViewCountLabel.AutoSize = true;
            this.ListViewCountLabel.Location = new System.Drawing.Point(12, 521);
            this.ListViewCountLabel.Name = "ListViewCountLabel";
            this.ListViewCountLabel.Size = new System.Drawing.Size(40, 13);
            this.ListViewCountLabel.TabIndex = 9;
            this.ListViewCountLabel.Text = "0 items";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(513, 530);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CategoryNoneCheckBox
            // 
            this.CategoryNoneCheckBox.AutoSize = true;
            this.CategoryNoneCheckBox.Checked = true;
            this.CategoryNoneCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CategoryNoneCheckBox.Location = new System.Drawing.Point(105, 66);
            this.CategoryNoneCheckBox.Name = "CategoryNoneCheckBox";
            this.CategoryNoneCheckBox.Size = new System.Drawing.Size(52, 17);
            this.CategoryNoneCheckBox.TabIndex = 11;
            this.CategoryNoneCheckBox.Text = "None";
            this.CategoryNoneCheckBox.UseVisualStyleBackColor = true;
            this.CategoryNoneCheckBox.CheckedChanged += new System.EventHandler(this.ShowCategory_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Categories:";
            // 
            // CategoryNotPrivateCheckBox
            // 
            this.CategoryNotPrivateCheckBox.AutoSize = true;
            this.CategoryNotPrivateCheckBox.Checked = true;
            this.CategoryNotPrivateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CategoryNotPrivateCheckBox.Location = new System.Drawing.Point(163, 66);
            this.CategoryNotPrivateCheckBox.Name = "CategoryNotPrivateCheckBox";
            this.CategoryNotPrivateCheckBox.Size = new System.Drawing.Size(78, 17);
            this.CategoryNotPrivateCheckBox.TabIndex = 13;
            this.CategoryNotPrivateCheckBox.Text = "Not private";
            this.CategoryNotPrivateCheckBox.UseVisualStyleBackColor = true;
            this.CategoryNotPrivateCheckBox.CheckedChanged += new System.EventHandler(this.ShowCategory_CheckedChanged);
            // 
            // CategoryPrivateCheckBox
            // 
            this.CategoryPrivateCheckBox.AutoSize = true;
            this.CategoryPrivateCheckBox.Checked = true;
            this.CategoryPrivateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CategoryPrivateCheckBox.Location = new System.Drawing.Point(247, 66);
            this.CategoryPrivateCheckBox.Name = "CategoryPrivateCheckBox";
            this.CategoryPrivateCheckBox.Size = new System.Drawing.Size(59, 17);
            this.CategoryPrivateCheckBox.TabIndex = 14;
            this.CategoryPrivateCheckBox.Text = "Private";
            this.CategoryPrivateCheckBox.UseVisualStyleBackColor = true;
            this.CategoryPrivateCheckBox.CheckedChanged += new System.EventHandler(this.ShowCategory_CheckedChanged);
            // 
            // EditorForm
            // 
            this.AcceptButton = this.LoadPrivateAircraftButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 565);
            this.Controls.Add(this.CategoryPrivateCheckBox);
            this.Controls.Add(this.CategoryNotPrivateCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CategoryNoneCheckBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ListViewCountLabel);
            this.Controls.Add(this.EndsWithRadio);
            this.Controls.Add(this.ContainsRadio);
            this.Controls.Add(this.StartsWithRadio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.LoadPrivateAircraftButton);
            this.Controls.Add(this.AircraftListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BaseStationSqbFileNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "not-private-operators Editor";
            this.OperatorNameContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BaseStationSqbFileNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView AircraftListView;
        private System.Windows.Forms.ColumnHeader OperatorNameColumn;
        private System.Windows.Forms.Button LoadPrivateAircraftButton;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton StartsWithRadio;
        private System.Windows.Forms.RadioButton ContainsRadio;
        private System.Windows.Forms.RadioButton EndsWithRadio;
        private System.Windows.Forms.Label ListViewCountLabel;
        private System.Windows.Forms.ColumnHeader CountAircraftColumn;
        private System.Windows.Forms.ColumnHeader CategoryColumn;
        private System.Windows.Forms.ContextMenuStrip OperatorNameContextMenu;
        private System.Windows.Forms.ToolStripMenuItem AddToNotPrivateNamesMenuItem;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem RemoveFromNotPrivateNamesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToPrivateNamesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveFromPrivateNamesMenuItem;
        private System.Windows.Forms.CheckBox CategoryNoneCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CategoryNotPrivateCheckBox;
        private System.Windows.Forms.CheckBox CategoryPrivateCheckBox;
    }
}
