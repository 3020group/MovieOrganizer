using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatTmdb.V3;

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
        private Movie m;
        public MovieInfo(Movie m)
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // We accepted a Movie object. This object contains the parameters to be filled and queried

            // The other issue: What about tags? Tags need to be kept persistent somehow (What database are they going to be in?)
            Title.Text = m.Title;

            Starring.Text = "";
            foreach(string actor in m.Actors)
            {
                Starring.Text += actor + Environment.NewLine;
            }

            Director.Text = m.Director;
            Released.Text = m.Year.ToString();
            ParentalRating.Text = m.Certification;
            Description.Text = m.Description;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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

                    // Add NewTag.Text to tags of movie
                    NewTag.Text = "";
                }
            }
        }
    }
}
