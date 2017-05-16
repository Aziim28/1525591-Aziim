<%@ Page Title="Management|AA's Collections" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Wmanagement.aspx.cs" Inherits="_1525591_CO5027.ManagementAdmin.Wmanagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--reference from-https://www.youtube.com/watch?v=hkiYuPBwnkQ&index=4&list=PLi5N5AdsklLbrs_7GAOAmmgnbKT042-U9 -->
    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="button" PostBackUrl="~/ManagementAdmin/AdminWatch.aspx">Add New Watch</asp:LinkButton>
    <br />
<br />
<asp:GridView ID="grdWproducts" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="sdswatchProducts" Width="100%" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" OnRowEditing="grdWproducts_RowEditing">
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
        <asp:BoundField DataField="watchProID" HeaderText="watchProID" SortExpression="watchProID" />
        <asp:BoundField DataField="watchName" HeaderText="watchName" SortExpression="watchName" />
        <asp:BoundField DataField="watchPrice" HeaderText="watchPrice" SortExpression="watchPrice" />
        <asp:BoundField DataField="watchDescription" HeaderText="watchDescription" SortExpression="watchDescription" />
        <asp:BoundField DataField="watchImage" HeaderText="watchImage" SortExpression="watchImage" />
    </Columns>
    <FooterStyle BackColor="#CCCCCC" />
    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
    <RowStyle BackColor="White" />
    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="#808080" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#383838" />
</asp:GridView>
<asp:SqlDataSource ID="sdswatchProducts" runat="server" ConnectionString="<%$ ConnectionStrings:db_1525591_co5027_aziimConnectionString %>" DeleteCommand="DELETE FROM [watchProduct] WHERE [ID] = @ID" InsertCommand="INSERT INTO [watchProduct] ([watchProID], [watchName], [watchPrice], [watchDescription], [watchImage]) VALUES (@watchProID, @watchName, @watchPrice, @watchDescription, @watchImage)" SelectCommand="SELECT * FROM [watchProduct]" UpdateCommand="UPDATE [watchProduct] SET [watchProID] = @watchProID, [watchName] = @watchName, [watchPrice] = @watchPrice, [watchDescription] = @watchDescription, [watchImage] = @watchImage WHERE [ID] = @ID">
    <DeleteParameters>
        <asp:Parameter Name="ID" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="watchProID" Type="Int32" />
        <asp:Parameter Name="watchName" Type="String" />
        <asp:Parameter Name="watchPrice" Type="Int32" />
        <asp:Parameter Name="watchDescription" Type="String" />
        <asp:Parameter Name="watchImage" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="watchProID" Type="Int32" />
        <asp:Parameter Name="watchName" Type="String" />
        <asp:Parameter Name="watchPrice" Type="Int32" />
        <asp:Parameter Name="watchDescription" Type="String" />
        <asp:Parameter Name="watchImage" Type="String" />
        <asp:Parameter Name="ID" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
<br />
<asp:LinkButton ID="LinkButton2" runat="server" CssClass="button" PostBackUrl="~/ManagementAdmin/AdminWatchType.aspx">Add New Strap Type</asp:LinkButton>
<br />
<br />
<asp:GridView ID="grdWproductsStrap" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="sdsproductStrap" Width="50%" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
        <asp:BoundField DataField="watchName" HeaderText="watchName" SortExpression="watchName" />
    </Columns>
    <FooterStyle BackColor="#CCCCCC" />
    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
    <RowStyle BackColor="White" />
    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="#808080" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#383838" />
</asp:GridView>
<asp:SqlDataSource ID="sdsproductStrap" runat="server" ConnectionString="<%$ ConnectionStrings:db_1525591_co5027_aziimConnectionString %>" DeleteCommand="DELETE FROM [watchProdType] WHERE [Id] = @Id" InsertCommand="INSERT INTO [watchProdType] ([watchName]) VALUES (@watchName)" SelectCommand="SELECT * FROM [watchProdType]" UpdateCommand="UPDATE [watchProdType] SET [watchName] = @watchName WHERE [Id] = @Id">
    <DeleteParameters>
        <asp:Parameter Name="Id" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="watchName" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="watchName" Type="String" />
        <asp:Parameter Name="Id" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>

</asp:Content>
