using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicAlgorithms
{
    class ArrayAlgorithms
    {
        #region High And Low 
        /// <summary>
        /// Finding the Maximun and Minimun of a string of Numbers 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static string HighAndLow(string numbers)
        {
            //Declaring New Array 
            int[] intarray = new int[100];

            //Converting String Into Array 
            intarray = Array.ConvertAll(numbers.Split(' '), int.Parse);

            //Grabbing Max And Min Of Array 
            int maxValue = intarray.Max();
            int lowValue = intarray.Min();

            //Returning Values
            return maxValue + " " + lowValue;
        }
        #endregion 
    }
}
