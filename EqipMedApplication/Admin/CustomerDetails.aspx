<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="CustomerDetails.aspx.cs" Inherits="EqipMedApplication.Admin.CustomerDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="plhSearch" runat="server">
      <div class="search-holder">
             <div class="form-group">
                   <asp:TextBox ID="txtSearch" runat="server" placeholder="Search" class="form-control" height="30px" Width="425px"  ></asp:TextBox>   
                  </div>
            </div>      
    <div>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="20px" ImageUrl="~/Button Images/search-13-16.png"  ImageAlign="Left" OnClick="ImageButton1_Click" />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="plhFilter" runat="server">         
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="plhData" runat="server">
    <asp:GridView ID="grdvCustomerDetails" runat="server" AutoGenerateColumns="False" Class="Table">
        <Columns>
            <asp:BoundField DataField="CUSTOMERID" HeaderText="CUSTOMER ID" />
            <asp:BoundField DataField="CUSTOMERNAME" HeaderText="CUSTOMER NAME" />
            <asp:BoundField DataField="CUSTOMERADDRESS" HeaderText="CUSTOMER ADDRESS" />
            <asp:BoundField DataField="CUSTOMERPHONE" HeaderText="CUSTOMER CONTACT" />
            <asp:BoundField DataField="CUSTOMEREMAIL" HeaderText="CUSTOMER EMAIL" />
            <asp:BoundField DataField="CUSTOMERDOB" HeaderText="CUSTOMER DOB" />
        </Columns>
    </asp:GridView>
</asp:Content>