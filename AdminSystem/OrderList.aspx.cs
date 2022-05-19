using System;
using ClassLibrary;
using System.Collections.Generic;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders(); //Updates the list box
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection(); //not accessing?
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataValueField = "ItemName";
        lstOrderList.DataBind();
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }
}