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

            Console.WriteLine("Enter Email address: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Mobile number: ");
            string mobileNumber = Console.ReadLine();

            string namePattern = "^[A-Z][a-zA-Z]{2,}$";
            string emailPattern = @"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-][a-zA-Z0-9]+)*\.[a-zA-Z]{2,}$";
            string mobilePattern = @"^\d{2}\s\d{10}$";

            bool isValidFirstName = Regex.IsMatch(firstName, namePattern);
            bool isValidLastName = Regex.IsMatch(lastName, namePattern);
            bool isValidEmail = Regex.IsMatch(email, emailPattern);
            bool isValidMobileNumber = Regex.IsMatch(mobileNumber, mobilePattern);

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

            if (isValidEmail)
            {
                Console.WriteLine("Valid email address.");
            }
            else
            {
                Console.WriteLine("Invalid email address.");
            }

            if (isValidMobileNumber)
            {
                Console.WriteLine("Valid mobile number.");
            }
            else
            {
                Console.WriteLine("Invalid mobile number.");
            }
        }
    }
}
