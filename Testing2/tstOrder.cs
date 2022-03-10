using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //creates an instance of the class i want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it has been created, and exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void ActiveOrderOK()
        {
            //creates and instance of the class i want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the order
            Boolean OrderConfirmed = true;
            //assign the data to the order
            AnOrder.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }
    }
}
