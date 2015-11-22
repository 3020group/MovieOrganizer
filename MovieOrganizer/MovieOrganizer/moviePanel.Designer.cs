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
            this.moviePosterBox.Location = new System.Drawing.Point(10, 10);
            this.moviePosterBox.Name = "moviePosterBox";
            this.moviePosterBox.Size = new System.Drawing.Size(100, 50);
            this.moviePosterBox.TabIndex = 0;
            this.moviePosterBox.TabStop = false;
            this.moviePosterBox.Click += new System.EventHandler(this.moviePosterBox_Click);
            this.moviePosterBox.Paint += new System.Windows.Forms.PaintEventHandler(this.moviePosterBox_Paint);
            this.Controls.Add(moviePosterBox);
            this.moviePosterBox.ImageLocation = "pinheadLarry.jpg";
            this.moviePosterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // movieTitle
            // 
            this.movieTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.movieTitle.AutoSize = true;
            this.movieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitle.Location = new System.Drawing.Point(0, 0);
            this.movieTitle.Name = "movieTitle";
            this.movieTitle.Size = new System.Drawing.Size(100, 23);
            this.movieTitle.TabIndex = 0;
            this.movieTitle.Text = "<TITLE>";
            // 
            // moviePanel
            // 
            this.Resize += new System.EventHandler(this.moviePanel_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.moviePosterBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox moviePosterBox;
        private System.Windows.Forms.Label movieTitle;
    }
}
