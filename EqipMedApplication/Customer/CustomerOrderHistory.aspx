<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerOrderHistory.aspx.cs" Inherits="EqipMedApplication.Customer.CustomerOrderHistory" %>

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
                <asp:Image ID="imgLogo" runat="server" ImageUrl="~/ProductImages/logo.jpg" />
            </div>
            </div>
            <div class="header-menu d-flex">
                <div class="menu-item">
                    <asp:ImageButton ID="ibtnHome" runat="server" Height="25px" style="margin-right:20px" ImageUrl="~/Button Images/pngfind.com-home-icon-png-transparent-6800118.png" OnClick="ibtnHome_Click" />
                </div>
                <div class="menu-item">
                    <asp:ImageButton ID="ibtnCart" runat="server" Height="25px" ImageUrl="~/Button Images/white-shopping-cart-icon-png-19.jpg" OnClick="btnCart_Click" />
                </div>
                <div class="menu-item">
                  
                </div>
            </div>
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </div>
         <asp:Label ID="lblViewOrderHistory" runat="server" Text="ORDER HISTORY" Font-Italic="True" ForeColor="Navy"></asp:Label> 
            <asp:GridView ID="grdvOrderHistory" runat="server" AutoGenerateColumns="False"  >
             <Columns>
            <asp:BoundField DataField="ORDERID" HeaderText="ORDERID" />
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
