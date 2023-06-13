using System;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    public class Program
    {
        public Func<string, bool> ValidateFirstName = (firstName) => Regex.IsMatch(firstName, "^[A-Z][a-zA-Z]{2,}$");
        public Func<string, bool> ValidateLastName = (lastName) => Regex.IsMatch(lastName, "^[A-Z][a-zA-Z]{2,}$");
        public Func<string, bool> ValidateEmail = (email) => Regex.IsMatch(email, @"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-][a-zA-Z0-9]+)*\.[a-zA-Z]{2,}$");
        public Func<string, bool> ValidateMobileNumber = (mobileNumber) => Regex.IsMatch(mobileNumber, @"^\d{2}\s\d{10}$");
        public Func<string, bool> ValidatePassword = (password) => Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=]).{8,}$");

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

            try
            {
                if (obj.ValidateFirstName(firstName))
                    Console.WriteLine("Valid first name.");
                else
                    throw new InvalidUserDetailException("Invalid first name.");
            }
            catch (InvalidUserDetailException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                if (obj.ValidateLastName(lastName))
                    Console.WriteLine("Valid last name.");
                else
                    throw new InvalidUserDetailException("Invalid last name.");
            }
            catch (InvalidUserDetailException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                if (obj.ValidateEmail(email))
                    Console.WriteLine("Valid email address.");
                else
                    throw new InvalidUserDetailException("Invalid email address.");
            }
            catch (InvalidUserDetailException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                if (obj.ValidateMobileNumber(mobileNumber))
                    Console.WriteLine("Valid mobile number.");
                else
                    throw new InvalidUserDetailException("Invalid mobile number.");
            }
            catch (InvalidUserDetailException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                if (obj.ValidatePassword(password))
                    Console.WriteLine("Valid password.");
                else
                    throw new InvalidUserDetailException("Invalid password.");
            }
            catch (InvalidUserDetailException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class InvalidUserDetailException : Exception
    {
        public InvalidUserDetailException(string message) : base(message)
        {
        }
    }
}
