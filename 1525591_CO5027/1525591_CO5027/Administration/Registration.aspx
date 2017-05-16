<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="_1525591_CO5027.Administration.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--reference from-https://www.youtube.com/watch?v=mBrxQQJdoHM&t=5s-->
    <link href="../CSS/Registration.css" rel="stylesheet" />
    <p>
        <asp:Literal ID="litWstatus" runat="server"></asp:Literal>
    </p>
    <p>
        UserName:</p>
    <p>
        <asp:TextBox ID="txtWuserName" runat="server" CssClass="winputs"></asp:TextBox>
    </p>
    <p>
        Password:</p>
    <p>
        <asp:TextBox ID="txtWpassword" runat="server" CssClass="winputs" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        Confirm Password:</p>
    <p>
        <asp:TextBox ID="txtWconfirmPassword" runat="server" CssClass="winputs" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        First Name:</p>
    <p>
        <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
    </p>
    <p>
        Last Name:</p>
    <p>
        <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
    </p>
    <p>
        Address:</p>
    <p>
        <asp:TextBox ID="txtAdd" runat="server"></asp:TextBox>
    </p>
    <p>
        Postal Code:</p>
    <p>
        <asp:TextBox ID="txtPostal" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click" Text="Sign Up" />
    </p>
</asp:Content>
