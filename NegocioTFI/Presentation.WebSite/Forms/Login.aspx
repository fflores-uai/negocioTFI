<%@ Page Title="" Language="C#" MasterPageFile="~/Forms/Shared/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Presentation.WebSite.Forms.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="lblUserName" Text="UserName" runat="server" />
    <asp:TextBox ID="UserName" runat="server" />
    <asp:Label ID="lblPassword" Text="Password" runat="server" />
    <asp:TextBox ID="Password" runat="server" />

    <asp:Button ID="btnLogin" Text="Login" runat="server" />
</asp:Content>