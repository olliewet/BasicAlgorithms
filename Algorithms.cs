using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace BasicAlgorithms
{
    public static class Extensions
    {
        public static int findIndex<T>(this T[] array, T item)
        {
            return Array.IndexOf(array, item);
        }
    }
    class Algorithms
    {

        #region FizzBuzz
        /// <summary>
        /// Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number 
        /// and for the multiples of five print “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz”.
        /// </summary>
        public static void fizzbuzz()
        {
            //Loop From 1 - 100 
            for (int num = 1; num <= 100; num++)
            {
                //If Number is Divideable By 3 and 5 its FizzBuzz
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("{0} FizzBuzz", num);
                }
                //If Number is Divideable 5 its Buzz
                else if (num % 5 == 0)
                {
                    Console.WriteLine("{0} Buzz", num);
                }
                //If Number is Divideable 5 its Buzz
                else if (num % 3 == 0)
                {
                    Console.WriteLine("{0} Fizz", num);
                }
                //Else Print The Number To Console 
                else
                {
                    Console.WriteLine("{0}", num);
                }
            }
        }
        #endregion

        #region Is The Number Even
        /// <summary>
        /// The Method below checks if the supplied number is even
        /// </summary>
        /// <param name="num"></param>
        public static void IsEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} Is Even", num);
            }
            else
            {
                Console.WriteLine("{0} is Not Even", num);
            }
        }
        #endregion

        #region Fibonacci 
        public static void Fibonacci_Seq()
        {
            //Declaring Users Input 
            int fiblength;

            //Assigning Value To the starter numbers
            int f1 = 0, f2 = 1, f3;


            Console.Write("How many fibonacci number do you want: ");

            //Reading Users Input
            fiblength = int.Parse(Console.ReadLine());

            //Printing the inital Numbers
            Console.Write(f1 + " " + f2 + " ");

            // I Less than Length, increase number by 1 
            for (int i = 2; i < fiblength; ++i)
            {
                //F3 equals f1 + f2 
                f3 = f1 + f2;

                //Printing F3 
                Console.Write(f3 + " ");

                //f1 becomes the old f2 , f2 becomes the old f3 
                f1 = f2;
                f2 = f3;
            }
            Console.WriteLine("Thats it! the length is {0}", fiblength);
        }

        #endregion

        #region Calculate Speed
        public static int CockroachSpeed(double x)
        {
            double distance;
            distance = x * 27.7778;
            return (int)distance;
            //#Happy Coding! ^_^
        }
        #endregion 

        #region test for Code Wars
        public static int Test(string numbers)
        {
            int[] integers = new int[100];
            integers = Array.ConvertAll(numbers.Split(' '), int.Parse);
            int even = 0;
            int odd = 0;

            //Finding Out Which Ones have More evens or odds
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

            int item;
            if (even < odd)
            {
                for (int i = 0; i < integers.Length; i++)
                {
                    if (integers[i] % 2 == 0)
                    {
                        item = integers[i];
                        int index = integers.findIndex(item);
                        index = index + 1;
                        return index;
                    }

                }
            }
            else
            {

                for (int i = 0; i < integers.Length; i++)
                {
                    if (integers[i] % 2 != 0)
                    {
                        item = integers[i];
                        int index = integers.findIndex(item);
                        index = index + 1;
                        return index;
                    }
                }
            }
            int n = 0;
            return n;
        }

        public static int TestBetter(string numbers)
        {
            var nums = numbers.Split(' ').Select((s, i) => new { Value = int.Parse(s), Index = i });
            var even = nums.Where(x => x.Value % 2 == 0);
            var odd = nums.Where(x => x.Value % 2 == 1);
            return even.Count() == 1 ? even.First().Index + 1 : odd.First().Index + 1;
        }
        #endregion

        #region Misc
        public static string[] Solution(string str)
        {
            return Regex.Matches(str + "_", @"\w{2}").Select(x => x.Value).ToArray();
        }
        #endregion 



    }
}




    




