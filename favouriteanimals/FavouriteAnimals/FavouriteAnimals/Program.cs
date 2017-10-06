using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Commands commands = new Commands();

            string[] arguments = { "-l", "-a", "-r", "-c" };

            if (args.Length == 0)
            {
                commands.ReadFile();
            }
            if (args[0] == "-l")
            {
                commands.AddAnimal();
            }
        }
    }
}
