<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDescription.aspx.cs" Inherits="EqipMedApplication.Customer.ProductDescription" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Stylesheet/style.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div class="header-holder">
        <div class="header-content container">
            <div class="header-logo">
             <asp:Image ID="imgLogo" runat="server" ImageUrl="~/ProductImages/logo.jpg" Height="30px" />
            </div>
         
            <div class="header-menu d-flex">
                <div class="menu-item">
                    <asp:ImageButton ID="ibtnHome" runat="server" ImageUrl="~/Button Images/pngfind.com-home-icon-png-transparent-6800118.png" Height="30px" OnClick="ibtnHome_Click" />
                </div>
                <div class="menu-item">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Button Images/white-shopping-cart-icon-png-19.jpg" Height="30px" Width="30px" OnClick="ImageButton1_Click" />
                </div>
                <div class="menu-item">
                    
                </div>
                <div class="menu-item">
                   <asp:Button ID="btnOrderHistory" runat="server" Text="Order History" class="btn btn-white-outline" OnClick="btnOrderHistory_Click" />
                </div>
            </div>
        </div>
    </div>
    <div class="main-container product-details-holder">
        <div class="main-content container">
            <div class="product-details-content d-flex">
                <div class="product-img w-40 px-15">
                    <asp:Image ID="imgProduct" runat="server" />    
                </div>
                <div class="product-details w-60 px-15">
                    <div class="h-50">
                        <div class="product-name f-18 font-medium">
                         <asp:Label ID="lblProductName" runat="server" Text="Label"></asp:Label> 
                        </div>
                        <div class="product-owner mt-10">
                            <span class="by-text primary-color">by</span>
                            <span class="owner-name secondary-color">
                                <asp:Label ID="lblSupplierName" runat="server" Text="Label"></asp:Label></span>
                        </div>
                        <div class="product-price mt-10">
                            <span class="icon"></span>
                            <span class="price primary-color f-18 font-bold">
                                <asp:Label ID="lblProductPrice" runat="server" Text="Label"></asp:Label>
                            </span>
                        </div>
                        <div class="product-availability mt-10">
                            <span class="accent-color f-15">Availability: </span>
                            <span class="primary-color f-16 font-medium"> <asp:Label ID="lblProductStock" runat="server" Text="Label"></asp:Label></span>
                        </div>
                    <div class="product-desc-btn-holder">
                        <div class="product-description mt-10">
                            <asp:Label ID="lblProductDescription" runat="server" Text="Label" Height="100px" Width="693px"></asp:Label>
                        </div>
                        <div class="btn-holder mt-10">
                            &nbsp;<asp:Button ID="btnProductCart" runat="server" Text="Add To Cart" class="btn btn-primary" OnClick="btnProductCart_Click"  />
                                          
                        &nbsp;
                            <asp:ImageButton ID="ibtnSubtract" runat="server" Height="25px" ImageUrl="~/Button Images/Subtract.png" OnClick="ibtnSubtract_Click" Width="25px" />
&nbsp;
                            <asp:TextBox ID="txtQuantity" runat="server" Width="16px">1</asp:TextBox>
&nbsp;
                            <asp:ImageButton ID="ibtnAdd" runat="server" Height="30px" ImageUrl="~/Button Images/add.png" OnClick="ibtnAdd_Click" Width="30px" />
                                          
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
