<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ConsumeWCFSelfHosting._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnConcat" runat="server" Text="Concat" OnClick="btnConcat_Click" />
        </div>
    </form>
</body>
</html>
