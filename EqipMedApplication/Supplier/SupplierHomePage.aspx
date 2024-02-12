<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierHomePage.aspx.cs" Inherits="EqipMedApplication.Supplier.SupplierHomePage" %>

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
                <asp:Image ID="Image1" runat="server" Height="50px" Width="100px" ImageUrl="~/ProductImages/eq_logo_black_no_bg.png"  />
            </div>
           
            <div class="header-menu d-flex">
                <div class="menu-item">
                    <asp:LinkButton ID="lbtnOrders" runat="server" OnClick="lbtnOrders_Click" >View Orders</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:LinkButton ID="lbtnProducts" runat="server" OnClick="lbtnProducts_Click">View Products</asp:LinkButton>
                </div>
                <div class="menu-item">
                    
                </div>
                <div class="menu-item">
                   <asp:Button ID="btnLogOut" runat="server" Text="Log Out" class="btn btn-white-outline" OnClick="btnLogOut_Click" />
                </div>
                
            </div>
        </div>
    </div>
    <div class="main-container form-holder">
        <div class="main-content container">
            <div class="form-heder">
                SUPPLIER NAVIGATION
            </div>

                <div class="btn-holder mb-4" >
                    <asp:Button ID="btnAddCategory" runat="server" Text="ADD CATEGORY" class="w-100 btn btn-primary" OnClick="btnAddCategory_Click"   />
                    <br />
                    <br/>
                </div>
                <div className="btn-holder mb-4">
                <asp:Button ID="btnAddProduct" runat="server" Text="ADD PRODUCT" class="w-100 btn btn-primary" OnClick="btnAddProduct_Click"   />
                </div>
                <div className="btn-holder mb-4">
                    <br/>
                </div>
        </div>
    </div>
    
    
    </form>
</body>
</html>
