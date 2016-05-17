namespace MovieOrganizer
{
    partial class MovieAdderForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.PosterPath = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RatingSelecter = new System.Windows.Forms.ComboBox();
            this.OwnedCheck = new System.Windows.Forms.CheckBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.GenreText = new System.Windows.Forms.TextBox();
            this.ActorText = new System.Windows.Forms.TextBox();
            this.FinalAdder = new System.Windows.Forms.Button();
            this.PosterSelector = new System.Windows.Forms.OpenFileDialog();
            this.Poster = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DirectorBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.RatingList = new System.Windows.Forms.ComboBox();
            this.tags = new System.Windows.Forms.Label();
            this.TagBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Poster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label2.Location = new System.Drawing.Point(208, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rating (/10):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genre(s), seperated by comma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label5.Location = new System.Drawing.Point(9, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Actor(s), seperated by comma:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label7.Location = new System.Drawing.Point(9, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rated:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label8.Location = new System.Drawing.Point(9, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Poster:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label9.Location = new System.Drawing.Point(9, 299);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Description:";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(13, 322);
            this.DescriptionText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(344, 90);
            this.DescriptionText.TabIndex = 9;
            // 
            // PosterPath
            // 
            this.PosterPath.AutoSize = true;
            this.PosterPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.PosterPath.Location = new System.Drawing.Point(64, 279);
            this.PosterPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PosterPath.Name = "PosterPath";
            this.PosterPath.Size = new System.Drawing.Size(47, 20);
            this.PosterPath.TabIndex = 10;
            this.PosterPath.Text = "None";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.button1.Location = new System.Drawing.Point(278, 258);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RatingSelecter
            // 
            this.RatingSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RatingSelecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.RatingSelecter.FormattingEnabled = true;
            this.RatingSelecter.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R"});
            this.RatingSelecter.Location = new System.Drawing.Point(65, 259);
            this.RatingSelecter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RatingSelecter.Name = "RatingSelecter";
            this.RatingSelecter.Size = new System.Drawing.Size(56, 21);
            this.RatingSelecter.TabIndex = 12;
            // 
            // OwnedCheck
            // 
            this.OwnedCheck.AutoSize = true;
            this.OwnedCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OwnedCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.OwnedCheck.Location = new System.Drawing.Point(10, 232);
            this.OwnedCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OwnedCheck.Name = "OwnedCheck";
            this.OwnedCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OwnedCheck.Size = new System.Drawing.Size(144, 24);
            this.OwnedCheck.TabIndex = 13;
            this.OwnedCheck.Text = ":I own this Movie";
            this.OwnedCheck.UseVisualStyleBackColor = true;
            // 
            // YearBox
            // 
            this.YearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.YearBox.Location = new System.Drawing.Point(324, 7);
            this.YearBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(38, 25);
            this.YearBox.TabIndex = 17;
            // 
            // TitleBox
            // 
            this.TitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.TitleBox.Location = new System.Drawing.Point(52, 4);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TitleBox.MaxLength = 50;
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(117, 25);
            this.TitleBox.TabIndex = 18;
            // 
            // GenreText
            // 
            this.GenreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.GenreText.Location = new System.Drawing.Point(10, 98);
            this.GenreText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenreText.MaxLength = 200;
            this.GenreText.Name = "GenreText";
            this.GenreText.Size = new System.Drawing.Size(240, 25);
            this.GenreText.TabIndex = 19;
            // 
            // ActorText
            // 
            this.ActorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.ActorText.Location = new System.Drawing.Point(10, 148);
            this.ActorText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ActorText.MaxLength = 200;
            this.ActorText.Name = "ActorText";
            this.ActorText.Size = new System.Drawing.Size(240, 25);
            this.ActorText.TabIndex = 20;
            // 
            // FinalAdder
            // 
            this.FinalAdder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.FinalAdder.Location = new System.Drawing.Point(117, 416);
            this.FinalAdder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FinalAdder.Name = "FinalAdder";
            this.FinalAdder.Size = new System.Drawing.Size(135, 25);
            this.FinalAdder.TabIndex = 23;
            this.FinalAdder.Text = "Add This Movie!";
            this.FinalAdder.UseVisualStyleBackColor = true;
            this.FinalAdder.Click += new System.EventHandler(this.FinalAdder_Click);
            // 
            // PosterSelector
            // 
            this.PosterSelector.FileName = "PosterSelect";
            // 
            // Poster
            // 
            this.Poster.Location = new System.Drawing.Point(253, 148);
            this.Poster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Poster.Name = "Poster";
            this.Poster.Size = new System.Drawing.Size(104, 96);
            this.Poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Poster.TabIndex = 24;
            this.Poster.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Director:";
            // 
            // DirectorBox
            // 
            this.DirectorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.DirectorBox.Location = new System.Drawing.Point(71, 28);
            this.DirectorBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DirectorBox.MaxLength = 50;
            this.DirectorBox.Name = "DirectorBox";
            this.DirectorBox.Size = new System.Drawing.Size(98, 25);
            this.DirectorBox.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label10.Location = new System.Drawing.Point(208, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Time (minutes):";
            // 
            // TimeBox
            // 
            this.TimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.TimeBox.Location = new System.Drawing.Point(324, 31);
            this.TimeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(38, 25);
            this.TimeBox.TabIndex = 28;
            // 
            // RatingList
            // 
            this.RatingList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RatingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.RatingList.FormattingEnabled = true;
            this.RatingList.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.RatingList.Location = new System.Drawing.Point(135, 49);
            this.RatingList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RatingList.Name = "RatingList";
            this.RatingList.Size = new System.Drawing.Size(34, 21);
            this.RatingList.TabIndex = 29;
            // 
            // tags
            // 
            this.tags.AutoSize = true;
            this.tags.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.tags.Location = new System.Drawing.Point(9, 186);
            this.tags.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(214, 20);
            this.tags.TabIndex = 30;
            this.tags.Text = "Tag(s), seperated by comma:";
            // 
            // TagBox
            // 
            this.TagBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.TagBox.Location = new System.Drawing.Point(10, 209);
            this.TagBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TagBox.MaxLength = 200;
            this.TagBox.Name = "TagBox";
            this.TagBox.Size = new System.Drawing.Size(240, 25);
            this.TagBox.TabIndex = 31;
            // 
            // MovieAdderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 518);
            this.Controls.Add(this.TagBox);
            this.Controls.Add(this.tags);
            this.Controls.Add(this.RatingList);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DirectorBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Poster);
            this.Controls.Add(this.FinalAdder);
            this.Controls.Add(this.ActorText);
            this.Controls.Add(this.GenreText);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.OwnedCheck);
            this.Controls.Add(this.RatingSelecter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PosterPath);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MovieAdderForm";
            this.Text = "Add A New Movie";
            ((System.ComponentModel.ISupportInitialize)(this.Poster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.TextBox DescriptionText;
        protected System.Windows.Forms.Label PosterPath;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.ComboBox RatingSelecter;
        protected System.Windows.Forms.CheckBox OwnedCheck;
        protected System.Windows.Forms.TextBox YearBox;
        protected System.Windows.Forms.TextBox TitleBox;
        protected System.Windows.Forms.TextBox GenreText;
        protected System.Windows.Forms.TextBox ActorText;
        protected System.Windows.Forms.Button FinalAdder;
        private System.Windows.Forms.OpenFileDialog PosterSelector;
        protected System.Windows.Forms.PictureBox Poster;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox DirectorBox;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.TextBox TimeBox;
        protected System.Windows.Forms.ComboBox RatingList;
        protected System.Windows.Forms.Label tags;
        protected System.Windows.Forms.TextBox TagBox;
    }
}