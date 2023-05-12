using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes user input

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();

            // Creates story from user input

            Console.WriteLine($"This is the story of a brave adventurer named {name} and their loyal {animal} friend and their " +

            $"quest to find the legendary lost treasure of {color} beard. {name} and their loyal companion followed a map that " +

            $"they found in an old library. It showed them the way to a hidden island where {color} beard had buried his treasure. " +

            $"They sailed across the sea, facing storms and pirates, until they reached the island. There, they searched for clues " +

            $"and solved riddles to find the entrance to a secret cave. Inside the cave, they faced traps and monsters, until they " +

            $"reached the final chamber. There, they saw a chest that glittered with gold and jewels. They had completed their " +

            $"quest and found the treasure! The end.");
        }
    }
}
