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
            this.applyButton = new System.Windows.Forms.Button();
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.passwordReLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.uInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.tabPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.pLockPanel.SuspendLayout();
            this.dirPanel.SuspendLayout();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPictureEditBox)).BeginInit();
            this.npPanel.SuspendLayout();
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
            this.searchTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.suggestionsTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suggestionsTab.Location = new System.Drawing.Point(4, 22);
            this.suggestionsTab.Name = "suggestionsTab";
            this.suggestionsTab.Size = new System.Drawing.Size(889, 515);
            this.suggestionsTab.TabIndex = 2;
            this.suggestionsTab.Text = "Suggestions";
            this.suggestionsTab.UseVisualStyleBackColor = true;
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
            this.settingsTab.Size = new System.Drawing.Size(889, 515);
            this.settingsTab.TabIndex = 3;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            this.settingsTab.Enter += new System.EventHandler(this.settingsTab_Enter);
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(233, 148);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(160, 33);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // pLockPanel
            // 
            this.pLockPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLockPanel.Controls.Add(this.pLockBox);
            this.pLockPanel.Controls.Add(this.newProfilebutton);
            this.pLockPanel.Location = new System.Drawing.Point(638, 298);
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
            // 
            // dirPanel
            // 
            this.dirPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dirPanel.Controls.Add(this.addButton);
            this.dirPanel.Controls.Add(this.dirBox);
            this.dirPanel.Controls.Add(this.dirLabel);
            this.dirPanel.Location = new System.Drawing.Point(411, 17);
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
            this.dirBox.Size = new System.Drawing.Size(333, 106);
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
            this.picturePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePanel.Controls.Add(this.pPictureEditBox);
            this.picturePanel.Controls.Add(this.browseButton);
            this.picturePanel.Controls.Add(this.picturePathBox);
            this.picturePanel.Location = new System.Drawing.Point(126, 223);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(455, 219);
            this.picturePanel.TabIndex = 1;
            // 
            // pPictureEditBox
            // 
            this.pPictureEditBox.Location = new System.Drawing.Point(31, 40);
            this.pPictureEditBox.Name = "pPictureEditBox";
            this.pPictureEditBox.Size = new System.Drawing.Size(224, 174);
            this.pPictureEditBox.TabIndex = 2;
            this.pPictureEditBox.TabStop = false;
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(284, -1);
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
            this.picturePathBox.Location = new System.Drawing.Point(3, 3);
            this.picturePathBox.Name = "picturePathBox";
            this.picturePathBox.Size = new System.Drawing.Size(271, 31);
            this.picturePathBox.TabIndex = 0;
            // 
            // npPanel
            // 
            this.npPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.npPanel.Controls.Add(this.applyButton);
            this.npPanel.Controls.Add(this.textBox2);
            this.npPanel.Controls.Add(this.passwordBox);
            this.npPanel.Controls.Add(this.nameBox);
            this.npPanel.Controls.Add(this.passwordReLabel);
            this.npPanel.Controls.Add(this.passwordLabel);
            this.npPanel.Controls.Add(this.nameLabel);
            this.npPanel.Location = new System.Drawing.Point(7, 17);
            this.npPanel.Name = "npPanel";
            this.npPanel.Size = new System.Drawing.Size(398, 200);
            this.npPanel.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(233, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 31);
            this.textBox2.TabIndex = 5;
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(233, 74);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(160, 31);
            this.passwordBox.TabIndex = 4;
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(233, 7);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(160, 31);
            this.nameBox.TabIndex = 3;
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
            // TabScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 611);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.uInfoPanel);
            this.Name = "TabScreen";
            this.Text = "TabScreen";
            this.Resize += new System.EventHandler(this.TabScreen_Resize);
            this.uInfoPanel.ResumeLayout(false);
            this.uInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.tabPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
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
    }
}