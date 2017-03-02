using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string> { "string1", "hello", "world", "Cow", "tomatoe", "Whale"};
            stringList.ForEach(Console.WriteLine);
            Console.ReadLine();
            List<string> fiveList = new List<string>(FiveList(stringList));
            fiveList.ForEach(Console.WriteLine);
            Console.ReadLine();





        }
        public static List<string> FiveList(List<string> stringList)
        {
            List<string> fiveList = new List<string>();
            foreach (string item in stringList)
            {
                if (item.Length == 5 )
                {
                    fiveList.Add(item);

                }
            }
            return fiveList;
        }
    }
}
