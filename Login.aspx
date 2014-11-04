<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" type="text/css" href="css/login.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="login-area">
        <div class="username">
            <asp:Label ID="Label1" runat="server" Text="UserName:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
        </div>
        <div class="password">
            <asp:Label ID="Label2" runat="server" Text="PassWord:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br />
        </div>
        <div class="login">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" 
                Text=" Login " />
        </div>
        <div class="registe">
            <asp:Button ID="Button2" runat="server" Text="Registe" 
                onclick="Button2_Click" />
        </div>
        <div class="info">
            <asp:Label ID="InfoLable" runat="server" ForeColor="Red"></asp:Label>   
        </div>
    </div>
    </form>
</body>
</html>
