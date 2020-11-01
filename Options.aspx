<%@ Page Language="C#" Inherits="WebApp.Options" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Options</title>
</head>
<body>
	<form id="form1" runat="server">
        <h1>Options Page</h1>
            <asp:Button id="PageChange1" runat="server" OnClick="PageChange_Click1" Text="Default Page"/>
            <br/>
            <br/>
            <table>
                <tr>
                    <td>
                       <asp:ListBox id="LeftBox" runat="server" Width="50">
                        </asp:ListBox> 
                    </td>
                    <td>
                        <table>
                            <tr>
                                <td>
                                    <asp:Button id="AddToRight" runat="server" Text=">>"
                                                OnClick="AddToRight_Click"/>
                                </td>
                            </tr>
                            <tr>
                               <td>
                                    <asp:Button id="AddToLeft" runat="server" Text="&lt;&lt;"
                                                OnClick="AddToLeft_Click"/>
                               </td> 
                            </tr>
                        </table>
                    </td>
                    <td>
                       <asp:ListBox id="RightBox" runat="server" Width="50">
                        </asp:ListBox>  
                    </td>
                </tr>
            </table>
            <br/>
            <br/>
            <asp:Label id="notification" runat="server" />
	</form>
</body>
</html>
