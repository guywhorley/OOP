using System;
using Acme.CMS.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CSMTest
{
    [TestClass]
    public class Product_Should
    {
        private Product m_product;
        private Product m_invalidProduct;
        private readonly int m_testId = 123;

        [TestInitialize]
        public void TestSetup()
        {
            m_product = new Product(m_testId)
            {
                ProductName = "Test Product",
                CurrentPrice = 1.99M
            };

            m_invalidProduct = new Product(777);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            m_product = null;
            m_invalidProduct = null;
        }

        [TestMethod]
        public void Have_Been_Created_With_Assigned_ProductId()
        {
            Assert.AreEqual(m_testId, m_product.ProductId);
        }

        [TestMethod]
        public void Pass_Validation_With_Required_Fields()
        {
            Assert.IsTrue(m_product.Validate());
        }

        [TestMethod]
        public void Fail_Validation_When_Name_Is_Missing()
        {
            Assert.IsFalse(m_invalidProduct.Validate());
        }

        [TestMethod]
        public void Fail_Validation_When_CurrentPrice_IsNull()
        {
            Assert.IsFalse(m_invalidProduct.Validate());
        }
    }
}