using System;
using Acme.CMS.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CSMTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        [TestCategory("Valid")]
        public void FullName_IsValid()
        {
            // Arrange
            Customer customer = new Customer()
            {
                FirstName = "Testy",
                LastName = "McTesterson"
            };

            // Act
            string expected = "Testy McTesterson";

            // Assert
            Assert.AreEqual(expected, customer.FullName);
        }

        [TestMethod]
        [TestCategory("Valid")]
        public void FullName_FirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer()
            {
                LastName = "McTesterson"
            };

            // Act
            string expected = "McTesterson";

            // Assert
            Assert.AreEqual(expected, customer.FullName);

        }

        [TestMethod]
        [TestCategory("Valid")]
        public void FullName_LastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer()
            {
                FirstName = "Testy",
            };

            // Act
            string expected = "Testy";

            // Assert
            Assert.AreEqual(expected, customer.FullName);

        }
    }
}
