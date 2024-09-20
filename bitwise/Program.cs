using System;

class Program
{
    static void Main()
    {
        int a = 5; // 0000 0101
        int b = 3; // 0000 0011

        // a) 5 & 3 (AND)
        int andResult = a & b;
        Console.WriteLine("5 & 3 = " + andResult);

        // b) 5 | 3 (OR)
        int orResult = a | b;
        Console.WriteLine("5 | 3 = " + orResult);

        // c) 5 ^ 3 (XOR)
        int xorResult = a ^ b;
        Console.WriteLine("5 ^ 3 = " + xorResult);

        // d) ~5 (NOT)
        int notResult = ~a;
        Console.WriteLine("~5 = " + notResult);

        // e) 5 << 1 (Left shift)
        int leftShiftResult = a << 1;
        Console.WriteLine("5 << 1 = " + leftShiftResult);

        // f) 5 >> 1 (Right shift)
        int rightShiftResult = a >> 1;
        Console.WriteLine("5 >> 1 = " + rightShiftResult);
    }
}