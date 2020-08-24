using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BasicAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Algorithms.Solution("olliedryisthebest"))
            {
                if(item.Length == 2)
                {

                }
                Console.WriteLine(item.ToString());
            }
        }
    }
}
