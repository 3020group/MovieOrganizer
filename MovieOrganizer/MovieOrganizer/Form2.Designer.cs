namespace MovieOrganizer
{
    partial class MovieInfo
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
            this.Poster = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ParentalRating = new System.Windows.Forms.Label();
            this.Released = new System.Windows.Forms.Label();
            this.Director = new System.Windows.Forms.Label();
            this.Starring = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Tags = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.NewTag = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Poster)).BeginInit();
            this.SuspendLayout();
            // 
            // Poster
            // 
            this.Poster.Location = new System.Drawing.Point(12, 45);
            this.Poster.Name = "Poster";
            this.Poster.Size = new System.Drawing.Size(235, 208);
            this.Poster.TabIndex = 0;
            this.Poster.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(253, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Starring:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.Title.Location = new System.Drawing.Point(12, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(149, 24);
            this.Title.TabIndex = 2;
            this.Title.Text = "<MOVIE TITLE>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(253, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Released in:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(253, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rating:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(253, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Directed By:";
            // 
            // ParentalRating
            // 
            this.ParentalRating.AutoSize = true;
            this.ParentalRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ParentalRating.Location = new System.Drawing.Point(313, 235);
            this.ParentalRating.Name = "ParentalRating";
            this.ParentalRating.Size = new System.Drawing.Size(145, 18);
            this.ParentalRating.TabIndex = 7;
            this.ParentalRating.Text = "<PARENT RATING>";
            // 
            // Released
            // 
            this.Released.AutoSize = true;
            this.Released.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Released.Location = new System.Drawing.Point(347, 201);
            this.Released.Name = "Released";
            this.Released.Size = new System.Drawing.Size(94, 18);
            this.Released.TabIndex = 8;
            this.Released.Text = "<RELEASE>";
            this.Released.Click += new System.EventHandler(this.label7_Click);
            // 
            // Director
            // 
            this.Director.AutoSize = true;
            this.Director.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Director.Location = new System.Drawing.Point(347, 172);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(104, 18);
            this.Director.TabIndex = 9;
            this.Director.Text = "<DIRECTOR>";
            // 
            // Starring
            // 
            this.Starring.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Starring.Location = new System.Drawing.Point(322, 45);
            this.Starring.Name = "Starring";
            this.Starring.Size = new System.Drawing.Size(75, 18);
            this.Starring.TabIndex = 10;
            this.Starring.Text = "<STARS>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(12, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tags:";
            // 
            // Tags
            // 
            this.Tags.AutoSize = true;
            this.Tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Tags.Location = new System.Drawing.Point(63, 271);
            this.Tags.Name = "Tags";
            this.Tags.Size = new System.Drawing.Size(81, 18);
            this.Tags.TabIndex = 12;
            this.Tags.Text = "Add a tag...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewTag
            // 
            this.NewTag.Location = new System.Drawing.Point(244, 270);
            this.NewTag.Name = "NewTag";
            this.NewTag.Size = new System.Drawing.Size(72, 22);
            this.NewTag.TabIndex = 14;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(13, 339);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(551, 179);
            this.Description.TabIndex = 15;
            this.Description.Text = "<DESCRIPTION>";
            // 
            // MovieInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 527);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.NewTag);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tags);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Starring);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.Released);
            this.Controls.Add(this.ParentalRating);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Poster);
            this.Name = "MovieInfo";
            this.Text = "Movie Information";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Poster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Poster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ParentalRating;
        private System.Windows.Forms.Label Released;
        private System.Windows.Forms.Label Director;
        private System.Windows.Forms.Label Starring;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Tags;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NewTag;
        private System.Windows.Forms.Label Description;
    }
}