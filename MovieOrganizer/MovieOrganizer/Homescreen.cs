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
    public partial class HomeScreen : MovieOrganizerForm
    {
        
        public HomeScreen()
        {
            InitializeComponent();

            XmlDocument xdoc = new XmlDocument();

            xdoc.Load("users.xml");

            ProfileSelector ps;

            XmlElement root = xdoc.DocumentElement;
            XmlNodeList userNodes = root.SelectNodes("/users/user");

            for (int i = 0; (i < userNodes.Count); i++)
            {
                ps =  new ProfileSelector(userNodes.Item(i)["name"].InnerText, userNodes.Item(i)["pic"].InnerText, this);
                ProfilePanel.Controls.Add(ps);
            }

            //need to check if anyone can create a new user
            var doc = System.Xml.Linq.XDocument.Load("settings.xml");

            if(doc.Element("allowCreate").Value.Equals("false"))
            {
                button2.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new HelpModule()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new NewUser(this)).Show();
        }

        // Method to add ProfileBox to FlowLayoutPanel
        public void addProfileBox(string name, string imagePath)
        {
            ProfileSelector ps = new ProfileSelector(name, imagePath, this);
            ProfilePanel.Controls.Add(ps);
        }

        private void HomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection fc = Application.OpenForms;

            for (int i = 0; i < fc.Count; i++)
            {
                if (!fc[i].Name.Equals("TabScreen")) // A new homescreen is loaded when we sign out. Make sure this is not closed by accident
                {
                    fc[i].Close();
                    i--;
                }
            }
        }
    }
}
