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
        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Invaild credential" Display="Dynamic" ForeColor="Red" OnServerValidate="checkCredentials_ServerValidate"></asp:CustomValidator>
        <br />
        <asp:Label ID="EnterEmail" runat="server" Text="Email:" TextMode="Email" Font-Bold="true"></asp:Label>
        <br />
        <asp:TextBox ID="Email" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ValidationGroup="SignUpValidation" ID="RegularExpressionEmailValidator" runat="server" ErrorMessage="Please enter a valid Email" ControlToValidate="Email" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>  
        <br />
        <asp:Label ID="EnterPassword" runat="server" Text="Password:" Font-Bold="true"></asp:Label>
        <br />
        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="LogInBtn" runat="server" Text="Login!" OnClick="LogInBtn_Click"/>
    </div>
    
</asp:Content>
