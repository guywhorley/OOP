using System;
using Acme.CMS.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CSMTest.Unit.Repositories
{
    [TestClass]
    public class OrderRespository_Should
    {
        private OrderRepository m_orderRepository;
        private readonly int m_testId = 1;
        private readonly int m_expectedOrderCount = 3;

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

    }
}