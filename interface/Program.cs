using System;
using System.Collections.Generic; //sử dụng List
using System.IO; //đọc file
using Newtonsoft.Json; //sử dụng json convert
using ObjectData; //sử dụng các thuộc tính của lớp movie

namespace MovieApp
{
    class Program
    {
        static void Main(string[] args){
            //đọc file json
            string movieJsonFilePath = "./Data/movie_data.json";
            string movieData = File.ReadAllText(movieJsonFilePath);       
            string studentJsonFilePath = "./Data/student_data.json";
            string studentData = File.ReadAllText(studentJsonFilePath);          

            //giải mã nội dung JSON thành danh sách các đối tượng    
            List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(movieData);  
   

            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(studentData);
       
           
       
            Sorter.Sort(movies);
            Sorter.Sort(students);

              
            Printer.Print(movies);
            Printer.Print(students);      
                      
        } 
    }
}
