using System;
using System.Collections.Generic;

namespace ObjectData
{

    public interface IMyComparable
    {
        int MyCompareTo(Object other);
    }

    public interface IMyPrintable
    {
        void Print();
    }

    public abstract class EntityBase<T> : IMyComparable, IMyPrintable 
    {
        public abstract int CompareTo(T other);

         public int MyCompareTo(object other)
        {
            if (other == null || other is not T)
                throw new InvalidOperationException("Invalid comparison");
            return CompareTo((T)other);
        }

         public abstract void Print();
    }

    public class Movie : EntityBase<Movie>
    {
        public string name { get; set; }
        public int release_date { get; set; }
        public override int CompareTo(Movie other)
        {
           return release_date.CompareTo(other.release_date);

        }

        public override void Print (){           
            Console.WriteLine($"Name: {name}, Release Date: {release_date}");
        }
    }

    public class Student : EntityBase<Student>
    {
        public string name { get; set; }
        public int dob { get; set; }
        public override int CompareTo(Student other)
        {
            return dob.CompareTo(other.dob);
        }
        public override void Print (){            
            Console.WriteLine($"Name: {name}, Release Date: {dob}");
        }
    }


    public static class Sorter
    {
        public static IEnumerable<T> Sort<T>(IEnumerable<T> items) where T: IMyComparable
        {
            // Convert to List to allow sorting
            var itemList = items.ToList();

            int n = itemList.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (itemList[j].MyCompareTo(itemList[j + 1]) > 0)
                    {
                        // Swap items
                        var temp = itemList[j];
                        itemList[j] = itemList[j + 1];
                        itemList[j + 1] = temp;
                    }
                }
            }

            return itemList; // Return the sorted list
        }

        
    }

    public static class Printer
        {
            
                public static void Print<T>(IEnumerable<T> items) where T:IMyPrintable
                {
                    Console.WriteLine("-----------------------------------------------------");
                    foreach (var item in items)
                    {
                       item.Print();
                    }
                }
            
        }
}