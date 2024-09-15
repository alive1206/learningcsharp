using System;
using System.Collections.Generic;

namespace ObjectData
{
   
    public interface IObject
    {              
        string name {get; set;}
    }

    public interface MyComparable<T>
    {
        int CompareTo(T other);
    }

    public class Movie : IObject, MyComparable<Movie>
    {
        public string name {get;set;}
        public int release_date {get;set;}
        public int CompareTo(Movie other)
        {
            return release_date.CompareTo(other.release_date);
        }
    }

    public class Student : IObject, MyComparable<Student>
    {
        public string name {get;set;}
        public int dob {get;set;}
        public int CompareTo(Student other)
        {
            return dob.CompareTo(other.dob);
        }
    }  
 

   public static class Sorter
{
    public static void Sort<T>(List<T> items) where T : IObject, MyComparable<T>
    {
        int n = items.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (items[j].CompareTo(items[j + 1]) > 0)
                {                   
                    T temp = items[j];
                    items[j] = items[j + 1];
                    items[j + 1] = temp;
                }
            }
        }
    }
}
public static class Printer
{
    public static void Print<T>(List<T> items) where T : IObject
    {
        Console.WriteLine($"\n{typeof(T).Name} List");
        Console.WriteLine("-----------------------------------------------------");
        foreach (var item in items)
        {
            
            if (item is Movie movie)
            {
                Console.WriteLine($"Name: {item.name}, Release Date: {movie.release_date}");
               
            }
            else if (item is Student student)
            {
                Console.WriteLine($"Name: {item.name}, Date of Birth: {student.dob}");
              
            }
        }
    }
}
}
