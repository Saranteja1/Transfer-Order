<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage/Home.Master" CodeBehind="Home.aspx.cs" Inherits="MyOwnWebsite.Forms.Home" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="contentplaceholder2">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">

    <div class="container">
        <h2>Home Page</h2>
    </div>
    <div>
        <ul>
            <li style="font-size:x-large;font-family:Algerian" class="active"><a href="../Forms/Home.aspx">Home</a></li>
            <li style="font-size:x-large;font-family:Algerian"><a href="../Forms/ImmedaiteSupervisor.aspx">Immedaite Supervisor</a></li>
            <li style="font-size:x-large;font-family:Algerian"><a href="ViewScreen.aspx">View Screen</a></li>
            <li style="font-size:x-large;font-family:Algerian"><a href="../Forms/CEO.aspx">CEO</a></li>
        </ul>
    </div>
</asp:Content>







