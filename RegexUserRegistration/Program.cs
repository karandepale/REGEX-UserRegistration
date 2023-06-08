using System;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last name: ");
            string lastName = Console.ReadLine();

            string namePattern = "^[A-Z][a-zA-Z]{2,}$";
            bool isValidFirstName = Regex.IsMatch(firstName, namePattern);
            bool isValidLastName = Regex.IsMatch(lastName, namePattern);

            if (isValidFirstName)
            {
                Console.WriteLine("Valid first name.");
            }
            else
            {
                Console.WriteLine("Invalid first name.");
            }

            if (isValidLastName)
            {
                Console.WriteLine("Valid last name.");
            }
            else
            {
                Console.WriteLine("Invalid last name.");
            }
        }
    }
}
