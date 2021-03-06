using System;
using TestingOrderCollection;
using ClassLibrary;

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
        lstOrderList.DataTextField = "ItemName";
        lstOrderList.DataBind();
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }


    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.reportByItemName(txtFilter.Text);
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "ItemName";
        lstOrderList.DataBind();
    }
}