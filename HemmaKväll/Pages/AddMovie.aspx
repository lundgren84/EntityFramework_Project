<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddMovie.aspx.cs" Inherits="HemmaKväll.Pages.AddMovie" %>
<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <h1>Add new movie</h1>
    <div class="container">
        <%-- Title --%>
        <div class="col-xs-1">
            <asp:Label ID="titleLbl" CssClass="label" AssociatedControlID="titleTxtBox" runat="server" Text="Title"></asp:Label>
        </div>
        <div class="col-xs-2">
            <asp:TextBox ID="titleTxtBox" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        
        <%-- genre --%>
        <div class="col-xs-1">
            <asp:Label ID="genreLbl" CssClass="label" AssociatedControlID="genreDropDown" runat="server" Text="Title"></asp:Label>
        </div>
        <div class="col-xs-2">
            <asp:DropDownList ID="genreDropDown" runat="server"></asp:DropDownList>
        </div>
        
        <%-- Length --%>
        <div class="col-xs-1">
            <asp:Label ID="lengthLbl" CssClass="label" AssociatedControlID="lengthTxtBox" runat="server" Text="Title"></asp:Label>
        </div>
        <div class="col-xs-2">
            <asp:TextBox ID="lengthTxtBox" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        
        <%-- Add --%>
        <div class="col-xs-1">
            <asp:Button ID="AddBtn" OnClick="AddBtn_OnClick" CssClass="btn" runat="server" Text="Add Movie"/>
        </div>
    </div>
</asp:Content>
