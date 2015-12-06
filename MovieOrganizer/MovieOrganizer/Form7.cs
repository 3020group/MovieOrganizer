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

namespace MovieOrganizer
{
    // TODO: This could probably look a little better. Class Interaction could be smoother too.
    public partial class MovieDeleter : Form
    {
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
            Movie result = caller.getMovie(MovieTarget.Text);
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
