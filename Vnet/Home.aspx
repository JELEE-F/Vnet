<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div id="homeWrapper">
        <h1 id="homeTitle">Welcome to Vnet</h1>
        <div id="divHomeLinks" runat="server">
            <div><a href="Login.aspx" id="homeLoginLink">Log In</a></div>
            <div><a href="SignUp.aspx" id="homeSignUpLink">Sign Up</a></div>
        </div>
    </div>
</asp:Content>

