using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexUserRegistration;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestValidEntries()
        {
            // Arrange
            Program obj = new Program();
            string firstName = "Karan";
            string lastName = "Depale";
            string email = "KaranTest@example.com";
            string mobileNumber = "91 1234567890";
            string password = "Pass@123";

            // Act & Assert
            try
            {
                obj.ValidateFirstName(firstName);
                obj.ValidateLastName(lastName);
                obj.ValidateEmail(email);
                obj.ValidateMobileNumber(mobileNumber);
                obj.ValidatePassword(password);
            }
            catch (InvalidUserDetailException ex)
            {
                Assert.Fail("Exception thrown: " + ex.Message);
            }
        }

        [TestMethod]
        public void TestInvalidEntries()
        {
            // Arrange
            Program obj = new Program();
            string firstName = "John123";
            string lastName = "Doe@";
            string email = "johndoecom";
            string mobileNumber = "1234567890";
            string password = "password";

            // Act & Assert
            Assert.ThrowsException<InvalidUserDetailException>(() => obj.ValidateFirstName(firstName));
            Assert.ThrowsException<InvalidUserDetailException>(() => obj.ValidateLastName(lastName));
            Assert.ThrowsException<InvalidUserDetailException>(() => obj.ValidateEmail(email));
            Assert.ThrowsException<InvalidUserDetailException>(() => obj.ValidateMobileNumber(mobileNumber));
            Assert.ThrowsException<InvalidUserDetailException>(() => obj.ValidatePassword(password));
        }

        [TestMethod]
        public void TestMultipleEmailEntries()
        {
            // Arrange
            Program obj = new Program();
            string[] validEmails = { "test@example.com", "user123@gmail.com", "john.doe@example.co.uk" };

            // Act & Assert
            foreach (string email in validEmails)
            {
                try
                {
                    obj.ValidateEmail(email);
                }
                catch (InvalidUserDetailException ex)
                {
                    Assert.Fail("Exception thrown: " + ex.Message);
                }
            }
        }
    }
}
