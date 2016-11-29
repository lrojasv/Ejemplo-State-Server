<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SesionCompartida.aspx.cs" Inherits="EjemploStateServer.SesionCompartida" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br/>

    <table>
        <tr>
            <td>Nombre</td>
            <td>
                <asp:TextBox runat="server" ID="txtNombre"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>Apellido</td>
            <td>
                <asp:TextBox runat="server" ID="txtApellido"></asp:TextBox>
            </td>
            <td></td>
        </tr>

        <tr>
            <td>
                <asp:Button runat="server" ID="btnGuardar" Text="Guardar" OnClick="btnGuardar_Click"/>
            </td>
            <td>
                <asp:Button runat="server" ID="btnLimpiar" Text="Limpiar" OnClick="btnLimpiar_Click" />
            </td>
            <td>
                <asp:Button runat="server" ID="btnMostrarResultado" Text="Mostrar Resultado" OnClick="btnMostrarResultado_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="3"></td>
        </tr>
    </table>
    
    <asp:Label runat="server" ID="lblResultado" Width="1108px" Font-Size="42pt"></asp:Label>
    
    <br /><br/>

    <asp:Label runat="server" ID="lblAppDomain"></asp:Label>

</asp:Content>
