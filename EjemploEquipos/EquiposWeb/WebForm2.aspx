<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
            CodeBehind="WebForm2.aspx.cs" Inherits="EquiposWeb.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <asp:ScriptManager runat="server" ID="ScriptManager1" />
    <div id="messageBox" runat="server" class="message-box">
        <asp:Literal runat="server" ID="ltMessage" />
        <asp:Button runat="server" ID="btnOK" Text="OK" OnClick="btnOK_Click" />
        <asp:Button runat="server" ID="btnCancel" Text="Cancel" OnClick="btnCancel_Click" />
    </div>

    <asp:CheckBox ID="checkOpcion"  AutoPostBack="true" OnCheckedChanged="chkBox_CheckedChanged" runat="server"/>
   
</asp:Content>
