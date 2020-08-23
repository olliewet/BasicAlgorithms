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
            /*
            Algorithms.fizzbuzz();
            Algorithms.IsEven(10);
            Algorithms.IsEven(11);
            Algorithms.IsEven(59);
            Algorithms.Fibonacci_Seq();
            */
            //Algorithms.changeReturn();
            //Algorithms.percentageShop();

            /*
            Console.WriteLine("Enter A Number");
            int number = int.Parse(Console.ReadLine());
            bool prime = Algorithms.isPrime(number);
            if(prime)
            {
                Console.WriteLine("{0} is Prime", number);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number",number);
            }
            */
            /*
            Algorithms.reservestring();

            if(Algorithms.isPalindrome("racecar"))
            {
                Console.WriteLine("Is Paldrome");
            }
            else
            {
                Console.WriteLine("Is not");
            }

            */
            //Algorithms.countwordsinstring();

            /*
            string[] stArray = new string[]
            {
                "Password1" , "pASS" , "Three", "Olie"
            };
            
            foreach (var r in Algorithms.FriendOrFoe(stArray))
            {
                Console.WriteLine(r);
            }
           
            */

            /*
            int[] exampleTest1 = { 10, 12, 14, 16 ,17};

           
            int[] exampleTest2 = { 11, 13, 14, 15, 17 };
            Algorithms.Find(exampleTest1);
            Algorithms.Find(exampleTest2);

            
            int[] exampleTest1 = { 5, 4, 6, 17, 19 };
            Algorithms.sumTwoSmallestNumbers(exampleTest1);


            /*
            var list = new List<int>(new[] { 1, 2, 4, 7, 9 });
            var result = Enumerable.Range(0, 10).Except(list);
            Console.WriteLine(result.ToList());
            */

            //Console.WriteLine(Algorithms.IsTriangle(3, 3, 3));
            /*
            string[] names = { "Bill", "Steve", "James", "Mohan" };
            Algorithms.HasA(names);
            */


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
