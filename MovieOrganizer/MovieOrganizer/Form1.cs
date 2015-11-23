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
    /*
    TODO ( Home Screen)
    - Figure out how to scroll through a collection of (clickable) images
        - Imagelist, scrollbar. How to implement scrollbar?
    - Connect images to user profiles
    - NEW opens appropriate window
    - HElP opens appropriate window
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            NewUser nu = new NewUser();
            nu.Show();
        }
    }
}
