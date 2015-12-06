namespace MovieOrganizer
{
    partial class MovieEditor
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
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Poster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 70);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(276, 70);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 120);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 145);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 215);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 310);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(11, 335);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(11, 360);
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(16, 388);
            // 
            // PosterPath
            // 
            this.PosterPath.Location = new System.Drawing.Point(81, 335);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 313);
            this.button1.Size = new System.Drawing.Size(105, 33);
            // 
            // RatingSelecter
            // 
            this.RatingSelecter.Location = new System.Drawing.Point(74, 313);
            this.RatingSelecter.Size = new System.Drawing.Size(73, 24);
            // 
            // OwnedCheck
            // 
            this.OwnedCheck.Location = new System.Drawing.Point(11, 278);
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(431, 70);
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(63, 67);
            // 
            // GenreText
            // 
            this.GenreText.Location = new System.Drawing.Point(12, 173);
            // 
            // ActorText
            // 
            this.ActorText.Location = new System.Drawing.Point(12, 243);
            // 
            // FinalAdder
            // 
            this.FinalAdder.Location = new System.Drawing.Point(155, 504);
            // 
            // Poster
            // 
            this.Poster.Location = new System.Drawing.Point(336, 189);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 96);
            // 
            // DirectorBox
            // 
            this.DirectorBox.Location = new System.Drawing.Point(89, 95);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(276, 99);
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(431, 99);
            // 
            // RatingList
            // 
            this.RatingList.Location = new System.Drawing.Point(174, 123);
            this.RatingList.Size = new System.Drawing.Size(44, 24);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label11.Location = new System.Drawing.Point(58, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(319, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Drag and Drop a Movie Here to Edit";
            // 
            // MovieEditor
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 540);
            this.Controls.Add(this.label11);
            this.Name = "MovieEditor";
            this.Text = "Edit A Movie";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MovieEditor_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MovieEditor_DragEnter);
            this.MouseEnter += new System.EventHandler(this.MovieEditor_MouseEnter);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.DescriptionText, 0);
            this.Controls.SetChildIndex(this.PosterPath, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.RatingSelecter, 0);
            this.Controls.SetChildIndex(this.OwnedCheck, 0);
            this.Controls.SetChildIndex(this.YearBox, 0);
            this.Controls.SetChildIndex(this.TitleBox, 0);
            this.Controls.SetChildIndex(this.GenreText, 0);
            this.Controls.SetChildIndex(this.ActorText, 0);
            this.Controls.SetChildIndex(this.FinalAdder, 0);
            this.Controls.SetChildIndex(this.Poster, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.DirectorBox, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.TimeBox, 0);
            this.Controls.SetChildIndex(this.RatingList, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Poster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
    }
}