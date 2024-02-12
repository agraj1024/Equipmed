<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierRegistration.aspx.cs" Inherits="EqipMedApplication.Supplier.SupplierRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Stylesheet/style.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.6.0.js"></script>
    <script src="../Scripts/jquery.validate.js"></script>
    <script src="../Scripts/SupplierRegistrationValidation.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" name="form1"  runat="server">
     <div class="header-holder">
        <div class="header-content container">
            <div class="header-logo">
              <asp:Image ID="Image1" runat="server" Height="50px" Width="100px" ImageUrl="~/ProductImages/eq_logo_black_no_bg.png"  />
            </div>
            <div class="header-menu d-flex">
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
                CREATE YOUR ACCOUNT
            </div>

                <div class="form-group">
                    <asp:TextBox ID="txtSupplierName" name="txtSupplierName"  runat="server" placeholder="Enter Supplier Name" class="form-control"  ></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtSupplierEmail" name="txtSupplierEmail" runat="server" placeholder="Enter Supplier Email" class="form-control"  ></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:TextBox ID="txtSupplierAddress" name="txtSupplierAddress"  runat="server" TextMode="MultiLine" placeholder="Enter Supplier Address" class="form-control"  ></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:TextBox ID="txtSupplierPhone" name="txtSupplierPhone"  runat="server" placeholder="Enter Supplier Phone number" class="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtSupplierPassword" name="txtSupplierPassword" runat="server" placeholder="Enter password" class="form-control" TextMode="Password" ></asp:TextBox>
                </div>
                <div class="form-group">
                <asp:TextBox ID="txtReEnterPassword" name="txtReEnterPassword"  runat="server" placeholder="Re-Enter Password" class="form-control" TextMode="Password"  ></asp:TextBox>
                </div>
                
                <div className="btn-holder mb-4">
                    <asp:Button ID="btnRegister" runat="server" Text="Register" class="w-100 btn btn-primary" OnClick="btnRegister_Click" />
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="lbtnLogIn" runat="server" OnClick="lbtnLogIn_Click" >Already Have an account ? Log In !</asp:LinkButton>
                    <br />
                </div>  
            <asp:Label ID="lblDisplay" runat="server" Text=" "></asp:Label>
    
    </div>
    </form>
</body>
</html>
