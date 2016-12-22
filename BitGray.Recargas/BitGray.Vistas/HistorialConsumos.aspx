<%@ Page Title="" Language="C#" MasterPageFile="~/MasterRecargas.Master" AutoEventWireup="true" CodeBehind="HistorialConsumos.aspx.cs" Inherits="BitGray.Vistas.HistorialConsumos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
        
    <table style="width:70%; margin-left:10px">
        <tr>
            <td>
                 <asp:Label ID="lblTitle" runat="server" Text="Listado de Consumos" Font-Size="Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <br />

                <asp:gridview runat="server" ID="grdConsumos"></asp:gridview>
                
            </td>
        </tr>
    </table>
</asp:Content>
