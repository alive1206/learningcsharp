namespace FruitData
{
    public class Fruit
    {
        public Guid id {get;set;}
        public string shape {get; set;}
        public string color {get; set;}
    }

    public class Lemon : Fruit
    {
        public string taste {get;set;}
    }

    public class Watermelon : Fruit
    {
        public string taste {get;set;}
    }
}