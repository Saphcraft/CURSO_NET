<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PrimerEntornoASP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="1"></asp:Label>
        </div>
        <asp:Button ID="Button1" runat="server" Text="sumar" OnClick="Button1_Click" />
        <br />
        <div>
            <asp:Label ID="Label2" runat="server" Text="Ingrese primer valor:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Ingrese segundo valor:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:RadioButton ID="sumar" runat="server" Text="sumar" GroupName="opcion" />
            <br />
            <asp:RadioButton ID="restar" runat="server" Text="restar" GroupName="opcion" />
            <br />
            <asp:Button ID="btnResultado" runat="server" OnClick="btnResultado_Click" Text="Resultado" />
            <br />
            <asp:Label ID="RESULTADO" runat="server" Text="resultado"></asp:Label>
        </div>
         <div>
            <asp:Label ID="Label4" runat="server" Text="Ingrese primer valor:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Ingrese segundo valor:"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
             <asp:DropDownList ID="operaciones" runat="server">
                 <asp:ListItem>sumar</asp:ListItem>
                 <asp:ListItem>restar</asp:ListItem>
                 <asp:ListItem>dividir</asp:ListItem>
                 <asp:ListItem>multiplicar</asp:ListItem>
             </asp:DropDownList>
            <br />
             <asp:Button ID="btnDrop" runat="server" OnClick="btnDrop_Click" Text="Button" />
            <br />
            <asp:Label ID="Label6" runat="server" Text="resultado"></asp:Label>
        </div>
    </form>
</body>
</html>
