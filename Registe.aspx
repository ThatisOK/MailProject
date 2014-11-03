<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registe.aspx.cs" Inherits="Registe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registe</title>
    <link rel="stylesheet" type="text/css" href="css/registe.css" />
    <script src="scripts/Register.js" type="text/javascript" charset="gbk"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="registe-area">
        <div class="username">
            <p>
                &nbsp; 用户名:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="用户名不能为空！" ForeColor="Red"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="password">
            <p>
                &nbsp;&nbsp;&nbsp; 密码:<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="请输入密码！" ForeColor="Red"></asp:RequiredFieldValidator>
            </p>
        </div>
        <div class="re-password">
            <p>
                确认密码:<asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="TextBox2" ControlToValidate="TextBox3" Display="Dynamic" 
                    ErrorMessage="两次密码不一致！" ForeColor="Red"></asp:CompareValidator>
            </p>
        </div>
        <div class="email">
            <p>
                &nbsp;&nbsp;&nbsp; 邮箱:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="TextBox4" ErrorMessage="请输入正确的邮箱格式！" ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </p>
        </div>
        <div class="sex">
            <p>
                &nbsp;&nbsp;&nbsp; 性别:<asp:RadioButton ID="Male" runat="server" Checked="True" GroupName="Sex"
                    Text="男" />
                <asp:RadioButton ID="Female" runat="server" GroupName="Sex" Text="女" />
            </p>
        </div>
        <div class="registe">
            <p>
                <asp:Button ID="Button1" runat="server" Text="立即注册" BorderColor="Black" BorderStyle="None"
                    BorderWidth="1px" Height="35px" OnClick="Button1_Click" Style="font-size: large"
                    Width="110px" />
            </p>
        </div>
        <div class="info">
            <table>
                <tr>
                    <td id="info">
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>
