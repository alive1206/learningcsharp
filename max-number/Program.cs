using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhập số bit n:");
        int n = int.Parse(Console.ReadLine());
        int maxNumber = GetMaxNumber(n);
        Console.WriteLine($"Số lớn nhất có thể biểu diễn bằng {n} bit là: {maxNumber}");
    }

    public static int GetMaxNumber(int n)
    {
        if (n < 1)
        {
            throw new ArgumentException("n phải lớn hơn 0.");
        }
        return (1 << n) - 1; //2^n -1
    }
}
