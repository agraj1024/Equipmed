<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="EqipMedApplication.Customer.Contact" %>

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
                    <asp:ImageButton ID="ibtnHome" runat="server" Height="25px" style="margin-right:20px" ImageUrl="~/Button Images/pngfind.com-home-icon-png-transparent-6800118.png" OnClick="ibtnHome_Click"   />
                </div>
                <div class="menu-item">
                   
                </div>
            </div>
        </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="#000040" Text="Contact Equipmed"></asp:Label>
          <br />
          <br />
         <asp:Label ID="lblViewOrderHistory" runat="server" Text="Contact Us By Phone On 7741845654" Font-Italic="True" Font-Bold="False" Font-Overline="False" Font-Size="XX-Large" ForeColor="Navy" Height="96px"></asp:Label> 
         <br />
         <asp:Label ID="Label2" runat="server" Text="Contact Us By Email On equipmed@gmail.com" Font-Italic="True" Font-Bold="False" Font-Overline="False" Font-Size="XX-Large" ForeColor="Navy" Height="96px"></asp:Label> 
         <br />
         <asp:Label ID="Label3" runat="server" Text="Follow Us On Instagram and Twitter @equipmed" Font-Italic="True" Font-Bold="False" Font-Overline="False" Font-Size="XX-Large" ForeColor="Navy" Height="96px"></asp:Label> 
    </form>
</body>
</html>
