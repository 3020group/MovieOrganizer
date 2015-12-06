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
using System.Text.RegularExpressions;

namespace MovieOrganizer
{
    // This form looks like and runs like welfare. Handle Enter, Better Input Val. Losing Text, Sizing?. Etc
    // Also the database is still fucked and there are loads of bugs (meta)

    /* TODO: - Make the window bigger so it doesn't look like an 8 year old made it
             - Rethink how Genres and Actors work so the Editor can inherit them smoothly (Add/Remove)
             - Implement Edit Window to Inherit All of this stuff (Pretty Simple).
             */
    public partial class MovieAdderForm : Form
    {
        // This is what will be used to run the Movie Adder.

        public MovieAdderForm()
        {
            InitializeComponent();
            RatingSelecter.SelectedIndex = 0;
        }

        private void MovieAdderForm_Load(object sender, EventArgs e)
        {

        }

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = PosterSelector.ShowDialog();

            if (res == DialogResult.OK) // Test result.
            {
                string file = PosterSelector.FileName;
                try
                {
                    Poster.Image = Image.FromFile(file);
                    PosterPath.Text = file;
                }
                catch (Exception)
                {
                    MessageBox.Show("Please select a valid Image File, or use the default image.", "Incorrect File Type");
                }

            }
        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {
        //    if (TitleBox.Text.Length > 13)
       //     {
        //        Size size = TextRenderer.MeasureText(TitleBox.Text, TitleBox.Font);
         //       TitleBox.Width = size.Width;
        //        TitleBox.Height = size.Height;
          //  }
        }

        protected virtual void FinalAdder_Click(object sender, EventArgs e)
        {
            int year = 0; int time = 0;
            if(TitleBox.Text.Length > 0 && !alreadyExists(TitleBox.Text))
            {
                try
                {
                    year = Int32.Parse(YearBox.Text);
                    if(year < 9999 && year > 1500) // Make sure the year makes sense.
                    {
                       // Keep going. Check Time Next
                       try
                        {
                            time = Int32.Parse(TimeBox.Text);
                            if(time > 0)
                            {
                                // Now Let's add the Movie's Info!
                                DialogResult makeSure = MessageBox.Show("Movie \"" + TitleBox.Text + "\" will be added. Make sure all information is correct before pressing OK", "Are You Sure?", MessageBoxButtons.OKCancel);
                                if (makeSure == DialogResult.OK)
                                {
                                    XmlDocument doc = new XmlDocument();
                                    string path = "movies.xml";
                                    doc.Load(path);
                                    addMovie(doc);
                                    doc.Save(path);
                                    foreach (Control ctrl in this.Controls)
                                    {
                                        if (ctrl is TextBox)
                                            (ctrl as TextBox).Clear();
                                    }
                                    Poster.Image = null;
                                    RatingList.SelectedIndex = -1;
                                    RatingSelecter.SelectedIndex = -1;
                                    OwnedCheck.Checked = false;
                                    PosterPath.Text = "None";
                                }
                            }
                            else
                            {
                                MessageBox.Show("The movie must have some kind of length!", "Time Too Short");
                            }

                        }
                        catch(FormatException)
                        {
                            time = 0;
                            MessageBox.Show("You need to enter the runtime as an integer.", "Runtime Format Not Permitted");
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Try Picking a year closer to our time.", "Year too far away");
                    }
                }
                catch (FormatException)
                {
                    year = 0;
                    MessageBox.Show("You need to enter a year as an integer.", "Year Format Not Permitted");
                }
            }
            else
            {
                MessageBox.Show("You need to choose a unique title of at least one character.", "Title Not Permitted");
            }
            // Put All The Fields Together, Validate and if(valid) Add a new Movie Node to XML File.
        }

        private bool alreadyExists(string newTitle)// Make sure username isn't in the DB
        {
            // Figure out how to iterate through XML doc and find names
            XmlDocument xdoc = new XmlDocument();

            xdoc.Load("movies.xml");

            XmlElement root = xdoc.DocumentElement;
            XmlNodeList movieNodes = root.SelectNodes("/movies/movie");

            bool found = false;
            for (int i = 0; (i < movieNodes.Count && !found); i++)
            {
                if (movieNodes.Item(i)["title"].Equals(newTitle))
                {
                    found = true;
                }
            }
            return found;
        }

        private void YearBox_TextChanged(object sender, EventArgs e)
        {
            // Yeah I'm just going to do this at final validation. Regex or Keypress, either way it turns into lots of work
            // (Maybe I can make this fancy another time)
        }
        
        protected void addMovie(XmlDocument doc)
        {
            // Given all of our attributes, let's add this movie to the XML Database
           // string path = "movies.xml";
           // XmlDocument doc = new XmlDocument();
           // doc.Load(path);

            XmlNode node = doc.CreateNode(XmlNodeType.Element, "movie", null);


            // Adding title
            XmlNode titleNode = doc.CreateElement("title");
            titleNode.InnerText = TitleBox.Text;

            // Adding year
            XmlNode yearNode = doc.CreateElement("year");
            yearNode.InnerText = YearBox.Text;

            // Adding runtime
            XmlNode lenNode = doc.CreateElement("length");
            lenNode.InnerText = TimeBox.Text;

            // Adding director
            XmlNode dirNode = doc.CreateElement("director");
            dirNode.InnerText = DirectorBox.Text;

            // Adding rating
            XmlNode ratingNode = doc.CreateElement("rating");
            ratingNode.InnerText = RatingList.Items[RatingList.SelectedIndex].ToString();

            // Multiple Genre Nodes
            List<XmlNode> genreNodes = new List<XmlNode>();
            string[] genres = GenreText.Text.Split(',');
            foreach(string genre in genres)
            {
                XmlNode genreNode = doc.CreateElement("genre");
                genreNode.InnerText = genre.Trim();
                genreNodes.Add(genreNode);
            }

            // Multiple Actor Nodes
            List<XmlNode> actorNodes = new List<XmlNode>();
            string[] actors = ActorText.Text.Split(',');
            foreach(string actor in actors)
            {
                XmlNode actorNode = doc.CreateElement("actor");
                actorNode.InnerText = actor.Trim();
                actorNodes.Add(actorNode);
            }


            // Adding isOwned
            XmlNode ownedNode = doc.CreateElement("owned");
            string owned = "false";
            if(OwnedCheck.Checked)
            {
                owned = "true";
            }
            ownedNode.InnerText = owned;

            // Adding poster path
            XmlNode posterNode = doc.CreateElement("poster");
            string poster = "notFound.jpg";
            if (!PosterPath.Text.Equals("None") && !PosterPath.Text.Equals("<Loaded>")) 
            {
                poster = PosterPath.Text;
            }
            posterNode.InnerText = poster;

            //Adding certification
            XmlNode certNode = doc.CreateElement("certification");
            certNode.InnerText = RatingSelecter.Items[RatingSelecter.SelectedIndex].ToString();

            XmlNode descNode = doc.CreateElement("description");
            descNode.InnerText = DescriptionText.Text;



            // We need to append all the child nodes based on component data

            node.AppendChild(titleNode);
            node.AppendChild(yearNode);
            node.AppendChild(lenNode);
            node.AppendChild(dirNode);
            node.AppendChild(ratingNode);

            // Add All Genre Nodes
            foreach(XmlNode genreNode in genreNodes)
            {
                node.AppendChild(genreNode);
            }

            // Add all Actor Nodes
            foreach(XmlNode actorNode in actorNodes)
            {
                node.AppendChild(actorNode);
            }

            node.AppendChild(ownedNode);
            node.AppendChild(posterNode);
            node.AppendChild(certNode);
            node.AppendChild(descNode);


            doc.DocumentElement.AppendChild(node);
           // doc.Save(path);
      
        }
    }
}
