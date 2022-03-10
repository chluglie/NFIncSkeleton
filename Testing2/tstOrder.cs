using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 * For reference:
 * blOrderItem
	OrderID	 *		Int		Primary Key
	CustomerID		Int x
	ItemName		Text x
	Date			Date x
	Quantity		Int x
	Price			Double x
	OrderConfirmed	Boolean	x
 * @author CR
 */

namespace TestingOrder
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
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }

        [TestMethod]
        public void DateOK()
        {
            //creates and instance of the class i want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData  = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.Date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Date, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            //creates and instance of the class i want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //creates and instance of the class i want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Double TestData = 2.50;
            //assign the data to the property
            AnOrder.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Price, TestData);
        }

        [TestMethod]
        public void ItemNameOK()
        {
            //creates and instance of the class i want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Clipper";
            //assign the data to the property
            AnOrder.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Name, TestData);
        }

        [TestMethod]
        public void CustomerIdOK()
        {
            //creates and instance of the class i want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnOrder.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }

        public void OrderIdOK()
        {
            //creates and instance of the class i want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }


    }
}
