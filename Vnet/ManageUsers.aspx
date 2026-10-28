<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageUsers.aspx.cs" Inherits="ManageUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:GridView ID="GridUsers" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridUsers_RowCancelingEdit" OnRowEditing="GridUsers_RowEditing">
    <Columns>
        <asp:BoundField DataField="FirstName" HeaderText="FIrst Name" />
        <asp:BoundField DataField="LastName" HeaderText="Last Name" HtmlEncodeFormatString="False" />
        <asp:BoundField DataField="Identification" HeaderText="ID" />
        <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" />
        <asp:BoundField DataField="Password" HeaderText="Password" />
        <asp:BoundField DataField="Points" HeaderText="Points" />
        <asp:BoundField DataField="Gender" HeaderText="Gender" />
        <asp:CommandField ButtonType="Button" ShowEditButton="True" />
    </Columns>
</asp:GridView>


</asp:Content>

