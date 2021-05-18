using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathDemo.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodADD()
        {
            var math = new MathDemo.Math();

            Assert.AreEqual(10, math.Add(8, 2));
            Assert.AreEqual(100, math.Add(20, 80));
        }

        [TestMethod]
        public void TestMethodSubtract()
        {
            var math = new MathDemo.Math();

            Assert.AreEqual(6, math.Subtract(8, 2));
            Assert.AreEqual(-60, math.Subtract(20, 80));
        }
    }
}
