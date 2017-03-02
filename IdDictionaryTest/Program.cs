using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdDictionaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students =
                new Dictionary<int, string>();
            string userInput;
            int studentID;
            Console.WriteLine("Enter your students (Or enter to finish):");
            do
            {
                Console.Write("ID: ");
                userInput = (Console.ReadLine());
                if (userInput == "")
                {
                    userInput = "0";

                }
                studentID = int.Parse(userInput);
                if (studentID != 0)
                {
                    Console.Write("Name: ");
                    string studentName = Console.ReadLine();
                    students.Add(studentID, studentName);
                }
                 

            } while (studentID != 0);

            Console.WriteLine("Class Roster: ");
            StringBuilder Roster = new StringBuilder();

            foreach (KeyValuePair<int, string> student in students)
            {
                //Console.WriteLine("(ID: " + student.Key + ") " + student.Value /N);
                Roster.AppendLine("(ID: " + student.Key + ") " + student.Value );
                
            }
            Console.WriteLine(Roster);
            Console.ReadLine();
        }
    }
}
