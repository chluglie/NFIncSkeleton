using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using TestingOrderCollection;

public partial class _1_DataEntry: System.Web.UI.Page
{
    Int32 OrderId;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]); //why is this not able to access?
        if (IsPostBack == false)
        {
            if (OrderId != -1)
            {
                DisplayOrders();
            }
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();

        OrderBook.ThisOrder.Find(OrderId);

        txtOrderId.Text = OrderBook.ThisOrder.OrderId.ToString();
        txtItemName.Text = OrderBook.ThisOrder.ItemName;
        txtPrice.Text = OrderBook.ThisOrder.Price.ToString();
        txtQuantity.Text = OrderBook.ThisOrder.Quantity.ToString();
        txtDate.Text = OrderBook.ThisOrder.DateAdded.ToString();
        txtCustomerId.Text = OrderBook.ThisOrder.CustomerId.ToString();
        chkActive.Checked = OrderBook.ThisOrder.Active;
    }
                
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the values
        string ItemName = txtItemName.Text;
        string DateAdded = txtDate.Text;
        long Quantity = long.Parse(txtQuantity.Text);
        double Price = double.Parse(txtPrice.Text);
        long CustomerId = long.Parse(txtCustomerId.Text);
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(ItemName, DateAdded, Quantity, Price, CustomerId);
        if (Error == "")
        {
            //capture the values
            AnOrder.OrderId = OrderId;
            AnOrder.ItemName = ItemName;
            AnOrder.DateAdded = DateTime.Parse(DateAdded);
            AnOrder.Quantity = (int)Quantity;
            AnOrder.Price = Price;
            AnOrder.CustomerId = (int)CustomerId;
            AnOrder.Active = chkActive.Checked;
            //store the item name in the session object
            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderId == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderId);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            //navigate to the list page
            Response.Redirect("OrderViewer.aspx");
        }
        
        else
        {
            lblError.Text = Error;
        }        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsOrder AnOrder = new clsOrder();
        Int32 OrderId;
        Boolean Found = false;
        OrderId = Convert.ToInt32(txtOrderId.Text);
        Found = AnOrder.Find(OrderId);
        if (Found == true)
        {
            txtItemName.Text = AnOrder.ItemName;
            txtPrice.Text = AnOrder.Price.ToString();
            txtQuantity.Text = AnOrder.Quantity.ToString();
            txtDate.Text = AnOrder.DateAdded.ToString();
            txtCustomerId.Text = AnOrder.CustomerId.ToString();
            chkActive.Checked = AnOrder.Active;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}