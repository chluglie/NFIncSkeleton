using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();


        //Constructor for the class
        public clsStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while the are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.EmployeeWorkStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["EmployeeWorkStatus"]);
                AStaff.EmployeeIDNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["EmployeeIDNumber"]);
                AStaff.EmployeeFullName = Convert.ToString(DB.DataTable.Rows[Index]["EmployeeFullName"]);
                AStaff.EmployeeDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["EmployeeDateOfBirth"]);
                AStaff.EmployeePosition = Convert.ToString(DB.DataTable.Rows[Index]["EmployeePosition"]);
                AStaff.EmployeeSalary = Convert.ToString(DB.DataTable.Rows[Index]["EmployeeSalary"]);
                //add the record to the private data mamber
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }



        public List<clsStaff> StaffList

        {
            get
            {
                //return the private data
                return mStaffList;
            }

            set
            {
                //set the private data
                mStaffList = value;

            }
        }    
            

                
            
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }

            set
            {
                //set the private data
                mThisStaff = value;

            }
        }
        public int Count
        {
            get
            {
                //return the private data
                return mStaffList.Count;
            }

            set
            {
                //we shall worry about this later
                

            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@EmployeeFullName", mThisStaff.EmployeeFullName);
            DB.AddParameter("@EmployeeDateOfBirth", mThisStaff.EmployeeDateOfBirth);
            DB.AddParameter("@EmployeePosition", mThisStaff.EmployeePosition);
            DB.AddParameter("@EmployeeSalary", mThisStaff.EmployeeSalary);
            DB.AddParameter("@EmployeeWorkStatus", mThisStaff.EmployeeWorkStatus);
            //execute the query returning the primary key values
            return DB.Execute("sproc_tblStaff_Insert");
        }


        public void Delete()
        {
            //deletes the record pointed to by thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@EmployeeIDNumber", mThisStaff.EmployeeIDNumber);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@EmployeeIDNumber", mThisStaff.EmployeeIDNumber);
            DB.AddParameter("@EmployeeFullName", mThisStaff.EmployeeFullName);
            DB.AddParameter("@EmployeeDateOfBirth", mThisStaff.EmployeeDateOfBirth);
            DB.AddParameter("@EmployeePosition", mThisStaff.EmployeePosition);
            DB.AddParameter("@EmployeeSalary", mThisStaff.EmployeeSalary);
            DB.AddParameter("@EmployeeWorkStatus", mThisStaff.EmployeeWorkStatus);
            //execute the query returning the primary key values
            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByEmployeeFullName(string EmployeeFullName)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter(@"EmployeeFullName", EmployeeFullName);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByEmployeeFullName");
            //populate the array list with the data table
            PopulateArray(DB);
        }














    }
}