<%@ Page MasterPageFile="~/Site1.Master" Language="C#" AutoEventWireup="true" CodeBehind="RemoveMovie.aspx.cs" Inherits="HemmaKväll.Pages.RemoveMovie" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Remove movies</h1>
    <div class="container">
        <%-- Movie --%>
        <div class="col-xs-1">
            <asp:Label ID="movieLbl" CssClass="label" AssociatedControlID="movieDropDown" runat="server" Text="Movie"></asp:Label>
        </div>
        <div class="col-xs-2">
            <asp:DropDownList ID="movieDropDown" runat="server"></asp:DropDownList>
        </div>
        
        <%-- Remove --%>
        <div class="col-xs-1">
            <asp:Button ID="RemoveBtn" OnClick="RemoveBtn_OnClick" CssClass="btn" runat="server" Text="Remove Movie"/>
        </div>
    </div>
</asp:Content>
