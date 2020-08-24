using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAlgorithms
{
    class TextAlgorithms
    {
        public static string Greet(string name)
        {
            return "Hello," + name + "how are you doing today?";
        }
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

        public static void countwordsinstring()
        {
            //Asking For Users Input
            Console.WriteLine("Enter a String Of Words");
            string userinput = Console.ReadLine();

            //Splitting input on '' which adds to counter
            int counter = userinput.Split(' ').ToList().Count;

            //Printing the amount of words in string
            Console.WriteLine("There is {0} Words in the String ", counter);
        }

        public static bool isPalindrome(string word)
        {
            //First Reversing the String Using LinQ
            string reversedString = new string(word.Reverse().ToArray());

            //Returning True or False
            return string.Compare(word, reversedString) == 0 ? true : false;
        }

        public static int GetVowelCount(string str)
        {
            return str.Count(i => "aeiou".Contains(i));
        }
        public static void reservestring()
        {
            Console.WriteLine("Enter a String you want reversing");
            string userinput = Console.ReadLine();
            string reversedString = new string(userinput.Reverse().ToArray());
            Console.WriteLine(reversedString);
        }

        //Used to find in the list the names that have the length
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(name => name.Length == 4);
        }
        public static string ToWeirdCase(string s)
        {
            return string.Join(" ",
              s.Split(' ')
              .Select(w => string.Concat(
                w.Select((ch, i) => i % 2 == 0 ? char.ToUpper(ch) : char.ToLower(ch)
              ))));
        }

        public static string repeatStr(int n, string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                StringBuilder builder = new StringBuilder(s.Length * n);
                for (int i = 0; i < n; i++) builder.Append(s);
                return builder.ToString();
            }
            return string.Empty;
        }
    }
}
