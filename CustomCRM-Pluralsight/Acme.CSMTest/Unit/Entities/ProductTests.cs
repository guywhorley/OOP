using Acme.BL.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.Test.Unit.Entities
{
    [TestClass]
    public class Product_Should
    {
        private Product m_product;
        private Product m_invalidProduct;
        private readonly int m_testId = 123;
        private readonly string m_testNameWithNoSpaces = "TestProduct";
        private readonly string m_testNameWithSpaces = "Test Product";

        [TestInitialize]
        public void TestSetup()
        {
            m_product = new Product(m_testId)
            {
                ProductName = m_testNameWithNoSpaces,
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

        [TestMethod]
        public void Return_Name_With_Spaces_Added()
        {
            Assert.AreEqual(m_testNameWithSpaces, m_product.ProductName);
        }
    }
}