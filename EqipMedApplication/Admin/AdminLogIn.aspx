<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogIn.aspx.cs" Inherits="EqipMedApplication.Admin.AdminLogIn" %>

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
            <div class="header-logo" >
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/ProductImages/logo.jpg" Height="30px" Width="165px" />
            </div>
            <div class="header-menu d-flex">
                <div class="menu-item">
                
                </div>
                <div class="menu-item">
                    <a href="About"></a>
                </div>
                <div class="menu-item">
                     <asp:Button ID="btnSupplierLogin" runat="server" Text="Supplier Login" class="btn btn-white-outline" OnClick="btnSupplierLogin_Click"   />
                </div>
                <div class="menu-item">
                     <asp:Button ID="btnCustomerLogin" runat="server" Text="Customer Login" class="btn btn-white-outline" OnClick="btnCustomerLogin_Click"   />
                </div>
                </div>
            </div>
        </div>
    </div>
    <div class="main-container form-holder">
        <div class="main-content container">
            <div class="form-heder">
                ADMIN LOGIN
            </div>

           
                <div class="form-group" controlId="email">
                    <asp:TextBox ID="txtAdminName" runat="server" class="form-control" placeholder="Enter Email"  ></asp:TextBox>
                </div>

                <div class="form-group" controlId="password">
                   <asp:TextBox ID="txtAdminPassword" runat="server" class="form-control" placeholder="Enter Password" TextMode="Password"  ></asp:TextBox>
                </div>
                <div className="btn-holder mb-4">
                <asp:Button ID="btnLogIn" runat="server" Text="Log In" class="w-100 btn btn-primary" OnClick="btnLogIn_Click"  />
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
