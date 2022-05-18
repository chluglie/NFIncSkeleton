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
            mProductID = 15;
            mProductAvailability = true;
            mProductSupplier = "Clipper Co.";
            mProductDesc = "Blue Clipper";
            mProductRestockSched = Convert.ToDateTime("22/12/2222");
            return true;
        }
        
    } 
}