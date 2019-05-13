<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="MyOwnWebsite.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to My Website </title>
</head>
<body>

    <link href="Script/Login.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <form id="form1" runat="server">
        <div class="imgcontainer">
           
           <%--<h3 style="font-size:x-large;font-weight:bold">Lovely Family</h3>--%>
           <img  src="Images/googlelogo_color_272x92dp.png"  height="80px" width="380px"  />
       </div> 
        


        <div class="container-fluid">
            <label for="login"><b>Staff Number</b></label>
            <asp:TextBox ID="txtname" PlaceHolder="Enter Username" runat="server"></asp:TextBox>

            <label for="password"><b>Password</b></label>
            <asp:TextBox ID="txtpwd" PlaceHolder="Enter Password" TextMode="Password" runat="server"></asp:TextBox>







            <asp:Button runat="server" ToolTip="Submit" Text="Submit" CssClass="btn btn-primary" OnClick="Unnamed_Click" />
        </div>
    </form>
</body>
</html>
