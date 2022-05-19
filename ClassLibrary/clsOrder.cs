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

        public string Valid(
            string itemName,
            string dateAdded,
            long quantity,
            double price,
            long customerId)
        {
            String Error = "";
            DateTime DateTemp;
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            //customerid
            if (customerId == null)
            {
                Error = Error + "The CustomerId is invalid: ";
                throw new ArgumentNullException(nameof(customerId));
            }
            if (customerId > int.MaxValue)
            {
                Error = Error + "The CustomerId must not be greater than 2147483647: ";
            }
            if (customerId < 0)
            {
                Error = Error + "The CustomerId must not be less than 0: ";
            }

            //itemname
            if (itemName.Length == 0 || itemName.Length == null)
            {
                Error = Error + "The item name is invalid: ";
                throw new ArgumentNullException(nameof(customerId));
            }
            if (itemName.Length > 50)
            {
                Error = Error + "The item name must not be greater than 50 characters: ";
            }

            //date
            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date entered is invalid: ";
            }


            //quantity
            if (quantity == null)
            {
                Error = Error + "The quantity is invalid: ";
                throw new ArgumentNullException(nameof(quantity));
            }
            if (quantity > int.MaxValue)
            {
                Error = Error + "The quantity must not be greater than 2147483647: ";
            }
            if (quantity < 0)
            {
                Error = Error + "The quantity must not be less than 0: ";
            }

            //price
            if (price == null)
            {
                Error = Error + "The price is invalid: ";
                throw new ArgumentNullException(nameof(price));
            }
            if (price > int.MaxValue)
            {
                Error = Error + "The price must not be greater than 2147483647: ";
            }
            if (price < 0)
            {
                Error = Error + "The price must not be less than 0: ";
            }
#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            return Error;
        }

        /*
         *  Old version of the find method
        public bool Find(int OrderId)
        {
            mOrderId = 5;
            mCustomerId = 20;
            mItemName = Convert.ToString("Clipper");
            mDateAdded = Convert.ToDateTime("16/04/2022");
            mQuantity = 12;
            mPrice = 3.95;
            mActive = true;
            return true;
        }
         */
        public bool Find(int OrderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", OrderId);
            DB.Execute("sproc_tblOrders_FilterByOrderNo");
            //Due to late completion I was unable to access the database but have added the implementatiopn -
            //the procedure for the table needs creating to work correctly.
            //set the private data members to the test data value
            if (DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]); ;
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //will cause the program to always run true
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
