using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieOrganizer
{
    public partial class TabScreen : Form
    {
        public TabScreen(string username,string imageLocation)
        {
            InitializeComponent();

            //set up the profile area
            usernameLabel.Text = username;
            profilePictureBox.ImageLocation = imageLocation;
            profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            //make the tabe take up the top of the screeen
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(tabControl.Width / tabControl.TabCount-1, 30); //need to take away 1 so the tabs dont take up too much space.
        }
    }
}
