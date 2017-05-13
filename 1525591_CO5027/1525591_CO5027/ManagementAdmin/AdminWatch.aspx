<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminWatch.aspx.cs" Inherits="_1525591_CO5027.ManagementAdmin.AdminWatch1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>
        Name:</p>
    <p>
        <asp:TextBox ID="txtNameP" runat="server"></asp:TextBox>
    </p>
    <p>
        Type:</p>
    <p>
        <asp:DropDownList ID="ddlTypeP" runat="server" DataSourceID="SqlDataSource" DataTextField="watchName" DataValueField="Id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:db_1525591_co5027_aziimConnectionString %>" SelectCommand="SELECT * FROM [watchProdType] ORDER BY [watchName]"></asp:SqlDataSource>
        </p>
    <p>
        Price:</p>
    <p>
        <asp:TextBox ID="txtPriceP" runat="server"></asp:TextBox>
    </p>
    <p>
        Picture:</p>
    <p>
        <asp:DropDownList ID="ddlPicP" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        Description:</p>
    <p>
        <asp:TextBox ID="txtDescP" runat="server" Height="73px" TextMode="MultiLine" Width="219px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnSubmitP" runat="server" Text="Submit" OnClick="btnSubmitP_Click" />
    </p>
    <p>
        <asp:Label ID="lblResultP" runat="server"></asp:Label>
    </p>

</asp:Content>
