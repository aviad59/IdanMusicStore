<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="UI.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style>
    body {
        background-image:url('\Pictures\Misc\Background.jpg') !important;
        background-repeat:no-repeat;
        background-attachment:fixed;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server"></asp:Panel>
    <br />
    <br />
    <h1 class="p1">Welcome to IdanMusicStore! </h1>
    <h3 class="p2">We are strongly encourage you to take a look on out product, we're selling almost everything related to music!</h3> 
    <br />

    <h2 class="p1">Updates:</h2>
    <article>
        <h3 class="p2">23.02.2021</h3>
        <p class="p3">
            Bug fixed!! <br />
            We worked around the clock to fix all the bugs you've reported about!
        </p>
    </article>
    <article>
        <h3 class="p2">10.02.2021</h3>
        <p class="p3">
            From now on you can also buy Drums! <br />
            checking out the product tab you will find a new section for all kind of drums!
        </p>
    </article>
</asp:Content>
