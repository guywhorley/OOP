using System.Collections.Generic;
using Acme.CMS.Repositories;
using Acme.CMS.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Acme.CSMTest.Unit.Repositories
{
    [TestClass]
    public class ProductRepository_Should
    {
        private ProductRepository m_productRepository;
        private readonly string m_productName = "Sunflowers";

        [TestInitialize]
        public void TestSetup()
        {
            m_productRepository = new ProductRepository();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            m_productRepository = null;
        }

        [TestMethod]
        public void Retrieve_Product_By_Id()
        {
            Assert.AreEqual(m_productName, m_productRepository.Retrieve(2).ProductName);
        }

        [TestMethod]
        public void Retrieve_All_Products()
        {
            // Act
            List<Product> products = m_productRepository.Retrieve();

            // Assert
            Assert.AreEqual(3, products.Count);
        }

        [TestMethod]
        public void Return_True_On_Save()
        {
            Assert.AreEqual(true, m_productRepository.Save());
        }
    }
}