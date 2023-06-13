using System;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    public class Program
    {
        public bool ValidateFirstName(string firstName)
        {
            string namePattern = "^[A-Z][a-zA-Z]{2,}$";
            return Regex.IsMatch(firstName, namePattern);
        }

        public bool ValidateLastName(string lastName)
        {
            string namePattern = "^[A-Z][a-zA-Z]{2,}$";
            return Regex.IsMatch(lastName, namePattern);
        }

        public bool ValidateEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-][a-zA-Z0-9]+)*\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        public bool ValidateMobileNumber(string mobileNumber)
        {
            string mobilePattern = @"^\d{2}\s\d{10}$";
            return Regex.IsMatch(mobileNumber, mobilePattern);
        }

        public bool ValidatePassword(string password)
        {
            string passwordPattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=]).{8,}$";
            return Regex.IsMatch(password, passwordPattern);
        }

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

            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();

            Program obj = new Program();
            bool isValidFirstName = obj.ValidateFirstName(firstName);
            bool isValidLastName = obj.ValidateLastName(lastName);
            bool isValidEmail = obj.ValidateEmail(email);
            bool isValidMobileNumber = obj.ValidateMobileNumber(mobileNumber);
            bool isValidPassword = obj.ValidatePassword(password);

            Console.Clear();

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

            if (isValidPassword)
            {
                Console.WriteLine("Valid password.");
            }
            else
            {
                Console.WriteLine("Invalid password.");
            }
        }
    }
}
