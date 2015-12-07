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
using System.Xml.Linq;

namespace MovieOrganizer
{
    public partial class AdvancedSearch : Form
    {
        bool pressed;
        List<Movie> results;
        Dictionary<string, System.Drawing.Color> buttonColors;
        // Three state mechanism for clicking checkboxes.
        // Default: Off, No inclusion into search result consideration
        // First Click: On, Must include in search result
        // Second Click: Excluse, Must Exclude from search result
        // Third click: Back to default
        public AdvancedSearch()
        {
            buttonColors = new Dictionary<string, System.Drawing.Color>();
            InitializeComponent();
            pressed = false; // Pressed must be true in order for genre selection to do anything
            results = new List<Movie>();


            // Let's build te dictionary
            buttonColors.Add("War", Color.Blue);
            buttonColors.Add("Sci-fi",Color.Green);
            buttonColors.Add("Horror",Color.Red);
            buttonColors.Add("Crime",Color.DarkOrchid);
            buttonColors.Add("Film-Noir",Color.Gold);
            buttonColors.Add("Comedy",Color.Khaki);
            buttonColors.Add("Mystery",Color.HotPink);
            buttonColors.Add("Short",Color.Purple);
            buttonColors.Add("Sport",Color.Turquoise);
            buttonColors.Add("Documentary",Color.Beige);
            buttonColors.Add("Family",Color.Salmon);
            buttonColors.Add("Fantasy",Color.Violet);
            buttonColors.Add("Thriller",Color.Magenta);
            buttonColors.Add("Music",Color.Navy);
            buttonColors.Add("Amination",Color.Brown);
            buttonColors.Add("Western",Color.Wheat);
            buttonColors.Add("Romance",Color.Yellow);
            buttonColors.Add("Adventure",Color.Lime);
            buttonColors.Add("Drama",Color.DarkRed);
            buttonColors.Add("Action",Color.Teal);
            buttonColors.Add("Musical",Color.Indigo);
            buttonColors.Add("History",Color.Orange);
            buttonColors.Add("Biography",Color.Cyan);

            foreach(Control c in this.Controls)
            {
                if(buttonColors.Keys.Contains(c.Text))
                {
                    c.BackColor = buttonColors[c.Text];
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AdvancedSearch_Load(object sender, EventArgs e)
        {

        }

        private void MakeSearch_Click(object sender, EventArgs e)
        {
            // APPLY Button. Look for movies that fit all parameters.
            // First: Validate input


            if (RatingsLow.SelectedIndex <= RatingsHigh.SelectedIndex) // rating range makes sense
            {
                if (YearLow.SelectedIndex <= YearHigh.SelectedIndex) // release data range makes sense
                {
                    if (RunTimeLow.Text.Length > 0 || RunTimeHigh.Text.Length > 0)
                    {
                        try
                        {
                            int lowTime = Int32.Parse(RunTimeLow.Text);
                            int highTime = Int32.Parse(RunTimeHigh.Text);

                            // At this point we know everything was successful
                            pressed = true;
                            getMovies();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Run time selections must be integers.", "Could Not Understand Run-time Format");
                        }
                    
                    }
                    else if (RunTimeLow.Text.Length == 0 && RunTimeHigh.Text.Length == 0)
                    {
                        pressed = true;
                        getMovies();
                    }

                }
                else
                {
                    MessageBox.Show("Please select a positive range of release dates.", "Cannot Understand Release Data Range");
                }
            }
            else
            {
                MessageBox.Show("Please select a positive range of ratings.", "Cannot Understand Rating Range");
            }



        }


        public void getMovies()
        {
           // MessageBox.Show("got here");
            results = new List<Movie>();
            // Now we filter through the movies

            // Iterate through XML Nodes, if Node satisfies parameters, grab it and give to movie constructor

            // Movie constructor takes an X Element
            XDocument doc = new XDocument();
            
            doc = XDocument.Load("movies.xml");
            // doc.Load("movies.xml");

            string[] actors = new string[0];
            if(ActorsBox.Text.Length > 0)
            {
                actors = ActorsBox.Text.Split(',');
            }

            List<string> movieActors = new List<string>();

            int i = 0;

            bool valid = true; // Assume the movie is not valid
            foreach (XElement xel in doc.Root.Elements())
            {
                movieActors = new List<string>();
                valid = true; // Start off assuming the movie is valid. Let's try to break it
                //MessageBox.Show(xel.Element("title").Value);
                if (TitleBox.Text.Length > 0 && !(xel.Element("title").Value.Contains(TitleBox.Text)))
                {
                    valid = false;
                }

                // Now we do actors.
                if (valid)
                {
                    // Add element("actor") to list movieActor
                    foreach(XElement ell in xel.Elements("actor"))
                    {
                        movieActors.Add(ell.Value);
                    }

                    while(valid && i < actors.Length)
                    {
                     //   MessageBox.Show(actors.Length.ToString() + " len actors");
                        if(movieActors.Contains(actors[i]))
                        {
                            i++;
                        }
                        else
                        {
                            valid = false;
                        }
                    }

                }

                

                // At this point, the title string is present and every actor
                if (DirectorBox.Text.Length > 0 && !(xel.Element("director").Value.Equals(DirectorBox.Text)))
                {
                    valid = false; // director not there
                }

                // Now we go through tags
                string[] tags = new String[0];
                if (TagsBox.Text.Length > 0)
                {
                    tags = TagsBox.Text.Split(',');
                }

                List<string> movieTags = new List<string>();

                if(valid)
                {
                    foreach (XElement ell in xel.Elements("tag"))
                    {
                        if (ell != null)
                        {
                            movieActors.Add(ell.Value);
                        }
                    }
                    i = 0;
                    while (valid && i < tags.Length)
                    {
                        if (movieActors.Contains(tags[i]))
                        {
                            i++;
                        }
                        else
                        {
                            valid = false;
                        }
                    }
                }

                int movieTime = 0; int low = 0; int high = 0;
                if (RunTimeLow.Text.Length > 0 && RunTimeHigh.Text.Length > 0)
                {
                    // At this point, movie contains title, has director, has all actors and tags
                    movieTime = Int32.Parse(xel.Element("length").Value);
                    low = Int32.Parse(RunTimeLow.Text);
                    high = Int32.Parse(RunTimeHigh.Text);

                    if (!Enumerable.Range(low, high).Contains(movieTime))
                    {
                        valid = false;
                    }
                }

                // title, dir, actors, tags, runtime


                // now cert.
                string cert = null;
                if(xel.Element("certification")!= null)
                {
                    cert = xel.Element("certification").Value;
                    if (!((cert.Equals("G") && GBox.Checked) || (cert.Equals("PG") && PGBox.Checked) || (cert.Equals("PG-13") && PG13Box.Checked) || (cert.Equals("R") && RBox.Checked)))
                    {
                        valid = false;
                    }
                }
                else
                {
                    valid = false;
                }
                

                int rating = Int32.Parse(xel.Element("rating").Value);
                int lo = 0; high = 0;
                if(RatingsLow.SelectedIndex > -1 && RatingsLow.SelectedIndex > -1)
                {
                    lo = Int32.Parse(RatingsLow.Items[RatingsLow.SelectedIndex].ToString());
                    high = Int32.Parse(RatingsHigh.Items[RatingsHigh.SelectedIndex].ToString());
                    if (!Enumerable.Range(lo, high).Contains(rating))
                    {
                        valid = false;
                    }

                }

                int year = Int32.Parse(xel.Element("year").Value);
                int loYear = 0; int hiYear = 0;
                if(YearLow.SelectedIndex > -1 && YearHigh.SelectedIndex > -1)
                {
                    loYear = Int32.Parse(YearLow.Items[RatingsLow.SelectedIndex].ToString());
                    hiYear = Int32.Parse(YearLow.Items[RatingsLow.SelectedIndex].ToString());

                    if(!Enumerable.Range(loYear, hiYear).Contains(year))
                    {
                        valid = false;
                    }
                }

                CheckBox cb;
                List<string> movieGenres = new List<string>();

                foreach(XElement ell in xel.Elements("genre"))
                {
                    movieGenres.Add(ell.Value);
                }

                List<string> activeGenres = new List<string>();
                foreach(Control c in this.Controls)
                {
                    if(buttonColors.Keys.Contains(c.Text))
                    {
                        cb = (CheckBox)c;
                        if(cb.Checked)
                        {
                            activeGenres.Add(cb.Text);
                        }
                    }
                }


                // Now we have a list<string> of movie's genres and a list<string> of selected genres
                int appear = 0;
                foreach(string s in movieGenres)
                {
                    if(activeGenres.Contains(s))
                    {
                        appear++;
                    }
                }

                if(appear == 0) // Not a single one of the movie's genres is in our list of pushed down genres
                {
                    valid = false;
                }

                if(valid)
                {
                //    MessageBox.Show(xel.Element("title").Value.ToString() + " ");
                    results.Add(new Movie(xel));
                }

                // This will generate all the movies. We will adjust results on genres upon selecting a genre button


                // Now pass along movies and genres
            }// FOR


           // MessageBox.Show(results.Count.ToString());
           //    Scatterplot.drawMovies(results);
        }



        // Somehow the genre pushing happens here. If it is checked, color it in and set it up
        private void FilmNoirCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if(cb.Checked)
            {
                // color it in and include the stuff
                cb.BackColor = buttonColors[cb.Text];
                getMovies();
            
            }
            else
            {
                // Lose color
                cb.BackColor = default(Color);
            }
        }

        // Push down genre button. If checked is now true, set color and include

    }
}
