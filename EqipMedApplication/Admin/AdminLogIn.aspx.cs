using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;
using BAL;
namespace EqipMedApplication.Admin
{
    public partial class AdminLogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            AdminRequestBE objRequest = new AdminRequestBE();
            objRequest.AdminName= txtAdminName.Text;
            objRequest.AdminPassword = txtAdminPassword.Text;
            AdminBAL objAdminBAL = new AdminBAL();
            AdminResponseBE objGetAdmin = objAdminBAL.GetAdminLoginCrednetials(objRequest);
            if (objGetAdmin.Status == 1)
            {
                Session["AdminName"] = objGetAdmin.AdminName;
                Response.Redirect("CustomerDetails.aspx");

            }
            else
            {

                lblResult.Text = "Log In Unsuccessful";

            }

        }

        protected void btnSupplierLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Supplier/SupplierLogIn.aspx");
        }

        protected void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Customer/CustomerLogIn.aspx");
        }
    }
}