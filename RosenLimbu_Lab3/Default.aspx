<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RosenLimbu_Lab3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://bootswatch.com/4/superhero/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <br />
        <p class="text-warning"><strong>Select Category:</strong></p>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllTechnicians" TypeName="TechnicianDB"></asp:ObjectDataSource>
        <br />
        <div class="btn-group">
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource2" DataTextField="Name" DataValueField="TechID" Height="27px" Width="123px" CssClass="auto-style2">
        </asp:DropDownList>
        </div>
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource3" Height="181px" Width="1012px">
            <Columns>
                <asp:BoundField DataField="Incident" HeaderText="Incident" SortExpression="Incident" />
                <asp:BoundField DataField="IncidentID" HeaderText="IncidentID" SortExpression="IncidentID" />
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" SortExpression="CustomerID" />
                <asp:BoundField DataField="ProductCode" HeaderText="ProductCode" SortExpression="ProductCode" />
                <asp:BoundField DataField="TechID" HeaderText="TechID" SortExpression="TechID" />
                <asp:BoundField DataField="DateOpened" HeaderText="DateOpened" SortExpression="DateOpened" />
                <asp:BoundField DataField="DateClosed" HeaderText="DateClosed" SortExpression="DateClosed" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetOpenTechIncidents" TypeName="IncidentsDB">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="TechID" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
    
    </div>
    </form>
</body>
</html>
