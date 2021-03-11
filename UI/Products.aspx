<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="UI.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br />
    <br />
    <br />
    
    <asp:DataList ID="ProductsDL" RepeatDirection="Horizontal" runat="server" RepeatColumns="5" CellPadding="4" ForeColor="#333333">
        <AlternatingItemStyle ForeColor="#262728" />
        <FooterStyle Font-Bold="True"  />
        <HeaderStyle Font-Bold="True"  />
        <ItemStyle BackColor="#F7F6F3" ForeColor="#282726" />
        <ItemTemplate>
            <asp:ImageButton ID="Image" runat="server" ImageUrl='<%# Eval("image") %>' style="max-height:300px;max-width:100px;min-width:100px;min-height:100px;"></asp:ImageButton>
            <br />
            <asp:Label ID="Name" runat="server" Text='<%# Eval("name") %>'></asp:Label>
            <br />
            <asp:Label ID="Coin" runat="server" Text='₪'></asp:Label>
            <asp:Label ID="Price" runat="server" Text='<%# Eval("price") %>'></asp:Label>
        </ItemTemplate>
        <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    </asp:DataList>

    

</asp:Content>
