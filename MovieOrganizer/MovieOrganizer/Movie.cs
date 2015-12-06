using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Net.Http;
using System.Net.Http.Headers;


namespace MovieOrganizer
{

    
    public class Movie
    {
        // Should we identify if the movie is owned here?
        private string title;
        private int year;
        private int rating; //user rating (out of 10)
        private List<string> actors;
        private string director;
        private List<string> genres;
        private int runTime;
        private string certification; //only for some movies
        private string poster;
        private string description;
        private bool owned;

        public Movie(XElement element)
        {

            try
            {
                title = element.Element("title").Value;
                year = Int32.Parse(element.Element("year").Value);
                rating = Int32.Parse(element.Element("rating").Value);

                if (element.Element("certification") != null)
                {
                    certification = element.Element("certification").Value;
                }
                else
                {
                    certification = null;
                }

                poster = element.Element("poster").Value;

                if (element.Element("description") != null)
                {
                    description = element.Element("description").Value;
                }
                else
                {
                    description = "No description found.";
                }


                //build the list of actors
                actors = new List<string>();

                foreach (var actor in element.Elements("actor"))
                {
                    actors.Add(actor.Value);
                }

                director = element.Element("director").Value;

                genres = new List<string>();

                foreach (var genre in element.Elements("genre"))
                {
                    genres.Add(genre.Value);
                }

                if(element.Element("owned").Equals("false"))
                {
                    owned = false;
                }
                else
                {
                    owned = true;
                }

                runTime = Int32.Parse(element.Element("length").Value.Split(' ')[0]);
            }
            catch(Exception e)
            {
                Console.WriteLine("Missing information from: "+element.Element("title").Value);
            }
            
        }

        public string Title
        {
            get { return title; }
        }

        public int Year
        {
            get { return year; }
        }

        public int Rating
        {
            get { return rating; }
        }

        public List<string> Actors
        {
            get { return actors; }
        }

        public string Director
        {
            get { return director; }
        }

        public List<string> Genres
        {
            get { return genres; }
        }

        public int Length
        {
            get { return runTime; }
        }

        public string Certification
        {
            get { return certification; }
        }

        public string Poster
        {
            get { return poster; }
        }

        public string Description
        {
            get { return description; }
        }

        public bool Owned
        {
            get { return owned; }
        }
    }
}
