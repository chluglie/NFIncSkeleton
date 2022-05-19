using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingOrder
{
    [TestClass]
    public class tstOrder
    {
        //good test data
           
        string ItemName = "Clipper";
        string DateAdded = DateTime.Now.Date.ToString();
        int Quantity = 12;
        double Price = 3.95;
        int CustomerId = 20;

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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }

        //Tests for CustomerId
        [TestMethod]
        public void CustomerIdMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 CustomerId = 0;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 CustomerId = -1;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 CustomerId = 1;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int64 CustomerId = -5000000000; //this should fail
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 CustomerId = 2147483646;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIdMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 CustomerId = 2147483647;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int64 CustomerId = 2147483648; //this should fail
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int64 CustomerId = 5000000000; //this should fail
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIdMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 CustomerId = 1073741823;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }

        //Tests for ItemName 
        
        [TestMethod]
        public void ItemNameMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ItemName = "a";
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ItemName = "aa";
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ItemName = "";
            ItemName = ItemName.PadRight(49, 'a');
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemNameMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ItemName = "";
            ItemName = ItemName.PadRight(50, 'a');
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ItemName = "";
            ItemName = ItemName.PadRight(51, 'a');
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ItemName = "";
            ItemName = ItemName.PadRight(500, 'a');
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ItemName = "";
            ItemName = ItemName.PadRight(25, 'a');
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }

        //Tests for Date
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        } 
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(+100);
            string DateAdded = TestDate.ToString();
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }  

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DateAdded = "This is not a date!";
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }


        //Tests for Quantity
        [TestMethod]
        public void QuantityMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 Quantity = 0;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 Quantity = -1;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 Quantity = 1;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int64 Quantity = -5000000000; //this should fail
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 Quantity = 2147483646;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 Quantity = 2147483647;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int64 Quantity = 2147483648; //this should fail
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int64 Quantity = 5000000000; //this should fail
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 Quantity = 1073741823;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }

        //Test for Price
        [TestMethod]
        public void PriceIdMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 Price = 0;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 Price = -1;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 Price = 1;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int64 Price = -5000000000; //this should fail
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 Price = 2147483646;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 Price = 2147483647;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int64 Price = 2147483648; //this should fail
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int64 Price = 5000000000;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Int32 Price = 1073741823;
            Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
            Assert.AreEqual(Error, "");
        }
    }
}
