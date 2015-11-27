using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MovieOrganizer
{
   

    public class Movie
    {
        //TODO: this should search for the movies image from imdb

        private string title; 
        private int year;
        private int rating; //user rating (out of 10)
        private List<string> actors;
        private string director;
        private List<string> genres;
        private int runTime;
        private string certification; //only for some movies

        public Movie(XElement element)
        {
            title = element.Element("title").Value;
            year = Int32.Parse(element.Element("year").Value);
            rating = Int32.Parse(element.Element("rating").Value);

            //build the list of actors
            actors = new List<string>();

            foreach(var actor in element.Elements("actor"))
            {
                actors.Add(actor.Value);
            }

            director = element.Element("director").Value;

            genres = new List<string>();

            foreach(var genre in  element.Elements("genre"))
            {
                genres.Add(genre.Value);
            }

            runTime = Int32.Parse(element.Element("length").Value.Split(' ')[0]);

            if (element.Element("certification") != null)
            {
                certification = element.Element("certification").Value;
            }
            else
            {
                certification = null;
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
    }
}
