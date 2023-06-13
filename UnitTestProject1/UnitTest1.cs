using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexUserRegistration;

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

            // Act
            bool isValidFirstName = obj.ValidateFirstName(firstName);
            bool isValidLastName = obj.ValidateLastName(lastName);
            bool isValidEmail = obj.ValidateEmail(email);
            bool isValidMobileNumber = obj.ValidateMobileNumber(mobileNumber);
            bool isValidPassword = obj.ValidatePassword(password);

            // Assert
            Assert.IsTrue(isValidFirstName);
            Assert.IsTrue(isValidLastName);
            Assert.IsTrue(isValidEmail);
            Assert.IsTrue(isValidMobileNumber);
            Assert.IsTrue(isValidPassword);
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

            // Act
            bool isValidFirstName = obj.ValidateFirstName(firstName);
            bool isValidLastName = obj.ValidateLastName(lastName);
            bool isValidEmail = obj.ValidateEmail(email);
            bool isValidMobileNumber = obj.ValidateMobileNumber(mobileNumber);
            bool isValidPassword = obj.ValidatePassword(password);

            // Assert
            Assert.IsFalse(isValidFirstName);
            Assert.IsFalse(isValidLastName);
            Assert.IsFalse(isValidEmail);
            Assert.IsFalse(isValidMobileNumber);
            Assert.IsFalse(isValidPassword);
        }
    }
}
