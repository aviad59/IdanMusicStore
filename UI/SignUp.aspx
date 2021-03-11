<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="UI.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="margin-top: 50px;">


        <br />

        <div class="form-row" style="margin-left: 25%;">
            <div class="col-md-4 mb-3">
                <asp:Label for="firstname" ID="Fname" runat="server" Text="First Name:"></asp:Label>
                <asp:TextBox ID="firstname" runat="server" CssClass="form-control" placeholder="Enter First Name..." CausesValidation="True"></asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="SignUpValidation" ID="RequiredFirstNameValidator" runat="server" ErrorMessage="Required" ControlToValidate="firstname" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ValidationGroup="SignUpValidation" ID="RegularExpressionFirstNameValidator" runat="server" ErrorMessage="Please enter a valid name" ControlToValidate="firstname" ValidationExpression="[a-zA-Z/'/-]+" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            </div>

            <div class="form-row">
                <asp:Label for="lastname" ID="Lname" runat="server" Text="Last Name:"></asp:Label>
                <asp:TextBox ID="lastname" runat="server" CssClass="form-control" placeholder="Enter Last Name..." CausesValidation="True"></asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="SignUpValidation" ID="RequiredLastNameValidator" runat="server" ErrorMessage="Required" ControlToValidate="lastname" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ValidationGroup="SignUpValidation" ID="RegularExpressionLastNameValidator" runat="server" ErrorMessage="Please enter a valid name" ControlToValidate="lastname" ValidationExpression="[a-zA-Z/'/-]+" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-row">
            <asp:Label for="EmailInput" ID="Email" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="EmailInput" runat="server" TextMode="Email" CssClass="form-control" placeholder="Enter Email..."></asp:TextBox>
            <asp:RequiredFieldValidator ValidationGroup="SignUpValidation" ID="RequiredEmailValidator" runat="server" ErrorMessage="Required" ControlToValidate="EmailInput" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ValidationGroup="SignUpValidation" ID="RegularExpressionEmailValidator" runat="server" ErrorMessage="Please enter a valid Email" ControlToValidate="EmailInput" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            <asp:CustomValidator ValidationGroup="SignUpValidation" ID="EmailExistsValidator" runat="server" ErrorMessage="Email already in use :(" ControlToValidate="EmailInput" Display="Dynamic" ForeColor="Red" OnServerValidate="EmailExistsValidator_ServerValidate"></asp:CustomValidator>
        </div>
        <br />
        <div class="form-row">
            <asp:Label for="password" ID="PSW" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="password" runat="server" TextMode="Password" CssClass="form-control" placeholder="Enter Password..." CausesValidation="True"></asp:TextBox>
            <asp:RequiredFieldValidator ValidationGroup="SignUpValidation" ID="RequiredPasswordValidator" runat="server" ErrorMessage="Required" ControlToValidate="password" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ValidationGroup="SignUpValidation" ID="RegularExpressionPasswordValidator" runat="server" ErrorMessage="Password must contain: 5-15 characters, 1 Uppercase letter, 1 Lowercase letter, 1 number " ControlToValidate="password" ValidationExpression="^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{5,15}$" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
        </div>
        <br />
        <div class="form-row">
            <asp:Label for="ConPassword" ID="CPSW" runat="server" Text="Confirm Password:"></asp:Label>
            <asp:TextBox ID="ConPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Confirm Password..."></asp:TextBox>
            <asp:RequiredFieldValidator ValidationGroup="SignUpValidation" ID="RequiredConPasswordValidator" runat="server" ErrorMessage="Required" ControlToValidate="ConPassword" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CustomValidator ValidationGroup="SignUpValidation" ID="DoPasswordsMatch" runat="server" ErrorMessage="Passwords must match" Display="Dynamic" ForeColor="Red" OnServerValidate="DoPasswordsMatch_ServerValidate"></asp:CustomValidator>
        </div>

        <br />

        <div class="form-row">
            <div class="custom-control custom-checkbox mb-3">
                <asp:CheckBox ID="IAgree" runat="server"/>
                <asp:Label ID="IAgreeText" for="IAgree" runat="server" Text="Agree to the "></asp:Label>
            </div>
        </div>

        <div class="form-row">
            <asp:Button ID="Submit" CssClass="btn btn-primary" runat="server" Text="Sign Up!" OnClick="Submit_Click" />
        </div>

    </div>
 

</asp:Content>