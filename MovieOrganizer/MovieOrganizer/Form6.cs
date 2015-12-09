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

            List<string> movieGenres = new List<string>();
            List<string> allGenres = new List<string>();
            allGenres.Add("SCI-FI"); allGenres.Add("CRIME"); allGenres.Add("ROMANCE"); allGenres.Add("ANIMATION");
            allGenres.Add("MUSIC"); allGenres.Add("COMEDY"); allGenres.Add("WAR"); allGenres.Add("HORROR");
            allGenres.Add("FILM-NOIR"); allGenres.Add("WESTERN"); allGenres.Add("THRILLER"); allGenres.Add("ADVENTURE");
            allGenres.Add("MYSTERY"); allGenres.Add("SHORT"); allGenres.Add("DRAMA"); allGenres.Add("ACTION");
            allGenres.Add("SPORT"); allGenres.Add("FANTASY"); allGenres.Add("FAMILY"); allGenres.Add("HISTORY");
            allGenres.Add("DOCUMENTARY"); allGenres.Add("MUSICAL"); allGenres.Add("BIOGRAPHY");


            movieGenres.AddRange(GenreText.Text.Replace(" ", "").ToUpper().Split(','));
            if (!movieGenres.Except(allGenres).Any())
            {
                // Now we see if all of movieGenres are in AllGenres
                if (TitleBox.Text.Length > 0 && !alreadyExists(TitleBox.Text))
                {
                    try
                    {
                        year = Int32.Parse(YearBox.Text);
                        if (year < 9999 && year > 1500) // Make sure the year makes sense.
                        {
                            // Keep going. Check Time Next
                            try
                            {
                                time = Int32.Parse(TimeBox.Text);
                                if (time > 0)
                                {
                                    // Now Let's add the Movie's Info!
                                    if (!(sender is MovieEditor))
                                    {
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
                                        MovieEditor s = (MovieEditor)sender;
                                        s.build();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("The movie must have some kind of length!", "Time Too Short");
                                }

                            }
                            catch (FormatException)
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
            else
            {
                MessageBox.Show("You may not introduce new genres.", "Genre Undefined");
            }
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
            if (RatingList.SelectedIndex >= 0)
                ratingNode.InnerText = RatingList.Items[RatingList.SelectedIndex].ToString();
            else
                ratingNode.InnerText = "0";

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

            // Multiple Tag Nodes
            List<XmlNode> tagNodes = new List<XmlNode>();
            string[] tags = TagBox.Text.Split(',');
            foreach(string tag in tags)
            {
                XmlNode tagNode = doc.CreateElement("tag");
                tagNode.InnerText = tag.Trim();
                tagNodes.Add(tagNode);
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

            // Add all tag nodes
            foreach(XmlNode tagNode in tagNodes)
            {
                node.AppendChild(tagNode);
            }

            node.AppendChild(ownedNode);
            node.AppendChild(posterNode);
            node.AppendChild(certNode);
            node.AppendChild(descNode);


            doc.DocumentElement.AppendChild(node);
            doc.Save("movies.xml");


            // Also increment tags: Genre, Actor, Director
            

            // Let's just lower case all of it just in case
            for(int i = 0; i <actors.Length; i++)
            {
                actors[i] = actors[i].ToLower();
            }

            for(int i = 0; i<genres.Length; i++)
            {
                genres[i] = genres[i].ToLower();
            }
            string director = DirectorBox.Text.ToLower();
            // we have actors, genres to play with, also DirectorBox.Text

            // This adds frequencies to already existing tags. We need a way to add NEW tags
            // Let's join up all of the strings in our actors, genres, director. These are the "attributes" of the film
            List<string> movieAttrs = new List<string>();
            movieAttrs.AddRange(actors); movieAttrs.AddRange(genres); movieAttrs.Add(director);

            XDocument xdoc = XDocument.Load("tags.xml");

            // For every attr, let's find the tags that matches. If we don't find a match, we add our own
            bool found = false;

            foreach(string s in movieAttrs)
            {
                found = false; // this string s is not found
                foreach(XElement ell in xdoc.Root.Elements())
                {
                    if(ell.Element("text").Value.ToString().ToLower().Equals(s))
                    {
                        ell.Element("frequency").Value = (Int32.Parse(ell.Element("frequency").Value.ToString()) + 1).ToString();
                        found = true; // we found our attrib in the xml
                    }
                }
                if(!found) // that tag was not in the xml file
                {
                    if(actors.Contains(s))
                    {
                        XElement tag = new XElement("tag");
                        tag.Add(new XElement("type", "actor"));
                        tag.Add(new XElement("text", s));
                        
                        tag.Add(new XElement("frequency", "1"));
                        xdoc.Root.Add(tag);
                        

                    }

                    if(director.Equals(s))
                    {
                        XElement tag = new XElement("tag");
                        tag.Add(new XElement("type", "director"));
                        tag.Add(new XElement("text", s));
                        
                        tag.Add(new XElement("frequency", "1"));
                        xdoc.Root.Add(tag);
                    }
                }
            }
            xdoc.Save("tags.xml");

        }

        private void RatingSelecter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MovieAdderForm_Validated(object sender, EventArgs e)
        {

        }
    }
}
