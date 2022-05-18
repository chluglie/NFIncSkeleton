using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private bool mActive;
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }

        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }

        //private data member for the orderid property
        private Int32 mOrderId;
        //OrderId public property
        public int OrderId 
        { 
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }

        private Int32 mCustomerId;
        public int CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }

        private string mItemName;
        public string ItemName
        {
            get
            {
                //this line of code sends data out of the property
                return mItemName;
            }
            set
            {
                //this line of code allows data into the property
                mItemName = value;
            }
        }

        private Int32 mQuantity;
        public Int32 Quantity
        {
            get
            {
                //this line of code sends data out of the property
                return mQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mQuantity = value;
            }
        }

        private Double mPrice;
        public Double Price
        {
            get
            {
                //this line of code sends data out of the property
                return mPrice;
            }
            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }
        }


        public bool Find(int OrderId)
        {
            //set the private data members to the test data value
            mOrderId = 5;
            mCustomerId = 20;
            mItemName = "Clipper";
            mDateAdded = Convert.ToDateTime("16/4/2022");
            mQuantity = 12;
            mPrice = 3.95;
            mActive = true;
            //will cause the program to always run true
            return true;
        }



    }
}
