<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the customer data entry page
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="IbICustomerName" runat="server" Text="Customer Name" width="160px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="160px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerDOB" runat="server" Text="Customer DOB" width="160px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerDOB" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerMobileNumber" runat="server" Text="Customer Mobile Number"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerMobileNumber" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerAddress" runat="server" Text="Customer Address" width="160px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkStatus" runat="server" Text=" STATUS" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
