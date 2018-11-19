using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TWZipCodeSharp.Test
{
    [TestClass]
    public class TestTWZipCode
    {
        [TestMethod]
        public void TestMatch()
        {
            var zipCode = TWZipCode.GetZipCode("�x�_��", "�H�q��");
            Assert.AreEqual("110",zipCode);
        }

        [TestMethod]
        public void TestNotFound()
        {
            var zipCode = TWZipCode.GetZipCode("�x�_��", "��w��");
            Assert.AreEqual(null,zipCode);
        }

        [TestMethod]
        public void TestNull()
        {
            var zipCode = TWZipCode.GetZipCode(null, null);
            Assert.AreEqual(null,zipCode);
        }
    }
}
