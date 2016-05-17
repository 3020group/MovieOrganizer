using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;


namespace MovieOrganizer
{
    /* TODO:
     - Check unique-names
     - Load from DB and pass to tab view
     - Soon: Query IMDB with input parameters
     */
    public partial class NewUser : MovieOrganizerForm
    {
        HomeScreen homeScreen;
        public NewUser(HomeScreen homeScreen)
        {
            this.homeScreen = homeScreen;
            
            InitializeComponent();
            MaxRating.SelectedIndex = MaxRating.FindStringExact("None");
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            ProfilePic.Image = Image.FromFile("defaultPic.jpg");
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            DialogResult res = PictureSelecter.ShowDialog();

            if (res == DialogResult.OK) // Test result.
            {
                string file = PictureSelecter.FileName;
                try
                {
                    ProfilePic.Image = Image.FromFile(file);
                    FileName.Text = file;
                }
                catch (Exception)
                {
                    MessageBox.Show("Please select a profile picture or use the default profile picture.", "Incorrect File Type");
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(NameField.Text.Length > 0) // They need a username
            {
                if(Password.Text == PasswordRepeat.Text) // Should we worry about identical usernames?
                {
                    //if UserName not in UserDB: (else show uniquename Dialog)
                    if (Password.Text.Length != 1) // good pw length
                    {
                        if (!alreadyExists(NameField.Text)) // Need a unique name
                        {
                            String[] input = NameField.Text.Split(' ');
                            MessageBox.Show(input[0] + ", welcome to MovieOrganizer! Your profile has been created.", "Congratulations!");
                            

                            // Make new XMLNode, add it to Users DB
                            addUser();

                            // Pass name and profile pic to HomeScreen to add picture
                            if(homeScreen!= null)
                            {
                                homeScreen.addProfileBox(NameField.Text, FileName.Text);
                            }

                            Close();
                        }
                        else
                        {
                            MessageBox.Show("You must select a unique username", "Username Taken");
                        }

                    }
                    else
                    {
                        MessageBox.Show("If you want a password, it must be at least two characters long.", "Password Too Short");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the same password twice.", "Unmatched Passwords");
                }
            }
            else
            {
                MessageBox.Show("Please enter a user name.", "Name Missing");
            }

            
        }

        // Take all the data from the components and form it into a new XML node, add the node into the user DB
        private void addUser()
        {
            string path = "users.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNode node = doc.CreateNode(XmlNodeType.Element, "user", null);


            // Adding name
            XmlNode nameNode = doc.CreateElement("name");
            nameNode.InnerText = NameField.Text;

            // Adding password
            string insert = "0";
            XmlNode pwNode = doc.CreateElement("password");
            if(Password.Text.Length > 1)//User wants a password
                insert = Password.Text;

            pwNode.InnerText = insert;


            // Adding pic
            string picPath = "defaultPic.jpg";
            XmlNode picNode = doc.CreateElement("pic");

            if (!FileName.Text.Equals("Choose File"))
                picPath = FileName.Text;

            picNode.InnerText = picPath;

            // Adding max_rating
            XmlNode ratingNode = doc.CreateElement("max_rating");

            ratingNode.InnerText = MaxRating.SelectedItem.ToString();

            // Adding is_admin
            XmlNode adminNode = doc.CreateElement("is_admin");
            adminNode.InnerText = adminBox.Checked.ToString().ToLower();

            // We need to append all the child nodes based on component data

            node.AppendChild(nameNode);
            node.AppendChild(pwNode);
            node.AppendChild(picNode);
            node.AppendChild(ratingNode);
            node.AppendChild(adminNode);


            doc.DocumentElement.AppendChild(node);

            //save back
            doc.Save(path);

        }

        private bool alreadyExists(string userName)// Make sure username isn't in the DB
        {
            // Figure out how to iterate through XML doc and find names
            XmlDocument xdoc = new XmlDocument();

            xdoc.Load("users.xml");

            XmlElement root = xdoc.DocumentElement;
            XmlNodeList userNodes = root.SelectNodes("/users/user");

            bool found = false;
            for(int i = 0; (i<userNodes.Count && !found); i++)
            {
                if (userNodes.Item(i)["name"].Equals(userName))
                {
                    found = true;
                }
            }
            return found;
        }
    }
}
