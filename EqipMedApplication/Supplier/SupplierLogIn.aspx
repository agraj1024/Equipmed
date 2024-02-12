<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierLogIn.aspx.cs" Inherits="EqipMedApplication.Supplier.SupplierLogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Stylesheet/style.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.6.0.js"></script>
    <script src="../Scripts/jquery.validate.js"></script>
    <script src="../Scripts/SupplierLogInValidation.js"></script>
    <title></title>
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
                 <asp:Button ID="btnCustomerLogin" runat="server" Text="Customer Login" class="btn btn-white-outline"  UseSubmitBehavior="False" ValidateRequestMode="Disabled" OnClick="btnCustomerLogin_Click"  />
                </div>
                <div class="menu-item">    
                 <asp:Button ID="btnAdminLogin" runat="server" Text="Admin Login" class="btn btn-white-outline" OnClick="btnAdminLogin_Click" UseSubmitBehavior="False" ValidateRequestMode="Disabled"  />     
                </div>  
            </div>
        </div>
    </div>
    <div class="main-container form-holder">
        <div class="main-content container">
            <div class="form-heder">
                SUPPLIER LOGIN
            </div>
                <div class="form-group" controlId="email">
                    <asp:TextBox ID="txtSupplierEmail" runat="server" class="form-control" placeholder="Enter Email"  ></asp:TextBox>
                </div>

                <div class="form-group" controlId="password">
                   <asp:TextBox ID="txtSupplierPassword" runat="server" class="form-control" placeholder="Enter Password" TextMode="Password"  ></asp:TextBox>
                </div>
                <div className="btn-holder mb-4">
                <asp:Button ID="btnLogIn" runat="server" Text="Log In" class="w-100 btn btn-primary" OnClick="btnLogIn_Click"  />
                 <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="lbtnSignUp" runat="server" OnClick="lbtnSignUp_Click">No Account ? Sign Up Fast !</asp:LinkButton>
                </div>       
                <div className="btn-holder mb-4">
                    <br/>
                    <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                </div>
        </div>
    </div>
    
    
    </form>
  
</body>
</html>
