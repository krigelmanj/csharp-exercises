using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            string input;
            //var answer= "";

            text = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            Console.Write(text);
            Console.ReadLine();

            Console.Write("What word would you like to search this text for.");
            input = Console.ReadLine();

            if (text.Contains(input))
            {
                Console.WriteLine("The word is contained within the text");
            }
            else if (text.Contains(input.ToLower()))
            {
                Console.WriteLine("Although word is contained within the text, it is not capitalized");
            }
           
            else
            {
                Console.WriteLine("The word is not within the text");
            }


            //Console.Write(answer);
            Console.ReadLine();


        }
    }
}
