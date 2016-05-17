using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MovieOrganizer
{
    public partial class ProfileSelector : UserControl
    {
        private string myPath;
        private HomeScreen homeScreen;
        public ProfileSelector(string user, string imagePath, HomeScreen homeScreen)
        {
            this.homeScreen = homeScreen;
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
            string password = "";
            XDocument xdoc = XDocument.Load("users.xml");
            foreach(XElement xel in xdoc.Root.Elements())
            {
                if(xel.Element("name").Value.ToString().Equals(UserName.Text))
                {
                    password = xel.Element("password").Value.ToString();
                }
            }
            

            if(password.Equals("0")) // no pw
            {
                TabScreen ts = new TabScreen(this.UserName.Text, myPath);
                ts.Show();
            }
            else
            {
                PwValidator pw = new PwValidator(this.UserName.Text, myPath, password, homeScreen);
                pw.Show();
            }    
        }

    }
}
