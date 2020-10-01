<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="EastCoastAdventures.AdminPage" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="~/Content/site.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="Logout" />

            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Admin"></asp:Label>
            <hr />
            <br />
            <br />
            Select a field type you would like to search by:
            <br />
            <asp:TextBox CssClass="inputField" Width="200px" ID="txtSearch" Font-Size="15px" runat="server"></asp:TextBox>
            &nbsp;<asp:DropDownList ID="ddSearch" CssClass="inputField" Width="200px" Font-Size="15px" runat="server">
                <asp:ListItem>Name</asp:ListItem>
                <asp:ListItem>Surname</asp:ListItem>
                <asp:ListItem>CellNr</asp:ListItem>
                <asp:ListItem>Adventure</asp:ListItem>
            </asp:DropDownList>
            &nbsp;<asp:Button CssClass="inputBtn" ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
            <asp:GridView class="greyGridTable" ID="GridView1" runat="server" Width="314px" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            <br />
            
            <br />
            <asp:Button CssClass="inputBtn" ID="btnThousand" Width="80%" runat="server" OnClick="btnThousand_Click" Text="Display all bookings with a price higher than R1000" />
            <br />
            <asp:Button CssClass="inputBtn"  ID="btnFive" Width="80%" runat="server" OnClick="btnFive_Click" Text="Display all bookings with more than 4 people" />
            <br />
            <asp:Button CssClass="inputBtn"  ID="btnOnePerson" Width="80%" runat="server" OnClick="btnOnePerson_Click" Text="Display all bookings with only one person" />
            <br />
            <asp:DropDownList ID="ddField" Visible="false" CssClass="inputField" Width="200px" Font-Size="15px" runat="server">
                <asp:ListItem Value="date">Date</asp:ListItem>
                <asp:ListItem Value="time">Time</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox CssClass="inputField" Width="200px" ID="txtNewValue" Visible="false" Font-Size="15px" runat="server"></asp:TextBox>
            <asp:Button CssClass="inputBtn btnEdit"  ID="btnEdit" Visible="false" runat="server" OnClick="btnEdit_Click" Text="Edit selected Record" />
            <asp:Button CssClass="inputBtn btnDelete"  ID="btnDelete" Visible="false" runat="server" OnClick="btnDelete_Click" Text="Delete selected record" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
