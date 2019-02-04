using System;
using Acme.BL.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.Test.Unit.Entities
{
    [TestClass]
    public class Order_Should
    {
        private Order m_order;
        private Order m_invalidOrder;
        private readonly int m_testId = 777;

        [TestInitialize]
        public void TestSetup()
        {
            m_order = new Order(m_testId)
            {
                OrderDate = new DateTimeOffset()
            };
            m_invalidOrder = new Order();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            m_order = null;
            m_invalidOrder = null;
        }

        [TestMethod]
        public void Have_Been_Created_With_Assigned_OrderId()
        {
            Assert.AreEqual(m_testId, m_order.OrderId);
        }

        [TestMethod]
        public void Pass_Validation_When_OrderDate_Is_Valid()
        {
            Assert.IsTrue(m_order.Validate());
        }

        [TestMethod]
        public void Fail_Validation_When_OrderDate_IsNull()
        {
            Assert.IsFalse(m_invalidOrder.Validate());
        }
    }
}