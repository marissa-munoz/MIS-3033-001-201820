//Marissa Munoz
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //static double add = 0; class level variable
            double valueThing =  Addition(5.5, 2);
            Console.WriteLine(valueThing);

            double val1 = 10.5;
            double val2 = 1.5;
            Subtraction(val1, val2);


            Console.ReadKey();
        }

        private static void Subtraction(double val1, double val2)
        {
            Console.WriteLine($"{val1 - val2}");
        }

        static double Addition(double value1, double value2)
        {
            double add = value1 + value2;
            return add; //different scope than the main method; if you were to call add in the main then you get errors, i.e. scope issue
        }

        
    }
}
