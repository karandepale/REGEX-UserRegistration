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

            string pattern = "^[A-Z][a-zA-Z]{2,}$";
            bool isValidFirstName = Regex.IsMatch(firstName, pattern);

            if (isValidFirstName)
            {
                Console.WriteLine("Valid first name.");
            }
            else
            {
                Console.WriteLine("Invalid first name.");
            }
        }
    }
}
