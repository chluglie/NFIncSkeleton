<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 285px; top: 10px; position: absolute" Text="Find" />
            <asp:Label ID="lblEmployeeDateOfBirth" runat="server" style="z-index: 1; left: 10px; top: 78px; position: absolute" Text="Date Of Birth"></asp:Label>
            <asp:Label ID="lblEmployeeFullName" runat="server" style="z-index: 1; left: 11px; top: 45px; position: absolute" Text="FullName" width="82px"></asp:Label>
            <asp:Label ID="lblEmployeeIDNumber" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="ID Number" width="82px"></asp:Label>
            <asp:Label ID="lblEmployeePosition" runat="server" style="z-index: 1; left: 12px; top: 111px; position: absolute" Text="Position" width="82px"></asp:Label>
            <asp:Label ID="lblEmployeeSalary" runat="server" style="z-index: 1; left: 13px; top: 150px; position: absolute" Text="Salary" width="82px"></asp:Label>
        </div>
        <asp:TextBox ID="txtEmployeeDateOfBirth" runat="server" style="z-index: 1; left: 104px; top: 76px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmployeeIDNumber" runat="server" style="z-index: 1; left: 105px; top: 12px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmployeeFullName" runat="server" style="z-index: 1; left: 105px; top: 46px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmployeeSalary" runat="server" style="z-index: 1; left: 103px; top: 151px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmployeePosition" runat="server" style="z-index: 1; left: 104px; top: 108px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkEmployeeWorkStatus" runat="server" style="z-index: 1; left: 10px; top: 218px; position: absolute" Text="WorkStatus" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 260px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 8px; top: 307px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 58px; top: 307px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
