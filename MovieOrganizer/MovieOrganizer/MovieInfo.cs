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
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace MovieOrganizer
{
    // Should the genre(s) of the film be included?
    public partial class MovieInfo : MovieOrganizerForm
    {
        private Movie m;
        private string moviePath;

        public MovieInfo(Movie m)
        {
            InitializeComponent();

            this.m = m;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            // We accepted a Movie object. This object contains the parameters to be filled and queried

            // The other issue: What about tags? Tags need to be kept persistent somehow (What database are they going to be in?)
            Title.Text = m.Title;
            XElement xel = null;
            XDocument xdoc = XDocument.Load("movies.xml");
            foreach (XElement ell in xdoc.Root.Elements())
            {
                if (ell.Element("title").Value.ToString().Equals(Title.Text))
                {
                    xel = ell;
                }
            }
            List<string> tags = new List<string>();
            if (xel.Elements("tag") != null)
            {
                foreach (XElement ell in xel.Elements("tag"))
                {
                    tags.Add(ell.Value);
                }
            }

            if (tags.Count > 0)
            {
                Tags.Text = "";
                foreach (string s in tags)
                {
                    Tags.Text += (s + ", ");
                }
                Tags.Text = Tags.Text.Remove(Tags.Text.Length - 2);
            }

            Starring.Text = "";

            foreach(string actor in m.Actors)
            {
                Starring.Text += actor + Environment.NewLine;
            }

            Director.Text = m.Director;
            Released.Text = m.Year.ToString();
            ParentalRating.Text = m.Certification;
            Description.Text = m.Description;
            Poster.Load(m.Poster);

            XDocument doc = System.Xml.Linq.XDocument.Load("paths.xml");
            string path;
            moviePath = null;

            foreach (XElement element in doc.Element("paths").Elements())
            {
                path = findMovie(element.Value, m.Title.Trim().Replace(" ","_"));
                if(path !=null)
                {
                    moviePath = path;
                    break;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e) // Do we allow multi word tags?
        {
            //
            
            // Add tag to collection
            if(NewTag.Text.Length > 0) // What if it's just blank spaces?
            {
                if(Tags.Text.Equals("Add a tag...") )
                {
                    Tags.Text = NewTag.Text;
                    
                }
                else
                {
                    Tags.Text += (", " + NewTag.Text);

                    // Add NewTag.Text to tags of movie
                    
                }
            }

            // Add NewTag.Text to XML
            XDocument xdoc = XDocument.Load("movies.xml");

            foreach(XElement xel in xdoc.Root.Elements())
            {
                if(xel.Element("title").Value.ToString().Equals(Title.Text))
                {
                    xel.Add(new XElement("tag", NewTag.Text));
                }
            }


            
            xdoc.Save("movies.xml"); NewTag.Text = "";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if(moviePath != null)
            {
                Process.Start("wmplayer.exe", moviePath);
            }
            else
            {
                MessageBox.Show("Could not find " + m.Title + " in any directory." + Environment.NewLine + "Try adding another directory through the settings page");
            }

        }

        private string findMovie(string path,string title)
        {  
            string regex = @".*" + @title + @"\.mp4";
            Regex r = new Regex(regex);
        
            string[] dir = Directory.GetFiles(path, "*.mp4");

            foreach(string file in dir)
            {
                if(r.IsMatch(file))
                {
                    return file;
                }
            }
    
            return null;
        }

        private void Poster_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Open Movie Editor w/ this movie
            MovieEditor me = new MovieEditor();
            me.Show();
            me.generateFields(m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Confirm then delete
            MovieDeleter md = new MovieDeleter(null);

            md.Result = m;
            if(md.deleteMovie())
            {
                Close();
            }
            

        }

        private void NewTag_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                button1_Click(sender, e);
            }
        }
    }
}
