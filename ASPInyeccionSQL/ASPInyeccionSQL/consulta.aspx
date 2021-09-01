<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consulta.aspx.cs" Inherits="ASPInyeccionSQL.consulta" %>

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
                <h1>BUSCAR USUARIO</h1>
                <div class="titulos">
                    <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre de usuario:"></asp:Label>
                </div>
                <div class="controles">
                    <asp:TextBox ID="txtNombreUsuario" CssClass="ancho" runat="server"></asp:TextBox><br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtNombreUsuario" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="titulos">
                <asp:Label ID="lblConfirmacion" runat="server" Text="&nbsp"></asp:Label>
            </div>
            <div class="controles">
                <asp:Button ID="btnBuscar" CssClass="btnFinal" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                <asp:Button ID="btnInicio" CssClass="btnRetorno" runat="server" Text="Inicio" CausesValidation="False" OnClick="btnInicio_Click"/>
            </div>
            <div class="filas validacion">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" ForeColor="Blue" />
            </div>
        </div>
    </form>
</body>
</html>
