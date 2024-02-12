<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="EqipMedApplication.Supplier.AddCategory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Stylesheet/style.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.6.0.js"></script>
    <script src="../Scripts/jquery.validate.js"></script>
    <script src="../Scripts/AddCategoryValidation.js"></script>
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
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Button Images/pngfind.com-home-icon-png-transparent-6800118.png" Height="30px" OnClick="ImageButton1_Click" Width="30px" />
                </div>
                <div class="menu-item">
                    <asp:LinkButton ID="lbtnAddProducts" runat="server" OnClick="lbtnAddProducts_Click">Add Products</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:LinkButton ID="lbtnProducts" runat="server" OnClick="lbtnProducts_Click">View Products</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:LinkButton ID="lbtnOrders" runat="server" OnClick="lbtnOrders_Click">View Orders</asp:LinkButton>
                </div>
                <div class="menu-item">
                    
                </div>
                <div class="menu-item">
                    
                </div>
                <div class="menu-item cart">
               
                </div>
            </div>
        </div>
    </div>
    <div class="main-container form-holder">
        <div class="main-content container">
            <div class="form-heder">
                ADD CATEGORY
            </div>

                <div class="form-group">
                    <asp:TextBox ID="txtCategoryName" runat="server" placeholder="Enter Category Name" class="form-control"  ></asp:TextBox>
                </div>   
                <div class="form-group">
                    <asp:TextBox ID="txtCategoryDescription" runat="server" TextMode="MultiLine" placeholder="Enter Category Description" class="form-control"  ></asp:TextBox>
                </div>
                
                <div className="btn-holder mb-4">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" class="w-100 btn btn-primary" OnClick="btnAdd_Click" />
                </div>  
            <asp:Label ID="lblDisplay" runat="server" Text=" "></asp:Label>
    
    </div>
    </form>
</body>
</html>
