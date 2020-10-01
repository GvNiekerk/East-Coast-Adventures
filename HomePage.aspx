<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="EastCoastAdventures.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="~/Content/site.css" />
    <link href="https://fonts.googleapis.com/css?family=Roboto&display=swap" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server">
            <h1 >East Coast Adventures</h1>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Admin" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="False" Font-Names="Arial Black" TabIndex="-10" Text="Our speciality is creating an adventure that suits all of your needs!"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Font-Names="Arial Black" Text="Create your custom adventure from the options below and if you book for 5 or more people you get a 30% discount"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtName" placeholder="Name" class="inputField" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtSurname" placeholder="Surname" class="inputField" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtCell" placeholder="Cell Nr" type="number" class="inputField" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Select your adventure:"></asp:Label>
            <br />
            <asp:RadioButton ID="rbQuad" runat="server" EnableTheming="True" GroupName="1" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Quad Biking" />
            <br />
            <asp:RadioButton ID="rbHorse" runat="server" GroupName="1" Text="Horse Back Riding" />
            <br />
            <asp:RadioButton ID="rbJet" runat="server" GroupName="1" Text="Jet Ski" />
            <br />
            <asp:RadioButton ID="rbKite" runat="server" GroupName="1" Text="kite Surfing" />
            <br />
            <asp:RadioButton ID="rbScuba" runat="server" GroupName="1" Text="Scuba Diving" />
            <br />
            <asp:RadioButton ID="rbShark" runat="server" GroupName="1" Text="Shark Cage Diving" />
            <br />
            <asp:RadioButton ID="rbSnorkle" runat="server" GroupName="1" Text="Snorkling" />
            <br />
            <asp:RadioButton ID="rbBoat" runat="server" GroupName="1" Text="Boat Cruise" />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Choose amount of people:"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" class="inputField" runat="server">
                <asp:ListItem Value="1">1 Person</asp:ListItem>
                <asp:ListItem Value="2">2 Persons</asp:ListItem>
                <asp:ListItem Value="3">3 Persons</asp:ListItem>
                <asp:ListItem Value="4">4 Persons</asp:ListItem>
                <asp:ListItem Value="5">5 Persons</asp:ListItem>
                <asp:ListItem Value="6">6 Persons</asp:ListItem>
                <asp:ListItem Value="7">7 Persons</asp:ListItem>
                <asp:ListItem Value="8">8 Persons</asp:ListItem>
                <asp:ListItem Value="9">9 Persons</asp:ListItem>
                <asp:ListItem Value="10">10 Persons</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Choose the day of the adventure:"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Choose the time of the adventure:"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList2" class="inputField" runat="server">
                <asp:ListItem>8AM</asp:ListItem>
                <asp:ListItem>9AM</asp:ListItem>
                <asp:ListItem>10AM</asp:ListItem>
                <asp:ListItem Value="11AM">11AM</asp:ListItem>
                <asp:ListItem Value="12AM">12AM</asp:ListItem>
                <asp:ListItem Value="1PM">1PM</asp:ListItem>
                <asp:ListItem Value="2PM">2PM</asp:ListItem>
                <asp:ListItem Value="3PM">3PM</asp:ListItem>
                <asp:ListItem>4PM</asp:ListItem>
                <asp:ListItem>5PM</asp:ListItem>
                <asp:ListItem>6PM</asp:ListItem>
                <asp:ListItem>7PM</asp:ListItem>
                <asp:ListItem>8PM</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="47px" OnClick="Button1_Click" Text="Display booking" Width="290px" />
            <br />
            <asp:Label ID="Label12" runat="server" Font-Size="X-Large" Text="Thank you for choosing East Coast Adventures, we look forward to seeing you !" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="Label11" runat="server" Text="Please review your booking below:" Visible="False"></asp:Label>
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="83px" Visible="False" Width="486px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Height="47px" OnClick="Button2_Click" Text="Place Adventure Booking" Visible="False" Width="291px" />
            <br />
            <br />
            <br />
        </asp:Panel>
    </form>
</body>
</html>
