using System;
using System.Collections.Generic;
using System.IO;

namespace FavouriteAnimals
{
    class Commands
    {
        private string[] text;
        private string path;
        private string newAnimal;

        public Commands()
        {
            path = @"./favourites.txt";
        }

        public void ReadFile()
        {
            text = File.ReadAllLines(path);

            for (int i = 1; i <= text.Length; i++)
            {
                    Console.WriteLine("{0}",text[i - 1]);
            } 
        }

        public void AddAnimal(string newAnimal)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(newAnimal);
            }
        }

        public void RemoveAnimal(string line)
        {
            List<string> lines = new List<string>(File.ReadAllLines(path));
            lines.RemoveAt(int.Parse(line) - 1);
            File.WriteAllLines(path, lines);
        }
    }
}