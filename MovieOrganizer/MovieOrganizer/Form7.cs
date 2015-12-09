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
    // TODO: This could probably look a little better. Class Interaction could be smoother too.
    public partial class MovieDeleter : Form
    {
        Movie result;
        private TabScreen caller;
        bool found = false;
        public MovieDeleter(TabScreen caller)
        {
            InitializeComponent();
            this.caller = caller;
        }

        private void Searcher_Click(object sender, EventArgs e)
        {
            // Run An Exact Text Search for MovieTarget.Text
            result = caller.getMovie(MovieTarget.Text);
            if (result != null)
            {
                TargetPoster.Load(result.Poster); found = true;
            }
            else
            {
                MessageBox.Show("Could not find that movie. Make sure your title is exact.", "Movie Not Found");
            }
        }

        private void MovieDeleter_Load(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (found)
            {
                DialogResult makeSure = MessageBox.Show("The movie \"" + MovieTarget.Text + "\" will be deleted. Are you sure you want to delete this movie?", "Confirm Action", MessageBoxButtons.YesNo);
                if (makeSure == DialogResult.Yes)
                {
                    // Remove Title from xml db
                    removeNode();

                    // Reset
                    found = false;
                    TargetPoster.Image = null;
                    MovieTarget.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Please find the movie you want to delete first.", "No Movie Selected");
            }
        }

        private void removeNode()
        {
            // Also decrement tags
            XmlDocument doc = new XmlDocument();
            string path = "movies.xml";
            doc.Load(path);

            XmlNode node = doc.SelectSingleNode("/movielist");

            foreach(XmlNode curr in node.ChildNodes)
            {
                if (curr.ChildNodes[0].InnerText.Trim().Equals(MovieTarget.Text))
                {
                    node.RemoveChild(curr);
                }
            }

            // Let's just lower case all of it just in case
            string[] actors = result.Actors.ToArray();
            string[] genres = result.Genres.ToArray();
            for (int i = 0; i < actors.Length; i++)
            {
                actors[i] = actors[i].ToLower();
            }

            for (int i = 0; i < genres.Length; i++)
            {
                genres[i] = genres[i].ToLower();
            }
            string director = result.Director.ToLower();
            // we have actors, genres to play with, also DirectorBox.Text
            XDocument xdoc = XDocument.Load("tags.xml");
            List<string> movieAttrs = new List<string>();
            movieAttrs.AddRange(actors); movieAttrs.AddRange(genres); movieAttrs.Add(director);

            foreach (string s in movieAttrs)
            {
                foreach (XElement ell in xdoc.Root.Elements())
                {
                    if (ell.Element("text").Value.ToString().ToLower().Equals(s))
                    {
                        ell.Element("frequency").Value = (Int32.Parse(ell.Element("frequency").Value.ToString()) - 1).ToString();
                        found = true; // we found our attrib in the xml
                    }
                }
            }
            xdoc.Save("tags.xml");


           

            doc.Save(path);
        }

        private void MovieDeleter_DragDrop(object sender, DragEventArgs e)
        {
            Movie m = (Movie)e.Data.GetData(typeof(Movie));
            MovieTarget.Text = m.Title.Trim();


            Searcher_Click(sender, e);
            // Call searcher_click
        }

        private void MovieDeleter_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Movie)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
