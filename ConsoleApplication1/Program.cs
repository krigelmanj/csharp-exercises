using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            double miles;
            double gallons;
            double mpg;
            string input;

            Console.Write("How many miles have you driven?");
            input = Console.ReadLine();
            miles = double.Parse(input);

            Console.Write("How many gallons of gas have you used?");
            input = Console.ReadLine();
            gallons = double.Parse(input);

            mpg = miles / gallons;
            Console.Write("You are getting " + mpg + " mpg");
            Console.ReadLine();





        }
    }
}
