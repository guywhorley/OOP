using System;
using Acme.CMS.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CSMTest.Unit.Repositories
{
    [TestClass]
    public class AddressRepository_Should
    {
        private AddressRepository m_addressRepository;
        private readonly int m_testId = 1;
        private readonly string m_City = "Testville";
        private readonly int m_count = 3;

        [TestInitialize]
        public void TestSetup()
        {
            m_addressRepository = new AddressRepository();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            m_addressRepository = null;
        }

        [TestMethod]
        public void Return_True_On_Save1()
        {
            Assert.IsTrue(m_addressRepository.Save());
        }

        [TestMethod]
        public void Return_Address_By_Id()
        {
            Assert.AreEqual(m_City, m_addressRepository.Retrieve(m_testId).City);
        }

        [TestMethod]
        public void Return_All_Addresses()
        {
            Assert.AreEqual(m_count, m_addressRepository.Retrieve().Count);
        }
    }
}