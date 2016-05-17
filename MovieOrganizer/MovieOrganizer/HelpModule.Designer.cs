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
            this.Topics.ItemHeight = 16;
            this.Topics.Items.AddRange(new object[] {
            "Searching for a movie",
            "Using advanced search",
            "Making a new account",
            "Playing movies",
            "Add, edit or delete",
            "Editing your profile"});
            this.Topics.Location = new System.Drawing.Point(24, 89);
            this.Topics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Topics.Name = "Topics";
            this.Topics.Size = new System.Drawing.Size(155, 116);
            this.Topics.TabIndex = 0;
            this.Topics.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(206, 89);
            this.Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(247, 263);
            this.Description.TabIndex = 1;
            this.Description.Text = "Select a topic to learn more.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(206, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Topic:";
            // 
            // HelpModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Topics);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HelpModule";
            this.Text = "Help";
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