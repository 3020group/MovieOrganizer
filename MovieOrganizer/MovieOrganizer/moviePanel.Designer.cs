namespace MovieOrganizer
{
    partial class moviePanel
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
            this.moviePosterBox = new System.Windows.Forms.PictureBox();
            this.movieTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moviePosterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // moviePosterBox
            // 
            this.moviePosterBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.moviePosterBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.moviePosterBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moviePosterBox.Location = new System.Drawing.Point(10, 10);
            this.moviePosterBox.Name = "moviePosterBox";
            this.moviePosterBox.Size = new System.Drawing.Size(100, 50);
            this.moviePosterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviePosterBox.TabIndex = 0;
            this.moviePosterBox.TabStop = false;
            this.moviePosterBox.Click += new System.EventHandler(this.moviePosterBox_Click);
            this.moviePosterBox.Paint += new System.Windows.Forms.PaintEventHandler(this.moviePosterBox_Paint);
            // 
            // movieTitle
            // 
            this.movieTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.movieTitle.AutoSize = true;
            this.movieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitle.Location = new System.Drawing.Point(0, 84);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(53, 15);
            this.movieTitle.TabIndex = 0;
            this.movieTitle.Text = "<TITLE>";
            this.movieTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moviePanel
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.movieTitle);
            this.Controls.Add(this.moviePosterBox);
            this.Resize += new System.EventHandler(this.moviePanel_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.moviePosterBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox moviePosterBox;
        private System.Windows.Forms.Label movieTitle;
    }
}
