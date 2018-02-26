using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            Console.WriteLine("Please enter any amount of text: ");
            string texty = Console.ReadLine();

            var x = fillDict(texty);

            // Print results
            foreach (KeyValuePair<char, int> c in x)
            {
                Console.WriteLine(c.Key + ": " + c.Value);
            }

            Console.ReadLine();

        }
        
        static Dictionary<char, int> fillDict(string y)
        {
            Dictionary<char, int> characters = new Dictionary<char, int>();

            string lowerText = y.ToLower();

            foreach (char c in lowerText)
            {
                if (char.IsLetter(c) == true)
                {
                    if (characters.ContainsKey(c) == false)
                    {
                        characters.Add(c, 1);
                    }
                    else
                    {
                        characters[c] += 1;
                    }
                }
                else
                {
                    continue;
                }
            }
            return characters;
        }

    }
}
