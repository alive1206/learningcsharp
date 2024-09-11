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
            List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(jsonData);       

            BubbleSort(movies);

            Console.WriteLine("Movie List:");

             foreach (var movie in movies)
            {
                Console.WriteLine($"Name: {movie.name}, Release Date: {movie.release_date}");
            }

            static void BubbleSort(List<Movie> movies) //behaviour
            {
                int n = movies.Count;
                for (int i=0; i<n-1; i++)
                {
                    for (int j=0; j<n-i-1;j++){
                        if (movies[j].release_date > movies[j+1].release_date)
                        {
                            Movie temp = movies[j];
                            movies[j] = movies[j+1];
                            movies[j+1] = temp;
                        }
                    }
                }
            }
        } 
    }
}
