using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhập một chuỗi:");
        string input= Console.ReadLine();
        var asciiInput = Encoding.ASCII.GetBytes(input);
        Console.WriteLine($"Mã hóa ASCII:\n{string.Join(" ",asciiInput)}");
        var utf8Input = Encoding.UTF8.GetBytes(input);
        Console.WriteLine($"Mã hóa UTF8:\n{string.Join(" ",utf8Input)}");
        
    }
}
