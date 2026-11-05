<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ManageUsers.aspx.cs" Inherits="ManageUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:GridView ID="GridUsers" runat="server" AutoGenerateColumns="False" DataKeyNames="Identification" OnRowCancelingEdit="GridUsers_RowCancelingEdit" OnRowEditing="GridUsers_RowEditing" OnRowUpdating="GridUsers_RowUpdating" OnRowDataBound="GridUsers_RowDataBound">
    <Columns>
        <asp:BoundField DataField="FirstName" HeaderText="First Name" />
        <asp:BoundField DataField="LastName" HeaderText="Last Name" HtmlEncodeFormatString="False" />
        <asp:BoundField DataField="Identification" HeaderText="ID" ReadOnly="True" />
        <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" />
        <asp:BoundField DataField="Password" HeaderText="Password" />
        <asp:BoundField DataField="Points" HeaderText="Points" />
        <asp:TemplateField HeaderText="Gender">
            <ItemTemplate>
                <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal" Enabled="False">
                    <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="2"></asp:ListItem>
                </asp:RadioButtonList>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="City">
            <ItemTemplate>
                <asp:DropDownList ID="ddlCity" runat="server" Enabled="False"></asp:DropDownList>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:CommandField ButtonType="Button" ShowEditButton="True" />
    </Columns>
</asp:GridView>


</asp:Content>

