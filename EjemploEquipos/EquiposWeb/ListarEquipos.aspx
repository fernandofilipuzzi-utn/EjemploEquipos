<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
        CodeBehind="ListarEquipos.aspx.cs" Inherits="EquiposWeb.ListarEquipos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:ListView ID="ltvListado" runat="server">
            <LayoutTemplate> 
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"/>
            </LayoutTemplate> 

            <ItemTemplate>
                <div>
                    <asp:Label runat="server" Text='<%#Eval("Nombre")%>'/>
                    <asp:Label runat="server" Text='<%#Eval("Club")%>'/>
                    <asp:Label runat="server" Text='<%#Eval("Puntos")%>'/>
                </div>
            </ItemTemplate>

        </asp:ListView>

     </div>

</asp:Content>
