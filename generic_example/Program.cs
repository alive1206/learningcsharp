using BoxData;
using System.Collections.Generic;
using System;


class Program
{
    public static void Main(string[] args)
    {
        Box<int> intBox = new Box<int>(123);
        Box<string> stringBox = new Box<string>("Hello, Generics!");
        Box<double> doubleBox = new Box<double>(3.14);

        intBox.Display();
        stringBox.Display();
        doubleBox.Display();

    }
}
