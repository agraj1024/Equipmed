<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="EqipMedApplication.Supplier.AddProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Stylesheet/style.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.6.0.js"></script>
    <script src="../Scripts/jquery.validate.js"></script>
    <script src="../Scripts/AddProductValidation.js"></script>
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
                     <asp:LinkButton ID="lbtnHome" runat="server" OnClick="lbtnHome_Click" >Home</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:LinkButton ID="lbtnCategory" runat="server" OnClick="lbtnCategory_Click">Add Category</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:LinkButton ID="lbtnViewProducts" runat="server" OnClick="lbtnViewProducts_Click">View Products</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:LinkButton ID="lbtnViewOrders" runat="server" OnClick="lbtnViewOrders_Click">View Orders</asp:LinkButton>
                </div>
                <div class="menu-item">
                   
                </div>
                <div class="menu-item">
                 
                </div>
            </div>
        </div>
    </div>
    <div class="main-container form-holder">
        <div class="main-content container">
            <div class="form-heder">
             ADD PRODUCT
            </div>

                <div class="form-group">
                    <asp:TextBox ID="txtProductName" runat="server" placeholder="Enter Product Name" class="form-control"  ></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtProductDescription" runat="server" TextMode="MultiLine" placeholder="Enter Product Description" class="form-control"  ></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:TextBox ID="txtProductPrice" runat="server" placeholder="Enter Product Price" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtProductStock" runat="server" placeholder="Enter Product Stock" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                <asp:FileUpload ID="fluProductImage" runat="server" placeholder="Provide Equipment Image" class="form-control"  />
                </div>
                <div class="form-group">
                <asp:DropDownList ID="ddlCategoryID" runat="server" placeholder="Provide Equipment Image" class="form-control" DataSourceID="Category" DataTextField="CATEGORYNAME" DataValueField="CATEGORYID"></asp:DropDownList>
                    <asp:SqlDataSource ID="Category" runat="server" ConnectionString="<%$ ConnectionStrings:EquipMedDBConnectionString %>" SelectCommand="SELECT [CATEGORYNAME], [CATEGORYID] FROM [CATEGORY]"></asp:SqlDataSource>
                </div>
                
                <div className="btn-holder mb-4">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" class="w-100 btn btn-primary" OnClick="btnAdd_Click"  />
                </div>  
            <asp:Label ID="lblDisplay" runat="server" Text=" "></asp:Label>
    
    </div>
    </form>
</body>
</html>
