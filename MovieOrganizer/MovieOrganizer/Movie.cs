using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using WatTmdb.V3;


namespace MovieOrganizer
{

    
    public class Movie
    {
        private string key = "d637d50db401e9af35c47fd0bcda4a4d";
        //TODO: this should search for the movies image from imdb

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

        private Tmdb api;
        
        public Movie(XElement element)
        {
            title = element.Element("title").Value;
            year = Int32.Parse(element.Element("year").Value);
            rating = Int32.Parse(element.Element("rating").Value);


            api = new Tmdb(key, "en");
            var result = api.SearchMovie(title, 1).results[0];
            var theMovie = api.GetMovieInfo(result.id);

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

            runTime = Int32.Parse(element.Element("length").Value.Split(' ')[0]);

            if (element.Element("certification") != null)
            {
                certification = element.Element("certification").Value;
            }
            else
            {
                // Get certification:
                if(theMovie.adult)
                {
                    certification = "R";
                }
                else
                {
                    certification = "PG";
                }
            }

            var image = api.GetMovieImages(theMovie.id);
            string path = @"https://image.tmdb.org/t/p/w185";
            path += image.posters[0].file_path;

            poster = path;

            description = theMovie.overview;

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

        // Query IMDB/OMDB to get movie poster given the title
    }
}
