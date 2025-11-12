<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio15_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Inserte dos números<br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Num1: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" Width="86px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Num2: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="88px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sumar" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Resultado: "></asp:Label>
        </div>
    </form>
</body>
</html>
