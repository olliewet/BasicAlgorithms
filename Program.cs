using System;
using System.Diagnostics;

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

            string[] stArray = new string[]
            {
                "Password1" , "pASS" , "Three", "Olie"
            };
            
            foreach (var r in Algorithms.FriendOrFoe(stArray))
            {
                Console.WriteLine(r);
            }
           

        }
    }
}
