using System;
using PetClass;

namespace ArrayExample
{
    class Program{
        static void Main(string[] args){
            var petList = new Pet();
            petList.pets = new string[] {"Dog", "Cat", "Bird"};
           for (var i = 0; i < petList.pets.Length; i++){
             Console.WriteLine(petList.pets[i]);
           }
        }
    }
}