using System;
using FruitData;

public class Program
{
    static void Main(string[] args)
    {

        var lemon = new Lemon()
        {
            shape = "Spherical",
            color = "Yellow",
            taste = "Sour"
        };

        var watermelon = new Watermelon()
        {
            shape = "Oval",
            color = "Green",
            taste = "Sweet"
        };

        Console.WriteLine($"Lemon props: \n-Shape: {lemon.shape} \n-Color:{lemon.color} \n-Taste:{lemon.taste}");
        Console.WriteLine($"\nWatermelon props: \n-Shape: {watermelon.shape} \n-Color:{watermelon.color} \n-Taste:{watermelon.taste}");

    }
}