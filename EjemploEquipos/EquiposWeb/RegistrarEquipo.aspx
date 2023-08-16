<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" 
     AutoEventWireup="true" CodeBehind="RegistrarEquipo.aspx.cs" 
     Inherits ="WebFormApp.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
      <asp:Label runat="server"  Text="Nombre:"></asp:Label>
      <asp:TextBox ID="tbNombre" runat="server" Text=""></asp:TextBox>            
    </div>
    <br/>
    <div>
      <asp:Label runat="server"  Text="Club:"></asp:Label>
      <asp:TextBox ID="tbClub" runat="server" Text=""></asp:TextBox>            
    </div>
    <br/>
    <div>
      <asp:Label runat="server"  Text="Ingrese el valor:"></asp:Label>
      <asp:TextBox ID="tbPuntos" runat="server" Text=""></asp:TextBox>            
    </div>
    <br/>
    <div>
      <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click"
                                                        Text="Ingresar Equipo"></asp:Button>

    </div>

</asp:Content>
