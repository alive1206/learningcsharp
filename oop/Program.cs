using System;
using MovieObject;

namespace OopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieDto myMovie = new MovieDto
            {
                id = Guid.NewGuid(), 
                title = "Reply 1988",
                genre = new[] { "Tâm Lý", "Tình Cảm" },
                description = "Tiếp nối sự thành công của hai bộ phim Lời Hồi Đáp 1997 và Lời Hồi Đáp 1994, Lời Hồi Đáp 1988 là bộ phim xoay quanh cuộc sống của 5 gia đình trong một khu xóm nhỏ, những vấn đề gì sẽ xảy ra với họ? Bi có, hài có sẽ khiến người xem dở khóc dở cười."
            };

            Console.WriteLine($"ID: {myMovie.id}");
            Console.WriteLine($"Title: {myMovie.title}");
            Console.WriteLine($"Genre: {string.Join(", ", myMovie.genre)}");
            Console.WriteLine($"Description: {myMovie.description}");
        }
    }
}
