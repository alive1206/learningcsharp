using System;
using System.Text;


class Program
{
    public static void Main(string[] args)
    {       
        var utf8 = Encoding.UTF8;
        var utf16 = Encoding.Unicode;
        //Count string
        // var inputString = "Hello 😄";
        // Console.WriteLine(inputString.Length);

        //Convert utf-8 to utf-16
        // Console.WriteLine("Hãy nhập một chuỗi để chuyển đổi từ UTF-8 sang UTF-16:");
        // var input = Console.ReadLine();

        // var inputUtf8Bytes = utf8.GetBytes(input);
        // Console.Write("Chuỗi UTF-8: ");
        // foreach(var b in inputUtf8Bytes)
        // {
        //     Console.Write(b + " ");
        // }

        // Console.WriteLine();

        // Console.Write("Chuỗi UTF-16: ");
        // var inputUtf16String = utf16.GetString(inputUtf8Bytes);
        // var inputUtf16Bytes = utf16.GetBytes(inputUtf16String);
        // foreach(var b in inputUtf16Bytes)
        // {
        //     Console.Write(b + " ");
        // }

        //Convert utf-16 to utf-8
        // Console.WriteLine("Hãy nhập một chuỗi để chuyển đổi từ UTF-16 sang UTF-8:");
        // var input = Console.ReadLine();

        // Console.Write("Chuỗi UTF-16: ");        
        // var inputUtf16Bytes = utf16.GetBytes(input);
        // foreach(var b in inputUtf16Bytes)
        // {
        //     Console.Write(b + " ");
        // }
        // Console.WriteLine();

       
        // var inputUtf8String = utf8.GetString(inputUtf16Bytes);
        // var inputUtf8Bytes = utf8.GetBytes(inputUtf8String);
        // Console.Write("Chuỗi UTF-8: ");
        // foreach(var b in inputUtf8Bytes)
        // {
        //     Console.Write(b + " ");
        // }

        //Decode unicode
        // Console.Write("Nhập mã Unicode Code Point(Bắt đầu bằng U+xxxx): ");
        // string input = Console.ReadLine();        
    
        // if (input.StartsWith("U+") && input.Length > 2)
        // {
        //     string hexValue = input.Substring(2);          
            
        //     int codePoint = Convert.ToInt32(hexValue, 16);           
        //     var chars = char.ConvertFromUtf32(codePoint);
        //     Console.WriteLine($"Ký tự tương ứng: {chars}");      
            
        // }
        // else
        // {
        //     throw new ArgumentException("Vui lòng nhập mã Unicode theo định dạng U+XXXX.");
        // }


        //Sắp xếp chuỗi
        // string[] strings = { "bánh", "bàn", "áo", "á", "cà phê", "cà" };
        // SortStrings(strings);

        // foreach (var str in strings)
        // {
        //     Console.WriteLine(str);
        // }

        //Chuẩn hóa Unicode
        Console.Write("Nhập vào một chuỗi: ");
        string input = Console.ReadLine();

        Console.WriteLine("Input: " + input);

      
        string decomposed = Decompose(input);
        Console.WriteLine("Dạng phân rã: " + decomposed);

       
        string recomposed = Recompose(decomposed);
        Console.WriteLine("Dạng kết hợp: " + recomposed);
            
    }

     static void SortStrings(string[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (CompareVietnamese(array[i], array[j]) > 0)
                {
                    string temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }

    static int CompareVietnamese(string a, string b)    
    {      
        string order = "aàảãáạăằắẳẵặâầấẩẫậbcdđefghijklmnopqrstuvwxyz";

        for (int i = 0; i < Math.Min(a.Length, b.Length); i++)
        {
            int indexA = order.IndexOf(a[i]);
            int indexB = order.IndexOf(b[i]);

            if (indexA != indexB)
            {
                return indexA - indexB;
            }
        }

        
        return a.Length - b.Length;
    }

     static string Decompose(string input)
    {
        StringBuilder result = new StringBuilder();
        foreach (char c in input)
        {
            if (c == 'ê') 
            {
                result.Append('e'); 
                result.Append((char)0x0302);
            }
            else
            {
                result.Append(c); 
            }
        }
        return result.ToString();
    }

    static string Recompose(string input)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (c == 'e' && i + 1 < input.Length && input[i + 1] == (char)0x0302)
            {
                result.Append('ê'); 
                i++; 
            }
            else
            {
                result.Append(c); 
            }
        }
        return result.ToString();
    }
}
