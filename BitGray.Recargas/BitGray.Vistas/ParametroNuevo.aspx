<%@ Page Title="" Language="C#" MasterPageFile="~/MasterRecargas.Master" AutoEventWireup="true" CodeBehind="ParametroNuevo.aspx.cs" Inherits="BitGray.Vistas.ParametroNuevo" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <asp:Panel runat="server" GroupingText="Crear Parámetro" Width="56%" >
            <br />
            <table style="width:70%; margin-left:10px">
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblCosto" Text="Costo X Segundo: " Font-Size="Small"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtCosto" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:CheckBox runat="server" ID="chkVigente" Text="Es Actual?: " TextAlign="Left" Font-Size="Small" />
                    </td>
                </tr>

                <tr style="align-items:center">
                    <td>
                        <br />
                        <asp:Button ID="btnSave" runat="server" Text="Guardar" OnClick="btnSave_Click"  />
                    </td>
                </tr>

            </table>
            <br />
        </asp:Panel>
</asp:Content>
