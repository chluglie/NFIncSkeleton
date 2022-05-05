using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {

        string EmployeeFullName = "Janusz Jakubczyk";
        string EmployeeDateOfBirth = "16/03/2000";
        string EmployeePosition = "Staff Management";
        string EmployeeSalary = "1000£";





        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void EmployeeWorkStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.EmployeeWorkStatus = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.EmployeeWorkStatus, TestData);
        }


        [TestMethod]
        public void EmployeeIDNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.EmployeeIDNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.EmployeeIDNumber, TestData);
        }



        [TestMethod]
        public void EmployeeFullNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Josh";
            //assign the data to the property
            AStaff.EmployeeFullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.EmployeeFullName, TestData);
        }



        [TestMethod]
        public void EmployeeDateOfBirthPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStaff.EmployeeDateOfBirth = TestData;
            Assert.AreEqual(AStaff.EmployeeDateOfBirth, TestData);
        }



        [TestMethod]
        public void EmployeePositionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Smith";
            //assign the data to the property
            AStaff.EmployeePosition = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.EmployeePosition, TestData);
        }



        [TestMethod]
        public void EmployeeSalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "1000£";
            //assign the data to the property
            AStaff.EmployeeSalary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.EmployeeSalary, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 EmployeeIDNumber = 1;
            //invoke the method
            Found = AStaff.Find(EmployeeIDNumber);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }



        [TestMethod]
        public void TestEmployeeIDNumberFoundOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmployeeIDNumber = 1;
            //invoke the methods
            Found = AStaff.Find(EmployeeIDNumber);
            //check the StaffID 
            if (AStaff.EmployeeIDNumber != 1)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestEmployeeFullNameFoundOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmployeeIDNumber = 1;
            //invoke the methods
            Found = AStaff.Find(EmployeeIDNumber);
            //check the StaffID 
            if (AStaff.EmployeeFullName != "Janusz Jakubczyk")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }




        public void TestEmployeePositionFoundOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmployeeIDNumber = 1;
            //invoke the methods
            Found = AStaff.Find(EmployeeIDNumber);
            //check the StaffID 
            if (AStaff.EmployeePosition != "Staff Management")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestEmployeeDateOfBirthFoundOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmployeeIDNumber = 1;
            //invoke the methods
            Found = AStaff.Find(EmployeeIDNumber);
            //check the StaffID 
            if (AStaff.EmployeeDateOfBirth != Convert.ToDateTime("16/03/2000"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(Found);




        }

        [TestMethod]
        public void TestEmployeeSalaryFoundOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmployeeIDNumber = 1;
            //invoke the methods
            Found = AStaff.Find(EmployeeIDNumber);
            //check the StaffID 
            if (AStaff.EmployeeSalary != "1000£")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestEmployeeWorkStatusFoundOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 EmployeeIDNumber = 1;
            //invoke the methods
            Found = AStaff.Find(EmployeeIDNumber);
            //check the StaffID 
            if (AStaff.EmployeeWorkStatus != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            Assert.AreEqual(Error, "");



        }

        [TestMethod]
        public void EmployeeFullNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeeFullName = ""; //this should be ok
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeFullNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeeFullName = "a"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmployeeFullNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeeFullName = "aa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmployeeFullNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeeFullName = ""; //this should be ok
            EmployeeFullName = EmployeeFullName.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeFullNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeeFullName = ""; //this should be ok
            EmployeeFullName = EmployeeFullName.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmployeeFullNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string EmployeeFullName = ""; //this should be ok
            EmployeeFullName = EmployeeFullName.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeFullNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeeFullName = ""; //this should be ok
            EmployeeFullName = EmployeeFullName.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmployeePositionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeePosition = ""; //this should be ok
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeePositionMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeePosition = "a"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmployeePositionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeePosition = "aa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void EmployeePositionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeePosition = ""; //this should be ok
            EmployeePosition = EmployeePosition.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeePositionMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeePosition= ""; //this should be ok
            EmployeePosition = EmployeePosition.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmployeePositionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string EmployeePosition = ""; //this should be ok
            EmployeePosition = EmployeePosition.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmployeePositionMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeePosition = ""; //this should be ok
            EmployeePosition = EmployeePosition.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeDateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string EmployeeDateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeDateOfBirthMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string EmployeeDateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeDateOfBirthMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string EmployeeDateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeDateOfBirthMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string EmployeeDateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmployeeDateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeeDateOfBirth = "This is not a date!"; //this should fail
            EmployeeFullName = EmployeeFullName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeSalaryMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeeSalary = ""; //this should be ok
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeSalaryMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeeSalary = "a"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmployeeSalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeeSalary = "aa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmployeeSalaryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeeSalary = ""; //this should be ok
            EmployeeSalary = EmployeeSalary.PadRight(14, 'a');
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeSalaryMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeeSalary = ""; //this should be ok
            EmployeeSalary = EmployeeSalary.PadRight(15, 'a');
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmployeeSalaryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string EmployeeSalary = ""; //this should be ok
            EmployeeSalary = EmployeeSalary.PadRight(16, 'a');
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmployeeSalaryMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmployeeSalary = ""; //this should be ok
            EmployeeSalary = EmployeeSalary.PadRight(7, 'a');
            //invoke the method
            Error = AStaff.Valid(EmployeeFullName, EmployeeDateOfBirth, EmployeePosition, EmployeeSalary);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}
