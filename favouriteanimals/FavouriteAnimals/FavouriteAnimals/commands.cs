﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteAnimals
{
    class Commands
    {
        private string[] text;
        private string path;

        public Commands()
        {
            path = @"./favourites.txt";
        }

        public void ReadFile()
        {
            text = File.ReadAllLines(path);

            for (int i = 1; i <= text.Length; i++)
            {
                    Console.WriteLine("{0} - {1}", i, text[i - 1]);
            } 
        }

        public void AddAnimal()
        {

        }
    }
}
