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
            AnCustomer.CustomerDOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerDOB, TestData);
        }

        public void CustomerNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "John Drill";
            //assign the data to the property
            AnCustomer.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerName, TestData);
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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance for the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            String CustomerID = "6542561JD";
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance for the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            String CustomerID = "6542561JD";
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer name
            if (AnCustomer.CustomerID != "6542561JD")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerDOBFound()
        {
            //create an instance for the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            String CustomerID = "6542561JD";
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer name
            if (AnCustomer.CustomerDOB != Convert.ToDateTime("12/04/1998"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerStatusFound()
        {
            //create an instance for the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            String CustomerID = "6542561JD";
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer name
            if (AnCustomer.CustomerStatus != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerNameFound()
        {
            //create an instance for the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            String CustomerID = "6542561JD";
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer name
            if (AnCustomer.CustomerName != "Test CustomerName")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerMobileNumberFound()
        {
            //create an instance for the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            String CustomerID = "6542561JD";
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer name
            if (AnCustomer.CustomerMobileNumber != 07442568472)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instance for the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            String CustomerID = "6542561JD";
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer name
            if (AnCustomer.CustomerAddress != "Test CustomerAddress")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }






    }
}
