using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAlgorithms
{
    class LinqAlgorithms
    {
        #region LinQ Find Items which contain a character
        public static void HasA(string[] names)
        {
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;
            foreach (var name in myLinqQuery)
            {
                Console.WriteLine(name);
            }
        }
        #endregion

        #region Return 2 Smallest Number of Array 
        /// <summary>
        /// Find 2 Smallest Numbers
        /// </summary>
        /// <param name="numbers"></param>
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            return numbers.OrderBy(i => i).Take(2).Sum();
        }
        #endregion 
    }
}
