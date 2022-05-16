using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class ConsoleMessages
    {
        public static void SayHi(string firstName)
        {
            Console.WriteLine($"Hello {firstName}");
        }

        public static void SayGoodbye()
        {
            Console.WriteLine("Goodbye!");
            Console.WriteLine("Thank you for visiting.");
        }

        public static string GetUsersName()
        {
            Console.Write("Enter your first name: ");
            string name = Console.ReadLine();
            return name;
        }

        public static (double, double) GetTwoNumbers()
        {
            bool isValid = false;
            bool isValid2 = false;
            double firstNumber = 1;
            double secondNumber = 1;

            while (!isValid)
            {
                Console.Write("Enter the first number: ");
                isValid = double.TryParse(Console.ReadLine(), out firstNumber);
            }
            while (!isValid2)
            { 
                Console.Write("Enter the second number: ");
                isValid2 = double.TryParse(Console.ReadLine(), out secondNumber);
            }

            return (firstNumber, secondNumber);

        }

        public static (string, string) GetFullName()
        {
            string? firstName;
            string? lastName;
            do
            {
                Console.Write("Enter your first name: ");
                firstName = Console.ReadLine();
            }   while (string.IsNullOrEmpty(firstName));

            do
            {
                Console.Write("Enter your last name: ");
                lastName = Console.ReadLine();
            }   while (string.IsNullOrEmpty(lastName));
             
            return (firstName, lastName);
        } 
                    
    }
}
