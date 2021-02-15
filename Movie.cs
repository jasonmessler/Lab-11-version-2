using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11_version_2
{
    class Movie
    {

        private string _category;
        private string _title;

        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }

        public Movie()
        {

        }

        public void GetSciFi()
        {
            var movieList = PrintList();
            var scifiTitles = new List<string>();

            foreach (var movie in movieList)
            {
                if (movie._category == "scifi")
                {
                    scifiTitles.Add(movie._title);


                }
            }
            scifiTitles.Sort();
            foreach (var film in scifiTitles)
            {
                Console.WriteLine(film);
            }
        }

        public void GetDrama()
        {
            var movieList = PrintList();
            var dramaTitles = new List<string>();


            foreach (var movie in movieList)
            {
                if (movie._category == "drama")
                {
                    dramaTitles.Add(movie._title);
                }
            }
            dramaTitles.Sort();
            foreach (var film in dramaTitles)
            {
                Console.WriteLine(film);
            }
        }

        public void GetAnimated()
        {
            var movieList = PrintList();
            var animatedTitles = new List<string>();

            foreach (var movie in movieList)
            {
                if (movie._category == "animated")
                {
                    animatedTitles.Add(movie._title);
                }
            }
            animatedTitles.Sort();
            foreach (var film in animatedTitles)
            {
                Console.WriteLine(film);

            }
        }

        public void GetHorror()
        {
            var movieList = PrintList();
            var horrorTitles = new List<string>();

            foreach (var movie in movieList)
            {
                if (movie._category == "horror")
                {
                    horrorTitles.Add(movie._title);
                }
            }
            horrorTitles.Sort();
            foreach (var film in horrorTitles)
            {
                Console.WriteLine(film);
            }
        }

        private List<Movie> PrintList()
        {
            var movieList = new List<Movie>();


            movieList.Add(new Movie("Alien", "scifi"));
            movieList.Add(new Movie("The Terminator", "scifi"));
            movieList.Add(new Movie("Blade Runner", "scifi"));
            movieList.Add(new Movie("Predator", "scifi"));
            movieList.Add(new Movie("Goodfellas", "drama"));
            movieList.Add(new Movie("Amadeus", "drama"));
            movieList.Add(new Movie("To kill a mockingbird", "drama"));
            movieList.Add(new Movie("The grapes of wrath", "drama"));
            movieList.Add(new Movie("Akira", "animated"));
            movieList.Add(new Movie("Fritz the cat", "animated"));
            movieList.Add(new Movie("The secret of NIMH", "animated"));
            movieList.Add(new Movie("Sausage Party", "animated"));
            movieList.Add(new Movie("The Exorcist", "horror"));
            movieList.Add(new Movie("The Thing", "horror"));
            movieList.Add(new Movie("The Void", "horror"));
            movieList.Add(new Movie("Reanimator", "horror"));

            return movieList;
        }
    }
}
