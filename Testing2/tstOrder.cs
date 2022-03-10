using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void TestMethod1()
        {
            //creates an instance of the class i want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it has been created, and exists
            Assert.IsNotNull(AnOrder);
        }
    }
}
