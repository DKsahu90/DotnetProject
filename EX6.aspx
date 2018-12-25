<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EX6.aspx.cs" Inherits="EX6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    $('')
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <b>Select Option:</b>
        <asp:Panel  ID="panel2" runat="server">

            <asp:CheckBox ID="chk1" runat="server" Text="A" />
             <asp:CheckBox ID="CheckBox1" runat="server" Text="B" />
             <asp:CheckBox ID="CheckBox2" runat="server" Text="C" />
             <asp:CheckBox ID="CheckBox3" runat="server" Text="D" />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
            <br />
            <asp:Label ID="lblResult" runat="server">

            </asp:Label>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
+++