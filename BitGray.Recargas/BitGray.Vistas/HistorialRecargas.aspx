<%@ Page Title="" Language="C#" MasterPageFile="~/MasterRecargas.Master" AutoEventWireup="true" CodeBehind="HistorialRecargas.aspx.cs" Inherits="BitGray.Vistas.HistorialRecargas" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    
    <table>
         <tr>
              <td>
                  <asp:Label runat="server" Text="Celular"></asp:Label>
              </td>
               <td>
                  <asp:TextBox runat="server" ID="txtCelular"></asp:TextBox>
              </td>
              <td>
                  <asp:Button ID="btnConsultar" Text="Consultar" runat="server" OnClick="btnConsultar_Click" />
              </td>
          </tr>
        
    </table> 
     <table>
         
        <tr>
            <td>
                <br />
                <br />
                <br />
                <asp:gridview runat="server" ID="grdRecargas">
                   
                </asp:gridview>
                
            </td>
        </tr>
    </table>
</asp:Content>
