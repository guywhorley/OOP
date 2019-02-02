using System;
using System.Collections.Generic;
using Acme.CMS.Entities;
using Acme.CMS.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CSMTest.Unit.Repositories
{
    [TestClass]
    public class CustomerRespository_Should
    {
        private CustomerRepository m_customerRepository;
        private readonly string m_lastName = "McTesterson";

        [TestInitialize]
        public void TestSetup()
        {
            m_customerRepository = new CustomerRepository();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            m_customerRepository = null;
        }

        [TestMethod]
        public void Retrieve_Existing_Customer_By_Id()
        {
            Assert.AreEqual(m_lastName, m_customerRepository.Retrieve(1).LastName);
        }

        [TestMethod]
        public void Retrieve_All_Customers()
        {
            // Act
            List<Customer> customers = m_customerRepository.Retrieve();

            // Assert
            Assert.AreEqual(3, customers.Count);
        }
    }
}
