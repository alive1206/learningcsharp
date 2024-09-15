using System;
using System.Collections.Generic;

namespace MovieData
{
   
    public interface IMovie
    {
        string name { get; set; }
        int release_date { get; set; }        
    }

     public class Movie : IMovie
    {
        public string name { get; set; }
        public int release_date { get; set; }
        public int genre { get; set; }
        public double rating {get; set;}
    }
 

    public class MovieAscending 
    {
        public string name { get; set; }
        public int release_date { get; set; }
       

        public void SortMovies(List<Movie> movies)
        {
            Console.WriteLine("Movie List Ascending:");
            int n = movies.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (movies[j].release_date > movies[j + 1].release_date)
                    {
                        Movie temp = movies[j];
                        movies[j] = movies[j + 1];
                        movies[j + 1] = temp;
                    }
                }
            }
            foreach (var movie in movies)
            {
                Console.WriteLine($"Name: {movie.name}, Release Date: {movie.release_date}");
            }
        }
    }


    public class MovieDescending 
    {
        public string name { get; set; }
        public int release_date { get; set; }
        public void SortMovies(List<Movie> movies)
        {
            Console.WriteLine("\nMovie List Descending:");
            int n = movies.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (movies[j].release_date < movies[j + 1].release_date)
                    {
                        Movie temp = movies[j];
                        movies[j] = movies[j + 1];
                        movies[j + 1] = temp;
                    }
                }
            }
            foreach (var movie in movies)
            {
                Console.WriteLine($"name: {movie.name}, Release Date: {movie.release_date}");
            }
        }
    }
}
