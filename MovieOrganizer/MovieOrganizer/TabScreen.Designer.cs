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
            this.uInfoPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.tabPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.collectionTab = new System.Windows.Forms.TabPage();
            this.suggestionsTab = new System.Windows.Forms.TabPage();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.uInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.tabPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
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
            this.tabPanel.Size = new System.Drawing.Size(897, 541);
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
            this.tabControl.Size = new System.Drawing.Size(897, 541);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // searchTab
            // 
            this.searchTab.Location = new System.Drawing.Point(4, 22);
            this.searchTab.Name = "searchTab";
            this.searchTab.Size = new System.Drawing.Size(889, 515);
            this.searchTab.TabIndex = 0;
            this.searchTab.Text = "Search";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // collectionTab
            // 
            this.collectionTab.AllowDrop = true;
            this.collectionTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.collectionTab.Location = new System.Drawing.Point(4, 22);
            this.collectionTab.Name = "collectionTab";
            this.collectionTab.Size = new System.Drawing.Size(889, 515);
            this.collectionTab.TabIndex = 1;
            this.collectionTab.Text = "Collection";
            this.collectionTab.UseVisualStyleBackColor = true;
            // 
            // suggestionsTab
            // 
            this.suggestionsTab.Location = new System.Drawing.Point(4, 22);
            this.suggestionsTab.Name = "suggestionsTab";
            this.suggestionsTab.Size = new System.Drawing.Size(889, 515);
            this.suggestionsTab.TabIndex = 2;
            this.suggestionsTab.Text = "Suggestions";
            this.suggestionsTab.UseVisualStyleBackColor = true;
            // 
            // settingsTab
            // 
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(889, 515);
            this.settingsTab.TabIndex = 3;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // TabScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 611);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.uInfoPanel);
            this.Name = "TabScreen";
            this.Text = "TabScreen";
            this.uInfoPanel.ResumeLayout(false);
            this.uInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.tabPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
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
    }
}