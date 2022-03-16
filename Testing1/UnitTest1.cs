using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
// table for reference
// [ProductId]           INT          IDENTITY (1, 1) NOT NULL,
// [ProductDesc]         VARCHAR(50) NULL,
//  [ProductSupplier]     VARCHAR(10)   NULL,
//  [ProductAvailability] BIT NULL,
//  [ProductRestockSched] DATE         NULL,
//  @Author Filip Marcinkowski
namespace TestingStock
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //creates instance of class Stock
            clsStock AStock = new clsStock();
            //shows if the classs is present
            Assert.IsNotNull(AStock);
        }
        [TestMethod]

        public void ProductIDOK()
        {
            //creates and instance of class Stock
            clsStock AStock = new clsStock();
            //creates a int type of data
            int TestData = 1;
            //sets Stock data
            //as TestData
            AStock.ProductID = TestData;

            Assert.AreEqual(AStock.ProductID, TestData);
        }
        [TestMethod]

        public void ProductDescOK()
        {
            //creates and instance of class Stock
            clsStock AStock = new clsStock();
            string TestData = "Information On Product may go up to 50 Characters";
            AStock.ProductDesc = TestData;
            Assert.AreEqual(AStock.ProductDesc, TestData);
            
        }
        [TestMethod]

        public void ProductSupplierOK()
        {
            //creates and instance of class Stock
            clsStock AStock = new clsStock();
            string TestData = "Supplier name up to 50 characters";
            AStock.ProductSupplier = TestData;
            Assert.AreEqual(AStock.ProductSupplier, TestData);
        }
        [TestMethod]
        public void AvailabilityOK()
        {
            // creates an instance of class stock
            clsStock AStock = new clsStock();
            //creates a boolean type of data to compare with clsStock
            Boolean TestData = true;
            //sets product availability in AStock to true
            AStock.ProductAvailability = TestData;
            //compares the the data
            Assert.AreEqual(AStock.ProductAvailability, TestData);
        }
        [TestMethod]

        public void ProductRestockSchedOK()
        {
            //creates and instance of class Stock
            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AStock.ProductRestockSched = TestData;
            Assert.AreEqual(AStock.ProductRestockSched, TestData);
        }
    }
}
