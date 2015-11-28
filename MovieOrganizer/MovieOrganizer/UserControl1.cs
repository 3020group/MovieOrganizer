using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieOrganizer
{
    public partial class ProfileSelector : UserControl
    {
        private string myPath;
        public ProfileSelector(string user, string imagePath)
        {

            InitializeComponent();
            this.UserName.Text = user;

            if (imagePath.Equals("Choose File") || imagePath.Equals("defaultPic.jpg") )
            {
                myPath = "defaultPic.jpg";
                this.ProfilePic.Image = Image.FromFile("defaultPic.jpg");
            }
            else
            {
                myPath = imagePath;
                this.ProfilePic.Image = Image.FromFile(imagePath);
            }

        }

        private void profilePic_Click(object sender, EventArgs e)
        {
            // This is where we go to tabview
            TabScreen ts = new TabScreen(this.UserName.Text, myPath);
            ts.Show();
        }

        private void ProfileSelector_Load(object sender, EventArgs e)
        {

        }

        private void ProfileSelector_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
