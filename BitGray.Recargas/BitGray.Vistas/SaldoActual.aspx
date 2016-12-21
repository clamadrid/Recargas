<%@ Page Title="" Language="C#" MasterPageFile="~/MasterRecargas.Master" AutoEventWireup="true" CodeBehind="SaldoActual.aspx.cs" Inherits="BitGray.Vistas.SaldoActual" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <asp:Panel runat="server" GroupingText="Saldo Actual">
    <table>
        <tr>
            <td>
                <asp:label runat="server" Text="Celular: " Font-Size="Small" ></asp:label>
            </td>
             <td>
               <asp:TextBox runat="server" ID="txtCelular" Font-Size="Small" ></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:label runat="server" Text="Saldo Disponible en dinero" Font-Size="Small" ></asp:label>
            </td>
             <td>
                <asp:label runat="server" ID="lblDisponibleDinero" Font-Size="Small" ></asp:label>
            </td>
        </tr>

        <tr>
            <td>
                <asp:label runat="server" Text="Saldo Disponible en segundos" Font-Size="Small" ></asp:label>
            </td>
             <td>
                <asp:label runat="server" ID="lblDisponibleSegundos" Font-Size="Small" ></asp:label>
            </td>
        </tr>
        <tr>
            <td>
            <asp:Button runat="server" Text="Consultar" ID="btnConsultar" OnClick="btnConsultar_Click" />
            </td>
        </tr>
    </table>
        </asp:Panel>
</asp:Content>
