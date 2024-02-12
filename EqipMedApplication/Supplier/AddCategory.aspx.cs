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
    public partial class AddCategory : System.Web.UI.Page
    {
        CategoryRequestBE objRequest = new CategoryRequestBE();

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
            objRequest.CategoryName = txtCategoryName.Text;
            objRequest.CategoryDescription = txtCategoryDescription.Text;
            CategoryBAL objCategoryBAL = new CategoryBAL();
            CategoryResponseBE objResponse = objCategoryBAL.InsertCategory(objRequest);
            if (objResponse.Status > 0)
            {
                lblDisplay.Text = "Category Added Successfully ";
            }
            else
            {
                lblDisplay.Text = "Addition of Category was Unsuccessful";
            }
        }


        protected void lbtnAddProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddProduct.aspx");
        }

        protected void lbtnProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewSupplierProduct.aspx");
        }

        protected void lbtnOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewSupplierOrder.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SupplierHomePage.aspx");
        }
    }
}