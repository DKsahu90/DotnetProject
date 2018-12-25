<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ex1.aspx.cs" Inherits="Ex1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.1.1.js" type="text/javascript">

    </script>

    <script  type="text/javascript">
         
        $(document).ready(function()
        {
            $("#btnAdd").click(function () {
                var value1 = $("#txtvalue1").val();
                var value2 = $("#txtvalue2").val();
                var error = "";
                if(value1=="")
                {
                    error += "Plz enter value1 " + "\n";
                }
                if (value2 == "")
                    error += "Plz enter value2" + "\n";
                if (error != "") {
                    alert(error);
                    return false;
                }

                var result = parseFloat(value1) + parseFloat(value2);

                $("#txtResult").val(result);
            })
        })

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style=" border-radius:20 5 solid; box-shadow:10,10 yellow">
         <strong>Enter Value1: </strong>
        <input type="text" id="txtvalue1" /><br /><br />

         <strong>Enter Value2: </strong>
        <input type="text" id="txtvalue2" /><br /><br />

        <input type="button" id="btnAdd" value="Add" />
       
        <br /><br />
        <strong>Result:</strong>
        <input type="text" id="txtResult" readonly="readonly" />
          
    </div>
    </form>
</body>
</html>
