using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MovieOrganizer
{
    public partial class moviePanel : Panel
    {
        // The picture doesn't load. Also User-Tags need to be put into play
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
            resizeTitleText(9.75F);

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
            this.movieTitle.Location = new System.Drawing.Point((this.Size.Width / 2), moviePosterBox.Location.X + moviePosterBox.Size.Height-1000);
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
            MovieInfo info = new MovieInfo(m);
            info.Show();
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

        private void moviePanel_Click(object sender, EventArgs e)
        {
            MovieInfo info = new MovieInfo(m);
            info.Show();
        }

        private void moviePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                this.DoDragDrop(m, DragDropEffects.Copy | DragDropEffects.Move);
            }
            else if(e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                MovieInfo mi = new MovieInfo(m);
                mi.Show();
            }
        }
            
            // What would be really cool would be making a custom cursor to visually identify drag-drop of the specific film. This may be tough though
        

        

        private void moviePanel_MouseUp(object sender, MouseEventArgs e)
        {
            // This needs to trigger te movie panel to open
        }








        private void moviePosterBox_MouseUp(object sender, MouseEventArgs e)
        {this.moviePanel_MouseUp(sender, e);}
        private void movieTitle_MouseUp(object sender, MouseEventArgs e)
        { this.moviePanel_MouseUp(sender, e);}

        private void moviePosterBox_MouseDown(object sender, MouseEventArgs e)
        { this.moviePanel_MouseDown(sender, e); }
        private void movieTitle_MouseDown(object sender, MouseEventArgs e)
        { this.moviePanel_MouseDown(sender, e); }


        // New Drag Event (To Go To Edit panel)
        // React to Mouse down, takes info over

    }
}
