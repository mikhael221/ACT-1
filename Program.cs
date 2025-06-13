using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();

            Console.Write("Enter your section: ");
            string section = Console.ReadLine();
            
            Console.WriteLine($"\nHello, {name}, your current sections is {section}!");

            Console.Write("Enter name of your subject: ");
            string subject = Console.ReadLine();

            Console.WriteLine($"\nHello, {name}, your current subject is {subject}!");

            int age;
            if (int.TryParse(ageInput, out age))
            {
                Console.WriteLine($"\nHello, {name}, your current age is {age}!");

                int plus = 5;
                int future = age + plus;

                Console.WriteLine($"\nHello, {name}, your age in the next 5 years will be {future}!");
            }
            else
            {
                Console.WriteLine("\nInvalid age input. Please enter a number.");
            }
        }
    }
}
