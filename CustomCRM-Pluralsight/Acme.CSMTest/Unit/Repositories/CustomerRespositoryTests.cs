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
        private readonly int m_testId = 1;
        private Customer m_expectedCustomer; 

        [TestInitialize]
        public void TestSetup()
        {
            m_customerRepository = new CustomerRepository();
            setupExpectedCustomer();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            m_customerRepository = null;
        }

        [TestMethod]
        public void Retrieve_Customer_By_Id()
        {
            Assert.AreEqual(m_lastName, m_customerRepository.Retrieve(m_testId).LastName);
        }

        [TestMethod]
        public void Retrieve_All_Customers()
        {
            // Act
            List<Customer> customers = m_customerRepository.Retrieve();

            // Assert
            Assert.AreEqual(3, customers.Count);
        }

        [TestMethod]
        public void Return_True_On_Save()
        {
            Assert.AreEqual(true, m_customerRepository.Save(m_customerRepository.Retrieve(m_testId)));
        }

        // TODO: add AddressList test

        [TestMethod]
        public void Retrieve_Addresses_From_Existing_Customer()
        {
            // Act
            Customer actual = m_customerRepository.Retrieve(m_testId);

            // Assert
            Assert.AreEqual(m_expectedCustomer.CustomerId, actual.CustomerId);
            Assert.AreEqual(m_expectedCustomer.EmailAddress, actual.EmailAddress);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(m_expectedCustomer.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(m_expectedCustomer.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }

        #region Private

        private void setupExpectedCustomer()
        {
            // the test data mirrors the test data structure in the AddressRepository
            // (which provides the address list to the customer. This address test data is
            // the same for every customer for now.
            // collection-initializers
            m_expectedCustomer = new Customer(m_testId)
            {
                EmailAddress = "Testy@McTesterson.org",
                FirstName = "Testy",
                LastName = "McTesterson",
                AddressList = new List<Address>()
                {
                    new Address(1)
                    {
                        StreetLine1 = "North Plum St.",
                        City = "1Testville",
                        State = "1Test",
                        Country = "1USA",
                        PostalCode = "66666-7777",
                        AddressType = AddressType.Home

                    },
                    new Address(2)
                    {
                        StreetLine1 = "777 5th Ave.",
                        City = "2Testville",
                        State = "2Test",
                        Country = "2USA",
                        PostalCode = "55555",
                        AddressType = AddressType.Work
                    }
                }
            };
        }

        #endregion
    }
}