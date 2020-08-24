using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAlgorithms
{
    class PracticeApplications
    {
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
                Console.WriteLine("You Have been Given {0} Back", change);
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
            Console.WriteLine("The Cost Of A Product is Now £{0}", total);
        }

    }
}
