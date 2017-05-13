<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminWatchType.aspx.cs" Inherits="_1525591_CO5027.ManagementAdmin.AdminWatch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Name:</p>
    <p>
        <asp:TextBox ID="txtNameW" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="txtSubmitW" runat="server" OnClick="txtSubmitW_Click" Text="Submit" />
    </p>
    <p>
        <asp:Label ID="lblResultW" runat="server"></asp:Label>
    </p>
</asp:Content>
