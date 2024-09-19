using System;

namespace StudentData
{
    public class Student
    {
        public string Name {get;set;}
        public int age;
        public double Grade {get;set;}

        public int Age 
        {
            get{return age;}
            set
            {  
                if (value > 0 && value < 100) 
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Invalid Age! It must be greater than 0 and less than 100.");
                }
            }
        }
       

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
        }
    }
}