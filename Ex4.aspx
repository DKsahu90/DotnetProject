<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ex4.aspx.cs" Inherits="Ex4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="Scripts/jquery-3.1.1.js" ></script>
    <script type="text/javascript">

        $(document).ready(function () {

            $("#CheckBox2").change(function () {

                if ($(this).is(":checked")) {
                    $("#Image2").show();
                    $("lbl[for=CheckBox2]").text("Hide Image");
                } else {

                    $("#Image2").hide();

                }
            });
        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBox ID="CheckBox2" runat="server" />
        <asp:Label ID="lbl" runat="server" Text="Show Image">Show Image</asp:Label>
         <asp:Image ID="Image2" ImageUrl="~/Images/f.jpg" Width="300" Height="300"  Style=" display:none" />
    </div>
    </form>
</body>
</html>
