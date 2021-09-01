<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alta.aspx.cs" Inherits="ASPInyeccionSQL.alta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/StyleSheet.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <div class="filas">
                <h1>ALTA DE USUARIO</h1>
                <div class="titulos">
                    <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
                </div>
                <div class="controles">
                    <asp:TextBox ID="txtNombre" CssClass="ancho" runat="server"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtNombre" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label2" runat="server" Text="Clave:"></asp:Label>
                </div>
                <div class="controles">
                    <asp:TextBox ID="txtClave" CssClass="ancho" runat="server" TextMode="Password"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtClave" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="filas">
                <div class="titulos">
                    <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>
                </div>
                <div class="controles">
                    <asp:TextBox ID="txtEmail" CssClass="ancho" runat="server"></asp:TextBox><br />              
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Introduce un email valido" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
    Display = "Dynamic" ControlToValidate="txtEmail" ForeColor="Red"></asp:RegularExpressionValidator>
                </div>
            </div>

            <div class="titulos">
                    <asp:Label ID="lblConfirmacion" runat="server" Text="&nbsp"></asp:Label>
            </div>
            <div class="controles">
                <asp:Button ID="btnAlta" CssClass="btnFinal" runat="server" Text="Alta" OnClick="btnAlta_Click"/>
                <asp:Button ID="btnInicio" CssClass="btnRetorno" runat="server" Text="Inicio" CausesValidation="False" OnClick="btnInicio_Click"/>
            </div>
            <div class="filas validacion">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" ForeColor="Blue" />
            </div>
        </div>
    </form>
</body>
</html>
