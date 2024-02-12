using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EqipMedApplication.Admin
{
    public partial class AdminMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtnProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductDetails.aspx");
        }

        protected void lbtnCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerDetails.aspx");

        }

        protected void lbtnSupplier_Click(object sender, EventArgs e)
        {
            Response.Redirect("SupplierDetails.aspx");
        }

        protected void lbtnCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("CategoryDetails.aspx");
        }

        protected void lbtnOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderDetails.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("AdminLogIn.aspx");
        }

       

    }
}