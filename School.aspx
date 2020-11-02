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
            <h3>Course Information</h3>
            <asp:GridView
                id="GridView1"
                runat="server"
                AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="CourseName" HeaderText="Courses"/>
                </Columns>
            </asp:GridView>
            <asp:TextBox id="CourseTB" runat="server" PlaceHolder="Enter Course"/>
            <br/>
            <asp:Button id="AddButton" runat="server" Text="Add Course" OnClick="AddButton_Click" />
            <asp:Button id="DeleteButton" runat="server" Text="Delete Course" />
            <asp:Button id="EditButton" runat="server" Text="Edit Course" />
            <asp:Label id="AlertLabel" runat="server" />
	</form>
</body>
</html>
