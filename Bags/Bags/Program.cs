using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bags
{


    class Bags
    {
        static void Main()
        {
            int bagsOrdered, largeBoxes = 0, mediumBoxes = 0, smallBoxes = 0;
            double totalCost;

            Console.Write("Number of Bags Ordered: ");
            bagsOrdered = int.Parse(Console.ReadLine());

            // Calculate the number of boxes needed for each size
            largeBoxes = bagsOrdered / 20;
            bagsOrdered %= 20;
            mediumBoxes = bagsOrdered / 10;
            bagsOrdered %= 10;
            smallBoxes = bagsOrdered / 5;
            bagsOrdered %= 5;

            // Calculate the total cost
            totalCost = largeBoxes * 3.00 + mediumBoxes * 2.50 + smallBoxes * 2.00 + bagsOrdered * 5.50;

            // Output the results
            Console.WriteLine("Boxes Used:");
            Console.WriteLine("Large - {0}", largeBoxes);
            Console.WriteLine("Medium - {0}", mediumBoxes);
            Console.WriteLine("Small - {0}", smallBoxes);
            Console.WriteLine("Your total cost is: ${0:0.00}", totalCost);
            Console.ReadLine();
        }
    }
         
}




