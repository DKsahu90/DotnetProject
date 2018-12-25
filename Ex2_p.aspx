<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ex2_p.aspx.cs" Inherits="Ex2_p" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.1.1.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {

            $("#button1").click(function () {

                var contents = "";
                $("p").each(function () {
                    contents += $(this).html() + "\n";
                });
                alert(contents);
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <p>This is First paragraph.</p>
        <p>This is Second paragraph</p>
          <p>This is third paragraph</p>
       <input type="button" id="button1" value="Show paragraph Contents" />
    </div>
    </form>
</body>
</html>
