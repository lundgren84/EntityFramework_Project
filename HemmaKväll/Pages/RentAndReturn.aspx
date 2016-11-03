<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="RentAndReturn.aspx.cs" Inherits="HemmaKväll.Pages.RentAndReturn" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Rent movie</h1>
    <asp:Label ID="Label1" runat="server" EnableTheming="True" Height="40px" Text="MovieID to rent"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" Height="31px"></asp:TextBox>
     <asp:Label ID="Label2" runat="server" EnableTheming="True" Height="40px" Text="MemberID"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" Height="31px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="rent_Movie_Click" Text="Rent" Height="38px" Width="82px" />
        <h1>Return movie</h1>
    <asp:Label ID="Label3" runat="server" EnableTheming="True" Height="40px" Text="MovieID to return"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" Height="31px"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" OnClick="return_Movie_Click" Text="Return" Height="38px" Width="82px" />
</asp:Content>
