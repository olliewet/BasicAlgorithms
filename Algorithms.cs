﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BasicAlgorithms
{
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
            for( int num = 1 ; num <= 100; num++)
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
                else if ( num % 3 == 0 )
                {
                    Console.WriteLine("{0} Fizz" , num);
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

        public static void changeReturn()
        {
            
            decimal change;
            Console.WriteLine("Please Enter Cost Of Product:");
            decimal costProduct = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Money Given:");
            decimal moneyGiven = decimal.Parse(Console.ReadLine());

            if (moneyGiven < costProduct)
            {
                Console.WriteLine("You Cannot Afford the Product");
            }
            else
            {
                change = moneyGiven - costProduct;
                Console.WriteLine("You Have been Given {0} Back" ,change);
            }      
        }

        public static void percentageShop()
        {
            Console.WriteLine("How Much is the Item");
            decimal costProduct = decimal.Parse(Console.ReadLine());

            Console.WriteLine("What Percent is off the item");
            decimal percent = decimal.Parse(Console.ReadLine());

            decimal percentage = (costProduct / 100) * percent;

            decimal total = costProduct - percentage;
            Console.WriteLine("The Cost Of A Product is Now £{0}",total);
        }

        //Help From Stack Over Flow 
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

        public static void reservestring()
        {
            Console.WriteLine("Enter a String you want reversing");
            string userinput = Console.ReadLine();
            string reversedString = new string(userinput.Reverse().ToArray());
            Console.WriteLine(reversedString);
        }

        public static bool isPalindrome(string word)
        {
            //First Reversing the String Using LinQ
            string reversedString = new string(word.Reverse().ToArray());

            //Returning True or False
            return string.Compare(word, reversedString) == 0 ? true : false;
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

    }
}
