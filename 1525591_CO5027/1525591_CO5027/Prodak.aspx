<%@ Page Title="Product|AA's Collections" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Prodak.aspx.cs" Inherits="_1525591_CO5027.Collections" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--reference from-https://www.youtube.com/watch?v=SFDQ6Lkp8Ec&t=1s-->
    <link href="CSS/Collections.css" rel="stylesheet" />
    <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="imgProds" runat="server" CssClass="detailsPic" /></td>
            <td><h2>
                <asp:Label ID="lblHead" runat="server" Text="Label"></asp:Label>
                <hr />
                </h2>
                <p>
                <asp:Label ID="lblMoney" runat="server" CssClass="detailsMoney"></asp:Label>
                </p>
            </td>
        </tr>

         <tr>
            <td>
                <asp:Label ID="lblDescrip" runat="server" CssClass="detailsDescrip"></asp:Label></td>
                <p>Quantity: </p>
             <asp:DropDownList ID="ddlAmounts" runat="server"></asp:DropDownList>
            <p><asp:Label ID="lblResults" runat="server" Text=""></asp:Label></p> 
        </tr>

         <tr>
            <td>Watch Number: <asp:Label ID="lblProdNo" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Button ID="btnAdd" runat="server" CssClass="button" OnClick="btnAdd_Click" Text="Add watch" />
             </td> 
                        
        </tr>

         <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Watch are available!" CssClass="productPrice"></asp:Label></td>            
        </tr>
    </table>
</asp:Content>
