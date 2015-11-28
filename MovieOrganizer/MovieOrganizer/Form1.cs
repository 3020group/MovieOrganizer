using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MovieOrganizer
{
    /* TODO -> Overall
    Make profile pictures persist in home view
    Impose limit on length of name(?)
    Pass tabview right data
    Setup movie info page with IMDB-DB
    */
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();

            // Populate profile view control from XML database
            // ProfilePanel
            /*
            ProfileSelector ps = new ProfileSelector(name, imagePath);
            selections.Add(ps);
            */
            // Iterate through xml database and add profileselector
            XmlDocument xdoc = new XmlDocument();

            xdoc.Load("users.xml");

            ProfileSelector ps;

            XmlElement root = xdoc.DocumentElement;
            XmlNodeList userNodes = root.SelectNodes("/users/user");

            for (int i = 0; (i < userNodes.Count); i++)
            {
                ps =  new ProfileSelector(userNodes.Item(i)["name"].InnerText, userNodes.Item(i)["pic"].InnerText);
                ProfilePanel.Controls.Add(ps);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelpModule hm = new HelpModule();
            hm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MovieInfo mi = new MovieInfo();
            mi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewUser nu = new NewUser(this);
            nu.Show();
        }

        private void ProfilePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        // Method to add ProfileBox to FlowLayoutPanel
        public void addProfileBox(string name, string imagePath)
        {
            // UserData added to XML elsewhere

            // Make a new ProfileBox based on input data 
            ProfileSelector ps = new ProfileSelector(name, imagePath);

            // add ps to panel
            ProfilePanel.Controls.Add(ps); // This will need tweaks for size and spacing

        }

        // We need an event for clicking on a specific picture. It will load a user from the XML Database,
        // whichever one has the corresponding name from the picture (ProfileBox). This might happen in the customComponent.
    }
}
