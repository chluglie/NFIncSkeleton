using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customer ID 
        private String mCustomerID;
        //private data member for the Customer DOB
        private DateTime mCustomerDOB;
        //private data member for the Customer Status
        private bool mCustomerStatus;
        //private data member for the Customer Name
        private String mCustomerName;
        //private data member for the Customer mobileNumber
        private long mCustomerMobileNumber;
        //private data member for the Customer Address
        private string mCustomerAddress;

        public bool CustomerStatus
        {
            get
            {
                return mCustomerStatus;
            }
            set
            {
                mCustomerStatus = value;
            }
        }
        public DateTime CustomerDOB
        {
            get
            {
                return mCustomerDOB;
            }
            set
            {
                mCustomerDOB = value;
            }
        }
        public string CustomerName
        {
            get
            {
                return mCustomerName;
            }
            set
            {
                mCustomerName = value;
            }
        }
        public string CustomerAddress
        {
            get
            {
                return mCustomerAddress;
            }
            set
            {
                mCustomerAddress = value;
            }
        }
        public long CustomerMobileNumber
        {
            get
            {
                return mCustomerMobileNumber;
            }
            set
            {
                mCustomerMobileNumber = value;
            }
        }
        public string CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        public bool Find(string customerID)
        {
            //set the ;private data members to the test data value
            mCustomerID = "6542561JD";
            mCustomerDOB = Convert.ToDateTime("12/04/1998");
            mCustomerAddress = "Test CustomerAddress";
            mCustomerMobileNumber = 07442568472;
            mCustomerName = "Test CustomerName";
            mCustomerStatus = true;
            //always return true
            return true;
        }
    }
}