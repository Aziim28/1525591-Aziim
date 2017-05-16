<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminWatchType.aspx.cs" Inherits="_1525591_CO5027.ManagementAdmin.AdminWatch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--reference from-https://www.youtube.com/watch?v=BKujvivVFKI&index=3&list=PLi5N5AdsklLbrs_7GAOAmmgnbKT042-U9 -->
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
