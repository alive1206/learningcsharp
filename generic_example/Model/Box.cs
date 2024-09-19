using System.Collections.Generic;
using System;

namespace BoxData
{
    public class Box<T>
    {
        public T Value {get; set;}

        public Box(T value)
        {
            Value = value;
        }
        public void Display()
        {
            if(Value != null)
            {
                Console.WriteLine($"Value: {Value}");
            }
        }      
    }
}