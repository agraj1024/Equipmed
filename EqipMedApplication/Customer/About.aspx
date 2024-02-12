<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="EqipMedApplication.Customer.About" %>

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
                   
                </div>
            </div>
        </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="#000040" Text="About EquipMed:"></asp:Label>
          <br />
          <br />
         <asp:Label ID="lblViewOrderHistory" runat="server" Text="EquipMed is an innovative e-commerce website that allows customers to discover and purchase all kinds of medical equipment as per their needs and
requirements. It follows the standard method for categorizing medical equipment into Durable Medical Equipment, Diagonostic Medical Equipment and 
so forth. It aims to revolutionize the way medical suppliers promote and distribute their equipment by allowing to cater to a wider and 
more diverse audience. It incorporates the latest developments in web design and e-commerce, thus allowing for a more wholesome user experience. Here at EquipMed we follow  the motto &quot;EQUIP, To Stay HIP!&quot;.  We beleive that one can never be too equipped, because everyday brings forth it's own set of challenges, but we here at EqipMed will definitely be READY to face them . Every Customer is and will always be an integral part of the EquipMed community." Font-Italic="True" Font-Bold="False" Font-Overline="False" Font-Size="XX-Large" ForeColor="Navy" Height="96px"></asp:Label> 

    </form>
</body>
</html>
