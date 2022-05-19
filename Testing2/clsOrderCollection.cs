using ClassLibrary;
using System;
using System.Collections.Generic;

namespace TestingOrderCollection
{

    public class clsOrderCollection
    {
        //private data member for the list and thisorder
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();
        
        /*
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
            TestItem.ItemName = "Zibbo";
            TestItem.OrderId = 2;
            TestItem.CustomerId = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Quantity = 12;
            TestItem.Price = 3.95;
            TestItem.Active = true;
            //add the item to the test list
            mOrderList.Add(TestItem);
        }
        */

        /*
        CREATE PROCEDURE sproc_tblOrder_SelectAll
        AS
        --select all records from the table
            select * from tblOrder
        RETURN 0
        */
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
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                AnOrder.ItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                AnOrder.Quantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                AnOrder.Price = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }

        

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

        public int addOrder()
        {
            return 1;
        }

        public void deleteOrder()
        {
            //needs creating
        }

        public void reportByItemName(string itemName)
        {
            //needs completing
        }

        public void updateOrders()
        {
            //needs completing
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemName", mThisOrder.ItemName);
            mThisOrder.OrderId = 123;
            return mThisOrder.OrderId;
        }

        /* SQL code for adding a new record to the SQL table.
         * As mentioned at the time of coding the database is inaccessable, so the code is here for easy implementation when accessable.
        CREATE PROCEDURE sproc_tblOrder_Insert
        --create parameters for the stored procedure
            @ItemName varchar(50),
            @Quantity int,
            @Price double,
            @Date date,
            @CustomerId int
            @Active bit

            AS
            --inserts into a new record
            INSERT TO tblOrder (ItemName, Quantity, Price, DateAdded, CustomerId, Active)
            values (@ItemName, @Quantity, @Price, @Date, @CustomerId, @Active)

            return @@Identity
         */
    }
}