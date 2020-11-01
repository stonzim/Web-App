<%@ Page Language="C#" Inherits="WebApp.Contact" %>
<%@ Register TagPrefix="My" TagName="UserInfoBoxControl" Src="UserInfoBoxControl.ascx"%>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Contact</title>
</head>
<body>
	<form id="form1" runat="server">
    <h1>Contact Page</h1>
    <asp:Button id="PageChange1" runat="server" OnClick="PageChange_Click1" Text="Default Page"/>
    <asp:Button id="PageChange2" runat="server" OnClick="PageChange_Click2" Text="Colour Page"/>
            <br/>
            <br/>
    <My:UserInfoBoxControl id="BoxControl" runat="server" />
            <br/>
    <asp:Label id="changeColour" runat="server">Change this colour</asp:Label>
            <br/>
            <br/>
    <asp:DropDownList id="ColourDropDown" runat="server"
                autopostback="true" OnSelectedIndexChanged="ColourDropDown_SelectedIndexChanged">
        <asp:ListItem>--None--</asp:ListItem>
        <asp:ListItem>Green</asp:ListItem>
        <asp:ListItem>Red</asp:ListItem>
        <asp:ListItem>Blue</asp:ListItem>
    </asp:DropDownList>
	</form>
</body>
</html>
