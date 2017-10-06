using System.Collections.Generic;
using System;

namespace UniqueChars
{
    public class Chars
    {
        public List<string> UniqueCharacters(string word)
        {
            List<string> letters = new List<string>();

            if (word == "")
            {
                letters.Add("empty");
            }
            else if (word == null)
            {
                letters.Add("null");
            }

            string value = word;
            String[] substrings = value.Split();

            foreach (var substring in substrings)
            {
                substring.ToString();
            }
            return letters;
        }
    } 
}