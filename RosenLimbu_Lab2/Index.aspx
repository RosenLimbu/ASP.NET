<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="RosenLimbu_Lab2.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            color: #9900CC;
        }
        .auto-style2 {
            width: 660px;
            height: 394px;
        }
        .auto-style3 {
            width: 393px;
            height: 242px;
        }
        .auto-style4 {
            font-weight: bold;
        }
        .auto-style5 {
            color: #000000;
            font-size: medium;
        }
        .auto-style6 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong>Good Time Celebration Party!!<br />
        <br />
        <br />
        </strong>
        <img alt="" class="auto-style2" src="Images/party.jpg" /><img alt="" class="auto-style3" src="Images/party1.jpg" /><br />
        <span class="auto-style6">Please select the following dates for booking:</span><br />
        <asp:Calendar ID="Calendar1" runat="server" Height="149px" OnSelectionChanged="Calendar1_SelectionChanged" Width="972px" OnDayRender="Calendar1_DayRender">
            <SelectedDayStyle BackColor="#FF9900" />
        </asp:Calendar>
        <asp:Label ID="lblSelectedDate" runat="server" CssClass="auto-style5"></asp:Label>
        <strong>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" CssClass="auto-style4" Height="36px" Text="Submit Vote" Width="105px" OnClick="btnSubmit_Click" />
        </strong>&nbsp;</div>
    </form>
</body>
</html>
