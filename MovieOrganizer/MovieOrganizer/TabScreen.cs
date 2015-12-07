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
    public partial class TabScreen : Form
    {
        private string username;
        private string imageLocation;
        private List<List<Movie>> curSearchPages;
        private List<Tag> tags;
        private Boolean supressEvents;

        private enum SearchType {Exact, All, Contains }
        private enum SortBy { Alphabetical,Year,Rating }

        //set up the dictionary of sorting patterns 
        private Dictionary<string, SortBy> sortBy;

        // Adding to settings tab: Add, Edit, Delete a movie options
        // Add: Blank form where you insert title, pic, desc, etc...
        // Edit: inherit from add except all fields are filled by dragging & dropping a movie into the form: it will fill all fields
        // Delete: Just search for a title and if it exists, it will be removed
        public TabScreen(string username,string imageLocation)
        {
            InitializeComponent();

            this.username = username;
            this.imageLocation = imageLocation;

            //set up the profile area
            usernameLabel.Text = username;
            profilePictureBox.ImageLocation = imageLocation;
            profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            //make the tabe take up the top of the screeen
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(tabControl.Width / tabControl.TabCount-1, 30); //need to take away 1 so the tabs dont take up too much space.

            //set up the dictionary of sorting patterns 
            sortBy = new Dictionary<string, SortBy>();
            sortBy.Add("Alphabetical", SortBy.Alphabetical);
            sortBy.Add("Rating", SortBy.Rating);
            sortBy.Add("Year", SortBy.Year);

            supressEvents = false;

            tags = getTags();
        }

        private void TabScreen_Resize(object sender, EventArgs e)
        {

            int newWidth = tabControl.Width / tabControl.TabCount - 1;

            if(newWidth <= 0)
            {
                newWidth = 0;
            }

            if (tabControl.SelectedTab.Equals(tabControl.TabPages["suggestionsTab"]))
            {
                foreach(Panel p in tabControl.TabPages["suggestionsTab"].Controls[0].Controls)
                {
                    p.Size = new Size((9 * suggestFlow.Size.Width) / 10, 225);
                }
            }

            tabControl.ItemSize = new Size(newWidth, 30);
            
        }

        private void settingsTab_Enter(object sender, EventArgs e)
        {
            nameBox.Text = username;

            //make the picture corrct for the profile
            picturePathBox.Text = imageLocation;
            pPictureEditBox.ImageLocation = imageLocation;
            pPictureEditBox.SizeMode = PictureBoxSizeMode.StretchImage;

            loadPaths(dirBox);

            //need to check if anyone can create a new user
            var doc = System.Xml.Linq.XDocument.Load("settings.xml");

            if (doc.Element("allowCreate").Value.Equals("true"))
            {
                pLockBox.Checked = true;
            }

            doc = System.Xml.Linq.XDocument.Load("users.xml");

            foreach(XElement element in doc.Element("users").Elements())
            {
                if (username.Equals(element.Element("name").Value))
                {
                    if (element.Element("is_admin").Value.Equals("false"))
                    {
                        
                        pLockPanel.Visible = false;
                    }
                }
            }
        }

        private void collectionTab_Enter(object sender, EventArgs e)
        {
            sortComboBox.Text = "Alphabetical";
        }

        private void suggestionsTab_Enter(object sender, EventArgs e)
        {
            suggestFlow.Controls.Clear();

            generateSuggestions();
        }

        private void generateSuggestions()
        {
            string suggestText="";

            foreach(Tag t in tags)
            {
                Panel p = new Panel();

                formatSuggestionPanel(p);
                
                //build the text saying what the movie is
                suggestText += "Because you watched " + getOwnedMovie(t);

                if(t.Type.Equals("actor"))
                {
                    suggestText += " you might like more movies with " + t.Text;
                }
                else if(t.Type.Equals("director"))
                {
                    suggestText += " you might like more movies directed by " + t.Text;
                }
                else if(t.Type.Equals("genre") )
                {
                    suggestText += " you might like more " + t.Text+" movies";
                }
                else
                {
                    //It shouldent reach here
                    suggestText = null;
                }
                   

                //need to add a label to tell what the suggestion is, and then add a flowlayoutpanel to store the movies
                Label l = new Label();
                l.Text = suggestText;
                l.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                l.Dock = DockStyle.Top;

                Panel seperator = new Panel();
                seperator.Size = new Size((9 * suggestFlow.Size.Width) / 10, 30);
                seperator.BackColor = Color.Transparent;
                seperator.Dock = DockStyle.Top;

                FlowLayoutPanel innerFlow = new FlowLayoutPanel();
                innerFlow.AutoScroll = true;
                innerFlow.AutoSize = false;
                innerFlow.WrapContents = false;

                p.Controls.Add(innerFlow);
                innerFlow.Dock = DockStyle.Fill;
                populateSuggestions(t,innerFlow);

                p.Controls.Add(seperator);
                p.Controls.Add(l);
                suggestFlow.Controls.Add(p);

                suggestText = "";
            }
        }

        private void formatSuggestionPanel(Panel p)
        {
            p.Size = new Size((9 * suggestFlow.Size.Width) / 10, 225);
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Margin = new Padding((suggestFlow.Size.Width - p.Size.Width) / 2, 0,0,30);
        }

        private List<Tag> getTags()
        {
            List<Tag> tags = new List<Tag>();
            List<Tag> suggest = new List<Tag>();
            Random r = new Random();
            int numGenre = 0;

            XDocument doc = System.Xml.Linq.XDocument.Load("tags.xml");
            List<Movie> movies = new List<Movie>();

            foreach (XElement element in doc.Element("tags").Elements())
            {
                tags.Add(new Tag(element));
            }

            tags.Sort();
            tags.Reverse(); //needs to be reverse because it should be descending 

            //now we need to pick 5 items from the list
            for (int i = 0; i < tags.Count; i++)
            {
                if (r.Next(0, 10) > 5 || (5 - suggest.Count) >= tags.Count - i - 1)
                {
                    

                    if (tags[i].Type.Equals("genre") && numGenre < 2 && moreExist(tags[i]))
                    {
                        suggest.Add(tags[i]);
                        numGenre++;
                    }
                    else if(!tags[i].Type.Equals("genre") && moreExist(tags[i]))
                    {
                        suggest.Add(tags[i]);
                    }

                    
                }
                if (suggest.Count == 5)
                {
                    break;
                }
            }

            return suggest;
        }

        private Boolean moreExist(Tag t)
        {
            XDocument doc = System.Xml.Linq.XDocument.Load("movies.xml");
          
            foreach (XElement element in doc.Element("movielist").Elements())
            {
                if(element.Element(t.Type).Value.Equals(t.Text) && element.Element("owned").Value.Equals("false"))
                {
                    return true;
                }
            }

            return false;
        }

        private void populateSuggestions(Tag t,FlowLayoutPanel flow)
        {
            XDocument doc = System.Xml.Linq.XDocument.Load("movies.xml");
            List<Movie> movies = new List<Movie>();
            int j = 0;

            foreach (XElement element in doc.Element("movielist").Elements())
            {
                if (j == 10)
                {
                    break;
                }
                else if (element.Element(t.Type).Value.Equals(t.Text))
                {
                    movies.Add(new Movie(element));
                    j++;
                }
            }

            foreach (Movie movie in movies)
            {
                moviePanel p = new moviePanel(movie, 130, 140);
                p.Anchor = AnchorStyles.None;
                p.Dock = DockStyle.None;
                p.Margin = new Padding(20, 5, 0, 0);
                p.BorderStyle = BorderStyle.FixedSingle;
                flow.Controls.Add(p);
            }
        }

        private string getOwnedMovie(Tag t)
        {
            Console.WriteLine(">>" + t.Text);

            var doc = System.Xml.Linq.XDocument.Load("movies.xml");

            foreach (var element in doc.Element("movielist").Elements())
            {
                if(element.Element(t.Type).Value.Equals(t.Text) && element.Element("owned").Value.Equals("true"))
                {
                    return "\""+element.Element("title").Value+"\"";
                }
            }

            return null;
        }

        private void loadPaths(TextBox box)
        {
            string newText = "";
            var doc = System.Xml.Linq.XDocument.Load("paths.xml");

            foreach (var element in doc.Element("paths").Elements())
            {
                newText += element.Value+Environment.NewLine;
            }

            box.Text = newText;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            DialogResult result = fb.ShowDialog();

            if(result == DialogResult.OK)
            {
                //Console.WriteLine(fb.SelectedPath);
                addToPath(fb.SelectedPath);
            }

            loadPaths(dirBox);
        
        }

        private void addToPath(string newPath)
        {
            var doc = System.Xml.Linq.XDocument.Load("paths.xml");
            System.Xml.Linq.XElement paths = doc.Element("paths");
            paths.Add(new System.Xml.Linq.XElement("path", newPath));
            doc.Save("paths.xml");
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Images (*.jpg)|*.jpg"; 
            DialogResult result = open.ShowDialog();

            if (result == DialogResult.OK)
            {
                imageLocation = open.FileName;
                picturePathBox.Text = imageLocation;
                profilePictureBox.ImageLocation = imageLocation;
                pPictureEditBox.ImageLocation = imageLocation;

                var doc = System.Xml.Linq.XDocument.Load("users.xml");

                foreach (var element in doc.Element("users").Elements())
                {
                    if (element.Element("name").Value.Equals(username))
                    {
                        //now we have the node were looking for
                        element.Element("pic").Value = imageLocation;
                    }
                }

                doc.Save("users.xml");
            }
           
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(exactRadio.Checked)
            {
                curSearchPages = populateResults(textBox1.Text, SearchType.Exact,false,sortBy[comboBox1.Text]);
            }
            else
            {
                curSearchPages = populateResults(textBox1.Text, SearchType.Contains,false, sortBy[comboBox1.Text]);
            }
            

            if(curSearchPages.Count>0)
            {
                populatePage(resultsPanel, curSearchPages[0]);
            }

            searchPageCombo.Items.Clear();
            IEnumerable<int> pageRange = Enumerable.Range(0, curSearchPages.Count);

            foreach (int i in pageRange)
            {
                searchPageCombo.Items.Add(i+1);
            }

            supressEvents = true;
            searchPageCombo.SelectedIndex = 0;
            supressEvents = false;

            searchNumPages.Text = curSearchPages.Count.ToString();

        }

        private List<List<Movie>> populateResults(string search, SearchType searchType,Boolean ownedOnly,SortBy sortBy)
        {

            List<List<Movie>> pages;
            List<Movie> movies= new List<Movie>();
            XDocument doc = System.Xml.Linq.XDocument.Load("movies.xml");


            foreach (XElement element in doc.Element("movielist").Elements())
            {
                if(searchType == SearchType.Exact)
                {
                    if (string.Equals(element.Element("title").Value.Trim(), search, StringComparison.OrdinalIgnoreCase) && (!ownedOnly || (ownedOnly && element.Element("owned").Value.Equals("true"))))
                    {
                        //we have found the node were looking for
                        movies.Add(new Movie(element));
                    }
                }
                else if(searchType == SearchType.All && (!ownedOnly || (ownedOnly && element.Element("owned").Value.Equals("true"))))
                {
                    movies.Add(new Movie(element));
                }
                else if(searchType == SearchType.Contains && search.Trim().Length != 0)
                {
                    if (element.Element("title").Value.ToLower().Contains(search.ToLower()))
                    {
                        //we have found the node were looking for
                        movies.Add(new Movie(element));
                    }
                }
            }

            Console.WriteLine(movies.Count);

            //now we can sort the movies before splitting the into pages
            if(sortBy == SortBy.Alphabetical)
            {
                movies.Sort((x,y)=>x.Title.CompareTo(y.Title));
            }
            else if(sortBy == SortBy.Rating)
            {
                movies.Sort((x, y) => x.Rating.CompareTo(y.Rating));
            }
            else //sort by year
            {
                movies.Sort((x, y) => x.Year.CompareTo(y.Year));
            }

            Console.WriteLine(movies.Count);

            pages = splitIntoPages(movies);

            return pages;
        }

        private List<List<Movie>> splitIntoPages(List<Movie> movies)
        {
            List<List<Movie>> pages = new List<List<Movie>>();
            List<Movie> page = new List<Movie>();

            int i = 0;
            foreach(Movie m in movies)
            {
                page.Add(m);
                
                if (i == 100)
                {
                    pages.Add(page);
                    i = 0;
                    page = new List<Movie>();
                }
                i++;

            }
            pages.Add(page);

            return pages;
        }

        private void populatePage(FlowLayoutPanel flow,List<Movie> page)
        {
            flow.Controls.Clear();
 
            //movies need to be added to moviePanels and put on the panel
            foreach (Movie movie in page)
            {
                //TODO: add option for custom moviePanel sizes
                moviePanel p = new moviePanel(movie,130,140);
                p.Anchor = AnchorStyles.None;
                p.Dock = DockStyle.None;
                p.Margin = new Padding(20, 5, 0, 0);
                p.BorderStyle = BorderStyle.FixedSingle;
                flow.Controls.Add(p);
            }
        }

        private void watchedCkeckBox_CheckedChanged(object sender, EventArgs e)
        {
            updateCollection();
        }

        private void updateCollection()
        {
            string filter = ""; //filter should be constructed based on filter settings

            //we dont want to keep calling updateCollection so we need to supress events
            supressEvents = true;
            pageCombo.Text = "0";
            supressEvents = false;

           curSearchPages = populateResults(filter,SearchType.All,ownedCheckBox.Checked,sortBy[sortComboBox.Text]);

            numPages.Text = curSearchPages.Count.ToString();
            if (curSearchPages.Count > 0)
            {
                populatePage(collectionPanel, curSearchPages[0]);
            }
            pageCombo.Items.Clear();
            IEnumerable<int> pageRange = Enumerable.Range(0, curSearchPages.Count);

            foreach(int i in pageRange)
            {
                pageCombo.Items.Add(i+1);
            }
        }

        private void ownedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            updateCollection();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCollection();
        }

        private void nameBox_Validating(object sender, CancelEventArgs e)
        {
            Regex re = new Regex(@"^[a-z|A-Z]\w\w+$");

            if(!re.IsMatch(nameBox.Text))
            {
                e.Cancel=true;
                nameBoxErrorProvider.SetError(nameBox, "Invalid username");
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_Validating(object sender, CancelEventArgs e)
        {
            Regex re = new Regex(@"^\w+\d(\d*|\w*)+$");

            if (!re.IsMatch(passwordBox.Text))
            {
                e.Cancel = true;
                nameBoxErrorProvider.SetError(passwordBox, "Invalid password");
            }
        }

        private void nameBox_Validated(object sender, EventArgs e)
        {
            nameBoxErrorProvider.SetError(nameBox, "");
        }

        private void passwordBox_Validated(object sender, EventArgs e)
        {
            nameBoxErrorProvider.SetError(passwordBox, "");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!textBox2.Text.Equals(passwordBox.Text))
            {
                e.Cancel = true;
                nameBoxErrorProvider.SetError(textBox2, "Passwords do not match");
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            nameBoxErrorProvider.SetError(textBox2, "");
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text.Equals("") && !textBox2.Equals(""))
            {
                passwordBox.Focus();
                nameBoxErrorProvider.SetError(passwordBox, "Invalid password");
            }
            else if (!textBox2.Text.Equals(passwordBox.Text))
            {
                textBox2.Focus();
                nameBoxErrorProvider.SetError(textBox2, "Passwords do not match");
            }
            else
            {
                nameBoxErrorProvider.SetError(passwordBox, "");
                nameBoxErrorProvider.SetError(textBox2, "");

                //at this point everything has been updated
                //now we need to update the xml to reflect changes

                var doc = System.Xml.Linq.XDocument.Load("users.xml");

                foreach (var element in doc.Element("users").Elements())
                {
                    if (element.Element("name").Value.Equals(username))
                    {
                        //now we have the node were looking for
                        if(!username.Equals(nameBox.Text))
                        {
                            username = nameBox.Text;
                            usernameLabel.Text = username;
                            element.Element("name").Value = username;
                        }

                        if(!passwordBox.Text.Equals(""))
                        {
                            element.Element("password").Value = passwordBox.Text;
                        }
                    }
                }

                doc.Save("users.xml");
            }
        }


        private void pageCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!supressEvents)
            {
                populatePage(collectionPanel, curSearchPages[Int32.Parse(pageCombo.Text)-1]);
            }
        }

        private void containsRadio_CheckedChanged(object sender, EventArgs e)
        {
                searchButton_Click(sender, e);
        }

        private void exactRadio_CheckedChanged(object sender, EventArgs e)
        {
                searchButton_Click(sender, e);
        }

        private void newProfilebutton_Click(object sender, EventArgs e)
        {
            NewUser nu = new NewUser(null);
            nu.Show();
        }

        private void pLockBox_CheckedChanged(object sender, EventArgs e)
        {
            //need to check if anyone can create a new user
            var doc = System.Xml.Linq.XDocument.Load("settings.xml");

            if (pLockBox.Checked)
            {
                doc.Element("allowCreate").Value = "true";
            }
            else
            {
                doc.Element("allowCreate").Value = "false";
            }

            doc.Save("settings.xml");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!supressEvents)
            {
                searchButton_Click(sender, e);
            }
        }

        private void searchTab_Enter(object sender, EventArgs e)
        {
            supressEvents = true;
            comboBox1.SelectedIndex = comboBox1.FindStringExact("Alphabetical");
            supressEvents = false;
        }

        private void searchPageCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!supressEvents)
            {
                populatePage(resultsPanel, curSearchPages[((int)searchPageCombo.Items[searchPageCombo.SelectedIndex])-1]);
            }
        }

        private void MovieAdder_Click(object sender, EventArgs e)
        {
            // Open Add Movie Form, Empty Textboxes for all fields (No Querying)
            MovieAdderForm maf = new MovieAdderForm();
            maf.Show();
        }

        private void MovieEditor_Click(object sender, EventArgs e)
        {
            // Open Editor Window: Drag and Drop a moviepanel should fill fields automatically
            // Editor window will extend from AdderWindow
            MovieEditor me = new MovieEditor();
            me.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Open Delete Panel: Search for a title and remove if it exists
            MovieDeleter md = new MovieDeleter(this);
            md.Show();
        }

        public Movie getMovie(string query)
        {
            Movie target = null;
            List<List<Movie>> result = populateResults(query, SearchType.Exact, false, sortBy[comboBox1.Items[0].ToString()]);
            if(result[0].Count > 0)
            {
                target = result[0][0];
            }
            return target;
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void resultsPanel_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void advancedSearchLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdvancedSearch ads = new AdvancedSearch();
            ads.Show();
        }
    }
}
