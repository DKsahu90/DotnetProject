<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ex3_class.aspx.cs" Inherits="Ex3_class" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="Scripts/jquery-3.1.1.js"></script>
     <script type="text/javascript">
         $(document).ready(function () {
             var content = "";
             $("div.style1,.style2,.style3").click(function () {
                 content = $(this).html();
                 alert(content);
             });
         });
     </script>
    <style type="text/css">
        .style1,.style2,.style3 {
             border:5px solid red;
             width:100px;
             height:100px;
             margin:5px;
             background-color:green;
             cursor:pointer;
             box-shadow:10px 10px grey;
             border-radius:15px 15px;
        }
    </style>
   
</head>
<body>
    <form id="form1" runat="server">
    <div class="style1">  Div1 </div>
    <div class="style2">  Div2 </div>
   <div class="style3">  Div3 </div>
    </form>
</body>
</html>
