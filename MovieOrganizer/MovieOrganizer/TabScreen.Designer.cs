using System;

namespace MovieOrganizer
{
    partial class TabScreen
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
            this.uInfoPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.tabPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.resultsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchNumPages = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchPageCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ssPanel = new System.Windows.Forms.Panel();
            this.containsRadio = new System.Windows.Forms.RadioButton();
            this.exactRadio = new System.Windows.Forms.RadioButton();
            this.advancedSearchLink = new System.Windows.Forms.LinkLabel();
            this.searchButton = new System.Windows.Forms.Button();
            this.collectionTab = new System.Windows.Forms.TabPage();
            this.collectionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.collectionFilterPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numPages = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pageCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ownedCheckBox = new System.Windows.Forms.CheckBox();
            this.watchedCkeckBox = new System.Windows.Forms.CheckBox();
            this.showLabel = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.sortByLabel = new System.Windows.Forms.Label();
            this.suggestionsTab = new System.Windows.Forms.TabPage();
            this.suggestFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.pLockPanel = new System.Windows.Forms.Panel();
            this.pLockBox = new System.Windows.Forms.CheckBox();
            this.newProfilebutton = new System.Windows.Forms.Button();
            this.dirPanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.dirBox = new System.Windows.Forms.TextBox();
            this.dirLabel = new System.Windows.Forms.Label();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.pPictureEditBox = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.picturePathBox = new System.Windows.Forms.TextBox();
            this.npPanel = new System.Windows.Forms.Panel();
            this.applyButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.passwordReLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBoxErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.uInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.tabPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ssPanel.SuspendLayout();
            this.collectionTab.SuspendLayout();
            this.collectionFilterPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.suggestionsTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.pLockPanel.SuspendLayout();
            this.dirPanel.SuspendLayout();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPictureEditBox)).BeginInit();
            this.npPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameBoxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // uInfoPanel
            // 
            this.uInfoPanel.Controls.Add(this.logoPictureBox);
            this.uInfoPanel.Controls.Add(this.usernameLabel);
            this.uInfoPanel.Controls.Add(this.profilePictureBox);
            this.uInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.uInfoPanel.Name = "uInfoPanel";
            this.uInfoPanel.Size = new System.Drawing.Size(897, 70);
            this.uInfoPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPictureBox.Location = new System.Drawing.Point(706, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(188, 64);
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(82, 32);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(80, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "<USERNAME>";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePictureBox.Location = new System.Drawing.Point(3, 3);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(73, 64);
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.tabControl);
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel.Location = new System.Drawing.Point(0, 70);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(897, 526);
            this.tabPanel.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.searchTab);
            this.tabControl.Controls.Add(this.collectionTab);
            this.tabControl.Controls.Add(this.suggestionsTab);
            this.tabControl.Controls.Add(this.settingsTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(897, 526);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // searchTab
            // 
            this.searchTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTab.Controls.Add(this.resultsPanel);
            this.searchTab.Controls.Add(this.panel1);
            this.searchTab.Location = new System.Drawing.Point(4, 22);
            this.searchTab.Name = "searchTab";
            this.searchTab.Size = new System.Drawing.Size(889, 500);
            this.searchTab.TabIndex = 0;
            this.searchTab.Text = "Search";
            this.searchTab.UseVisualStyleBackColor = true;
            this.searchTab.Enter += new System.EventHandler(this.searchTab_Enter);
            // 
            // resultsPanel
            // 
            this.resultsPanel.AutoScroll = true;
            this.resultsPanel.BackColor = System.Drawing.Color.Gray;
            this.resultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsPanel.Location = new System.Drawing.Point(0, 100);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(887, 398);
            this.resultsPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.ssPanel);
            this.panel1.Controls.Add(this.advancedSearchLink);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 100);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alphabetical",
            "Rating",
            "Year"});
            this.comboBox1.Location = new System.Drawing.Point(499, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sort by:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.searchNumPages);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.searchPageCombo);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(412, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 48);
            this.panel3.TabIndex = 7;
            // 
            // searchNumPages
            // 
            this.searchNumPages.AutoSize = true;
            this.searchNumPages.Location = new System.Drawing.Point(131, 13);
            this.searchNumPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchNumPages.Name = "searchNumPages";
            this.searchNumPages.Size = new System.Drawing.Size(13, 13);
            this.searchNumPages.TabIndex = 3;
            this.searchNumPages.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "out of";
            // 
            // searchPageCombo
            // 
            this.searchPageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchPageCombo.FormattingEnabled = true;
            this.searchPageCombo.Location = new System.Drawing.Point(31, 11);
            this.searchPageCombo.Margin = new System.Windows.Forms.Padding(2);
            this.searchPageCombo.Name = "searchPageCombo";
            this.searchPageCombo.Size = new System.Drawing.Size(58, 21);
            this.searchPageCombo.TabIndex = 1;
            this.searchPageCombo.SelectedIndexChanged += new System.EventHandler(this.searchPageCombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Page";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 29);
            this.textBox1.TabIndex = 1;
            // 
            // ssPanel
            // 
            this.ssPanel.Controls.Add(this.containsRadio);
            this.ssPanel.Controls.Add(this.exactRadio);
            this.ssPanel.Location = new System.Drawing.Point(8, 43);
            this.ssPanel.Name = "ssPanel";
            this.ssPanel.Size = new System.Drawing.Size(92, 54);
            this.ssPanel.TabIndex = 3;
            // 
            // containsRadio
            // 
            this.containsRadio.AutoSize = true;
            this.containsRadio.Location = new System.Drawing.Point(3, 26);
            this.containsRadio.Name = "containsRadio";
            this.containsRadio.Size = new System.Drawing.Size(66, 17);
            this.containsRadio.TabIndex = 1;
            this.containsRadio.TabStop = true;
            this.containsRadio.Text = "Contains";
            this.containsRadio.UseVisualStyleBackColor = true;
            this.containsRadio.CheckedChanged += new System.EventHandler(this.containsRadio_CheckedChanged);
            // 
            // exactRadio
            // 
            this.exactRadio.AutoSize = true;
            this.exactRadio.Checked = true;
            this.exactRadio.Location = new System.Drawing.Point(3, 3);
            this.exactRadio.Name = "exactRadio";
            this.exactRadio.Size = new System.Drawing.Size(52, 17);
            this.exactRadio.TabIndex = 0;
            this.exactRadio.TabStop = true;
            this.exactRadio.Text = "Exact";
            this.exactRadio.UseVisualStyleBackColor = true;
            this.exactRadio.CheckedChanged += new System.EventHandler(this.exactRadio_CheckedChanged);
            // 
            // advancedSearchLink
            // 
            this.advancedSearchLink.AutoSize = true;
            this.advancedSearchLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advancedSearchLink.Location = new System.Drawing.Point(106, 46);
            this.advancedSearchLink.Name = "advancedSearchLink";
            this.advancedSearchLink.Size = new System.Drawing.Size(182, 25);
            this.advancedSearchLink.TabIndex = 4;
            this.advancedSearchLink.TabStop = true;
            this.advancedSearchLink.Text = "Advanced Search";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(279, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(95, 29);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // collectionTab
            // 
            this.collectionTab.AllowDrop = true;
            this.collectionTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.collectionTab.Controls.Add(this.collectionPanel);
            this.collectionTab.Controls.Add(this.collectionFilterPanel);
            this.collectionTab.Location = new System.Drawing.Point(4, 22);
            this.collectionTab.Name = "collectionTab";
            this.collectionTab.Size = new System.Drawing.Size(889, 500);
            this.collectionTab.TabIndex = 1;
            this.collectionTab.Text = "Collection";
            this.collectionTab.UseVisualStyleBackColor = true;
            this.collectionTab.Enter += new System.EventHandler(this.collectionTab_Enter);
            // 
            // collectionPanel
            // 
            this.collectionPanel.AutoScroll = true;
            this.collectionPanel.BackColor = System.Drawing.Color.Gray;
            this.collectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectionPanel.Location = new System.Drawing.Point(0, 86);
            this.collectionPanel.Name = "collectionPanel";
            this.collectionPanel.Size = new System.Drawing.Size(887, 412);
            this.collectionPanel.TabIndex = 0;
            // 
            // collectionFilterPanel
            // 
            this.collectionFilterPanel.Controls.Add(this.panel2);
            this.collectionFilterPanel.Controls.Add(this.ownedCheckBox);
            this.collectionFilterPanel.Controls.Add(this.watchedCkeckBox);
            this.collectionFilterPanel.Controls.Add(this.showLabel);
            this.collectionFilterPanel.Controls.Add(this.sortComboBox);
            this.collectionFilterPanel.Controls.Add(this.sortByLabel);
            this.collectionFilterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.collectionFilterPanel.Location = new System.Drawing.Point(0, 0);
            this.collectionFilterPanel.Name = "collectionFilterPanel";
            this.collectionFilterPanel.Size = new System.Drawing.Size(887, 86);
            this.collectionFilterPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numPages);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pageCombo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(489, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 46);
            this.panel2.TabIndex = 6;
            // 
            // numPages
            // 
            this.numPages.AutoSize = true;
            this.numPages.Location = new System.Drawing.Point(131, 13);
            this.numPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numPages.Name = "numPages";
            this.numPages.Size = new System.Drawing.Size(13, 13);
            this.numPages.TabIndex = 3;
            this.numPages.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "out of";
            // 
            // pageCombo
            // 
            this.pageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pageCombo.FormattingEnabled = true;
            this.pageCombo.Location = new System.Drawing.Point(31, 11);
            this.pageCombo.Margin = new System.Windows.Forms.Padding(2);
            this.pageCombo.Name = "pageCombo";
            this.pageCombo.Size = new System.Drawing.Size(58, 21);
            this.pageCombo.TabIndex = 1;
            this.pageCombo.SelectedIndexChanged += new System.EventHandler(this.pageCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Page";
            // 
            // ownedCheckBox
            // 
            this.ownedCheckBox.AutoSize = true;
            this.ownedCheckBox.Checked = true;
            this.ownedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ownedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownedCheckBox.Location = new System.Drawing.Point(373, 50);
            this.ownedCheckBox.Name = "ownedCheckBox";
            this.ownedCheckBox.Size = new System.Drawing.Size(69, 20);
            this.ownedCheckBox.TabIndex = 4;
            this.ownedCheckBox.Text = "Owned";
            this.ownedCheckBox.UseVisualStyleBackColor = true;
            this.ownedCheckBox.CheckedChanged += new System.EventHandler(this.ownedCheckBox_CheckedChanged);
            // 
            // watchedCkeckBox
            // 
            this.watchedCkeckBox.AutoSize = true;
            this.watchedCkeckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchedCkeckBox.Location = new System.Drawing.Point(373, 24);
            this.watchedCkeckBox.Name = "watchedCkeckBox";
            this.watchedCkeckBox.Size = new System.Drawing.Size(81, 20);
            this.watchedCkeckBox.TabIndex = 3;
            this.watchedCkeckBox.Text = "Watched";
            this.watchedCkeckBox.UseVisualStyleBackColor = true;
            this.watchedCkeckBox.CheckedChanged += new System.EventHandler(this.watchedCkeckBox_CheckedChanged);
            // 
            // showLabel
            // 
            this.showLabel.AutoSize = true;
            this.showLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLabel.Location = new System.Drawing.Point(296, 19);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(71, 25);
            this.showLabel.TabIndex = 2;
            this.showLabel.Text = "Show:";
            // 
            // sortComboBox
            // 
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Alphabetical",
            "Rating",
            "Year"});
            this.sortComboBox.Location = new System.Drawing.Point(94, 23);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(121, 21);
            this.sortComboBox.TabIndex = 1;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // sortByLabel
            // 
            this.sortByLabel.AutoSize = true;
            this.sortByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByLabel.Location = new System.Drawing.Point(2, 19);
            this.sortByLabel.Name = "sortByLabel";
            this.sortByLabel.Size = new System.Drawing.Size(86, 25);
            this.sortByLabel.TabIndex = 0;
            this.sortByLabel.Text = "Sort by:";
            // 
            // suggestionsTab
            // 
            this.suggestionsTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suggestionsTab.Controls.Add(this.suggestFlow);
            this.suggestionsTab.Location = new System.Drawing.Point(4, 22);
            this.suggestionsTab.Name = "suggestionsTab";
            this.suggestionsTab.Size = new System.Drawing.Size(889, 500);
            this.suggestionsTab.TabIndex = 2;
            this.suggestionsTab.Text = "Suggestions";
            this.suggestionsTab.UseVisualStyleBackColor = true;
            this.suggestionsTab.Enter += new System.EventHandler(this.suggestionsTab_Enter);
            // 
            // suggestFlow
            // 
            this.suggestFlow.AutoScroll = true;
            this.suggestFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suggestFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.suggestFlow.Location = new System.Drawing.Point(0, 0);
            this.suggestFlow.Name = "suggestFlow";
            this.suggestFlow.Padding = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.suggestFlow.Size = new System.Drawing.Size(887, 498);
            this.suggestFlow.TabIndex = 0;
            this.suggestFlow.WrapContents = false;
            // 
            // settingsTab
            // 
            this.settingsTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsTab.Controls.Add(this.pLockPanel);
            this.settingsTab.Controls.Add(this.dirPanel);
            this.settingsTab.Controls.Add(this.picturePanel);
            this.settingsTab.Controls.Add(this.npPanel);
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(889, 500);
            this.settingsTab.TabIndex = 3;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            this.settingsTab.Enter += new System.EventHandler(this.settingsTab_Enter);
            // 
            // pLockPanel
            // 
            this.pLockPanel.Controls.Add(this.pLockBox);
            this.pLockPanel.Controls.Add(this.newProfilebutton);
            this.pLockPanel.Location = new System.Drawing.Point(509, 328);
            this.pLockPanel.Name = "pLockPanel";
            this.pLockPanel.Size = new System.Drawing.Size(200, 64);
            this.pLockPanel.TabIndex = 3;
            // 
            // pLockBox
            // 
            this.pLockBox.AutoSize = true;
            this.pLockBox.Location = new System.Drawing.Point(2, 42);
            this.pLockBox.Name = "pLockBox";
            this.pLockBox.Size = new System.Drawing.Size(193, 17);
            this.pLockBox.TabIndex = 1;
            this.pLockBox.Text = "Allow anyone to make a new profile";
            this.pLockBox.UseVisualStyleBackColor = true;
            this.pLockBox.CheckedChanged += new System.EventHandler(this.pLockBox_CheckedChanged);
            // 
            // newProfilebutton
            // 
            this.newProfilebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProfilebutton.Location = new System.Drawing.Point(3, 3);
            this.newProfilebutton.Name = "newProfilebutton";
            this.newProfilebutton.Size = new System.Drawing.Size(165, 34);
            this.newProfilebutton.TabIndex = 0;
            this.newProfilebutton.Text = "New Profile";
            this.newProfilebutton.UseVisualStyleBackColor = true;
            this.newProfilebutton.Click += new System.EventHandler(this.newProfilebutton_Click);
            // 
            // dirPanel
            // 
            this.dirPanel.Controls.Add(this.addButton);
            this.dirPanel.Controls.Add(this.dirBox);
            this.dirPanel.Controls.Add(this.dirLabel);
            this.dirPanel.Location = new System.Drawing.Point(7, 255);
            this.dirPanel.Name = "dirPanel";
            this.dirPanel.Size = new System.Drawing.Size(454, 200);
            this.dirPanel.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(5, 153);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(92, 28);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dirBox
            // 
            this.dirBox.Location = new System.Drawing.Point(5, 30);
            this.dirBox.Multiline = true;
            this.dirBox.Name = "dirBox";
            this.dirBox.Size = new System.Drawing.Size(392, 106);
            this.dirBox.TabIndex = 1;
            // 
            // dirLabel
            // 
            this.dirLabel.AutoSize = true;
            this.dirLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirLabel.Location = new System.Drawing.Point(0, 0);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(169, 25);
            this.dirLabel.TabIndex = 0;
            this.dirLabel.Text = "Movie Locations";
            this.dirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picturePanel
            // 
            this.picturePanel.Controls.Add(this.pPictureEditBox);
            this.picturePanel.Controls.Add(this.browseButton);
            this.picturePanel.Controls.Add(this.picturePathBox);
            this.picturePanel.Location = new System.Drawing.Point(480, 17);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(409, 219);
            this.picturePanel.TabIndex = 1;
            // 
            // pPictureEditBox
            // 
            this.pPictureEditBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPictureEditBox.Location = new System.Drawing.Point(3, 40);
            this.pPictureEditBox.Name = "pPictureEditBox";
            this.pPictureEditBox.Size = new System.Drawing.Size(195, 159);
            this.pPictureEditBox.TabIndex = 2;
            this.pPictureEditBox.TabStop = false;
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(280, 7);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(98, 31);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // picturePathBox
            // 
            this.picturePathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picturePathBox.Location = new System.Drawing.Point(3, 4);
            this.picturePathBox.Name = "picturePathBox";
            this.picturePathBox.Size = new System.Drawing.Size(271, 31);
            this.picturePathBox.TabIndex = 0;
            // 
            // npPanel
            // 
            this.npPanel.Controls.Add(this.applyButton);
            this.npPanel.Controls.Add(this.textBox2);
            this.npPanel.Controls.Add(this.passwordBox);
            this.npPanel.Controls.Add(this.nameBox);
            this.npPanel.Controls.Add(this.passwordReLabel);
            this.npPanel.Controls.Add(this.passwordLabel);
            this.npPanel.Controls.Add(this.nameLabel);
            this.npPanel.Location = new System.Drawing.Point(7, 17);
            this.npPanel.Name = "npPanel";
            this.npPanel.Padding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.npPanel.Size = new System.Drawing.Size(398, 219);
            this.npPanel.TabIndex = 0;
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(222, 166);
            this.applyButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(160, 33);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(222, 111);
            this.textBox2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 31);
            this.textBox2.TabIndex = 5;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            this.textBox2.Validated += new System.EventHandler(this.textBox2_Validated);
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(222, 74);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(160, 31);
            this.passwordBox.TabIndex = 4;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            this.passwordBox.Validating += new System.ComponentModel.CancelEventHandler(this.passwordBox_Validating);
            this.passwordBox.Validated += new System.EventHandler(this.passwordBox_Validated);
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(222, 7);
            this.nameBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(160, 31);
            this.nameBox.TabIndex = 3;
            this.nameBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameBox_Validating);
            this.nameBox.Validated += new System.EventHandler(this.nameBox_Validated);
            // 
            // passwordReLabel
            // 
            this.passwordReLabel.AutoSize = true;
            this.passwordReLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordReLabel.Location = new System.Drawing.Point(3, 111);
            this.passwordReLabel.Name = "passwordReLabel";
            this.passwordReLabel.Size = new System.Drawing.Size(207, 25);
            this.passwordReLabel.TabIndex = 2;
            this.passwordReLabel.Text = "Password (re-enter):";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(49, 74);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(160, 25);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "New Password:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(135, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // nameBoxErrorProvider
            // 
            this.nameBoxErrorProvider.ContainerControl = this;
            // 
            // TabScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 596);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.uInfoPanel);
            this.DoubleBuffered = true;
            this.Name = "TabScreen";
            this.Text = "TabScreen";
            this.Resize += new System.EventHandler(this.TabScreen_Resize);
            this.uInfoPanel.ResumeLayout(false);
            this.uInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.tabPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.searchTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ssPanel.ResumeLayout(false);
            this.ssPanel.PerformLayout();
            this.collectionTab.ResumeLayout(false);
            this.collectionFilterPanel.ResumeLayout(false);
            this.collectionFilterPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.suggestionsTab.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.pLockPanel.ResumeLayout(false);
            this.pLockPanel.PerformLayout();
            this.dirPanel.ResumeLayout(false);
            this.dirPanel.PerformLayout();
            this.picturePanel.ResumeLayout(false);
            this.picturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPictureEditBox)).EndInit();
            this.npPanel.ResumeLayout(false);
            this.npPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameBoxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uInfoPanel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel tabPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.TabPage collectionTab;
        private System.Windows.Forms.TabPage suggestionsTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Panel npPanel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label passwordReLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.PictureBox pPictureEditBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox picturePathBox;
        private System.Windows.Forms.Panel dirPanel;
        private System.Windows.Forms.Label dirLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox dirBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Panel pLockPanel;
        private System.Windows.Forms.CheckBox pLockBox;
        private System.Windows.Forms.Button newProfilebutton;
        private System.Windows.Forms.LinkLabel advancedSearchLink;
        private System.Windows.Forms.Panel ssPanel;
        private System.Windows.Forms.RadioButton containsRadio;
        private System.Windows.Forms.RadioButton exactRadio;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel resultsPanel;
        private System.Windows.Forms.FlowLayoutPanel collectionPanel;
        private System.Windows.Forms.Panel collectionFilterPanel;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Label sortByLabel;
        private System.Windows.Forms.CheckBox ownedCheckBox;
        private System.Windows.Forms.CheckBox watchedCkeckBox;
        private System.Windows.Forms.Label showLabel;
        private System.Windows.Forms.FlowLayoutPanel suggestFlow;
        private System.Windows.Forms.ErrorProvider nameBoxErrorProvider;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label numPages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pageCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label searchNumPages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox searchPageCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}