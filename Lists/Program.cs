using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                intList.Add(i);
            }


            List<int> evenList = EvenList(intList);
            
             
            for (int i = 0; i < evenList.Count; i++)
            {
                Console.Write(evenList[i]);
            }

            Console.ReadLine();

        }
        public static List<int> EvenList(List<int> intList)
        {
            List<int> evenList = new List<int>();

            foreach (int integer in intList)
            {
                if (integer % 2 == 0)
                {
                    evenList.Add(integer);
                }

            }
            return evenList;

        }
       


    }
         
}
