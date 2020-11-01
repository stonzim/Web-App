<%@ Page Language="C#" Inherits="WebApp.Colour" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Colour</title>
</head>
<body>
	<form id="form1" runat="server">
            <h1>Colour Page</h1>
            <asp:Button id="PageChange1" runat="server" OnClick="PageChange_Click1" Text="Default Page"/>
            <asp:Button id="PageChange2" runat="server" OnClick="PageChange_Click2" Text="Contact Page"/>
            <br/>
            <asp:Label id="label" runat="server" text="Change my colour"/>
            <br/>
            <asp:RadioButton id="green" runat="server" GroupName="buttons" text="Green" 
                             OnCheckedChanged="Colour_CheckedChanged" AutoPostBack="true"/>
            <asp:RadioButton id="red" runat="server" GroupName="buttons" text="Red" 
                             OnCheckedChanged="Colour_CheckedChanged" AutoPostBack="true"/>
            <asp:RadioButton id="blue" runat="server" GroupName="buttons" text="Blue" 
                             OnCheckedChanged="Colour_CheckedChanged" AutoPostBack="true"/>
            <br/>
	</form>
</body>
</html>
