using ClassLibrary;
using System;
using System.Collections.Generic;

namespace TestingOrderCollection
{
    public class clsOrderCollection
    {
        //creating the cosntructor
        public clsOrderCollection()
        {
            //This is the first version, however the updated version using the data base is commented out beneath.
            //This is due to not having access to the time of the database at the time of coding. However, the code as been built so it
            //can easily be swapped out and used when connected to the database.

            //creating the items of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.ItemName = "Clipper";
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Quantity = 12;
            TestItem.Price = 3.95;
            TestItem.Active = true;
            //adds the item to the test list
            mOrderList.Add(TestItem);
            //reintialise the object for some new data
            TestItem = new clsOrder();
            TestItem.ItemName = "ZObbo";
            TestItem.OrderId = 2;
            TestItem.CustomerId = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Quantity = 12;
            TestItem.Price = 3.95;
            TestItem.Active = true;
            //add the item to the test list
            mOrderList.Add(TestItem);

            /*
            public clsOrderCollection() 
            {
                Int32 Index = 0;
                Int32 RecordCount = 0;
                clsDataConnection DB = new clsDatConnection();
                DB.execute("sproc_tblOrder_SelectAll");
                RecordCount = DB.Count;
                while (Index < RecordCount)
                {
                    clsOrder AnOrder = new clsOrder();
                    AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]); ;
                    AnOrder.mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                    AnOrder.mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                    AnOrder.mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                    AnOrder.mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                    AnOrder.mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                    AnOrder.mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                    mOrderList.Add(AnOrder);
                    Index++;
                }
            }
             */
        }





        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //do later
            }
        }

        private clsOrder mThisOrder;
        public clsOrder ThisOrder 
        { 
            get 
            {
                return mThisOrder;
            } 
            set 
            {
                mThisOrder = value;
            } 
        }
    }
}