using System;
using System.Collections.Generic;
using Acme.BL.Entities;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.Test.Unit.Common
{
    [TestClass]
    public class LoggingService_Should
    {
        [TestMethod]
        public void Write_Changed_Items_To_Output()
        {
            // Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer()
            {
                EmailAddress = "Testy@McTesterson.test",
                FirstName = "Testy",
                LastName = "McTesterson",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product()
            {
                ProductName = "Rake",
                ProductDescription = "Garden rake with steel head.",
                CurrentPrice = 12.99M
            };
            changedItems.Add(product);

            var order = new Order(777)
            {
                OrderDate = new DateTimeOffset(),
            };
            changedItems.Add(order);

            // Act
            LoggingService.WriteToFile(changedItems, "Testing...");

            // Assert - Nothing to assert for now.
        }
    }
}