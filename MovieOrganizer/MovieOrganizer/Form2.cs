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
    /* TODO: MovieInfo Form
    - Load dynamic movie data from IMDB -> Queries based on title. Fill labels upon opening
    - Add tags: (Max Tags?)
        - Upon Clicking add:
            - if textbox has text:
                - tags.add(textbox.text)
                - textbox.flush
                */

    // Somehow the name of the film needs to be passed to this form. At that point I can query the IMDB-DB for filling labels.
    public partial class MovieInfo : Form
    {
        public MovieInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // We need to accept XML data from whichever form opened this window. That is where we get the movie name and its info.
        }

        private void button1_Click(object sender, EventArgs e) // Do we allow multi word tags?
        {
            // Add tag to collection
            if(NewTag.Text.Length > 0) // What if it's just blank spaces?
            {
                if(Tags.Text.Equals("Add a tag...") )
                {
                    Tags.Text = NewTag.Text;
                    NewTag.Text = "";
                }
                else
                {
                    Tags.Text += (", " + NewTag.Text);
                    NewTag.Text = "";
                    // Add NewTag.Text to tags of movie
                }
            }
        }
    }
}
