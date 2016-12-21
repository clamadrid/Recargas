<%@ Page Title="" Language="C#" MasterPageFile="~/MasterRecargas.Master" AutoEventWireup="true" CodeBehind="HistorialConsumos.aspx.cs" Inherits="BitGray.Vistas.HistorialConsumos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <table>
        <tr>
            <td>
                <asp:gridview runat="server" ID="grdConsumos"></asp:gridview>
                
            </td>
        </tr>
    </table>
</asp:Content>
