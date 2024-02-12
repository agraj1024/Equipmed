<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="EqipMedApplication.Admin.ProductDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="plhSearch" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="plhFilter" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="plhData" runat="server">
    <asp:GridView ID="grdvProductDetails" runat="server" AutoGenerateColumns="False" Class="Table">
        <Columns>
            <asp:BoundField DataField="PRODUCTID" HeaderText="PRODUCT ID" />
            <asp:BoundField DataField="PRODUCTNAME" HeaderText="PRODUCT NAME" />
            <asp:BoundField DataField="PRODUCTDESCRIPTION" HeaderText="DESCRIPTION" />
            <asp:BoundField DataField="PRODUCTPRICE" HeaderText="PRODUCT PRICE" />
            <asp:BoundField DataField="PRODUCTSTOCK" HeaderText="PRODUCT STOCK" />
            <asp:BoundField DataField="CATEGORYID" HeaderText="CATEGORY ID" />
            <asp:BoundField DataField="SUPPLIERID" HeaderText="SUPPLIER ID" />
            <asp:ImageField DataImageUrlField="ProductImage" HeaderText="PRODUCT IMAGE">
            </asp:ImageField>
        </Columns>
    </asp:GridView>
</asp:Content>
