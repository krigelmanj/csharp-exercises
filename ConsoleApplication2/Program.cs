using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        private static bool fail;

        static void Main(string[] args)
        {
            double radius;
            string input;
            double area;
            double pi;
            pi = Math.PI;
            radius = 0;
            do
            {
                if (fail == false)
                {
                    Console.WriteLine("Enter a radius");
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your radius must be greater than 0, please enter an acceptable radius");
                    input = Console.ReadLine();
                }

                radius = double.Parse(input);

                if (radius <= 0)
                {
                   
                    fail = true;
                }
                else
                {
                    fail = false;
                }

            } while(fail);



            area = pi * radius * radius;

            Console.WriteLine("The radius of a circle of radius "+ radius + " is " + area + ".");
            Console.ReadLine();



        }
    }
}
