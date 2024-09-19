using BookData;

public class Program
{
    public static void Main(string[] args)
    {
        // Tạo 3 cuốn sách
        Book book1 = new Book("C# Programming", "John Doe");
        Book book2 = new Book("Learn Java", "Jane Smith");
        Book book3 = new Book("Python Basics", "Tom Johnson");

        // In thông tin của từng cuốn sách
        book1.PrintBookInfo();
        book2.PrintBookInfo();
        book3.PrintBookInfo();

        // In tổng số sách đã tạo
        Book.PrintTotalBooks();
    }
}
