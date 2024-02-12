using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;
using BAL;

namespace EqipMedApplication.Supplier
{
    public partial class AddProduct : System.Web.UI.Page
    {
        ProductRequestBE objRequest = new ProductRequestBE();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["SupplierID"] == null)
                {
                    Response.Redirect("SupplierLogIn.aspx");
                }
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            objRequest.ProductName = txtProductName.Text;
            objRequest.ProductDescription = txtProductDescription.Text;
            objRequest.ProductPrice = Convert.ToDouble(txtProductPrice.Text);
            objRequest.ProductStock = Convert.ToInt32(txtProductStock.Text);
            objRequest.CategoryID = Convert.ToInt32(ddlCategoryID.SelectedValue);
            objRequest.SupplierID = (int)Session["SupplierID"];
            if (fluProductImage.HasFile)
            {
                objRequest.ProductImage ="/ProductImages/"+fluProductImage.FileName;
                fluProductImage.SaveAs(Server.MapPath("//ProductImages//" + fluProductImage.FileName)); 

            }
            ProductBAL objSupplierBAL = new ProductBAL();
            ProductResponseBE objResponse = objSupplierBAL.InsertProduct(objRequest);
            if (objResponse.Status > 0)
            {
                lblDisplay.Text = " Product Added Successfully";
            }
            else
            {
                lblDisplay.Text = "Product Addition Unsuccessful";
            }
        }


        protected void lbtnCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCategory.aspx");

        }

        protected void lbtnViewProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewSupplierProduct.aspx");

        }

        protected void lbtnViewOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewSupplierOrder.aspx");
        }

        protected void lbtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("SupplierHomePage.aspx");
        }
    }
}