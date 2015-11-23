namespace MovieOrganizer
{
    partial class HelpModule
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
            this.Topics = new System.Windows.Forms.ListBox();
            this.Description = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Topics
            // 
            this.Topics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Topics.FormattingEnabled = true;
            this.Topics.ItemHeight = 20;
            this.Topics.Items.AddRange(new object[] {
            "Searching a Movie",
            "Using Advanced Search",
            "Making a New Account",
            "Signing in to your account",
            "Help"});
            this.Topics.Location = new System.Drawing.Point(32, 109);
            this.Topics.Name = "Topics";
            this.Topics.Size = new System.Drawing.Size(190, 324);
            this.Topics.TabIndex = 0;
            this.Topics.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(275, 109);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(185, 17);
            this.Description.TabIndex = 1;
            this.Description.Text = "Select a topic to learn more.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(274, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Topic:";
            // 
            // HelpModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Topics);
            this.Name = "HelpModule";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.HelpModule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Topics;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}