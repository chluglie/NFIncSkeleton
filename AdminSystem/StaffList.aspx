<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 402px; width: 574px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 11px; top: 435px; position: absolute" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 51px; top: 435px; position: absolute; width: 41px" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 97px; top: 435px; position: absolute" Text="Delete" />
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 568px; position: absolute" Text="lblError"></asp:Label>
        <asp:Label ID="lblmess" runat="server" style="z-index: 1; left: 9px; top: 480px; position: absolute" Text="Enter a Full Name"></asp:Label>
        <asp:TextBox ID="txtFullName" runat="server" style="z-index: 1; left: 129px; top: 480px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 17px; top: 523px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 70px; top: 523px; position: absolute" Text="Clear" />
    </form>
</body>
</html>
