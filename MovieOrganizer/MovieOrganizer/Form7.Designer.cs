namespace MovieOrganizer
{
    partial class MovieDeleter
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
            this.label1 = new System.Windows.Forms.Label();
            this.MovieTarget = new System.Windows.Forms.TextBox();
            this.TargetPoster = new System.Windows.Forms.PictureBox();
            this.Searcher = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TargetPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label1.Location = new System.Drawing.Point(24, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie:";
            // 
            // MovieTarget
            // 
            this.MovieTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MovieTarget.Location = new System.Drawing.Point(90, 89);
            this.MovieTarget.Name = "MovieTarget";
            this.MovieTarget.Size = new System.Drawing.Size(276, 29);
            this.MovieTarget.TabIndex = 2;
            // 
            // TargetPoster
            // 
            this.TargetPoster.Location = new System.Drawing.Point(90, 143);
            this.TargetPoster.Name = "TargetPoster";
            this.TargetPoster.Size = new System.Drawing.Size(276, 254);
            this.TargetPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TargetPoster.TabIndex = 3;
            this.TargetPoster.TabStop = false;
            // 
            // Searcher
            // 
            this.Searcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Searcher.Location = new System.Drawing.Point(372, 89);
            this.Searcher.Name = "Searcher";
            this.Searcher.Size = new System.Drawing.Size(82, 29);
            this.Searcher.TabIndex = 4;
            this.Searcher.Text = "Find";
            this.Searcher.UseVisualStyleBackColor = true;
            this.Searcher.Click += new System.EventHandler(this.Searcher_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.DeleteButton.Location = new System.Drawing.Point(139, 421);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(170, 51);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete This Movie";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MovieDeleter
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 484);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Searcher);
            this.Controls.Add(this.TargetPoster);
            this.Controls.Add(this.MovieTarget);
            this.Controls.Add(this.label1);
            this.Name = "MovieDeleter";
            this.Text = "Delete A Movie";
            this.Load += new System.EventHandler(this.MovieDeleter_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MovieDeleter_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MovieDeleter_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.TargetPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MovieTarget;
        private System.Windows.Forms.PictureBox TargetPoster;
        private System.Windows.Forms.Button Searcher;
        private System.Windows.Forms.Button DeleteButton;
    }
}