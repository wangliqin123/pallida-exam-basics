using System;

namespace FavouriteAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();

            Commands commands = new Commands();

            string[] arguments = { "-a", "-r" };

            if (args.Length == 0)
            {
                commands.ReadFile();
            }
            if (args[0] == "-a")
            {
                commands.AddAnimal(args[1]);
            }
            if (args[0] == "-r")
            {
                commands.RemoveAnimal(args[1]);
            }
        }

        public static void Welcome()
        {
            Console.WriteLine("C# FavouriteAnimals [animal] [animal]");
        }
    }
}