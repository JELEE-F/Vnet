<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="SUform">

        <h1 id="SUformTitle">Sign Up</h1>

        <div id="SUfirstNameTitle">First name</div>
        <div><asp:TextBox ID="SUfirstName" runat="server" ClientIDMode="Static"></asp:TextBox></div>
        <div><asp:Label ID="lblFirstNameError" runat="server" ForeColor="Red" ClientIDMode="Static" Text=""></asp:Label></div>

        <div id="SUlastNameTitle">Last name</div>
        <div><asp:TextBox ID="SUlastName" runat="server" ClientIDMode="Static"></asp:TextBox></div>
        <div><asp:Label ID="lblLastNameError" runat="server" ForeColor="Red" ClientIDMode="Static" Text=""></asp:Label></div>

        <div id="SUidTitle">ID (9 digits)</div>
        <div><asp:TextBox ID="SUid" runat="server" ClientIDMode="Static"></asp:TextBox></div>
        <div><asp:Label ID="lblIdError" runat="server" ForeColor="Red" ClientIDMode="Static" Text=""></asp:Label></div>

        <div id="SUphoneTitle">Phone number</div>
        <div><asp:TextBox ID="SUphone" runat="server" ClientIDMode="Static"></asp:TextBox></div>
        <div><asp:Label ID="lblPhoneError" runat="server" ForeColor="Red" ClientIDMode="Static" Text=""></asp:Label></div>

        <div id="SUemailTitle">Email address</div>
        <div><asp:TextBox ID="SUemail" runat="server" ClientIDMode="Static"></asp:TextBox></div>
        <div><asp:Label ID="lblEmailError" runat="server" ForeColor="Red" ClientIDMode="Static" Text=""></asp:Label></div>

        <div id="genderPlace">
            <a id="SUgenderTitle">Gender: </a>
            <asp:RadioButtonList ID="Gender" runat="server" ClientIDMode="Static" RepeatDirection="Horizontal">
                <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                <asp:ListItem Text="Female" Value="2"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div><asp:Label ID="lblGenderError" runat="server" ForeColor="Red" ClientIDMode="Static" Text=""></asp:Label></div>

        <div id="SUcityTitle">Select City</div>
        <div><asp:DropDownList ID="SUcity" runat="server" ClientIDMode="Static"></asp:DropDownList></div>
        <div><asp:Label ID="lblCityError" runat="server" ForeColor="Red" ClientIDMode="Static" Text=""></asp:Label></div>

        <div id="SUpassTitle">Password</div>
        <div><asp:TextBox ID="SUpassword" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox></div>
        <div><asp:Label ID="lblPasswordError" runat="server" ForeColor="Red" ClientIDMode="Static" Text=""></asp:Label></div>

        <div><asp:Button ID="btnRegister" runat="server" Text="Sign Up" OnClick="btnRegister_Click" ClientIDMode="Static" /></div>
        <div id="SUloginRedirect"><a id="SUyesaccTxt">already have an account?</a> <a href="Login.aspx" id="SUloginLink">Log In</a></div>

    </div>
</asp:Content>