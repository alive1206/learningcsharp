using System;
using System.Collections.Generic; //sử dụng List
using System.IO; //đọc file
using Newtonsoft.Json; //sử dụng json convert
using MovieData; //sử dụng các thuộc tính của lớp movie

namespace MovieApp
{
    class Program
    {
        static void Main(string[] args){
            //đọc file json
            string jsonFilePath = "./Data/movie_data.json";
            string jsonData = File.ReadAllText(jsonFilePath);            

            //giải mã nội dung JSON thành danh sách các đối tượng Movie         
            List<Movie> movieList = JsonConvert.DeserializeObject<List<Movie>>(jsonData);
       
            List<Movie> movies = new List<Movie>(movieList);
       
            MovieAscending movieAscending = new MovieAscending();
            movieAscending.SortMovies(movies);
       
            MovieDescending movieDescending = new MovieDescending();
            movieDescending.SortMovies(movies);

          
        } 
    }
}
