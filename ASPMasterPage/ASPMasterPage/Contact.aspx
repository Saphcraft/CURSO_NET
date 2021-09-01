<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ASPMasterPage.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>
    <address>
        <img alt="img" longdesc="img" src="file:///G:/DESARROLLO%20DE%20APLICACIONES%20CON%20TECNOLOGIAS%20WEB/MF0491_3%20Entorno%20cliente/UF1841%20Lenguajes%20de%20marcas/Ejercicio%20REPASO%201/img/image.png" style="width: 1042px; height: 473px" /></address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
