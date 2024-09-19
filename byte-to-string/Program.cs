using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhập một chuỗi:");
        string input= Console.ReadLine();
        var asciiInputByte = Encoding.ASCII.GetBytes(input);        
        Console.WriteLine($"Mã hóa ASCII:\n{string.Join(" ",asciiInputByte)}");
        var asciiInputString =  Encoding.ASCII.GetString(asciiInputByte);
        Console.WriteLine($"ASCII String:\n{asciiInputString}\n");


        var utf8InputByte = Encoding.UTF8.GetBytes(input);
        Console.WriteLine($"Mã hóa UTF8:\n{string.Join(" ",utf8InputByte)}");
        var utf8InputString =  Encoding.ASCII.GetString(utf8InputByte);
        Console.WriteLine($"UTF8 String:\n{utf8InputString}");
        
    }
}
