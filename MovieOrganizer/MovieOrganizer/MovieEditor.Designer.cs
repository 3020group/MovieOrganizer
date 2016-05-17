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
            this.label1.Location = new System.Drawing.Point(5, 57);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(207, 57);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 101);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 131);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 203);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 349);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(4, 369);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 389);
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(8, 412);
            this.DescriptionText.Size = new System.Drawing.Size(344, 74);
            // 
            // PosterPath
            // 
            this.PosterPath.Location = new System.Drawing.Point(63, 369);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 345);
            this.button1.Size = new System.Drawing.Size(79, 27);
            // 
            // RatingSelecter
            // 
            this.RatingSelecter.Location = new System.Drawing.Point(52, 351);
            // 
            // OwnedCheck
            // 
            this.OwnedCheck.Location = new System.Drawing.Point(8, 323);
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(323, 57);
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(59, 54);
            // 
            // GenreText
            // 
            this.GenreText.Location = new System.Drawing.Point(9, 154);
            // 
            // ActorText
            // 
            this.ActorText.Location = new System.Drawing.Point(8, 226);
            // 
            // FinalAdder
            // 
            this.FinalAdder.Location = new System.Drawing.Point(116, 506);
            // 
            // Poster
            // 
            this.Poster.Location = new System.Drawing.Point(256, 236);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 78);
            // 
            // DirectorBox
            // 
            this.DirectorBox.Location = new System.Drawing.Point(78, 77);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(207, 80);
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(323, 80);
            // 
            // RatingList
            // 
            this.RatingList.Location = new System.Drawing.Point(142, 100);
            // 
            // tags
            // 
            this.tags.Location = new System.Drawing.Point(8, 271);
            // 
            // TagBox
            // 
            this.TagBox.Location = new System.Drawing.Point(9, 294);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label11.Location = new System.Drawing.Point(44, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(261, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Drag and Drop a Movie Here to Edit";
            // 
            // MovieEditor
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 577);
            this.Controls.Add(this.label11);
            this.Name = "MovieEditor";
            this.Text = "Edit A Movie";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MovieEditor_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MovieEditor_DragEnter);
            this.MouseEnter += new System.EventHandler(this.MovieEditor_MouseEnter);
            this.Controls.SetChildIndex(this.tags, 0);
            this.Controls.SetChildIndex(this.TagBox, 0);
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