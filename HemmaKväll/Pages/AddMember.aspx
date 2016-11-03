<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddMember.aspx.cs" Inherits="HemmaKväll.Pages.AddMember" %>


<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Add new member</h1>
    <div class="container">
        <%-- FirstName --%>
        <div class="row">
            <div class="col-xs-1">
                <asp:Label ID="Label1" CssClass="label" runat="server" Text="Firstname"></asp:Label></div>
            <div class="col-xs-2">
                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox></div>
        </div>
        <%-- LastName --%>
        <div class="row">
            <div class="col-xs-1">
                <asp:Label ID="Label2" CssClass="label"  runat="server" Text="LastName"></asp:Label></div>
            <div class="col-xs-2">
                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox></div>
        </div>
        <%-- Phone --%>
        <div class="row">
            <div class="col-xs-1">
                <asp:Label ID="Label3" CssClass="label"  runat="server" Text="Phonenumber"></asp:Label></div>
            <div class="col-xs-2">
                <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox></div>
        </div>
        <%-- SSN --%>
        <div class="row">
            <div class="col-xs-1">
                <asp:Label ID="Label4" CssClass="label"  runat="server" Text="SSN"></asp:Label></div>
            <div class="col-xs-2">
                <asp:TextBox ID="TextBox4" CssClass="form-control" runat="server"></asp:TextBox></div>
        </div>
        <%-- ADD --%>
        <div class="row">
            <div class="col-xs-1">
                <asp:Button OnClick="Button1_Click" ID="Button1" CssClass="btn"  runat="server" Text="Add member" /></div>
           
        </div>
    </div>


</asp:Content>
