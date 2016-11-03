<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="RemoveMember.aspx.cs" Inherits="HemmaKväll.Pages.RemoveMember" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Remove member</h1>
<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
    <asp:Button ID="remove_button" runat="server" OnClick="remove_button_Click" Text="Remove" />
    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="MultiLine"></asp:TextBox>
</asp:Content>
