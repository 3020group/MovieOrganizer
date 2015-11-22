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
    public partial class TabScreen : Form
    {
        private string username;
        private string imageLocation;

        public TabScreen(string username,string imageLocation)
        {
            InitializeComponent();

            this.username = username;
            this.imageLocation = imageLocation;

            //set up the profile area
            usernameLabel.Text = username;
            profilePictureBox.ImageLocation = imageLocation;
            profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            //make the tabe take up the top of the screeen
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(tabControl.Width / tabControl.TabCount-1, 30); //need to take away 1 so the tabs dont take up too much space.
        }

        private void TabScreen_Resize(object sender, EventArgs e)
        {
            tabControl.ItemSize = new Size(tabControl.Width / tabControl.TabCount - 1, 30);
        }

        private void settingsTab_Enter(object sender, EventArgs e)
        {
            nameBox.Text = username;

            //make the picture corrct for the profile
            picturePathBox.Text = imageLocation;
            pPictureEditBox.ImageLocation = imageLocation;
            pPictureEditBox.SizeMode = PictureBoxSizeMode.StretchImage;

            loadPaths(dirBox);

        }

        private void loadPaths(TextBox box)
        {
            string newText = "";
            var doc = System.Xml.Linq.XDocument.Load("paths.xml");

            foreach (var element in doc.Element("paths").Elements())
            {
                newText += element.Value+Environment.NewLine;
            }

            box.Text = newText;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            DialogResult result = fb.ShowDialog();

            if(result == DialogResult.OK)
            {
                Console.WriteLine(fb.SelectedPath);
                addToPath(fb.SelectedPath);
            }

            loadPaths(dirBox);
        
        }

        private void addToPath(string newPath)
        {
            var doc = System.Xml.Linq.XDocument.Load("paths.xml");
            System.Xml.Linq.XElement paths = doc.Element("paths");
            paths.Add(new System.Xml.Linq.XElement("path", newPath));
            doc.Save("paths.xml");
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Images (*.jpg)|*.jpg"; //TODO: what about other types of images?
            DialogResult result = open.ShowDialog();

            if (result == DialogResult.OK)
            {
                imageLocation = open.FileName;
                picturePathBox.Text = imageLocation;
                profilePictureBox.ImageLocation = imageLocation;
                pPictureEditBox.ImageLocation = imageLocation;
                //TODO: update the user's account in xml so the path is current
            }

        }

        private void settingsTab_Click(object sender, EventArgs e)
        {

        }

        private void pPictureEditBox_Click(object sender, EventArgs e)
        {

        }

        private void moviePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
