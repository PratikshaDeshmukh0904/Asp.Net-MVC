<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PracticeLinq.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4>Using Lambda Expression</h4>
            <asp:GridView runat="server" ID="gridview1"></asp:GridView>
            <br />
            <br />
            <h4>Using Sql like query Expression </h4>
             <asp:GridView runat="server" ID="gridview2"></asp:GridView>
        </div>
    </form>
</body>
</html>
