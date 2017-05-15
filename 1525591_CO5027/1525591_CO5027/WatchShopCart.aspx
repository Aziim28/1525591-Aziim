<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WatchShopCart.aspx.cs" Inherits="_1525591_CO5027.WatchShopCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="pnlWshopCart" runat="server">

    </asp:Panel>

    <table>
        <tr>
            <td>Total: </td>
            <td><asp:Literal ID="litWtotal" runat="server" Text="" /></td>
        </tr>

        <tr>
            <td>Tax: </td>
            <td><asp:Literal ID="litWtax" runat="server" Text="" /></td>
        </tr>

        <tr>
            <td>Shipping: </td>
            <td>$ 10</td>
        </tr>

        <tr>
            <td>The Total Amount: </td>
            <td><asp:Literal ID="litWtotalAmount" runat="server" Text="" /></td>
        </tr>

        <tr>
            <td>
                <asp:LinkButton ID="lnkWproceed" runat="server" PostBackUrl="~/Default.aspx"
                    Text="Proceed Shopping" />
                OR
                <asp:Button ID="btnWcheckout" runat="server" PostBackUrl="~/Succeed.aspx"
                    CssClass="Button" Width="250px" Text="Proceed Checkout" />
            </td>
        </tr>
    </table>
</asp:Content>
