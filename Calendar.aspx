<%@ Page Language="C#" Inherits="WebApp.Calendar" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Calendar</title>
</head>
<body>
	<form id="form1" runat="server">
        <h1>Calendar Page</h1>
        <asp:Button id="PageChange1" runat="server" OnClick="PageChange_Click1" Text="Default Page"/>
        <br/>
        <br/>
        <asp:Calendar id="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" OnDayRender="Calendar1_DayRender"/>
        <br/>
        <asp:Label id="chosenDate" runat="server" text="Date: "/>
	</form>
</body>
</html>
