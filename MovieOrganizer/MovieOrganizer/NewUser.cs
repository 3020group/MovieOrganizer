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

namespace MovieOrganizer
{
    /* TODO (New User):
     - Set up File Browsing
     - Check with admin-settings (Create admin vs normal account)
     - Upon create: Add user to collection
     */
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            ProfilePic.Image = Image.FromFile("defaultPic.png");
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
                    

                    String[] input = NameField.Text.Split(' ');
                    MessageBox.Show(input[0] + ", welcome to MovieOrganizer! Your profile has been created.", "Congratulations!");
                    Close();

                    // Add user to collection based on given parameters
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
    }
}
