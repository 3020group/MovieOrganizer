using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Diagnostics;

namespace MovieOrganizer
{
    public partial class PwValidator : MovieOrganizerForm
    {
        string user; string path; string password;
        HomeScreen homeScreen;

        public PwValidator(string user, string path, string password, HomeScreen homeScreen)
        {
            this.homeScreen = homeScreen;
            InitializeComponent();
            this.user = user; this.path = path; this.password = password;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(password))
            {
                TabScreen ts = new TabScreen(user, path);
                ts.Show();
                homeScreen.Close();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid password for " + user + ".", "Mismatched Passwords");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                EnterButton_Click(sender, e);
            }
        }
    }
}
