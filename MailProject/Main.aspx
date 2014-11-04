<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    收件人<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
&nbsp; 主题<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
&nbsp; 正文<asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />
&nbsp; 附件<asp:FileUpload ID="FileUpload1" runat="server" />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="发送" />
    </form>
</body>
</html>
