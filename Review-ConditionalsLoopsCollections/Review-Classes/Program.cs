using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Student Marissa = new Student(); //creating an instance of the student class, 
            Marissa.FirstName = "Marissa";
            Marissa.LastName = "Munoz";
            Marissa.IsOnProbation = false;
            Marissa.GPA = 3.7;
            Marissa.SoonerID = 5;

            Student yeet = new Student(3, "Yeet", "Last", 80000.5);


            Console.ReadKey();
        }
    }
}
