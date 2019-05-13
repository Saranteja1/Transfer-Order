<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/MasterPage/Home.Master" CodeBehind="ViewScreen.aspx.cs" Inherits="MyOwnWebsite.Forms.Departmnet" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="contentplaceholder2">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">

    <script type="text/javascript">
        function Populate() {
            var e = document.getElementById("contentplaceholder2_ddlempno");
            var strUser = e.options[e.selectedIndex].value;
            var strUser1 = e.options[e.selectedIndex].text;
            if (strUser == 0) {
                alert("Please Select Employee Number /Name");
                return false;
            }
           

           
        }

           

         





           
           
          
           
        }
    </script>
    <style type="text/css">
        .button {
            color: green;
        }

        .Textbox {
            width: 800px;
            padding: 12px 20px;
            margin: 8px 0;
            box-sizing: border-box;
            / border: 2px solid dotted;
            border-radius: 4px;
        }
    </style>
    <script type="text/javascript">

</script>


    <div class="panel panel-primary">

        <div class="panel-heading">
            <h3 class="panel-title">Immediate Approval  Form</h3>
        </div>
        <div class="panel-body">

            <div align="center">
                <table>
                    <tr>
                        <td style="font-family: 'Bookman Old Style', Times, serif; font-size: large; font-weight: 200">
                            <label for="Employeename">Employee Staffno / Name </label>
                        </td>
                        <td style="font-family: 'Bookman Old Style', Times, serif; font-size: large; font-weight: 200">
                            <asp:DropDownList ID="ddlempno" runat="server" AutoPostBack="true" EnableViewState="true" Width="120%" OnSelectedIndexChanged="ddlempno_SelectedIndexChanged" class="form-control input-sm"></asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </div>

            <div>
                <table>
                    <br />
                </table>
            </div>









            <div class="form-group col-md-4 col-sm-12">
                <label for="Name">Staff Number </label>

                <asp:TextBox ID="txtstaffno" Font-Bold="true" runat="server" class="form-control input-sm" PlaceHolder="Enter Staff Number "></asp:TextBox>
            </div>

            <div class="form-group col-md-4 col-sm-12">
                <label for="Name">Name </label>

                <asp:TextBox ID="txtname" Font-Bold="true" runat="server" class="form-control input-sm" PlaceHolder="Enter Employee Name "></asp:TextBox>
            </div>
            <div class="form-group col-md-4 col-sm-12">
                <label for="deptid">Department </label>

                <asp:TextBox ID="txtdept" Font-Bold="true" runat="server" class="form-control input-sm" PlaceHolder="Enter Department "></asp:TextBox>
            </div>
            <div class="form-group col-md-4 col-sm-12">
                <label for="Designation">Designation </label>

                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                <asp:TextBox ID="txtdesgination" Font-Bold="true" runat="server" class="form-control input-sm" PlaceHolder="Enter Designation"></asp:TextBox>
            </div>
            <div class="form-group col-md-4 col-sm-12">
                <label for="Location">Location </label>

                <asp:TextBox ID="txtloaction" Font-Bold="true" runat="server" class="form-control input-sm" PlaceHolder="Enter Location"></asp:TextBox>
            </div>
            <div class="form-group col-md-4 col-sm-12">
                <label for="Cluster">Cluster </label>

                <asp:TextBox ID="txtluster" Font-Bold="true" runat="server" class="form-control input-sm" PlaceHolder="Enter Cluster"></asp:TextBox>
            </div>
            <div class="form-group col-md-4 col-sm-12">
                <label for="Email">Email </label>

                <asp:TextBox ID="txtemail" Font-Bold="true" runat="server" class="form-control input-sm" PlaceHolder="Enter Email"></asp:TextBox>
            </div>
            <div class="form-group col-md-4 col-sm-12">
                <label for="Adress">Adress </label>

                <asp:TextBox ID="txtadress" Font-Bold="true" runat="server" class="form-control input-sm" PlaceHolder="Enter Adress"></asp:TextBox>
            </div>
            <div class="form-group col-md-4 col-sm-12">
                <label for="immedaitesup">Immediate Supervisor </label>

                <asp:TextBox ID="txtimmedaitesup" Font-Bold="true" runat="server" class="form-control input-sm" PlaceHolder="Enter Immediate Suervisor"></asp:TextBox>
            </div>
            <div class="form-group col-md-4 col-sm-12">
                <label for="uplineSup">Upline Supervisor </label>

                <asp:TextBox ID="txtuplinesup" Font-Bold="true" runat="server" class="form-control input-sm" PlaceHolder="Enter Upline Suervisor"></asp:TextBox>
            </div>
        </div>
    </div>


    <div class="panel panel-primary" id="divhide" runat="server">
        <div class="panel-heading">
            <h3 class="panel-title">Transfer Process</h3>
        </div>
        <div class="panel-body">


            <div class="form-group col-md-4 col-sm-12" id="divselectprocess" runat="server">
                <label for="Selection Project">Select Process </label>
                <asp:DropDownList ID="drpselectionprjct" class="form-control input-sm" runat="server" Font-Bold="true" AutoPostBack="true" >
                    <asp:ListItem Text="::Select::" Value="0"></asp:ListItem>
                    <asp:ListItem Text="Project" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Department" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Function" Value="3"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group col-md-4 col-sm-12" id="divprjct" runat="server">
                <label for="Selection Project">Existing Project </label>
                <asp:DropDownList ID="drpexistingprjct" class="form-control input-sm" runat="server" Font-Bold="true" AutoPostBack="true" ></asp:DropDownList>
            </div>
            <div class="form-group col-md-4 col-sm-12" id="divnewprjct" runat="server">
                <label for="New Project">New Project </label>
                <asp:DropDownList ID="drpnewprjct" class="form-control input-sm" runat="server" Font-Bold="true" AutoPostBack="true"></asp:DropDownList>
            </div>
            <div class="form-group col-md-4 col-sm-12" id="divdept" runat="server">
                <label for="existingdept">Existing Department</label>
                <asp:DropDownList ID="drpexisitngdept" class="form-control input-sm" runat="server" Font-Bold="true" AutoPostBack="true" ></asp:DropDownList>
            </div>
            <div class="form-group col-md-4 col-sm-12" id="divnewdept" runat="server">
                <label for="newdept">New Department</label>
                <asp:DropDownList ID="drpnewdept" class="form-control input-sm" runat="server" Font-Bold="true" AutoPostBack="true" ></asp:DropDownList>
            </div>
            <div class="form-group col-md-4 col-sm-12" id="divfunction" runat="server">
                <label for="existingfunction">Existing Function</label>
                <asp:DropDownList ID="drpexistingfunction" class="form-control input-sm" runat="server" AutoPostBack="true" Font-Bold="true" ></asp:DropDownList>
            </div>
            <div class="form-group col-md-4 col-sm-12" id="divexisfunction" runat="server">
                <label for="newfunction">New Function</label>
                <asp:DropDownList ID="drpnewfunction" class="form-control input-sm" runat="server" Font-Bold="true" AutoPostBack="true" ></asp:DropDownList>
            </div>
        </div>
    </div>
    <div class="panel">
        <div class="col-md-5 col-sm-3">
            <div class="form-group col-md-2 col-sm-2 pull-right">
                <table>
                    <tr>
                        <td>
                            <asp:Button ID="btnapprove" runat="server" class="btn btn-danger" OnClientClick="Populate();" value="Submit" Text="Approve"  />
                        </td>
                        <td>&nbsp;
                            <td>
                                <asp:Button ID="btnreset" runat="server" class="btn btn-danger" value="Submit" Text="Reset" />
                            </td>
                        </td>

                    </tr>
                </table>


            </div>
        </div>
        <div>
        </div>
    </div>




</asp:Content>


