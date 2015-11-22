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
        public moviePanel(string title)
        {
            InitializeComponent();

            //set the movie poster to the correct size
            moviePosterBox.Size = new System.Drawing.Size((this.Size.Height*4)/5,(this.Size.Height*3)/4);
            moviePosterBox.SizeMode = PictureBoxSizeMode.StretchImage;
            moviePosterBox.Show();
            movieTitle.Text = title;
            
        }

        public moviePanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void moviePosterBox_Click(object sender, EventArgs e)
        {

        }

        private void moviePanel_Resize(object sender, EventArgs e) 
        {
            moviePosterBox.Size = new System.Drawing.Size((this.Size.Height * 4) / 5, (this.Size.Height * 3) / 4);
            
        }

        private void moviePosterBox_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
