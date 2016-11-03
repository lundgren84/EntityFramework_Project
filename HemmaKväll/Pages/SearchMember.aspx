<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SearchMember.aspx.cs" Inherits="HemmaKväll.Pages.SearchMember" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Search member</h1>
    <div class="container">
        <div class="row">
            <div class="col-xs-2">
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            </div>
            <div class="col-xs-2">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            <div class="col-xs-2">
                <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="Search" />
            </div>
        </div>

        <h2>All Members</h2>
        <div runat="server" id="AllMembers">
            <div class="row">
                <div class="col-xs-1"></div>
                <div class="col-xs-1"></div>
                <div class="col-xs-1"></div>
            </div>
        </div>
    </div>
</asp:Content>
