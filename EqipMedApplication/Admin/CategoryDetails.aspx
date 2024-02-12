<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="CategoryDetails.aspx.cs" Inherits="EqipMedApplication.Admin.CategoryDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="plhSearch" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="plhFilter" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="plhData" runat="server">
    <asp:GridView ID="grdvCategoryDetails" runat="server" AutoGenerateColumns="False" Class="Table">
    <Columns>
    <asp:BoundField DataField="CATEGORYID" HeaderText="CATEGORY ID" />
    <asp:BoundField DataField="CATEGORYNAME" HeaderText="CATEGORY NAME" />
    <asp:BoundField DataField="CATEGORYDESCRIPTION" HeaderText="CATEGORY DESCRIPTION" />
    </Columns>
    </asp:GridView>
</asp:Content>
