using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mEmployeeIDNumber;
        private string mEmployeeFullName;
        private DateTime mEmployeeDateOfBirth;
        private string mEmployeePosition;
        private string mEmployeeSalary;
        private bool mEmployeeWorkStatus;



        public bool EmployeeWorkStatus
        {
            get
            {
                return mEmployeeWorkStatus;
            }
            set
            {
                mEmployeeWorkStatus = value;
            }
        }


        public int EmployeeIDNumber
        {
            get
            {
                return mEmployeeIDNumber;
            }
            set
            {
                mEmployeeIDNumber = value;
            }
        }


        public string EmployeeFullName
        {
            get
            {
                return mEmployeeFullName;
            }
            set
            {
                mEmployeeFullName = value;
            }
        }


        public DateTime EmployeeDateOfBirth
        {
            get
            {
                return mEmployeeDateOfBirth;

            }
            set
            {
                mEmployeeDateOfBirth = value;
            }
        }
        public string EmployeePosition
        {
            get
            {
                return mEmployeePosition;
            }
            set
            {
                mEmployeePosition = value;
            }
        }
        public string EmployeeSalary
        {
            get
            {
                return mEmployeeSalary;
            }
            set
            {
                mEmployeeSalary = value;
            }
        }

        public bool Find(int EmployeeIDNumber)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@EmployeeIDNumber", EmployeeIDNumber);

            DB.Execute("sproc_tblStaff_FilterByEmployeeIDNumber");

            if (DB.Count == 1)
            {
                mEmployeeIDNumber = Convert.ToInt32(DB.DataTable.Rows[0]["EmployeeIDNumber"]);
                mEmployeeFullName = Convert.ToString(DB.DataTable.Rows[0]["EmployeeFullName"]);
                mEmployeeDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["EmployeeDateOfBirth"]);
                mEmployeePosition = Convert.ToString(DB.DataTable.Rows[0]["EmployeePosition"]);
                mEmployeeSalary = Convert.ToString(DB.DataTable.Rows[0]["EmployeeSalary"]);
                mEmployeeWorkStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["EmployeeWorkStatus"]);

                return true;
            }

            else
            {
                return false;
            }
        }

        public string Valid(string employeeFullName, string employeeDateOfBirth, string employeePosition, string employeeSalary)
        {
            String Error = "";

            if (employeeDateOfBirth.Length == 0)
            {
                Error = Error + "The date of birth cannot be blank : ";
            }


            if (employeeFullName.Length == 0)
            {
                Error = Error + "The full name may not be blank : ";

            }

            if (employeeFullName.Length > 51)
            {
                Error = Error + "The full name cannot be longer than 50 characters : ";
            }

            if (employeePosition.Length == 0)
            {
                Error = Error + "The position may not be blank : ";

            }

            if (employeePosition.Length > 51)
            {
                Error = Error + "The position cannot be longer than 50 characters : ";

            }

            if (employeeSalary.Length == 0)
            {
                Error = Error + "The salary may not be blank : ";

            }

            if (employeeSalary.Length > 15)
            {
                Error = Error + "The salary is too long : ";

            }

            return Error;


        }


    }


}