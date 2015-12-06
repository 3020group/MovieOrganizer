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
    public partial class MovieEditor : MovieAdderForm
    {
        // The main bug is that the database is still screwed up (missing attributes)
        Movie m;
        public MovieEditor()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            RatingSelecter.SelectedIndex = -1;
            m = null;
            this.AllowDrop = true;
            FinalAdder.Text = "Apply Changes";
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).ReadOnly = true;
                else if (ctrl is ComboBox)
                    ((ComboBox)ctrl).Enabled = false;
                else if (ctrl is CheckBox)
                    ((CheckBox)ctrl).Enabled = false;
                else if (ctrl is Button)
                    ((Button)ctrl).Enabled = false;
            }
        }



        private void button1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void MovieEditor_DragEnter(object sender, DragEventArgs e)
        {
          //  MessageBox.Show("Something");
            if (e.Data.GetDataPresent(typeof(Movie) ) ) 
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MovieEditor_MouseEnter(object sender, EventArgs e)
        {
        }

        private void MovieEditor_DragDrop(object sender, DragEventArgs e)
        {

            m = (Movie)e.Data.GetData(typeof(Movie));
          //  MessageBox.Show(m.Title);

            // The Movie Data Has Been Captured. Let's Now Fill The Data Entries
            TitleBox.Text = m.Title;
            YearBox.Text = m.Year.ToString();
            DirectorBox.Text = m.Director;
            TimeBox.Text = m.Length.ToString();
            RatingList.SelectedIndex = m.Rating;

            // Multiple Genres
            // We recieved a list of strings
            foreach(string genre in m.Genres)
            {
                GenreText.Text += (genre + ",");
            }
            GenreText.Text = GenreText.Text.Remove(GenreText.Text.Length - 1);


            // Multiple Actors
            // We recieved a list of strings
            foreach (string actor in m.Actors)
            {
                ActorText.Text += (actor + ",");
            }
            ActorText.Text = ActorText.Text.Remove(ActorText.Text.Length - 1);


            Poster.Load(m.Poster);
            PosterPath.Text = "<Loaded>";
            button1.Text = "Change...";
            Console.WriteLine(m.Owned);
            OwnedCheck.Checked = m.Owned;

            // Enumerate Certifications G PG PG-13 R
            Dictionary<string, int> certs = new Dictionary<string, int>();
            certs.Add("G", 0);
            certs.Add("PG", 1);
            certs.Add("PG-13", 2);
            certs.Add("R", 3);


            if(m.Certification != null)
            {
                RatingSelecter.SelectedIndex = certs[m.Certification];
            }


            if (m.Description != null)
            {
                DescriptionText.Text = m.Description;
            }





            // Now we can re-enable editing:
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).ReadOnly = false;
                else if (ctrl is ComboBox)
                    ((ComboBox)ctrl).Enabled = true;
                else if (ctrl is CheckBox)
                    ((CheckBox)ctrl).Enabled = true;
                else if (ctrl is Button)
                    ((Button)ctrl).Enabled = true;
            }
        }



        // Finally, Press the button to edit attributes then close window. This is the last part
        protected override void FinalAdder_Click(object sender, EventArgs e)
        {
                DialogResult makeSure = MessageBox.Show("The movie \"" + m.Title + "\" will be changed. Are you sure you want to edit this movie?", "Confirm Action", MessageBoxButtons.YesNo);
                if (makeSure == DialogResult.Yes)
                {
                    // Remove Title from xml db
                    editNode();

                    // Reset
                    Close();
                }            
        }




        // Update all XML Attributes from entered data
        // Let's get the XML Attribute that corresponds to this title (All Titles are Unique)

        // Let's just do it the greasy way: Remove the old node and build a new one from the input data
        private void editNode()
        {
            XmlDocument doc = new XmlDocument();
            string path = "movies.xml";
            doc.Load(path);

            XmlNode node = doc.SelectSingleNode("/movielist");

            foreach (XmlNode curr in node.ChildNodes)
            {
                if (curr.ChildNodes[0].InnerText.Equals(m.Title))
                {
                    node.RemoveChild(curr);
                }
            }
            //doc.Save(path);

            base.addMovie(doc);
            doc.Save(path);
        }
        // Take drop method: Accept Movie from MoviePanel
    }


   
}
