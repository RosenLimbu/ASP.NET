<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RosenLimbu_Lab1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="main.css" rel="stylesheet" />
</head>
<body style="width: 1200px">
    <form id="form1" runat="server">
    <div>
    
        <table class="tableClass">
            <tr>
                <td class="ddlFromHead">From:</td>
                <td class="ddlFrom">
                    <asp:DropDownList ID="ddlFrom" runat="server" Height="21px" Width="129px">
                    </asp:DropDownList>
                </td>
                <td class="nbsp1">&nbsp;</td>
                <td class="nbsp2">
                    &nbsp;</td>
                <td class="ddlTo">
                    To:</td>
                <td class="ddlTo">
                    <asp:DropDownList ID="ddlTo" runat="server" Height="16px" Width="144px">
                    </asp:DropDownList>
                </td>
                <td rowspan="5" class="imgHead">
                    <img alt="" class="imgBackground" src="Images/Image.jpg" /></td>
            </tr>
            <tr>
                <td class="txtFromClass"></td>
                <td class="txtFrom">
                    <asp:TextBox ID="txtFrom" runat="server" Height="17px" Width="140px"></asp:TextBox>
                </td>
                <td class="reqValidator"><strong>
                    <asp:RequiredFieldValidator ID="inputRequiredFieldValidator" runat="server" ErrorMessage="Please enter a value!" ForeColor="Red" ControlToValidate="txtFrom"></asp:RequiredFieldValidator>
                    </strong></td>
                <td class="inputRangeValidator">
                    <strong>
                    <asp:RangeValidator ID="inputRangeValidator" runat="server" ErrorMessage="Please enter a number between -1000 and 1000!" ForeColor="Red" MaximumValue="1000" MinimumValue="-1000" Type="Double" ControlToValidate="txtFrom"></asp:RangeValidator>
                    </strong>
                </td>
                <td class="lblConvert">
                    Convert &gt;&gt;</td>
                <td class="lblConvert">
                    <asp:Label ID="lblConverted" runat="server" Enabled="False" Text="Conversion"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="nbsp6">&nbsp;</td>
                <td class="btnConvert">
                    <asp:Button ID="btnConvert" runat="server" OnClick="btnConvert_Click" Text="Convert" />
                </td>
                <td class="nbsp1">
                    &nbsp;</td>
                <td class="nbsp3">
                    &nbsp;</td>
                <td class="btnClear">
                    &nbsp;</td>
                <td class="btnClear">
                    <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
                </td>
            </tr>
            <tr>
                <td class="nbsp6">&nbsp;</td>
                <td class="ddlFrom">&nbsp;</td>
                <td class="nbsp5">&nbsp;</td>
                <td class="nbsp2">&nbsp;</td>
                <td class="ddlTo">&nbsp;</td>
                <td class="ddlTo">&nbsp;</td>
            </tr>
            <tr>
                <td class="nbsp4">&nbsp;</td>
                <td class="nbsp4">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
