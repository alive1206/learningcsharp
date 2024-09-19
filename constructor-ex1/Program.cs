using PersonData;
using System;

class Program
{
    public static void Main(string[] args)
    {
        var person1 = new Person()
        {
            Hobbies = ["None"],
        };
        person1.Display();

        var person2 = new Person("Alice", 30)
        {
            Hobbies = ["None"],
        };
        person2.Display();

        var person3 = new Person("Bob", 25, ["Reading", "Traveling", "Music"])
        {
        
        };
        person3.Display();
        
    }
}
