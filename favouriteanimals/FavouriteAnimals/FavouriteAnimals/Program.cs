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

            string[] arguments = {"-a", "-r"};

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
    }
}
