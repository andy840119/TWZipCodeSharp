using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TWZipCodeSharp.Test
{
    [TestClass]
    public class TestTWZipCode
    {
        [TestMethod]
        public void TestMatch()
        {
            var zipCode = TWZipCode.GetZipCode("台北市", "信義區");
            Assert.AreEqual("110",zipCode);
        }

        [TestMethod]
        public void TestNotFound()
        {
            var zipCode = TWZipCode.GetZipCode("台北市", "文德路");
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
