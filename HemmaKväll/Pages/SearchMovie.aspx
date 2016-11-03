<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SearchMovie.aspx.cs" Inherits="HemmaKväll.Pages.SearchMovie" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Search movie</h1>
    <div class="container">
        <div class="row">
            <div class="col-xs-2">
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            </div>            
            <div class="col-xs-2">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
             <div class="col-xs-2">
                <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
            </div>
            <div class="col-xs-2">
                <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="Search" />
            </div>
        </div>
        <asp:Panel ID="PanelSearch" runat="server">
            <h2>Search Result</h2>
            <div runat="server" id="SearchMovies">
            </div>
        </asp:Panel>
        <h2>All Movies</h2>
        <div runat="server" id="AllMovies">
            <div class="row">
                <div class="col-xs-1"></div>
                <div class="col-xs-1"></div>
                <div class="col-xs-1"></div>
            </div>
        </div>
    </div>
</asp:Content>
