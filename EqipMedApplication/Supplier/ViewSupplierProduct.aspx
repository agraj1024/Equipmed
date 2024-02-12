<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewSupplierProduct.aspx.cs" Inherits="EqipMedApplication.Supplier.ViewSupplierProduct" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Stylesheet/style.css" rel="stylesheet" />
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
         <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
      <div class="header-holder">
        <div class="header-content container">
            <div class="header-logo">
                <asp:Image ID="imgLogo" runat="server" ImageUrl="~/ProductImages/logo.jpg" />
            </div>
            <div class="header-menu d-flex">
                <div class="menu-item">
                    <asp:LinkButton ID="lbtnHome" runat="server" OnClick="lbtnHome_Click" >Home</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:LinkButton ID="lbtnOrders" runat="server" OnClick="lbtnOrders_Click">View Orders</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:LinkButton ID="lbtnAddProduct" runat="server" OnClick="lbtnAddProduct_Click"  >Add Products</asp:LinkButton>
                </div>
                <div class="menu-item">
                    <asp:LinkButton ID="lbtnAddCategory" runat="server" OnClick="lbtnAddCategory_Click" >Add Categories</asp:LinkButton>
                </div>
               
                <div class="menu-item">
                    
                </div>
                <div class="menu-item">
                  
                </div>
            </div>
        </div>
    </div>
         <asp:Label ID="lblViewProducts" runat="server" Text="SUPPLIER PRODUCTS" Font-Italic="True" ForeColor="Navy"></asp:Label> 
            <asp:GridView ID="grdvSupplierProducts" runat="server" AutoGenerateColumns="False" DataKeyNames="PRODUCTID"  >
             <Columns>
            <asp:BoundField DataField="PRODUCTID" HeaderText="PRODUCT ID" />
            <asp:BoundField DataField="PRODUCTNAME" HeaderText="PRODUCT NAME" />
            <asp:BoundField DataField="PRODUCTDESCRIPTION" HeaderText="DESCRIPTION" />
            <asp:BoundField DataField="PRODUCTPRICE" HeaderText="PRODUCT PRICE" />
            <asp:BoundField DataField="PRODUCTSTOCK" HeaderText="PRODUCT STOCK" />
            <asp:BoundField DataField="CATEGORYID" HeaderText="CATEGORY ID" />
            <asp:BoundField DataField="PRODUCTIMAGE" HeaderText="IMAGE PATH" />
                 <asp:TemplateField HeaderText="EDIT PRODUCT">
                     <ItemTemplate>
                         <asp:ImageButton ID="ibtnEdit" runat="server" Height="30px" ImageUrl="~/ProductImages/imgedit.png" OnClick="ibtnEdit_Click" Width="30px" />
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:ImageField DataImageUrlField="ProductImage" HeaderText="PRODUCT IMAGE">
                 </asp:ImageField>
            </Columns>
            </asp:GridView>
         <asp:Label ID="lblDisplay" runat="server" Text="Label"></asp:Label>
         <asp:Button ID="btnShow" runat="server" Text="Show" style=" display:none" />
         <asp:ModalPopupExtender ID="ModalPopupExtender1" runat="server" CancelControlID="btnCancel" TargetControlID="btnShow" PopupControlID="pnlEdit" ></asp:ModalPopupExtender>
         <asp:Panel ID="pnlEdit" runat="server" style="background-color:white;padding:10px;height:400px;width:350px;box-shadow: rgba(0, 0, 0, 0.35) 0px 5px 15px;" BorderColor="Blue" BorderWidth="10px" BorderStyle="Solid" >
                    <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Enter Product ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Enter Product Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label3" runat="server" Text="Enter Product Description"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="lblAge1" class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="Enter Product Price"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Enter Product Stock"></asp:Label>
                </td>
                <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
              <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="Enter Category ID"></asp:Label>
                </td>
                <td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
            </tr>
              <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label7" runat="server" Text="Enter Image Path"></asp:Label>
                </td>
                <td><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="padding-top:20px"  >
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnPopUpdate" runat="server" Text="Update" OnClick="btnPopUpdate_Click"/>
                    &nbsp;
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                   
                    
            </td>
            </tr>
        </table>
        <br />
         </asp:Panel>
    </form>
</body>
</html>
