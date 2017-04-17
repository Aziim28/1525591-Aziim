<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CollectionManagement.aspx.cs" Inherits="_1525591_CO5027.Management.CollectionManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <p>
        Name:</p>
    <p>
        <asp:TextBox ID="namatxt" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="sendbtn" runat="server" OnClick="sendbtn_Click" Text="Send" />
    </p>
    <p>
        <asp:Label ID="endlabel" runat="server"></asp:Label>
    </p>

</asp:Content>
