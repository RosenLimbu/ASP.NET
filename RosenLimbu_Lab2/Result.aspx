<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="RosenLimbu_Lab2.Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            font-size: medium;
        }
        .auto-style3 {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>Voting Results<br />
        <br />
        </strong><span class="auto-style2">Day 1:
        <asp:TextBox ID="txtDay1" runat="server" Width="169px"></asp:TextBox>
        <br />
        <br />
        Day 2:
        <asp:TextBox ID="txtDay2" runat="server" Width="173px"></asp:TextBox>
        <br />
        <br />
        Day 3:
        <asp:TextBox ID="txtDay3" runat="server" Width="172px"></asp:TextBox>
        <br />
        <br />
        <strong>
        <asp:Button ID="btnReturn" runat="server" CssClass="auto-style3" Height="31px" Text="Return" Width="71px" OnClick="btnReturn_Click" />
        </strong></span>
    
    </div>
    </form>
</body>
</html>
