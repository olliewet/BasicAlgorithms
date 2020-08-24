using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAlgorithms
{
    class NumberAlgorithms
    {
        public static bool isPrime(int number)
        {
            //For efficency Declaring which Numbers are Already Prime and Not from 1-5
            if (number == 1) return false;
            if (number == 2 || number == 3 || number == 5) return true;
            if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0) return false;


            var boundary = (int)Math.Floor(Math.Sqrt(number));

            // You can do less work by observing that at this point, all primes 
            // other than 2 and 3 leave a remainder of either 1 or 5 when divided by 6. 
            // The other possible remainders have been taken care of.
            int i = 6; // start from 6, since others below have been handled.
            while (i <= boundary)
            {
                if (number % (i + 1) == 0 || number % (i + 5) == 0)
                    return false;

                i += 6;
            }
            return true;
        }

        // Returns the Output of a triangle of odd numbers
        public static long rowSumOddNumbers(long n)
        {
            return n * n * n;
        }

        public static int Find(int[] integers)
        {
            int even = 0;
            int odd = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;

                }
            }
            if (even < odd)
            {
                Console.WriteLine("even is the outlier");
                for (int i = 0; i < integers.Length; i++)
                {
                    if (integers[i] % 2 == 0)
                    {
                        return integers[i];
                    }

                }
            }
            else
            {
                Console.WriteLine("Odd is the outlier");
                for (int i = 0; i < integers.Length; i++)
                {
                    if (integers[i] % 2 != 0)
                    {
                        return integers[i];
                    }
                }
            }
            int n = 0;
            return n;
        }
        public static int FindDeletedNumber(List<int> startingList, List<int> mixedList)
        {
            var result = Enumerable.Range(0, 10).Except(startingList);
            return -1;
        }

        public static int GetUnique(IEnumerable<int> numbers)
        {
            IEnumerable<int> uniqueItems = numbers.Distinct<int>();
            var cleanArray = numbers.GroupBy(x => x)
             .Where(x => x.Count() == 1)
             .SelectMany(x => x)
             .ToArray();

            foreach (int value in cleanArray)
            {
                return value;
            }
            return -1;
        }
        public static int AreaOrPerimeter(int l, int w)
        {
            if (l == w) // Square 
            {
                // Work out Area
                return l * w;
            }
            else
            {
                // Work out Perimeter 
                return l + l + w + w;
            }
        }

        public static int GetAverage(int[] marks)
        {
            double average = marks.Average();
            int interval = (int)Math.Floor(average);
            return interval;
            // OR 
            //return (int)marks.Average();
        }

        public static bool IsSquare(int n)
        {
            //Get the Square Number 
            double result = Math.Sqrt(n);

            //Check if the square number when divided by 1 has any remainders
            bool isSquare = result % 1 == 0;
            return isSquare;
        }
        public static bool IsTriangle(int a, int b, int c)
        {
            if (a + b > c)
            {
                return true;
            }
            else if (a + c > b)
            {
                return true;
            }
            else if (b + c > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int add(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
