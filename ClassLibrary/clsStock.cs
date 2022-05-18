using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public clsStock() { }
            private Int32 mProductID;
        private Boolean mProductAvailability;
        private String mProductSupplier;
        private String mProductDesc;
        private DateTime mProductRestockSched;
        public bool ProductAvailability { 
            get 
            {
                return mProductAvailability;
            }
            set 
            {
                mProductAvailability = value;
            } 
        }
        public string ProductSupplier { 
            get
            {
                return mProductSupplier;
            }
            set
            {
                mProductSupplier = value;
            }
        }
        public string ProductDesc {
            get 
            {
                return mProductDesc;
            } 
            set 
            {
                mProductDesc = value;
            } 
        }
        public Int32 ProductID {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        }
        public DateTime ProductRestockSched {
            get
            {
                return mProductRestockSched;
            }
            set
            {
                mProductRestockSched = value;
            }
        }

        public bool find(int ProductID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", ProductID);
            DB.Execture("sproc_ProductTable_FilerByProductID");
            if (DB.Count == 1)
            {
                mProductID = Convert.ToInt32(DB.ProductTable.Rows[0]["ProductID"]);
                mProductAvailability = Convert.ToBoolean(DB.ProductTable.Rows[0]["ProductAvailability"]);
                mProductSupplier = Convert.ToString(DB.ProductTable.Rows[0]["ProductSupplier"]);
                mProductDesc = Convert.ToString(DB.ProductTable.Rows[0]["ProductName"]);
                mProductRestockSched = Convert.ToDateTime(DB.ProductTable.Rows[0]["ProductRestockSched"]);
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}