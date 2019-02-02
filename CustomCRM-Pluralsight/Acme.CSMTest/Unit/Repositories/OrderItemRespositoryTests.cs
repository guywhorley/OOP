using System;
using Acme.CMS.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CSMTest.Unit.Repositories
{
    [TestClass]
    public class OrderItemRepository_Should
    {
        private OrderItemRepository m_orderItemRepository;
        private readonly int m_testId = 1;
        private readonly decimal m_purchasePrice = 9.99M;
        private readonly int m_expectedCount = 3;

        [TestInitialize]
        public void TestSetup()
        {
            m_orderItemRepository = new OrderItemRepository();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            m_orderItemRepository = null;
        }

        [TestMethod]
        public void Return_True_On_Save()
        {
            Assert.IsTrue(m_orderItemRepository.Save());
        }

        [TestMethod]
        public void Retrieve_OrderItem_By_Id()
        {
            Assert.AreEqual(m_purchasePrice, m_orderItemRepository.Retrieve(m_testId).PurchasePrice);
        }

        [TestMethod]
        public void Retrieve_All_OrderItems()
        {
            Assert.AreEqual(m_expectedCount, m_orderItemRepository.Retrieve().Count);
        }
    }
}