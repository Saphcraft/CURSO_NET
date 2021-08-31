<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CuestionarioASP_NET._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="CSS/estilos.css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
      <form id="form1" runat="server">
        <div>
            <div class="container">
                <div class="page-header">
	                <h1>ASP<span><small> Cuestionario</small></span></h1>
	            </div>                      
                    <asp:Label ID="Label1" Cssclass="titulo" runat="server" Text="1- ¿Que es una aplicación Web?"></asp:Label >    
                <div>
                    <asp:Panel ID="Panel1" runat="server">
                        <asp:RadioButton ID="p1a" runat="server" GroupName="p1" Text=" a.- Conjunto o agrupación de IAM" AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p1b" runat="server" GroupName="p1" Text=" b.- a y e" AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p1c" runat="server" GroupName="p1" Text=" c.- Elementos de PHP" AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p1d" runat="server" GroupName="p1" Text=" d.- Clases hechas en HTML" AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p1e" runat="server" GroupName="p1" Text=" e.- Conjunto de paginas HTML" AutoPostBack="true"/><br />
                        <br />
                    </asp:Panel>
                </div>
                    <asp:Label ID="Label5" Cssclass="titulo" runat="server" Text="2- Qué es un servidor Web"></asp:Label>
                <div>             
                    <asp:Panel ID="Panel2" runat="server">
                        <asp:RadioButton ID="p5a" runat="server" GroupName="p2" Text="a.- Sistemas inteligente que facilita la cración de paginas imagenes, etc." AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p5b" runat="server" GroupName="p2" Text="b.- Sistemas informatico que no debe estar a la red porque se produciran errores." AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p5c" runat="server" GroupName="p2" Text="c.- Sistemas informático conectado a la red donde se almacenan páginas imagenes, etc." AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p5d" runat="server" GroupName="p2" Text="d.- Almacenador de paginas web" AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p5e" runat="server" GroupName="p2" Text="e.- Pide parámetros de configuración" AutoPostBack="true"/><br />
                        <br />
                    </asp:Panel>
                </div>
                 <asp:Label ID="Label8" Cssclass="titulo" runat="server" Text="3- ¿Qué significan las siglas HTTP?"></asp:Label>
                <div>             
                    <asp:Panel ID="Panel3" runat="server">
                        <asp:RadioButton ID="p8a" runat="server" GroupName="p3" Text="a.- Hight Text Transfer Protocol" AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p8b" runat="server" GroupName="p3" Text="b.- Hiden Text Trans Protocol" AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p8c" runat="server" GroupName="p3" Text="c.- Hidetext Transfer Protocol" AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p8d" runat="server" GroupName="p3" Text="d.- Hyper Transfer Text Protocol" AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p8e" runat="server" GroupName="p3" Text="e.- Hypertext Transfer Protocol" AutoPostBack="true"/><br />
                        <br />
                    </asp:Panel>
                </div>
                <asp:Label ID="Label17" runat="server" Cssclass="titulo" Text="4- ¿Qué es un formulario Web?"></asp:Label>
                <div>
                    <asp:Panel ID="Panel4" runat="server">
                        <asp:RadioButton ID="p17a" runat="server" GroupName="p5" Text="a.- Es una página expresada en lenguaje de marcas" AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p17b" runat="server" GroupName="p5" Text="b.- Es una .docx expresada en lenguaje de marcas" AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p17c" runat="server" GroupName="p5" Text="c.- Es una página de códigos PHP" AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p17d" runat="server" GroupName="p5" Text="d.- Es un documento realizado en DreamWeaver" AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p17e" runat="server" GroupName="p5" Text="e.- Contenedor de WindowsForm" AutoPostBack="true"/><br />
                        <asp:RadioButton ID="p17f" runat="server" GroupName="p5" Text="f.- Otras" AutoPostBack="true"/>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Obligatorio" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Está fuera de rango" MaximumValue="20" MinimumValue="10" ControlToValidate="TextBox2" ForeColor="Red" Type="Integer">No está dentro del rango</asp:RangeValidator><br />

                        
                    </asp:Panel>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox><br>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="No coinciden" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ForeColor="Red"></asp:CompareValidator><br /><br />
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label><br>
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Introduce un email valido" ValidationExpression="/^[^\s@]+@[^\s@]+\.[^\s@]+$/" ControlToValidate="TextBox5" ForeColor="Red"></asp:RegularExpressionValidator>


                </div>  

                <div>
                    <asp:Label ID="respuestas" Cssclass="titulo" runat="server" Text=""> </asp:Label>
                </div>
                <div class="btn" >
                    <asp:Button type="submit" ID="resultado" runat="server" Text="RESULTADO" Width="313px" OnClick="resultado_Click" /><br /><br />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" />
                </div>        
            </div>
        </div>       
    </form>
</body>
</html>
