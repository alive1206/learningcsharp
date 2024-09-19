using System;

namespace BookData
{
    public class Book
    {
        public string title {get; set;}
        public string author {get; set;}
       
        public static int totalBooks = 0;

      

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            totalBooks++;
        }
    

        public void PrintBookInfo()
        {
            Console.WriteLine($"title: {title}, author: {author}");
        }

        public static void PrintTotalBooks()
        {
            Console.WriteLine($"Total books: {totalBooks}");
        }
    }
}