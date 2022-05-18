<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the order data entry page.
    <form id="OrderId" runat="server">
        <asp:Label ID="lblOrderId" runat="server" Text="Order ID" width="222px"></asp:Label>
        <asp:TextBox ID="txtOrderId" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <p>
            <asp:Label ID="lblDate" runat="server" Text="Order Date" width="222px"></asp:Label>
            <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblQuantity" runat="server" Text="Order Quantity" width="222px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPrice" runat="server" Text="Order Price" width="222px"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblItemName" runat="server" Text="Order Item Name"  width="222px"></asp:Label>
        <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID" width="222px"></asp:Label>
            <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkActive" runat="server" Text="Order Active" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
