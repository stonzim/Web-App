<%@ Page Language="C#" Inherits="WebApp.School" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>School</title>
</head>
<body>
	<form id="form1" runat="server">
            <h1>School Page</h1>
            <asp:Button id="PageChange1" runat="server" OnClick="PageChange_Click1" Text="Default Page"/>
            <br/>
            <br/>
            <asp:GridView
                id="GridView1"
                runat="server"
                AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="StudentName" HeaderText="First Name"/>
                </Columns>
                <Columns>
                    <asp:BoundField DataField="CourseName" HeaderText="Enrolled Course"/>
                </Columns>
            </asp:GridView>
	</form>
</body>
</html>
