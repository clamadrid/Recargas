<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterRecargas.Master" CodeBehind="Parametros.aspx.cs" Inherits="BitGray.Vistas.Parametros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server">
    
        <asp:Panel runat="server" GroupingText="Parámetro Actual" Font-Size="Medium" Width="56%" >
            <br />
            <table style="width:70%; margin-left:10px">
                <tr>
                    <td>
                        <asp:Label ID="lblParametroActual" runat="server" Text="Parámetro: " Font-Size="Small"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="txtParametroActual" runat="server" Font-Size="Small"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
        </asp:Panel>
        <br />
        <br />
        
 
</asp:Content>
