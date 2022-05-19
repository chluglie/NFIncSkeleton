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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
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
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@Date", mThisOrder.DateAdded);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@Active", mThisOrder.Active);
            return DB.Execute("sproc_tblOrder_Insert");
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

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemName", mThisOrder.ItemName);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@Date", mThisOrder.DateAdded);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@Active", mThisOrder.Active);
            DB.Execute("sproc_tblOrder_Update");
        }

        /* SQL Code for Update
         * 
CREATE PROCEDURE sproc_tblOrder_Update
--create parameters for the stored procedure
    @OrderId int,
    @ItemName varchar(50),
    @Quantity int,
    @Price double,
    @Date date,
    @CustomerId int,
    @Active bit

    AS
    --update the record as the specified by @OrderId value
    update tblOrder
    set ItemName=@ItemName,
        Quantity=@Quantity,
        Price=@Price,
        DateAdded=@Date,
        CustomerId=@CustomerId,
        Active=@Active,

    where OrderId=@OrderId
         */

        public void Delete()
        {

        }

        /* SQL Code for Delete
         * 
        
         */
    }
}