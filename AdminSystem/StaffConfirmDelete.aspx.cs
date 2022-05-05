using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 EmployeeIDNumber;

    protected void Page_Load(object sender, EventArgs e)
    {
        EmployeeIDNumber = Convert.ToInt32(Session["EmployeeIDNumber"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        Delete();
        Response.Redirect("StaffList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }

    void Delete()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to delete
        StaffBook.ThisStaff.Find(EmployeeIDNumber);
        StaffBook.Delete();
        
    }
}