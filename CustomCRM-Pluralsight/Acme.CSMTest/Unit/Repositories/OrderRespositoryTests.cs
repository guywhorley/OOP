using System;
using System.Collections.Generic;
using Acme.CMS.Entities;
using Acme.CMS.Repositories;
using Acme.CMS.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CSMTest.Unit.Repositories
{
    [TestClass]
    public class OrderRespository_Should
    {
        private OrderRepository m_orderRepository;
        private readonly int m_testId = 1;
        private readonly int m_expectedOrderCount = 3;
        private OrderDisplay m_expOrderDisplay;
        private readonly int m_testOrderId = 10;

        [TestInitialize]
        public void TestSetup()
        {
            m_orderRepository = new OrderRepository();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            m_orderRepository = null;
        }

        [TestMethod]
        public void Return_True_On_Save()
        {
            Assert.IsTrue(m_orderRepository.Save(m_orderRepository.Retrieve(m_testId)));
        }

        [TestMethod]
        public void Retrieve_Product_By_Id()
        {
            Assert.AreEqual(m_testId, m_orderRepository.Retrieve(m_testId).OrderId);
        }

        [TestMethod]
        public void Retrieve_All_Orders()
        {
            Assert.AreEqual(m_expectedOrderCount, m_orderRepository.Retrieve().Count);
        }

        [TestMethod]
        public void Retrieve_OrderDisplay_By_OrderId()
        {
            // Arrange
            setupExpectedOrderDisplay();

            // Act
            var actual = m_orderRepository.RetrieveOrderDisplay(m_testOrderId);

            // Assert
            Assert.AreEqual(m_expOrderDisplay.FirstName, actual.FirstName);
            Assert.AreEqual(m_expOrderDisplay.LastName, actual.LastName);
            Assert.AreEqual(m_expOrderDisplay.ShippingAddress.City, actual.ShippingAddress.City);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(m_expOrderDisplay.OrderDisplayItemList[i].PurchasePrice,
                    actual.OrderDisplayItemList[i].PurchasePrice);
                Assert.AreEqual(m_expOrderDisplay.OrderDisplayItemList[i].OrderQuantity,
                    actual.OrderDisplayItemList[i].OrderQuantity);
            }
        }

        #region Private

        private void setupExpectedOrderDisplay()
        {
            m_expOrderDisplay = new OrderDisplay()
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                OrderDate = new DateTimeOffset(),
                ShippingAddress = new Address()
                {
                    AddressType = AddressType.Work,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                },
                OrderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        ProductName = "Sunflowers",
                        PurchasePrice = 15.96M,
                        OrderQuantity = 2
                    },
                    new OrderDisplayItem()
                    {
                        ProductName = "Rake",
                        PurchasePrice = 6M,
                        OrderQuantity = 1
                    }
                }
            };
        }

        #endregion
    }
}