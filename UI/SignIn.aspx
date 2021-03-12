<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="UI.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <div style="margin-left: 40%;">
        <asp:Label ID="loginTitle" runat="server" Text="Login" Font-Bold="true" Font-Size="Larger" Font-Underline="true"></asp:Label>
        <br />
        <br />
        <asp:Label ID="EnterEmail" runat="server" Text="Email:" TextMode="Email" Font-Bold="true"></asp:Label>
        <br />
        <asp:TextBox ID="Email" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="EnterPassword" runat="server" Text="Password:" Font-Bold="true"></asp:Label>
        <br />
        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    
</asp:Content>
