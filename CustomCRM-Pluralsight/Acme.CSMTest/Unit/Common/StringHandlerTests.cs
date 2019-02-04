using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Acme.Common.StringHandler;

namespace Acme.Test.Unit.Common
{
    [TestClass]
    public class StringHandler_Should
    {
        private string m_testNameWithNoSpaces = "ThisIsATestString";
        private string m_testNameWithSpaces = "This Is A Test String";

        [TestInitialize]
        public void TestSetup()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        public void Insert_Spaces_Before_Capitalized_Words_And_Trim()
        {
            // Act
            string actual = InsertSpaces(m_testNameWithNoSpaces);

            // Assert
            Assert.AreEqual(m_testNameWithSpaces, actual);
        }

        [TestMethod]
        public void Return_Empty_String_When_Passed_Empty_String()
        {
            Assert.AreEqual(string.Empty, InsertSpaces(string.Empty));
        }

        [TestMethod]
        public void Not_Insert_Additional_Spaces_When_Already_Existing()
        {
            Assert.AreEqual(m_testNameWithSpaces, InsertSpaces(m_testNameWithSpaces));
        }

        [TestMethod]
        public void Handle_All_UpperCase()
        {
            Assert.AreEqual("A B C", InsertSpaces("ABC"));
        }
    }
}
