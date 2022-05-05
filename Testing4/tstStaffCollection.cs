using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);

        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();

            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.EmployeeWorkStatus = true;
            TestItem.EmployeeDateOfBirth = Convert.ToDateTime("16/03/2000");
            TestItem.EmployeeFullName = "Janusz Jakubczyk";
            TestItem.EmployeePosition = "Staff Management";
            TestItem.EmployeeSalary = "1000£";
            TestItem.EmployeeIDNumber = 1;

            TestList.Add(TestItem);

            AllStaff.StaffList = TestList;



            Assert.AreEqual(AllStaff.StaffList, TestList);
        }


        [TestMethod]

        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestStaff = new clsStaff();

            TestStaff.EmployeeWorkStatus = true;
            TestStaff.EmployeeDateOfBirth = Convert.ToDateTime("16/03/2000");
            TestStaff.EmployeeFullName = "Janusz Jakubczyk";
            TestStaff.EmployeePosition = "Staff Management";
            TestStaff.EmployeeSalary = "1000£";
            TestStaff.EmployeeIDNumber = 1;

            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

       // [TestMethod]
       // public void CountPropertyOK()
       // {
       //    //create an instance of the class we want to create
       //     clsStaffCollection AllStaff = new clsStaffCollection();
       //     //create some test data to assign to the property
       //     Int32 SomeCount = 0;
       //     //assign the data to the property
       //     AllStaff.Count = SomeCount;
       //     //test to see that the two values are the same
       //     Assert.AreEqual(AllStaff.Count, SomeCount);
       // }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();

            TestItem.EmployeeWorkStatus = true;
            TestItem.EmployeeFullName = "Janusz Jakubczyk";
            TestItem.EmployeeDateOfBirth = Convert.ToDateTime("16/03/2000");
            TestItem.EmployeePosition = "Staff Management";
            TestItem.EmployeeSalary = "1000£";
            TestItem.EmployeeIDNumber = 1;

            TestList.Add(TestItem);

            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

       // [TestMethod]

       // public void TwoRecordsPresent()
       // {
       //     //create an instance of the class we want to create 
       //     clsStaffCollection AllStaff = new clsStaffCollection();
       //     //test to see that the two values are the same
       //     Assert.AreEqual(AllStaff.Count, 2);
       // }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the data 
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.EmployeeWorkStatus = true;
            TestItem.EmployeeFullName = "Janusz Jakubczyk";
            TestItem.EmployeeDateOfBirth = Convert.ToDateTime("16/03/2000");
            TestItem.EmployeePosition = "Staff Management";
            TestItem.EmployeeSalary = "1000£";
            TestItem.EmployeeIDNumber = 1;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.EmployeeIDNumber = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.EmployeeWorkStatus = true;
            TestItem.EmployeeFullName = "Janusz Jakubczyk";
            TestItem.EmployeeDateOfBirth = Convert.ToDateTime("16/03/2000");
            TestItem.EmployeePosition = "Staff Management";
            TestItem.EmployeeSalary = "1000£";
            TestItem.EmployeeIDNumber = 1;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.EmployeeIDNumber = PrimaryKey;
            //Find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //Delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.EmployeeWorkStatus = true;
            TestItem.EmployeeFullName = "Janusz Jakubczyk";
            TestItem.EmployeeDateOfBirth = Convert.ToDateTime("16/03/2000");
            TestItem.EmployeePosition = "Staff Management";
            TestItem.EmployeeSalary = "1000£";
            TestItem.EmployeeIDNumber = 1;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.EmployeeIDNumber = PrimaryKey;
            //modify the test data
            TestItem.EmployeeWorkStatus = false;
            TestItem.EmployeeFullName = "Piotr Jakubczyk";
            TestItem.EmployeeDateOfBirth = Convert.ToDateTime("17/03/2001");
            TestItem.EmployeePosition = "Stock Management";
            TestItem.EmployeeSalary = "2000£";
            TestItem.EmployeeIDNumber = 2;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void ReportByFullNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records);
            FilteredStaff.ReportByEmployeeFullName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }



        [TestMethod]
        public void ReportByEmployeeFullNameNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a post code that doesn't exist
            FilteredStaff.ReportByEmployeeFullName("baka kaak");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }


        [TestMethod]
        public void ReportByEmployeeFullNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredStaff.ReportByEmployeeFullName("kaak baka");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredStaff.StaffList[0].EmployeeIDNumber != 36)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredStaff.StaffList[1].EmployeeIDNumber != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }





    }
}
