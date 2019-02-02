using System;
using Acme.CMS.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CSMTest
{
    [TestClass]
    public class CustomerTest
    {
        private Customer m_customer;
        private static readonly string m_firstName = "Testy";
        private static readonly string m_lastName = "McTesterson";
        private static readonly string m_email = "Testy@McTesterson.org";


        [TestInitialize]
        public void TestSetup()
        {
            m_customer = new Customer();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Customer.InstanceCount = 0;
        }

        [TestMethod]
        public void Customer_FullName_ConstructedCorrectly()
        {
            // Arrange
            m_customer.FirstName = m_firstName;
            m_customer.LastName = m_lastName;

            // Act
            var expected = "Testy McTesterson";

            // Assert
            Assert.AreEqual(expected, m_customer.FullName);
        }

        [TestMethod]
        public void Customer_FullName_FirstNameEmpty()
        {
            // Arrange
            m_customer.LastName = m_lastName;

            // Act
            var expected = "McTesterson";

            // Assert
            Assert.AreEqual(expected, m_customer.FullName);
        }

        [TestMethod]
        public void Customer_FullName_LastNameEmpty()
        {
            // Arrange
            m_customer.FirstName = m_firstName;

            // Act
            var expected = "Testy";

            // Assert
            Assert.AreEqual(expected, m_customer.FullName);
        }

        [TestMethod]
        public void Customer_IncrementCount_IsCorrect()
        {
            // Arrange
            var customer1 = new Customer();
            var customer2 = new Customer();
            var customer3 = new Customer();

            // Assert
            Assert.AreEqual(4, Customer.InstanceCount);
        }

        [TestMethod]
        public void Customer_Valid_Validate_ReturnsTrue()
        {
            // Arrange
            m_customer.LastName = m_lastName;
            m_customer.EmailAddress = m_email;

            // Assert
            Assert.AreEqual(true, m_customer.Validate());
        }
        
        [TestMethod]
        public void Customer_NoLastName_Validate_ReturnsFalse()
        {
            // Arrange
            m_customer.EmailAddress = m_email;
            m_customer.LastName = String.Empty;

            // Assert
            Assert.AreEqual(false, m_customer.Validate());
        }

        [TestMethod]
        public void Customer_NoEmail_Validate_ReturnsFalse()
        {
            // Assert
            Assert.AreEqual(false, m_customer.Validate());
        }
    }
}
