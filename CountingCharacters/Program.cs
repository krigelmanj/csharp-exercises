using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            String testString;
            testString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Dictionary<char, int> keyCount =
                new Dictionary<char, int>();

            foreach (char c in testString)
            {
                string charCheck = c.ToString(); 
                if (!keyCount.ContainsKey(c))
                {
                    keyCount.Add(c, 0);
                    keyCount[c] += 1; 
                }
                else
                {
                    keyCount[c] += 1;
                }
            }

            //StringBuilder charList = new StringBuilder();

            foreach (KeyValuePair<char, int> charCount in keyCount)
            {
                string charHolder = charCount.Value.ToString();
                Console.WriteLine(charCount.Key + " : " + charHolder);

            }

            Console.ReadLine();
        }
    }
}
