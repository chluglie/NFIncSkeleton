<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the stock data entry page
    <form id="form1" runat="server">
        <asp:Label ID="lblProductID" runat="server" Text="ProductID" width="225px"></asp:Label>
        <asp:TextBox ID="txtProductID" runat="server" style="margin-left: 21px; margin-top: 12px" Width="225px"></asp:TextBox>
        <p>
    <asp:Label ID="lblProductSupplier" runat="server" Text="ProductSupplier" width="225px"></asp:Label>

            <asp:TextBox ID="txtProductSupplier" runat="server" style="margin-left: 21px" Width="225px"></asp:TextBox>
        </p>
        <p style="height: 36px">
        <asp:Label ID="lblProductDesc" runat="server" Text="ProductDesc" width="225px"></asp:Label>
        <asp:TextBox ID="txtProductDesc" runat="server" style="margin-left: 21px; margin-top: 12px" Width="225px" Height="16px"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkProductAvailability" runat="server" Text="In Stock" width="225px" />
        </p>
        <asp:Label ID="lblProductRestockSchedule" runat="server" Text="ProductRestockSched" width="225px"></asp:Label>
        <asp:TextBox ID="txtProductRestockSched" runat="server" style="margin-left: 21px" Width="225px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="56px" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="margin-left: 42px; margin-right: 18px" Text="Cancel" />
        </p>
    </form>
        
    </body>
</html>
