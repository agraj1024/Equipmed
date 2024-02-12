<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerHomePage.aspx.cs" Inherits="EqipMedApplication.Customer.CustomerHomePage" %>

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
                 <asp:Image ID="Image1" runat="server" Height="50px" Width="100px" ImageUrl="~/ProductImages/eq_logo_black_no_bg.png"  />
               </div>
            <div class="search-holder">
                <div class="form-group">
                   <asp:TextBox ID="txtSearch" runat="server" placeholder="Search for products" class="form-control" height="30px" Width="425px"  ></asp:TextBox>
                       </div>
                  </div>
            <div>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="20px" ImageUrl="~/Button Images/search-13-16.png" OnClick="ImageButton1_Click" ImageAlign="Left" />   
           </div>
             <div class="header-menu d-flex">
                <div class="menu-item">
          
                </div>
                <div class="menu-item">
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">About</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Contact</asp:LinkButton>
                </div>
                <div class="menu-item">
                </div>
                <div class="menu-item ">
                    <asp:ImageButton ID="ibtnCart" runat="server" ImageUrl="~/Button Images/white-shopping-cart-icon-png-19.jpg" Height="30px" OnClick="ibtnCart_Click" />
                </div>
                <div class="menu-item">
                <asp:Label ID="lblCustomerName" runat="server" ForeColor="White"></asp:Label>
                </div>
                <div class="menu-item">
                    <asp:Button ID="btnOrderHistory" runat="server" Text="Order History" class="btn btn-white-outline" OnClick="btnOrderHistory_Click" />
                </div>
                <div class="menu-item">
                    <asp:Button ID="btnLogOut" runat="server" Text="Log Out" class="btn btn-white-outline" OnClick="btnLogOut_Click"  />
                </div>
            </div>
        </div>
    </div>
    <div class="main-container homepage-holder">
        <div class="main-content container">
            <div class="tabs-holder">
                <div class="tab active">
                <asp:LinkButton ID="lbtnDurable" runat="server" OnClick="lbtnDurable_Click">Durable Medical Equipment</asp:LinkButton>
                </div>
               <div class="tab">
                <asp:LinkButton ID="lbtnDiagonostic" runat="server" OnClick="lbtnDiagonostic_Click">Diagonostic Medical Equipment</asp:LinkButton>
               </div>
                <div class="tab"> 
                <asp:LinkButton ID="lbtnElectronic" runat="server" OnClick="lbtnElectronic_Click">Electronic Medical Equipment</asp:LinkButton>
                </div>
                <div class="tab"> 
                <asp:LinkButton ID="lbtnAcute" runat="server" OnClick="lbtnAcute_Click">Acute Care</asp:LinkButton>
                </div>
                <div class="tab"> 
                <asp:LinkButton ID="lbtnProcedural" runat="server" OnClick="lbtnProcedural_Click">Procedural Medical Equipment</asp:LinkButton>
                </div>
            </div>

            <div class="product-card-holder">
                <asp:DataList ID="dtlGetProductView" runat="server" CellPadding="3" CellSpacing="2" GridLines="Both" RepeatColumns="3" RepeatDirection="Horizontal" Width="100%" Style="left: 71px; top: 154px; position: absolute; height: 593px; width: 1203px">        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />        <ItemTemplate>            <table style="width: 100%; text-align: center; font-weight: bold; font-size: medium">                <tr>                    <td>                        <asp:Image ID="imgProdView" runat="server" Width="250" Height="200" ImageUrl='<%#Eval("ProductImage")%>' />                                          </td>                    <td>&nbsp;</td>                    <td>&nbsp;</td>                </tr>                <tr>                    <td>                        <asp:Label ID="lblName" runat="server" Text="ProductName: "></asp:Label>                        <asp:Label ID="lblProdName" runat="server" Text='<%#Eval("ProductName")%>'></asp:Label>                    </td>                    <td>&nbsp;</td>                    <td>&nbsp;</td>                </tr>                <tr>                    <td>                        <asp:Label ID="lblPrice" runat="server" Text="Price: ₹"></asp:Label>                        <asp:Label ID="lblProdPrice" runat="server" Text='<%#Eval("ProductPrice")%>'></asp:Label>                    </td>                    <td>&nbsp;</td>                    <td>&nbsp;</td>                </tr>                <tr>                    <td>                        <asp:Label ID="Label1" runat="server" Text="Available Stock: "></asp:Label>                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("ProductStock")%>'></asp:Label>                    </td>                    <td>&nbsp;</td>                    <td>&nbsp;</td>                </tr>                <tr>                    <td>                        <asp:LinkButton ID="lbtnProdView" runat="server" CommandName="ViewProduct" CommandArgument='<%#Eval("ProductID")%>' OnCommand="lbtnProdView_Command">View</asp:LinkButton>                    </td>                    <td>&nbsp;</td>                    <td>&nbsp;</td>                </tr>                <tr>                    <td>                        <asp:LinkButton ID="lbtnAddToCart" runat="server" CommandName="AddToCart" CommandArgument='<%#Eval("ProductID")%>' OnCommand="lbtnAddToCart_Command">Add To Cart</asp:LinkButton>                    </td>                    <td>&nbsp;</td>                    <td>&nbsp;</td>                </tr>            </table>        </ItemTemplate>    </asp:DataList>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
