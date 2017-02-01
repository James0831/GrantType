<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 class="login">Login In Screen</h1>
     <table>
            <tr>
                <td>Email:</td>
                <td>
                    <asp:TextBox ID="EmailTextBox" runat="server" placeholder="@email" TextMode ="email"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password:</td>
                <td>
                    <asp:TextBox ID="PasswordTextBox" runat="server" placeholder="*******" TextMode =" Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button class="button" ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
                </td>
                <td>
                    <asp:Label ID="ResualtLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
