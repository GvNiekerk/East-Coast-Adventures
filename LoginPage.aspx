<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="EastCoastAdventures.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="~/Content/site.css" />
</head>
<body>
    <form class="login" id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" BorderColor="#3333CC">
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Admin Login "></asp:Label>
            <br />
            <hr />
            <asp:TextBox ID="TextBox1" Width="90%" class="inputField" placeholder="username" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2"  Width="90%" runat="server" class="inputField" placeholder="password" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button runat="server"  OnClick="Unnamed1_Click" Text="Login" id="btnLogin" Width="90%" />
            <br />
        </asp:Panel>
    </form>
</body>
</html>
