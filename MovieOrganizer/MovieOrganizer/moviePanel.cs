using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieOrganizer
{
    public partial class moviePanel : Panel
    {

        Movie m;


        public moviePanel(Movie m,int width,int height)

        {
            this.m = m;
            InitializeComponent();

            this.Size = new System.Drawing.Size(width, height);
            moviePosterBox.Size = new System.Drawing.Size((this.Size.Height * 2) / 3, (this.Size.Height * 3) / 4);
            moviePosterBox.Location = new System.Drawing.Point((this.Size.Width - moviePosterBox.Size.Width) / 2, (this.Size.Width - moviePosterBox.Size.Width) / 4);
            moviePosterBox.ImageLocation = m.Poster;

            movieTitle.Text = m.Title;
            movieTitle.Show();
            resizeTitleText(10.75F);

            this.movieTitle.Location = new System.Drawing.Point((this.Size.Width / 2), moviePosterBox.Location.X + moviePosterBox.Size.Height);
        }


        public moviePanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            moviePosterBox.Size = new System.Drawing.Size((this.Size.Height * 2) / 3, (this.Size.Height * 3) / 4);
            moviePosterBox.Location = new System.Drawing.Point((this.Size.Width - moviePosterBox.Size.Width)/2, (this.Size.Width - moviePosterBox.Size.Width) / 4);
            moviePosterBox.ImageLocation = m.Poster;

            movieTitle.Text = m.Title;
            Console.WriteLine(movieTitle.Text);
            movieTitle.Show();
            this.movieTitle.Location = new System.Drawing.Point((this.Size.Width / 2), moviePosterBox.Location.X + moviePosterBox.Size.Height);
        }

        public void resizeTitleText(Single size)
        {
            System.Drawing.Font font = new System.Drawing.Font("Microsoft Sans Serif", size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitle.Font = font;
 
            if (TextRenderer.MeasureText(movieTitle.Text,font).Width > this.Size.Width)
            {
                resizeTitleText(size-1);
            }
        }


        private void moviePosterBox_Click(object sender, EventArgs e)
        {

        }

        private void moviePanel_Resize(object sender, EventArgs e) 
        {
            moviePosterBox.Size = new System.Drawing.Size((this.Size.Height * 2) / 3, (this.Size.Height * 3) / 4);
            moviePosterBox.Location = new System.Drawing.Point((this.Size.Width - moviePosterBox.Size.Width) / 2, (this.Size.Width - moviePosterBox.Size.Width)/4);
            this.movieTitle.Location = new System.Drawing.Point((this.Size.Width/2)-(movieTitle.Size.Width/2),moviePosterBox.Location.X + moviePosterBox.Size.Height);
        }

        private void moviePosterBox_Paint(object sender, PaintEventArgs e)
        {
            
        }

       
    }
}
