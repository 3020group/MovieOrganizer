namespace MovieOrganizer
{
    partial class ProfileSelector
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
            this.ProfilePic = new System.Windows.Forms.PictureBox();
            this.UserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfilePic
            // 
            this.ProfilePic.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfilePic.Location = new System.Drawing.Point(0, 0);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(137, 120);
            this.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePic.TabIndex = 0;
            this.ProfilePic.TabStop = false;
            this.ProfilePic.Click += new System.EventHandler(this.profilePic_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(3, 123);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(46, 17);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "label1";
            // 
            // ProfileSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.ProfilePic);
            this.Name = "ProfileSelector";
            this.Size = new System.Drawing.Size(137, 150);
            this.Load += new System.EventHandler(this.ProfileSelector_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProfileSelector_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProfilePic;
        private System.Windows.Forms.Label UserName;
    }
}
