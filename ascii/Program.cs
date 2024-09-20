using System;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {       
        ASCIIEncoding ascii = new ASCIIEncoding();
        

        //Encode ASCII
        // Console.WriteLine("Hãy nhập ký tự bất kỳ mà bạn muốn mã hóa bằng ASCII:");
        // var input = Console.ReadLine();
        // var encodedInput = ascii.GetBytes(input);   
        // Console.WriteLine($"Mã hóa ASCII: {string.Join(" ", encodedInput)}");

        //Decode ASCII
        // Console.WriteLine("Hãy nhập một số từ 0 đến 127 để lấy ký tự ASCII tương ứng:");
        // int input = Convert.ToInt32(Console.ReadLine());     
        // byte[] byteArray = new byte[] { (byte)input };
        // var decodedInput = ascii.GetString(byteArray);
        // if (input >= 0 && input <= 127)
        // {          
        //     Console.WriteLine($"{decodedInput}");
        // }
        // else
        // {
        //     throw new ArgumentException("Vui lòng nhập một số nguyên hợp lệ trong khoảng từ 0 đến 127!");
        // }

        //Ascending ASCII
        // Console.WriteLine("Nhập một chuỗi:");
        // var input = Console.ReadLine();       
        // var encodedInput = ascii.GetBytes(input);
        // Array.Sort(encodedInput);    
        // Console.WriteLine("Các mã ASCII theo thứ tự tăng dần là:");       
        // Console.WriteLine($"{string.Join(" ",encodedInput)}");    

        //Uppercase or Lowercase
        // Console.WriteLine("Nhập một ký tự:");
        // var input = Console.ReadKey().KeyChar;
        // Console.WriteLine();  
        // int asciiValue = (int)input;      
        // if (asciiValue >= 65 && asciiValue <= 90)
        // {
        //     Console.WriteLine($"{input} là chữ hoa (mã ASCII: {asciiValue})");
        // }
        // else if (asciiValue >= 97 && asciiValue <= 122)
        // {
        //     Console.WriteLine($"{input} là chữ thường (mã ASCII: {asciiValue})");
        // }
        // else
        // {
        //     throw new ArgumentException($"{input} không phải là chữ cái (mã ASCII: {asciiValue})");
        // }

        //Simple Encode
        Console.WriteLine("Nhập một chuỗi:");
        var input = Console.ReadLine();
        var encodedInput = "";

        foreach (char c in input)
        {
            char encodedChar;
            if (c == 'Z')
            {
                encodedChar = 'A'; 
            }
            else if (c == 'z')
            {
                encodedChar = 'a'; 
            }
            else
            {
                encodedChar = (char)(c + 1);
            }
            encodedInput += encodedChar;
        }

        Console.WriteLine($"Chuỗi đã mã hóa là: {encodedInput}");
            
    }
}
