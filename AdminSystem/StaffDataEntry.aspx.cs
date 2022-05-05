using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 EmployeeIDNumber;
    protected void Page_Load(object sender, EventArgs e)
    {
        EmployeeIDNumber = Convert.ToInt32(Session["EmployeeIDNumber"]);
        if (IsPostBack == false)
        {
            if (EmployeeIDNumber != -1)
            {
                DisplayStaff();
            }
        }
    }

    private void DisplayStaff()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();

        StaffBook.ThisStaff.Find(EmployeeIDNumber);

        txtEmployeeIDNumber.Text = StaffBook.ThisStaff.EmployeeIDNumber.ToString();
        txtEmployeeFullName.Text = StaffBook.ThisStaff.EmployeeFullName;
        txtEmployeePosition.Text = StaffBook.ThisStaff.EmployeePosition;
        txtEmployeeSalary.Text = StaffBook.ThisStaff.EmployeeSalary;
        txtEmployeeDateOfBirth.Text = StaffBook.ThisStaff.EmployeeDateOfBirth.ToString();
        chkEmployeeWorkStatus.Checked = StaffBook.ThisStaff.EmployeeWorkStatus;
    }





    protected void btnOK_Click(object sender, EventArgs e)
    {


        //create a new  instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the name

        string employeeFullName = txtEmployeeFullName.Text;
        string employeePosition = txtEmployeePosition.Text;
        string employeeDateOfBirth = txtEmployeeDateOfBirth.Text;
        string employeeSalary = txtEmployeeSalary.Text;
        string Error = "";
        Error = AStaff.Valid(employeeFullName, employeePosition, employeeDateOfBirth, employeeSalary);

        if (Error == "")
        {
            AStaff.EmployeeIDNumber = EmployeeIDNumber;
            AStaff.EmployeeFullName = employeeFullName;
            AStaff.EmployeePosition = employeePosition;
            AStaff.EmployeeDateOfBirth = Convert.ToDateTime(employeeDateOfBirth);
            AStaff.EmployeeSalary = employeeSalary;
            AStaff.EmployeeWorkStatus = chkEmployeeWorkStatus.Checked;
            //store the name in the session object

            clsStaffCollection StaffList = new clsStaffCollection();

            if (EmployeeIDNumber == -1)
            {
                StaffList.ThisStaff = AStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(Convert.ToInt32(EmployeeIDNumber));
                StaffList.ThisStaff = AStaff;
                StaffList.Update();
            }

            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AStaff = new clsStaff();
        Int32 EmployeeIDNumber;
        Boolean Found = false;
        EmployeeIDNumber = Convert.ToInt32(txtEmployeeIDNumber.Text);
        Found = AStaff.Find(EmployeeIDNumber);
        if (Found == true)
        {
            txtEmployeeFullName.Text = AStaff.EmployeeFullName;
            txtEmployeePosition.Text = AStaff.EmployeePosition;
            txtEmployeeSalary.Text = AStaff.EmployeeSalary;
            txtEmployeeDateOfBirth.Text = AStaff.EmployeeDateOfBirth.ToString();

        }
    }
}