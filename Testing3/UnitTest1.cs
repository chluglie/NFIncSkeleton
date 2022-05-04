using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class customer
            clsCustomer AnCustomer = new clsCustomer();
            //test if the the class exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void CustomerStatusOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.CustomerStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerStatus, TestData);
        }

        [TestMethod]
        public void CustomerDOBOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DOB, TestData);
        }

        public void CustomerNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "John Drill";
            //assign the data to the property
            AnCustomer.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Name, TestData);
        }

        [TestMethod]
        public void CustomerAddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "9 gayhurst leicester le4 2up";
            //assign the data to the property
            AnCustomer.CustomerAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerAddress, TestData);
        }

        [TestMethod]
        public void CustomerMobileNumberOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int64 TestData = 07442568472;
            //assign the data to the property
            AnCustomer.CustomerMobileNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerMobileNumber, TestData);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "6542561JD";
            //assign the data to the property
            AnCustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }


    }
}
