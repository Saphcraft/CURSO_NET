<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bajas.aspx.cs" Inherits="ASPMasterPage.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="css/StyleSheet.css" rel="stylesheet" />
    <br /><br />
    <div class="row mt-6">
        <h1>BAJA DE CLIENTES</h1>
        <div class="filas">
            <!-- ID -->
            <div class="titulo">
                <asp:Label ID="Label1" runat="server" Text="Id" Width="100px"></asp:Label>
            </div>
            <div class="controles">
                <asp:DropDownList ID="ddID" CssClass="flotado" runat="server" DataSourceID="SqlDataSource1" DataTextField="ID"></asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SIMULACROSQLConnectionString %>" SelectCommand="SELECT [ID] FROM [cliente]"></asp:SqlDataSource>
                <asp:Button ID="btnEliminar" CssClass="btnFinal flotado" runat="server" Text="Eliminar" CausesValidation="False" OnClick="btnEliminar_Click"/>               
            </div>
        </div>
        <div class="filas">
            <asp:GridView ID="GridDatos" runat="server" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" DataKeyNames="ID">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="apellido1" HeaderText="apellido1" SortExpression="apellido1" />
                    <asp:BoundField DataField="apellido2" HeaderText="apellido2" SortExpression="apellido2" />
                    <asp:BoundField DataField="ciudad" HeaderText="ciudad" SortExpression="ciudad" />
                    <asp:BoundField DataField="categoria" HeaderText="categoria" SortExpression="categoria" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SIMULACROSQLConnectionString %>" SelectCommand="SELECT * FROM [cliente]"></asp:SqlDataSource>
        </div>
        <div class="filas">
            <!-- BOTON -->
            <div class="titulos">
                <asp:Label ID="lblConfirmacion" runat="server" Text="&nbsp"></asp:Label>
            </div>
        </div>
       
        <div class="filas validacion">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" ForeColor="Blue" />
        </div>
    </div>

</asp:Content>
