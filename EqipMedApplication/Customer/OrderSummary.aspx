<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderSummary.aspx.cs" Inherits="EqipMedApplication.Customer.OrderSummary" %>

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
                <asp:Image ID="Image1" runat="server" ImageUrl="~/ProductImages/logo.jpg" />
            </div>
           
            <div class="header-menu d-flex">
                <div class="menu-item">
                    
                </div>
                <div class="menu-item">
                    <asp:ImageButton ID="ibtnCart" runat="server" ImageUrl="~/Button Images/white-shopping-cart-icon-png-19.jpg" Height="25px" OnClick="ibtnCart_Click" />
                </div>
                <div class="menu-item">
                   
                </div>
                <div class="menu-item">
                    
                </div>
                <div class="menu-item">
                   <asp:Button ID="btnOrderHistory" runat="server" Text="Order History"  class="btn btn-white-outline"/>
                      
                </div>
            </div>
        </div>
    </div>
    <div class="main-container cart-holder">
        <div class="main-content container">
            <div class="page-header-text">Order Summary</div>
            <asp:GridView ID="grdvOrderSummary" runat="server" AutoGenerateColumns="False"  >
             <Columns>
            <asp:BoundField DataField="ORDERID" HeaderText="ORDERID" />
            <asp:BoundField DataField="PRODUCTNAME" HeaderText="PRODUCT NAME" />
            <asp:BoundField DataField="QUANTITY" HeaderText="QUANTITY ORDERED" />
            <asp:BoundField DataField="PRODUCTPRICE" HeaderText="PRODUCT PRICE" />
            <asp:BoundField DataField="TOTALAMOUNT" HeaderText="TOTAL AMOUNT" />
            <asp:BoundField DataField="ORDERDATE" HeaderText="ORDER DATE" />
            </Columns>
            </asp:GridView>
            <br />
            <br />
           <asp:Button ID="btnContinue" runat="server" Text="Continue Shopping" class="btn btn-primary" OnClick="btnContinue_Click" />
            <div class="cart-product-detials-holder d-flex mx--15">
                <div class="cart-product-holder w-70 px-15">
                    

                    
                </div>
                <div class="car-detials-holder w-30 px-15">
                    <div class="px-15 car-detials box-shadow">
                        <div class="sub-header-text p-10">
                            
                        </div>
                        <div class="d-flex align-items-center justify-content-between f-15 p-10">
                            <div class="primary-color"><span class="icon icon-rupee">
                                <svg version="1.1" id="Capa_1" xmlns="http://www.w3.org/2000/svg"
                                        xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" width="401.998px"
                                        height="401.998px" viewBox="0 0 401.998 401.998"
                                        style="enable-background:new 0 0 401.998 401.998;" xml:space="preserve">
                                    <g>
                                    <path
                                                d="M326.62,91.076c-1.711-1.713-3.901-2.568-6.563-2.568h-48.82c-3.238-15.793-9.329-29.502-18.274-41.112h66.52
                                                c2.669,0,4.853-0.856,6.57-2.565c1.704-1.712,2.56-3.903,2.56-6.567V9.136c0-2.666-0.855-4.853-2.56-6.567
                                                C324.334,0.859,322.15,0,319.481,0H81.941c-2.666,0-4.853,0.859-6.567,2.568c-1.709,1.714-2.568,3.901-2.568,6.567v37.972
                                                c0,2.474,0.904,4.615,2.712,6.423s3.949,2.712,6.423,2.712h41.399c40.159,0,65.665,10.751,76.513,32.261H81.941
                                                c-2.666,0-4.856,0.855-6.567,2.568c-1.709,1.715-2.568,3.901-2.568,6.567v29.124c0,2.664,0.855,4.854,2.568,6.563
                                                c1.714,1.715,3.905,2.568,6.567,2.568h121.915c-4.188,15.612-13.944,27.506-29.268,35.691
                                                c-15.325,8.186-35.544,12.279-60.67,12.279H81.941c-2.474,0-4.615,0.905-6.423,2.712c-1.809,1.809-2.712,3.951-2.712,6.423v36.263
                                                c0,2.478,0.855,4.571,2.568,6.282c36.543,38.828,83.939,93.165,142.182,163.025c1.715,2.286,4.093,3.426,7.139,3.426h55.672
                                                c4.001,0,6.763-1.708,8.281-5.141c1.903-3.426,1.53-6.662-1.143-9.708c-55.572-68.143-99.258-119.153-131.045-153.032
                                                c32.358-3.806,58.625-14.277,78.802-31.404c20.174-17.129,32.449-39.403,36.83-66.811h47.965c2.662,0,4.853-0.854,6.563-2.568
                                                c1.715-1.709,2.573-3.899,2.573-6.563V97.646C329.193,94.977,328.335,92.79,326.62,91.076z" />
                                    </g>
                                </svg>
                                </span>
                                <asp:Label ID="lblOrderResult" runat="server"></asp:Label>
                            </div>
                        </div>

                        <div class="d-flex align-items-center justify-content-between f-15 p-10">
                        </div>
                        <div class="btn-holder p-10">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
    
    
    
   
</body>
</html>
