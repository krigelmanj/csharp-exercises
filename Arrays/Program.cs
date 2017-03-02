using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            


            int[] testArray = new int[6] { 1, 1, 2, 3, 5, 8 };

            foreach (int item in testArray)
            {
                Console.WriteLine(item);
                

            }
            Console.ReadLine();

        }
    }
}
