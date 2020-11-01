<%@ Page Language="C#" Inherits="WebApp.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
    <h1>Default Page</h1>
    <asp:Button id="PageChange1" runat="server" OnClick="PageChange_Click1" Text="Contact Page"/>
    <asp:Button id="PageChange2" runat="server" OnClick="PageChange_Click2" Text="Colour Page"/>
    <asp:Button id="PageChange3" runat="server" OnClick="PageChange_Click3" Text="Calendar Page"/>
    <asp:Button id="PageChange4" runat="server" OnClick="PageChange_Click4" Text="Options Page"/>
    <asp:Button id="PageChange5" runat="server" OnClick="PageChange_Click5" Text="School Page"/>
    <h2>Type your name</h2>
    <asp:TextBox id="textInput" runat="server" placeholder="Enter name"/>
	<asp:Button id="button1" runat="server" Text="Click me!" OnClick="Button1Clicked" />
            <br/>
            <br/>
                <asp:Label id="blah" runat="server" />
            <br/>
    <h2>Click on a greeting</h2>
    <asp:DropDownList runat="server" id="GreetList" autopostback="true"
                      OnSelectedIndexChanged="GreetList_SelectedIndexChanged">
        <asp:ListItem>--None--</asp:ListItem>
        <asp:ListItem value="Hello">Hello</asp:ListItem>
        <asp:ListItem value="Greetings">Greetings</asp:ListItem>
        <asp:ListItem value="Go away">Go away</asp:ListItem>
    </asp:DropDownList>
    <asp:Label id="blahblah" runat="server"/>
	</form>
</body>
</html>
