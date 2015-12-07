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
        // Three state mechanism for clicking checkboxes.
        // Default: Off, No inclusion into search result consideration
        // First Click: On, Must include in search result
        // Second Click: Excluse, Must Exclude from search result
        // Third click: Back to default
        public AdvancedSearch()
        {
            
            InitializeComponent();
            pressed = false; // Pressed must be true in order for genre selection to do anything
            results = new List<Movie>();

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

                if(valid)
                {
                    MessageBox.Show(xel.Element("title").Value.ToString() + " ");
                    results.Add(new Movie(xel));
                }

                // This will generate all the movies. We will adjust results on genres upon selecting a genre button


                
            }// FOR


            MessageBox.Show(results.Count.ToString());
           //    Scatterplot.drawMovies(results);
        }
    }
}
