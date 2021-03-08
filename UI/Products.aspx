<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="UI.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br />
    <br />
    <br />
    
    <asp:DataList ID="ProductsDL" RepeatDirection="Horizontal" runat="server">
        <ItemTemplate>
            <asp:Label ID="Name" runat="server" Text='<%# Eval("name") %>'></asp:Label>
            <br />
            <%--  --%>
        </ItemTemplate>
    </asp:DataList>

    

</asp:Content>
