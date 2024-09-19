namespace PersonData
{
    public class Person
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public string[] Hobbies {get; set;}

        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(string name, int age,string[] hobbies)
        {           
            Name = name;
            Age = age;
            Hobbies = hobbies;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}\nHobbies: {string.Join(", ", Hobbies)}");
        }
    }
}