using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAlgorithms
{
    class TextAlgorithms
    {
        public static string AlphabetPosition(string text)
        {
            //Declaring New Dictionary with char and int
            var letterPositions = new Dictionary<char, int>
        {
            {'a', 1},
            {'b', 2},
            {'c', 3},
            {'d', 4},
            {'e', 5},
            {'f', 6},
            {'g', 7},
            {'h', 8},
            {'i', 9},
            {'j', 10},
            {'k', 11},
            {'l', 12},
            {'m', 13},
            {'n', 14},
            {'o', 15},
            {'p', 16},
            {'q', 17},
            {'r', 18},
            {'s', 19},
            {'t', 20},
            {'u', 21},
            {'v', 22},
            {'w', 23},
            {'x', 24},
            {'y', 25},
            {'z', 26}
        };

            //Declaring New List 
            var convertedLetters = new List<int>();

            //Looping through Inputed Text 
            foreach (var c in text.ToLower())
            {
                if (letterPositions.ContainsKey(c))
                {
                    convertedLetters.Add(letterPositions[c]);
                }
            }

            return string.Join(" ", convertedLetters);
        }

        public static string AlphabetPositionLinQ(string text)
        {
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }

    }
}
