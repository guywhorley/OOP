using Acme.BL.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.Test.Unit.Entities
{
    [TestClass]
    public class OrderItem_Should
    {
        private OrderItem m_orderItem;
        private readonly int m_testId = 777;
        private readonly int m_OrderQuantity = 3;
        private readonly int m_ProductId = 2019;
        private readonly decimal m_purchasePrice = 2.99M;
        private OrderItem m_invalidOrderItem;

        [TestInitialize]
        public void TestSetup()
        {
            m_orderItem = new OrderItem(m_testId)
            {
                OrderQuantity = m_OrderQuantity,
                PurchasePrice = m_purchasePrice,
                ProductId = m_ProductId
            };
            m_invalidOrderItem = new OrderItem();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            m_orderItem = null;
            m_invalidOrderItem = null;
        }

        [TestMethod]
        public void Have_Been_Created_With_Assigned_OrderItemId()
        {
            Assert.AreEqual(m_testId, m_orderItem.OrderItemId);
        }

        [TestMethod]
        public void Pass_Validation_When_Required_Properties_Are_Set()
        {
            Assert.IsTrue(m_orderItem.Validate());
        }

        [TestMethod]
        public void Fail_Validation_When_OrderQuantity_Is_Missing()
        {
            // Arrange
            m_invalidOrderItem.ProductId = m_ProductId;
            m_invalidOrderItem.PurchasePrice = m_purchasePrice;

            // Assert
            Assert.IsFalse(m_invalidOrderItem.Validate());
        }

        [TestMethod]
        public void Fail_Validation_When_ProductId_Is_Missing()
        {
            // Arrange
            m_invalidOrderItem.OrderQuantity = m_OrderQuantity;
            m_invalidOrderItem.PurchasePrice = m_purchasePrice;

            // Assert
            Assert.IsFalse(m_invalidOrderItem.Validate());
        }

        [TestMethod]
        public void Fail_Validation_When_PurchasePrice_Is_Missing()
        {
            // Arrange
            m_invalidOrderItem.OrderQuantity = m_OrderQuantity;
            m_invalidOrderItem.ProductId = m_ProductId;

            // Assert
            Assert.IsFalse(m_invalidOrderItem.Validate());
        }
    }
}