using Microsoft.VisualStudio.TestTools.UnitTesting;
using University.Students.Api.TestService;
using System;
namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                var ttt = new TestService();
                var x = ttt.square(5);
                Assert.IsTrue(x == 25);
            }
            catch (Exception e) {
                Assert.IsTrue(false);
            }
        }
    }
}