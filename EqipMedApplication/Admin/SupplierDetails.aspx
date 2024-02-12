<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="SupplierDetails.aspx.cs" Inherits="EqipMedApplication.Admin.SupplierDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="plhSearch" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="plhFilter" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="plhData" runat="server">
    <asp:GridView ID="grdvSupplierDetails" runat="server" AutoGenerateColumns="False" Class="Table">
        <Columns>
            <asp:BoundField DataField="SUPPLIERID" HeaderText="SUPPLIER ID" />
            <asp:BoundField DataField="SUPPLIERNAME" HeaderText="SUPPLIER NAME" />
            <asp:BoundField DataField="SUPPLIERADDRESS" HeaderText="SUPPLIERADDRESS" />
            <asp:BoundField DataField="SUPPLIERPHONE" HeaderText="SUPPLIER CONTACT" />
            <asp:BoundField DataField="SUPPLIEREMAIL" HeaderText="SUPPLIER EMAIL" />
        </Columns>
    </asp:GridView>
</asp:Content>
