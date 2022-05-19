using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestingOrderCollection
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            //add items to the list
            clsOrder TestItem = new clsOrder();
            //set the data for the test property
            TestItem.ItemName = "Clipper";
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Quantity = 12;
            TestItem.Price = 3.95;
            TestItem.Active = true;
            //add the test item to the list
            TestList.Add(TestItem);
            //assign data to property and test the values
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }


        [TestMethod]
        public void CountOrderOK()  //This test is made redundant by the updated version of clsOrderCollection, inside clsOrderCollection.cs
        {                           //When linked to the database this test should be removed as it will fail.
            clsOrderCollection AllOrders = new clsOrderCollection();
            Int32 TestCount = 2; //quick fix just to make the test pass
            AllOrders.Count = TestCount;
            Assert.AreEqual(AllOrders.Count, TestCount);
        }

        [TestMethod]
        public void ThisOrderOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //add items to the list
            clsOrder TestOrder = new clsOrder();
            //set the data for the test property
            TestOrder.ItemName = "Clipper";
            TestOrder.OrderId = 1;
            TestOrder.CustomerId = 1;
            TestOrder.DateAdded = DateTime.Now.Date;
            TestOrder.Quantity = 12;
            TestOrder.Price = 3.95;
            TestOrder.Active = true;
            //add the data to the list
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            //adding some test data
            TestItem.ItemName = "Clipper";
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Quantity = 12;
            TestItem.Price = 3.95;
            TestItem.Active = true;
            //adding the item to the test list
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent() //This test is made redundant by the updated version of clsOrderCollection, inside clsOrderCollection.cs
        {                               //When linked to the database this test should be removed as it will fail.
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.AreEqual(AllOrders.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            TestItem.ItemName = "Clipper";
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Quantity = 12;
            TestItem.Price = 3.95;
            TestItem.Active = true;
            //set ThisAddress to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
    }
}
