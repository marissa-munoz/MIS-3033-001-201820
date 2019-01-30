//Marissa Munoz
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conditionals

            double cogs = 79.99;
            double gears = 250.00;
            double standardMarkup = .15;
            double combinedMarkup = .125;
            double salesTax = .089;

            //prompt user, store the number in variable
            Console.WriteLine("How many cogs?");
            double cogNumber = Convert.ToDouble(Console.ReadLine());

            double cogTotal = cogNumber * cogs;
            //prompt user, store the number in variable
            Console.WriteLine("How many gears?");
            double gearsNumber = Convert.ToDouble(Console.ReadLine());

            double gearTotal = gearsNumber * gears;

            double machineNumberPartsTotal = cogNumber + gearsNumber;

            double gearTotalWithTax = 0;
            double cogTotalWithTax = 0;

            if(cogNumber >= 10 || gearsNumber >= 10 || machineNumberPartsTotal >= 16)
            {
                gearTotalWithTax = gearTotal + (gearTotal * combinedMarkup) + (gearTotal * salesTax);
                cogTotalWithTax = cogTotal + (cogTotal * combinedMarkup) + (cogTotal * salesTax);
            }
            else
            {
                gearTotalWithTax = gearTotal + (gearTotal * standardMarkup) + (gearTotal * salesTax);
                cogTotalWithTax = cogTotal + (cogTotal * standardMarkup) + (cogTotal * salesTax);
            }

            Console.WriteLine($"Here is your total: ");
            Console.WriteLine($"Cogs: {cogNumber} and the total price is {cogTotal.ToString("C2")}: {cogTotalWithTax.ToString("C2")}");
            Console.WriteLine($"Gears: {gearsNumber} and the total price is {gearTotal.ToString("C2")}: {gearTotalWithTax.ToString("C2")}");


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
