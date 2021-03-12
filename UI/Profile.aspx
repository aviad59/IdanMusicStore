<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="UI.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<br />
<br />
<asp:Label ID="Greeting" runat="server" Text="Hello there," Font-Bold="true" Font-Size="Larger"></asp:Label>    
<asp:Label ID="FullName" runat="server" Text='<%=fullName%>' Font-Bold="true" Font-Size="Larger"></asp:Label>    

<br />
<br />
    <%if (isAdmin)
      { %>
    <asp:GridView ID="UsersList" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
    <br />
    <asp:Label ID="SetAdmin" runat="server" Text="Set Admin:" Font-Bold="true"></asp:Label>
    <asp:RegularExpressionValidator ValidationGroup="SignUpValidation" ID="RegularExpressionEmailValidator" runat="server" ErrorMessage="Please enter a valid Email" ControlToValidate="Email" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>  
    <br />
    <asp:TextBox ID="emailSetAdmin" runat="server"></asp:TextBox>
    <asp:Button ID="SetAdminBTN" runat="server" Text="Set" Width="30px" OnClick="SetAdminBTN_Click"/>
    <%} %>
<br />
</asp:Content>
