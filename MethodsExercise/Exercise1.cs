using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace MethodsExercise
{
    class Program

        // Declares string fields at the class level so that the values assigned to them in the "TakeName()", "TakeFavoriteAnimal()"
        // and "TakeFavoriteColor() can be accessed by the "CreateStory" method
    {
        private static string name = "";
        private static string animal = "";
        private static string color = "";

        // Asks for the user's name and stores the input in the "name" variable
        public static void TakeName()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Program.name = name;
        }

        // Asks for the user's favorite animal and stores the input in the "animal" variable
        public static void TakeFavoriteAnimal()
        {
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();
            Program.animal = animal;
        }

        // Asks for the user's favorite color and stores the input in the "color" variable
        public static void TakeFavoriteColor()
        {
            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();
            Program.color = color;
        }

        // Creates story from user input
        public static void CreateStory()
        {
            Console.WriteLine($"This is the story of a brave adventurer named {name} and their loyal {animal} friend and their " +

            $"quest to find the legendary lost treasure of {color} beard. {name} and their loyal companion followed a map that " +

            $"they found in an old library. It showed them the way to a hidden island where {color} beard had buried his treasure. " +

            $"They sailed across the sea, facing storms and pirates, until they reached the island. There, they searched for clues " +

            $"and solved riddles to find the entrance to a secret cave. Inside the cave, they faced traps and monsters, until they " +

            $"reached the final chamber. There, they saw a chest that glittered with gold and jewels. They had completed their " +

            $"quest and found the treasure! The end.");
        }
        static void Main(string[] args)
        {
            TakeName();
            TakeFavoriteAnimal();
            TakeFavoriteColor();
            CreateStory();

        }
    }
}
