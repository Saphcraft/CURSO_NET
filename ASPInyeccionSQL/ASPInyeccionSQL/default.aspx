<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ASPInyeccionSQL._default" %>

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
            <asp:Button ID="btnAlta" CssClass="boton" runat ="server" Text="Alta de Usuario" OnClick="btnAlta_Click" />
            <asp:Button ID="btnConsulta" CssClass="boton" runat="server" Text="Consulta de Usuario" OnClick="btnConsulta_Click" />
            <asp:Button ID="btnBaja" CssClass="boton" runat="server" Text="Baja de Usuario" OnClick="btnBaja_Click" />
            <asp:Button ID="btnModificar" CssClass="boton" runat="server" Text="Modificación de Usuario" OnClick="btnModificar_Click"/>
        </div>
    </form>
</body>
</html>
