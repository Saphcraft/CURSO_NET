<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Modificaciones.aspx.cs" Inherits="ASPMasterPage.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="css/StyleSheet.css" rel="stylesheet" />
    <br /><br />
    <div class="row mt-2">
        <h1>MODIFICACION DE CLIENTES</h1>
        <div class="filas">
            <!-- ID -->
            <div class="titulos">
                <asp:Label ID="Label1" runat="server" Text="Id" Width="100px"></asp:Label>
            </div>
            <div class="controles">
                <asp:DropDownList ID="ddID" CssClass="flotado" runat="server" DataSourceID="SqlDataSource1" DataTextField="ID"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SIMULACROSQLConnectionString %>" SelectCommand="SELECT [ID] FROM [cliente]"></asp:SqlDataSource>
                <asp:Button ID="btnBuscar" CssClass="btnFinal flotado" runat="server" Text="Buscar" CausesValidation="False" OnClick="btnBuscar_Click"/>               
            </div>
        </div>
        <div class="filas">
            <!-- NOMBRE -->
            <div class="titulos">
                <asp:Label ID="Label2" runat="server" Text="Nombre" Width="100px"></asp:Label>
            </div>
            <div class="controles">
                <asp:TextBox ID="txtNombre" CssClass="ancho" runat="server"></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtNombre" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="filas">
            <!-- APELLIDO1 -->
            <div class="titulos">
                <asp:Label ID="Label3" runat="server" Text="Apellido 1" Width="100px"></asp:Label>
            </div>
            <div class="controles">
                <asp:TextBox ID="txtApellido1" CssClass="ancho" runat="server"></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtApellido1" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="filas">
            <!-- APELLIDO2 -->
            <div class="titulos">
                <asp:Label ID="Label4" runat="server" Text="Apellido 2" Width="100px"></asp:Label>
            </div>
            <div class="controles">
                <asp:TextBox ID="txtApellido2" CssClass="ancho" runat="server"></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtApellido2" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="filas">
            <!-- CIUDAD -->
            <div class="titulos">
                <asp:Label ID="Label5" runat="server" Text="Ciudad" Width="100px"></asp:Label>
            </div>
            <div class="controles">
                <asp:TextBox ID="txtCiudad" CssClass="ancho" runat="server"></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtCiudad" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="filas">
            <!-- CATEGORIA -->
            <div class="titulos">
                <asp:Label ID="Label6" runat="server" Text="Categoria" Width="100px"></asp:Label>
            </div>
            <div class="controles">
                <asp:TextBox ID="txtCategoria" CssClass="ancho" runat="server"></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="txtCategoria" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="filas">
            <!-- BOTON -->
            <div class="titulos">
                <asp:Label ID="lblConfirmacion" runat="server" Text="&nbsp"></asp:Label>
            </div>
            <div class="controles">
                <asp:Button ID="btnModificar" CssClass="btnFinal" runat="server" Text="Modificar" OnClick="btnModificar_Click" />
            </div>
        </div>
        <div class="filas validacion">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" ForeColor="Blue" />
        </div>
    </div>
</asp:Content>
