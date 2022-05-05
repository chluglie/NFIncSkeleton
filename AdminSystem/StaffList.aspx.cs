using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        //create an instance of the Staff Collection
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to list of addresses in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "EmployeeIDNumber";
        //set the data field to display
        lstStaffList.DataTextField = "EmployeeFullName";
        //bind the data to the list
        lstStaffList.DataBind();
    }




    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["EmployeeIDNumber"] = -1;
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }






    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 EmployeeIDNumber;

        if (lstStaffList.SelectedIndex != -1)
        {
            EmployeeIDNumber = Convert.ToInt32(lstStaffList.SelectedValue);

            Session["EmployeeIDNumber"] = EmployeeIDNumber;

            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 EmployeeIDNumber;

        if (lstStaffList.SelectedIndex != -1)
        {
            EmployeeIDNumber = Convert.ToInt32(lstStaffList.SelectedValue);

            Session["StaffID"] = EmployeeIDNumber;

            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByEmployeeFullName(txtFullName.Text);
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "EmployeeIDNumber";
        lstStaffList.DataTextField = "EmployeePosition";
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByEmployeeFullName("");
        txtFullName.Text = "";
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "EmployeeIDNumber";
        lstStaffList.DataTextField = "EmployeeFullName";
        lstStaffList.DataBind();
    }
}