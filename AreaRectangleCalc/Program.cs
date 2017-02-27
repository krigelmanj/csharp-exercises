using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaRectangleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double length;
            double width;
            double area;

            Console.WriteLine("Length of Rectangle");
            input = Console.ReadLine();
            length = double.Parse(input);

            Console.WriteLine("Height of Rectangle");
            input = Console.ReadLine();
            width = double.Parse(input);

            area = length * width;
            Console.WriteLine("The area of your rectangle is " + area);
            Console.ReadLine();


            
            
        }
    }
}
