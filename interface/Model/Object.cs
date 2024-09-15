using System;
using System.Collections.Generic;

namespace ObjectData
{
   
    public interface IObject
    {              
        string name {get; set;}
    }

    public class Movie : IObject
    {
        public string name {get;set;}
        public int release_date {get;set;}
    }

    public class Student : IObject
    {
        public string name {get;set;}
        public int dob {get;set;}
    }  
 

   public class Sorter
{
    public void sort(List<Movie> movies)
    {
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
    }

    public void sort(List<Student> students)
    {
        int n = students.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (students[j].dob > students[j + 1].dob)
                {                 
                    Student temp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = temp;
                }
            }
        }
    }
}

public class Printer
{
    public void print(List<Movie> movies)
    {
        Console.WriteLine("Movie List");
        Console.WriteLine("-----------------------------------------------------");
        foreach (var movie in movies)
        {
            Console.WriteLine($"Movie name: {movie.name}, Release Date: {movie.release_date}");
        }
    }

    public  void print(List<Student> students)
    {
        Console.WriteLine("\nStudent List");
        Console.WriteLine("-----------------------------------------------------");
        foreach (var student in students)
        {
            Console.WriteLine($"Student name: {student.name}, Date of Birth: {student.dob}");
        }
    }
}
}
