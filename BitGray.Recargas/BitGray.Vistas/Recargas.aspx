<%@ Page Language="C#" MasterPageFile="~/MasterRecargas.Master" AutoEventWireup="true" CodeBehind="Recargas.aspx.cs" Inherits="BitGray.Vistas.Recargas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server">
    
        <asp:Panel runat="server" GroupingText="Crear Recargas" Font-Size="Small">
        <table style="width:30%; margin-left:10px">
         
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblCelular" Text="Número Celular"></asp:Label>
                </td>
               <td>
                   <asp:TextBox runat="server" ID="txtCelular"></asp:TextBox>
               </td>
                </tr>
             <tr>
                <td>
                    <asp:Label runat="server" ID="lblValor" Text ="Valor Recarga"></asp:Label>
                </td>
               <td>
                   <asp:TextBox runat="server" ID="txtValor"></asp:TextBox>
               </td>
            </tr>
            <tr>
                <td>
                    <br />
                    <asp:Button ID="btnSave" Text="Guardar" runat="server" OnClick="btnSave_Click" />
                </td>
            </tr>           
        </table>       
       </asp:Panel>
  
</asp:Content>
