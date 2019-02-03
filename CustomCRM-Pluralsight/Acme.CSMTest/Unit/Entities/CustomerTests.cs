using System;
using Acme.CMS.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CSMTest
{
    [TestClass]
    public class Customer_Should
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
        public void Have_FullName_Constructed_Correctly()
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
        public void Have_FullName_When_FirstName_Is_Empty()
        {
            // Arrange
            m_customer.LastName = m_lastName;

            // Act
            var expected = "McTesterson";

            // Assert
            Assert.AreEqual(expected, m_customer.FullName);
        }

        [TestMethod]
        public void Have_FullName_When_LastName_Is_Empty()
        {
            // Arrange
            m_customer.FirstName = m_firstName;

            // Act
            var expected = "Testy";

            // Assert
            Assert.AreEqual(expected, m_customer.FullName);
        }

        [TestMethod]
        public void Set_IncrementCount_Correctly()
        {
            // Arrange
            var customer1 = new Customer();
            var customer2 = new Customer();
            var customer3 = new Customer();

            // Assert (setup adds a single customer)
            Assert.AreEqual(4, Customer.InstanceCount);
        }

        [TestMethod]
        public void Pass_Validation_When_Required_Properties_Exist()
        {
            // Arrange
            m_customer.LastName = m_lastName;
            m_customer.EmailAddress = m_email;

            // Assert
            Assert.AreEqual(true, m_customer.Validate());
        }

        [TestMethod]
        public void Fail_Validation_When_Missing_LastName()
        {
            // Arrange
            m_customer.EmailAddress = m_email;
            m_customer.LastName = String.Empty;

            // Assert
            Assert.AreEqual(false, m_customer.Validate());
        }

        [TestMethod]
        public void Fail_Validation_When_Missing_Email()
        {
            // Assert
            Assert.AreEqual(false, m_customer.Validate());
        }

        [TestMethod]
        public void Return_An_Empty_List_Of_Addresses()
        {
            Assert.IsNotNull(m_customer.AddressList);
            Assert.AreEqual(0, m_customer.AddressList.Count);
        }
    }
}