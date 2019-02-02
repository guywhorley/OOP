using System;
using Acme.CMS.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CSMTest.Unit.Entities
{
    [TestClass]
    public class Address_Should
    {
        private Address m_address;
        private readonly int m_testId = 1;

        [TestInitialize]
        public void TestSetup()
        {
            m_address = new Address(m_testId);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            m_address = null;
        }
        [TestMethod]
        public void Have_Been_Created_With_Assigned_AddressId()
        {
            Assert.AreEqual(m_testId, m_address.AddressId);
        }
    }
}
