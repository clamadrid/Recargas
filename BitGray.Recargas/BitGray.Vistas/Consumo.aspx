<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterRecargas.Master" CodeBehind="Consumo.aspx.cs" Inherits="BitGray.Vistas.Consumo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Body" runat="server"   >

    <div>
      <asp:Panel runat="server" GroupingText="Crear Parámetro" Width="56%">
            <br />     
     <table style="width:70%; margin-left:10px">           
            <tr>
                <td colspan="2">
                    <asp:Label runat="server" ID="lblCelular" Text="Celular: " Font-Size="Small"></asp:Label>
                </td>
               <td>
                   <asp:TextBox runat="server" ID="txtCelular" Font-Size="Small"></asp:TextBox>
               </td>
                </tr>
             <tr>
                <td colspan="2">
                    <asp:Label runat="server" ID="lblValor" Text ="Segundos: " Font-Size="Small" ></asp:Label>
                </td>
               <td>
                   <asp:TextBox runat="server" ID="txtValor" Font-Size="Small"></asp:TextBox>
               </td>
            </tr>
            <tr>
                <td>
                    <br />
                   
                    <asp:Button ID="btnSave" Text="Guardar" runat="server" OnClick="btnSave_Click" Font-Size="Small"/>
                </td>            
            </tr>           
        </table>
 
          <br />
      </asp:Panel>
    </div>
</asp:Content>
