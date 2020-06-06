namespace Editor
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
            this.BaseStationSqbOneFileNameTextBox = new System.Windows.Forms.TextBox();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ApplyFilterButton = new System.Windows.Forms.Button();
            this.NamesAndContentsSplitter = new System.Windows.Forms.SplitContainer();
            this.FilesTabControl = new System.Windows.Forms.TabControl();
            this.NotPrivateRegularExpressionsTabPage = new System.Windows.Forms.TabPage();
            this.NotPrivateNamesTabPage = new System.Windows.Forms.TabPage();
            this.PrivateNamesTabPage = new System.Windows.Forms.TabPage();
            this.BaseStationSqbTwoFileNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AllFromOneRadio = new System.Windows.Forms.RadioButton();
            this.AllNewFromOneRadio = new System.Windows.Forms.RadioButton();
            this.AllNewFromTwoRadio = new System.Windows.Forms.RadioButton();
            this.NotPrivateRegularExpressionsContent = new Editor.StringsFileContentListViewControl();
            this.NotPrivateNamesContent = new Editor.StringsFileContentListViewControl();
            this.PrivateNamesContent = new Editor.StringsFileContentListViewControl();
            this.OperatorNameContextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NamesAndContentsSplitter)).BeginInit();
            this.NamesAndContentsSplitter.Panel1.SuspendLayout();
            this.NamesAndContentsSplitter.Panel2.SuspendLayout();
            this.NamesAndContentsSplitter.SuspendLayout();
            this.FilesTabControl.SuspendLayout();
            this.NotPrivateRegularExpressionsTabPage.SuspendLayout();
            this.NotPrivateNamesTabPage.SuspendLayout();
            this.PrivateNamesTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseStationSqbOneFileNameTextBox
            // 
            this.BaseStationSqbOneFileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseStationSqbOneFileNameTextBox.Location = new System.Drawing.Point(109, 1);
            this.BaseStationSqbOneFileNameTextBox.Name = "BaseStationSqbOneFileNameTextBox";
            this.BaseStationSqbOneFileNameTextBox.Size = new System.Drawing.Size(463, 20);
            this.BaseStationSqbOneFileNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BaseStation.sqb #1:";
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
            this.AircraftListView.Location = new System.Drawing.Point(0, 133);
            this.AircraftListView.Name = "AircraftListView";
            this.AircraftListView.Size = new System.Drawing.Size(575, 360);
            this.AircraftListView.TabIndex = 12;
            this.AircraftListView.UseCompatibleStateImageBehavior = false;
            this.AircraftListView.View = System.Windows.Forms.View.Details;
            this.AircraftListView.VirtualMode = true;
            this.AircraftListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.AircraftListView_RetrieveVirtualItem);
            this.AircraftListView.SearchForVirtualItem += new System.Windows.Forms.SearchForVirtualItemEventHandler(this.AircraftListView_SearchForVirtualItem);
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
            this.LoadPrivateAircraftButton.Location = new System.Drawing.Point(497, 53);
            this.LoadPrivateAircraftButton.Name = "LoadPrivateAircraftButton";
            this.LoadPrivateAircraftButton.Size = new System.Drawing.Size(75, 23);
            this.LoadPrivateAircraftButton.TabIndex = 4;
            this.LoadPrivateAircraftButton.Text = "Load";
            this.LoadPrivateAircraftButton.UseVisualStyleBackColor = true;
            this.LoadPrivateAircraftButton.Click += new System.EventHandler(this.LoadPrivateAircraftButton_Click);
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTextBox.Location = new System.Drawing.Point(109, 84);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(154, 20);
            this.FilterTextBox.TabIndex = 6;
            this.FilterTextBox.Enter += new System.EventHandler(this.FilterTextBox_Enter);
            this.FilterTextBox.Leave += new System.EventHandler(this.FilterTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "&Filter:";
            // 
            // StartsWithRadio
            // 
            this.StartsWithRadio.AutoSize = true;
            this.StartsWithRadio.Checked = true;
            this.StartsWithRadio.Location = new System.Drawing.Point(0, 0);
            this.StartsWithRadio.Name = "StartsWithRadio";
            this.StartsWithRadio.Size = new System.Drawing.Size(74, 17);
            this.StartsWithRadio.TabIndex = 0;
            this.StartsWithRadio.TabStop = true;
            this.StartsWithRadio.Text = "&Starts with";
            this.StartsWithRadio.UseVisualStyleBackColor = true;
            this.StartsWithRadio.Enter += new System.EventHandler(this.FilterRadioButton_Enter);
            this.StartsWithRadio.Leave += new System.EventHandler(this.FilterRadioButton_Leave);
            // 
            // ContainsRadio
            // 
            this.ContainsRadio.AutoSize = true;
            this.ContainsRadio.Location = new System.Drawing.Point(80, 0);
            this.ContainsRadio.Name = "ContainsRadio";
            this.ContainsRadio.Size = new System.Drawing.Size(66, 17);
            this.ContainsRadio.TabIndex = 1;
            this.ContainsRadio.Text = "&Contains";
            this.ContainsRadio.UseVisualStyleBackColor = true;
            this.ContainsRadio.Enter += new System.EventHandler(this.FilterRadioButton_Enter);
            this.ContainsRadio.Leave += new System.EventHandler(this.FilterRadioButton_Leave);
            // 
            // EndsWithRadio
            // 
            this.EndsWithRadio.AutoSize = true;
            this.EndsWithRadio.Location = new System.Drawing.Point(152, 0);
            this.EndsWithRadio.Name = "EndsWithRadio";
            this.EndsWithRadio.Size = new System.Drawing.Size(71, 17);
            this.EndsWithRadio.TabIndex = 2;
            this.EndsWithRadio.Text = "&Ends with";
            this.EndsWithRadio.UseVisualStyleBackColor = true;
            this.EndsWithRadio.Enter += new System.EventHandler(this.FilterRadioButton_Enter);
            this.EndsWithRadio.Leave += new System.EventHandler(this.FilterRadioButton_Leave);
            // 
            // ListViewCountLabel
            // 
            this.ListViewCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ListViewCountLabel.AutoSize = true;
            this.ListViewCountLabel.Location = new System.Drawing.Point(-3, 496);
            this.ListViewCountLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ListViewCountLabel.Name = "ListViewCountLabel";
            this.ListViewCountLabel.Size = new System.Drawing.Size(40, 13);
            this.ListViewCountLabel.TabIndex = 13;
            this.ListViewCountLabel.Text = "0 items";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(878, 533);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CategoryNoneCheckBox
            // 
            this.CategoryNoneCheckBox.AutoSize = true;
            this.CategoryNoneCheckBox.Checked = true;
            this.CategoryNoneCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CategoryNoneCheckBox.Location = new System.Drawing.Point(109, 110);
            this.CategoryNoneCheckBox.Name = "CategoryNoneCheckBox";
            this.CategoryNoneCheckBox.Size = new System.Drawing.Size(52, 17);
            this.CategoryNoneCheckBox.TabIndex = 9;
            this.CategoryNoneCheckBox.Text = "N&one";
            this.CategoryNoneCheckBox.UseVisualStyleBackColor = true;
            this.CategoryNoneCheckBox.CheckedChanged += new System.EventHandler(this.ShowCategory_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categories:";
            // 
            // CategoryNotPrivateCheckBox
            // 
            this.CategoryNotPrivateCheckBox.AutoSize = true;
            this.CategoryNotPrivateCheckBox.Checked = true;
            this.CategoryNotPrivateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CategoryNotPrivateCheckBox.Location = new System.Drawing.Point(167, 110);
            this.CategoryNotPrivateCheckBox.Name = "CategoryNotPrivateCheckBox";
            this.CategoryNotPrivateCheckBox.Size = new System.Drawing.Size(78, 17);
            this.CategoryNotPrivateCheckBox.TabIndex = 10;
            this.CategoryNotPrivateCheckBox.Text = "&Not private";
            this.CategoryNotPrivateCheckBox.UseVisualStyleBackColor = true;
            this.CategoryNotPrivateCheckBox.CheckedChanged += new System.EventHandler(this.ShowCategory_CheckedChanged);
            // 
            // CategoryPrivateCheckBox
            // 
            this.CategoryPrivateCheckBox.AutoSize = true;
            this.CategoryPrivateCheckBox.Checked = true;
            this.CategoryPrivateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CategoryPrivateCheckBox.Location = new System.Drawing.Point(251, 110);
            this.CategoryPrivateCheckBox.Name = "CategoryPrivateCheckBox";
            this.CategoryPrivateCheckBox.Size = new System.Drawing.Size(59, 17);
            this.CategoryPrivateCheckBox.TabIndex = 11;
            this.CategoryPrivateCheckBox.Text = "&Private";
            this.CategoryPrivateCheckBox.UseVisualStyleBackColor = true;
            this.CategoryPrivateCheckBox.CheckedChanged += new System.EventHandler(this.ShowCategory_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BaseStationSqbTwoFileNameTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ApplyFilterButton);
            this.panel1.Controls.Add(this.AircraftListView);
            this.panel1.Controls.Add(this.ListViewCountLabel);
            this.panel1.Controls.Add(this.CategoryPrivateCheckBox);
            this.panel1.Controls.Add(this.CategoryNotPrivateCheckBox);
            this.panel1.Controls.Add(this.LoadPrivateAircraftButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BaseStationSqbOneFileNameTextBox);
            this.panel1.Controls.Add(this.CategoryNoneCheckBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FilterTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 509);
            this.panel1.TabIndex = 0;
            // 
            // ApplyFilterButton
            // 
            this.ApplyFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyFilterButton.Location = new System.Drawing.Point(497, 82);
            this.ApplyFilterButton.Name = "ApplyFilterButton";
            this.ApplyFilterButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyFilterButton.TabIndex = 7;
            this.ApplyFilterButton.Text = "&Apply";
            this.ApplyFilterButton.UseVisualStyleBackColor = true;
            this.ApplyFilterButton.Click += new System.EventHandler(this.ApplyFilterButton_Click);
            // 
            // NamesAndContentsSplitter
            // 
            this.NamesAndContentsSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NamesAndContentsSplitter.Location = new System.Drawing.Point(12, 12);
            this.NamesAndContentsSplitter.Name = "NamesAndContentsSplitter";
            // 
            // NamesAndContentsSplitter.Panel1
            // 
            this.NamesAndContentsSplitter.Panel1.Controls.Add(this.panel1);
            // 
            // NamesAndContentsSplitter.Panel2
            // 
            this.NamesAndContentsSplitter.Panel2.Controls.Add(this.FilesTabControl);
            this.NamesAndContentsSplitter.Size = new System.Drawing.Size(941, 509);
            this.NamesAndContentsSplitter.SplitterDistance = 575;
            this.NamesAndContentsSplitter.TabIndex = 16;
            // 
            // FilesTabControl
            // 
            this.FilesTabControl.Controls.Add(this.NotPrivateRegularExpressionsTabPage);
            this.FilesTabControl.Controls.Add(this.NotPrivateNamesTabPage);
            this.FilesTabControl.Controls.Add(this.PrivateNamesTabPage);
            this.FilesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesTabControl.HotTrack = true;
            this.FilesTabControl.Location = new System.Drawing.Point(0, 0);
            this.FilesTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.FilesTabControl.Name = "FilesTabControl";
            this.FilesTabControl.Padding = new System.Drawing.Point(0, 0);
            this.FilesTabControl.SelectedIndex = 0;
            this.FilesTabControl.Size = new System.Drawing.Size(362, 509);
            this.FilesTabControl.TabIndex = 0;
            // 
            // NotPrivateRegularExpressionsTabPage
            // 
            this.NotPrivateRegularExpressionsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.NotPrivateRegularExpressionsTabPage.Controls.Add(this.NotPrivateRegularExpressionsContent);
            this.NotPrivateRegularExpressionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.NotPrivateRegularExpressionsTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.NotPrivateRegularExpressionsTabPage.Name = "NotPrivateRegularExpressionsTabPage";
            this.NotPrivateRegularExpressionsTabPage.Size = new System.Drawing.Size(354, 483);
            this.NotPrivateRegularExpressionsTabPage.TabIndex = 1;
            this.NotPrivateRegularExpressionsTabPage.Text = "not-private-regular-expressions";
            // 
            // NotPrivateNamesTabPage
            // 
            this.NotPrivateNamesTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.NotPrivateNamesTabPage.Controls.Add(this.NotPrivateNamesContent);
            this.NotPrivateNamesTabPage.Location = new System.Drawing.Point(4, 22);
            this.NotPrivateNamesTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.NotPrivateNamesTabPage.Name = "NotPrivateNamesTabPage";
            this.NotPrivateNamesTabPage.Size = new System.Drawing.Size(341, 483);
            this.NotPrivateNamesTabPage.TabIndex = 2;
            this.NotPrivateNamesTabPage.Text = "not-private-names";
            // 
            // PrivateNamesTabPage
            // 
            this.PrivateNamesTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.PrivateNamesTabPage.Controls.Add(this.PrivateNamesContent);
            this.PrivateNamesTabPage.Location = new System.Drawing.Point(4, 22);
            this.PrivateNamesTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.PrivateNamesTabPage.Name = "PrivateNamesTabPage";
            this.PrivateNamesTabPage.Size = new System.Drawing.Size(341, 483);
            this.PrivateNamesTabPage.TabIndex = 3;
            this.PrivateNamesTabPage.Text = "private-names";
            // 
            // BaseStationSqbTwoFileNameTextBox
            // 
            this.BaseStationSqbTwoFileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseStationSqbTwoFileNameTextBox.Location = new System.Drawing.Point(109, 27);
            this.BaseStationSqbTwoFileNameTextBox.Name = "BaseStationSqbTwoFileNameTextBox";
            this.BaseStationSqbTwoFileNameTextBox.Size = new System.Drawing.Size(463, 20);
            this.BaseStationSqbTwoFileNameTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "BaseStation.sqb #2:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.StartsWithRadio);
            this.panel2.Controls.Add(this.ContainsRadio);
            this.panel2.Controls.Add(this.EndsWithRadio);
            this.panel2.Location = new System.Drawing.Point(269, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 20);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.AllNewFromTwoRadio);
            this.panel3.Controls.Add(this.AllNewFromOneRadio);
            this.panel3.Controls.Add(this.AllFromOneRadio);
            this.panel3.Location = new System.Drawing.Point(109, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 17);
            this.panel3.TabIndex = 19;
            // 
            // AllFromOneRadio
            // 
            this.AllFromOneRadio.AutoSize = true;
            this.AllFromOneRadio.Location = new System.Drawing.Point(0, 0);
            this.AllFromOneRadio.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.AllFromOneRadio.Name = "AllFromOneRadio";
            this.AllFromOneRadio.Size = new System.Drawing.Size(75, 17);
            this.AllFromOneRadio.TabIndex = 0;
            this.AllFromOneRadio.TabStop = true;
            this.AllFromOneRadio.Text = "All from #1";
            this.AllFromOneRadio.UseVisualStyleBackColor = true;
            this.AllFromOneRadio.CheckedChanged += new System.EventHandler(this.LoadAllFromRadios_CheckedChanged);
            // 
            // AllNewFromOneRadio
            // 
            this.AllNewFromOneRadio.AutoSize = true;
            this.AllNewFromOneRadio.Location = new System.Drawing.Point(78, 0);
            this.AllNewFromOneRadio.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.AllNewFromOneRadio.Name = "AllNewFromOneRadio";
            this.AllNewFromOneRadio.Size = new System.Drawing.Size(98, 17);
            this.AllNewFromOneRadio.TabIndex = 1;
            this.AllNewFromOneRadio.TabStop = true;
            this.AllNewFromOneRadio.Text = "All new from #1";
            this.AllNewFromOneRadio.UseVisualStyleBackColor = true;
            this.AllNewFromOneRadio.CheckedChanged += new System.EventHandler(this.LoadAllFromRadios_CheckedChanged);
            // 
            // AllNewFromTwoRadio
            // 
            this.AllNewFromTwoRadio.AutoSize = true;
            this.AllNewFromTwoRadio.Location = new System.Drawing.Point(179, 0);
            this.AllNewFromTwoRadio.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.AllNewFromTwoRadio.Name = "AllNewFromTwoRadio";
            this.AllNewFromTwoRadio.Size = new System.Drawing.Size(98, 17);
            this.AllNewFromTwoRadio.TabIndex = 2;
            this.AllNewFromTwoRadio.TabStop = true;
            this.AllNewFromTwoRadio.Text = "All new from #2";
            this.AllNewFromTwoRadio.UseVisualStyleBackColor = true;
            this.AllNewFromTwoRadio.CheckedChanged += new System.EventHandler(this.LoadAllFromRadios_CheckedChanged);
            // 
            // NotPrivateRegularExpressionsContent
            // 
            this.NotPrivateRegularExpressionsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotPrivateRegularExpressionsContent.Location = new System.Drawing.Point(0, 0);
            this.NotPrivateRegularExpressionsContent.Margin = new System.Windows.Forms.Padding(0);
            this.NotPrivateRegularExpressionsContent.Name = "NotPrivateRegularExpressionsContent";
            this.NotPrivateRegularExpressionsContent.Size = new System.Drawing.Size(354, 483);
            this.NotPrivateRegularExpressionsContent.TabIndex = 0;
            this.NotPrivateRegularExpressionsContent.AppliedEdit += new System.EventHandler(this.FileContentControl_AppliedEdit);
            // 
            // NotPrivateNamesContent
            // 
            this.NotPrivateNamesContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotPrivateNamesContent.Location = new System.Drawing.Point(0, 0);
            this.NotPrivateNamesContent.Margin = new System.Windows.Forms.Padding(0);
            this.NotPrivateNamesContent.Name = "NotPrivateNamesContent";
            this.NotPrivateNamesContent.Size = new System.Drawing.Size(341, 483);
            this.NotPrivateNamesContent.TabIndex = 0;
            this.NotPrivateNamesContent.AppliedEdit += new System.EventHandler(this.FileContentControl_AppliedEdit);
            // 
            // PrivateNamesContent
            // 
            this.PrivateNamesContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrivateNamesContent.Location = new System.Drawing.Point(0, 0);
            this.PrivateNamesContent.Name = "PrivateNamesContent";
            this.PrivateNamesContent.Size = new System.Drawing.Size(341, 483);
            this.PrivateNamesContent.TabIndex = 0;
            this.PrivateNamesContent.AppliedEdit += new System.EventHandler(this.FileContentControl_AppliedEdit);
            // 
            // EditorForm
            // 
            this.AcceptButton = this.LoadPrivateAircraftButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 565);
            this.Controls.Add(this.NamesAndContentsSplitter);
            this.Controls.Add(this.SaveButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "not-private-operators Editor";
            this.OperatorNameContextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.NamesAndContentsSplitter.Panel1.ResumeLayout(false);
            this.NamesAndContentsSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NamesAndContentsSplitter)).EndInit();
            this.NamesAndContentsSplitter.ResumeLayout(false);
            this.FilesTabControl.ResumeLayout(false);
            this.NotPrivateRegularExpressionsTabPage.ResumeLayout(false);
            this.NotPrivateNamesTabPage.ResumeLayout(false);
            this.PrivateNamesTabPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox BaseStationSqbOneFileNameTextBox;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer NamesAndContentsSplitter;
        private System.Windows.Forms.TabControl FilesTabControl;
        private System.Windows.Forms.TabPage NotPrivateRegularExpressionsTabPage;
        private System.Windows.Forms.TabPage NotPrivateNamesTabPage;
        private System.Windows.Forms.TabPage PrivateNamesTabPage;
        private StringsFileContentListViewControl NotPrivateRegularExpressionsContent;
        private StringsFileContentListViewControl NotPrivateNamesContent;
        private StringsFileContentListViewControl PrivateNamesContent;
        private System.Windows.Forms.Button ApplyFilterButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton AllNewFromTwoRadio;
        private System.Windows.Forms.RadioButton AllNewFromOneRadio;
        private System.Windows.Forms.RadioButton AllFromOneRadio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox BaseStationSqbTwoFileNameTextBox;
        private System.Windows.Forms.Label label4;
    }
}

