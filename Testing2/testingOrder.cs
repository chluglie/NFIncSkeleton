using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateAdded, TestData);
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
            AnOrder.ItemName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ItemName, TestData);
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

        [TestMethod]
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

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class i want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the resulats of validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 OrderId = 5;
            //Invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAnOrderNoFound() //This test finds the a record
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 5;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the quantity no
            if (AnOrder.OrderId != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCustomerNoFound() //This test finds the a record
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 5;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the quantity no
            if (AnOrder.CustomerId != 20)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestItemNameFound() //This test finds the a record
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 5;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.ItemName != "Clipper")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateFound() //This test finds the a record
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 5;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.DateAdded != Convert.ToDateTime("16/04/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestQuantityNoFound() //This test finds the a record
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 5;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Quantity != 12)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPriceNoFound() //This test finds the a record
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 5;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Price != 3.95)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestOrderConfirmedFound() //This test finds the a record
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 5;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
    }
}
