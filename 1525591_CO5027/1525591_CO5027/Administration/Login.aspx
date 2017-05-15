<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_1525591_CO5027.Administration.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/Login.css" rel="stylesheet" />
    <asp:Literal ID="litWstatus" runat="server"></asp:Literal>
<br />
<br />
Username:<br />
<asp:TextBox ID="txtWuserName" runat="server" CssClass="winputs"></asp:TextBox>
<br />
<br />
Password:<br />
<asp:TextBox ID="txtWpassword" runat="server" CssClass="winputs" TextMode="Password"></asp:TextBox>
<br />
<asp:Button ID="btnSignIn" runat="server" CssClass="button" OnClick="btnSignIn_Click" Text="Sign In" />
<br />
</asp:Content>
