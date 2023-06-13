using System;
using System.Text.RegularExpressions;

namespace RegexUserRegistration
{
    public class Program
    {
        public void ValidateFirstName(string firstName)
        {
            string namePattern = "^[A-Z][a-zA-Z]{2,}$";
            if (!Regex.IsMatch(firstName, namePattern))
            {
                throw new InvalidUserDetailException("Invalid first name.");
            }
        }

        public void ValidateLastName(string lastName)
        {
            string namePattern = "^[A-Z][a-zA-Z]{2,}$";
            if (!Regex.IsMatch(lastName, namePattern))
            {
                throw new InvalidUserDetailException("Invalid last name.");
            }
        }

        public void ValidateEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.-][a-zA-Z0-9]+)*\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                throw new InvalidUserDetailException("Invalid email address.");
            }
        }

        public void ValidateMobileNumber(string mobileNumber)
        {
            string mobilePattern = @"^\d{2}\s\d{10}$";
            if (!Regex.IsMatch(mobileNumber, mobilePattern))
            {
                throw new InvalidUserDetailException("Invalid mobile number.");
            }
        }

        public void ValidatePassword(string password)
        {
            string passwordPattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=]).{8,}$";
            if (!Regex.IsMatch(password, passwordPattern))
            {
                throw new InvalidUserDetailException("Invalid password.");
            }
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

            try
            {
                obj.ValidateFirstName(firstName);
                Console.WriteLine("Valid first name.");
            }
            catch (InvalidUserDetailException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                obj.ValidateLastName(lastName);
                Console.WriteLine("Valid last name.");
            }
            catch (InvalidUserDetailException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                obj.ValidateEmail(email);
                Console.WriteLine("Valid email address.");
            }
            catch (InvalidUserDetailException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                obj.ValidateMobileNumber(mobileNumber);
                Console.WriteLine("Valid mobile number.");
            }
            catch (InvalidUserDetailException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                obj.ValidatePassword(password);
                Console.WriteLine("Valid password.");
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
