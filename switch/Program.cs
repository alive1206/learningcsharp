using System;

namespace SwitchApplication
{
    class Program{
        static void Main(string[] args)
        {
            //Type casting
            Console.WriteLine("Choose your lucky number from 1 to 10: ");
            int choice = Convert.ToInt32(Console.ReadLine());    

            switch (choice)
            {
                case 1:
                Console.WriteLine("Congrats! You will be lucky today.");
                break;
                case 2:
                Console.WriteLine("Congrats! You will be lucky today.");
                break;
                case 3:
                Console.WriteLine("Congrats! You will be lucky today.");
                break;
                case 4:
                Console.WriteLine("Congrats! You will be lucky today.");
                break;
                case 5:
                Console.WriteLine("Congrats! You will be lucky today.");
                break;
                case 6:
                Console.WriteLine("Congrats! You will be lucky today.");
                break;
                case 7:
                Console.WriteLine("Congrats! You will be lucky today.");
                break;
                case 8:
                Console.WriteLine("Congrats! You will be lucky today.");
                break;
                case 9:
                Console.WriteLine("Congrats! You will be lucky today.");
                break;
                case 10:
                Console.WriteLine("Congrats! You will be lucky today.");
                break;
            }


        }
    }
}
