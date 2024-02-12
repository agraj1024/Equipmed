<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="OrderDetails.aspx.cs" Inherits="EqipMedApplication.Admin.OrderDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="plhSearch" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="plhFilter" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="plhData" runat="server">
    <asp:GridView ID="grdvOrderDetails" runat="server" AutoGenerateColumns="False" Class="Table">
    <Columns>
            <asp:BoundField DataField="ORDERID" HeaderText="ORDERID" />
            <asp:BoundField DataField="CUSTOMERNAME" HeaderText="CUSTOMER NAME" />
            <asp:BoundField DataField="PRODUCTNAME" HeaderText="PRODUCT NAME" />
            <asp:BoundField DataField="QUANTITY" HeaderText="QUANTITY ORDERED" />
            <asp:BoundField DataField="PRODUCTPRICE" HeaderText="PRODUCT PRICE" />
            <asp:BoundField DataField="PRODUCTPRICE" HeaderText="TOTAL AMOUNT" />
            <asp:BoundField DataField="ORDERDATE" HeaderText="ORDER DATE" />
        </Columns>
     </asp:GridView>
</asp:Content>
