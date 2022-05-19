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

        [TestMethod]
        public void UpdateMethodOK()
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
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //modify the test data
            TestItem.ItemName = "Zibbo";
            TestItem.OrderId = 3;
            TestItem.CustomerId = 7;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Quantity = 4;
            TestItem.Price = 7.69;
            TestItem.Active = false;
            //set the record based on the new test data and update the record
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            //find the recond and test to see if order matches
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ReporttByItemNameOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.reportByItemName("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByItemNameNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.reportByItemName("lighter");
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByItemNameTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            //apply a lighter that doesnt exist
            FilteredOrders.reportByItemName("Electric Lighter");
            if (FilteredOrders.Count == 2)
            {
                //checks that the first record is id 2
                if (FilteredOrders.OrderList[0].OrderId != 2)
                {
                    OK = false;
                }
                //checks that the first record is id 3
                if (FilteredOrders.OrderList[0].OrderId != 3)
                {
                    OK = false;
                }
            } 
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        

        /* SQL code for reporting by Item Name
         * 
CREATE PROCEDURE [dbo].sproc_tblOrder_FilterByItemName
    @ItemName varchar (50)
AS
    select * from tblOrder where ItemName like @ItemName+'%';   
         */
    }
}
