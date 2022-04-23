using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public object CustomerId { get; set; }
        
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

        public bool Find(object OrderId)
        {
            //set the private data members to the test data value
            mOrderId = 5;
            //will cause the program to always run true
            return true;
        }



    }
}
