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
        public ProfileSelector(string user, string imagePath)
        {
 
            InitializeComponent();
            this.UserName.Text = user;

            if (imagePath.Equals("Choose File") || imagePath.Equals("defaultPic.png") )
            {
                this.ProfilePic.Image = Image.FromFile("defaultPic.png");
            }
            else
            {
                this.ProfilePic.Image = Image.FromFile(imagePath);
            }

        }

        private void profilePic_Click(object sender, EventArgs e)
        {
            // This is where we go to tabview
        }

        private void ProfileSelector_Load(object sender, EventArgs e)
        {

        }

        private void ProfileSelector_MouseClick(object sender, MouseEventArgs e)
        {
            // Load user from XML DB. Pass user to tab view
            MessageBox.Show("okay this is where we open the tabs");
        }
    }
}
