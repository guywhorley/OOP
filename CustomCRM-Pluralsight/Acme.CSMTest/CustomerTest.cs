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


        [TestInitialize]
        public void TestSetup()
        {
            m_customer = new Customer();
        }

        [TestMethod]
        public void FullName_IsValid()
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
        public void FullName_FirstNameEmpty()
        {
            // Arrange
            m_customer.LastName = m_lastName;

            // Act
            var expected = "McTesterson";

            // Assert
            Assert.AreEqual(expected, m_customer.FullName);
        }

        [TestMethod]
        public void FullName_LastNameEmpty()
        {
            // Arrange
            m_customer.FirstName = m_firstName;

            // Act
            var expected = "Testy";

            // Assert
            Assert.AreEqual(expected, m_customer.FullName);
        }

        [TestMethod]
        public void CustomerIncrementCount_IsCorrect()
        {
            // Arrange
            var customer1 = new Customer();
            var customer2 = new Customer();
            var customer3 = new Customer();

            // Assert
            Assert.AreEqual(4, Customer.InstanceCount);
        }
    }
}
