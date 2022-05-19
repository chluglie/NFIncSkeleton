<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the order list page
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" DataSourceID="lstOrderList" Height="284px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="412px"></asp:ListBox>
    </form>
</body>
</html>
