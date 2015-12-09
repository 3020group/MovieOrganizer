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

namespace MovieOrganizer
{
    public partial class PwValidator : Form
    {
        string user; string path; string password;
        public PwValidator(string user, string path, string password)
        {
            InitializeComponent();
            this.user = user; this.path = path; this.password = password;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PwValidator_Load(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(password))
            {
                TabScreen ts = new TabScreen(user, path);
                ts.Show();
            }
            else
            {
                MessageBox.Show("Invalid password for " + user + ".", "Mismatched Passwords");
            }
        }
    }
}
