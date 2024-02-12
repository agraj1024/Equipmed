using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EqipMedApplication.Supplier
{
    public partial class SupplierHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            if(!IsPostBack)
            {
                if (Session["SupplierID"] == null)
                {
                    Response.Redirect("SupplierLogIn.aspx");
                }
            }
        }

        protected void lbtnProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewSupplierProduct.aspx");
        }

        protected void btnAddCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCategory.aspx");
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddProduct.aspx");
        }

        protected void lbtnOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewSupplierOrder.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("SupplierLogIn.aspx");
        }


    }
}