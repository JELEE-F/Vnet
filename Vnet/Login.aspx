<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div id="LIform">
        <h2 id="LIloginTitle">Login</h2>
        <table>
            <tr>
                <td id="LIidTitle">ID</td>
            </tr>
            <tr>
                <td><asp:TextBox ID="LIid" runat="server" ClientIDMode="Static"></asp:TextBox></td>
            </tr>
            <tr>
                <td id="LIpasswordTitle">Password</td>
            </tr>
            <tr>
                <td><asp:TextBox ID="LIpassword" runat="server" TextMode="Password" ClientIDMode="Static"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Button ID="LIbtnLogIn" runat="server" Text="Log In" ClientIDMode="Static" onClick="btnLogin_Click" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="LIlblError" runat="server" ForeColor="Red" /></td>
            </tr>
            <tr>
                <td id="LIsignUpRedirect"><a id="LInoAccTxt">Dont have an account?</a> <a href="SignUp.aspx" id="LIsignUpLink">Sign up</a></td>
            </tr>
        </table>
    </div>
</asp:Content>

