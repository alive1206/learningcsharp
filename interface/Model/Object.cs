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

    public class Movie : IMyComparable, IMyPrintable
    {
        public string name { get; set; }
        public int release_date { get; set; }
        public int MyCompareTo(Object o)
        {
            if (o == null || o is not Movie) throw new InvalidDataException("Invalid Movie");

            var other = (Movie)o;

            if (release_date == other.release_date) return 0;
            if (release_date > other.release_date) return 1;
            return -1;

        }

        public void Print (){           
            Console.WriteLine($"Name: {name}, Release Date: {release_date}");
        }
    }

    public class Student : IMyComparable, IMyPrintable
    {
        public string name { get; set; }
        public int dob { get; set; }
        public int MyCompareTo(Object o)
        {

            if (o == null || o is not Student) throw new InvalidDataException("Invalid Student");

            var other = (Student)o;

            if (dob == other.dob) return 0;
            if (dob > other.dob) return 1;
            return -1;
        }
        public void Print (){            
            Console.WriteLine($"Name: {name}, Release Date: {dob}");
        }
    }


    public static class Sorter
    {
        public static IEnumerable<IMyComparable> Sort(IEnumerable<IMyComparable> items)
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
            
                public static void Print(IEnumerable<IMyPrintable> items)
                {
                    Console.WriteLine("-----------------------------------------------------");
                    foreach (var item in items)
                    {
                       item.Print();
                    }
                }
            
        }
}