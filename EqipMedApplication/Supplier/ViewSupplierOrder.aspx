<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewSupplierOrder.aspx.cs" Inherits="EqipMedApplication.Supplier.ViewSupplierOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Stylesheet/style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
      <div class="header-holder">
        <div class="header-content container">
            <div class="header-logo">
                <asp:Image ID="imgLogo" runat="server" ImageUrl="~/ProductImages/logo.jpg" />
            </div>
            <div class="header-menu d-flex">
                <div class="menu-item">
                    <asp:LinkButton ID="lbtnHome" runat="server" OnClick="lbtnHome_Click"  >Home</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:LinkButton ID="lbtnOrders" runat="server" OnClick="lbtnOrders_Click">View Products</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:LinkButton ID="lbtnAddProduct" runat="server" OnClick="lbtnAddProduct_Click"  >Add Products</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:LinkButton ID="lbtnAddCategory" runat="server" OnClick="lbtnAddCategory_Click" >Add Categories</asp:LinkButton>
                </div>
               

                <div class="menu-item">
                    </Button>
                </div>
                <div class="menu-item">
                    <Button type="button" class="btn btn-white-outline">
                        Signup</Button>
                </div>
            </div>
        </div>
    </div>
         <asp:Label ID="lblViewProducts" runat="server" Text="SUPPLIER ORDERS" ForeColor="Navy"></asp:Label> 
          <asp:GridView ID="grdvSupplierOrders" runat="server" AutoGenerateColumns="False" Class="Table">
    <Columns>
            <asp:BoundField DataField="ORDERID" HeaderText="ORDERID" />
            <asp:BoundField DataField="CUSTOMERNAME" HeaderText="CUSTOMER NAME" />
            <asp:BoundField DataField="PRODUCTNAME" HeaderText="PRODUCT NAME" />
            <asp:BoundField DataField="QUANTITY" HeaderText="QUANTITY ORDERED" />
            <asp:BoundField DataField="PRODUCTPRICE" HeaderText="PRODUCT PRICE" />
            <asp:BoundField DataField="TOTALAMOUNT" HeaderText="TOTAL AMOUNT" />
            <asp:BoundField DataField="ORDERDATE" HeaderText="ORDER DATE" />
        </Columns>
     </asp:GridView>

    
    
    </form>
</body>
</html>
