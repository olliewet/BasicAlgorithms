using System;
using System.Collections.Generic;
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

    }
}
