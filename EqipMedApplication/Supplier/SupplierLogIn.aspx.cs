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
    public partial class SupplierLogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            SupplierRequestBE objRequest = new SupplierRequestBE();
            objRequest.SupplierEmail = txtSupplierEmail.Text;
            objRequest.SupplierPassword = txtSupplierPassword.Text;
            SupplierBAL objSupplierBAL = new SupplierBAL();
            SupplierResponseBE objGetSupplier = objSupplierBAL.GetSupplierLoginCredentials(objRequest);
            if (objGetSupplier.Status == 1)
            {
                Session["SupplierID"] = objGetSupplier.SupplierID;
                Session["SupplierName"] = objGetSupplier.SupplierName;
                Response.Redirect("SupplierHomePage.aspx");

            }
            else
            {

                lblResult.Text = "Log In Unsuccessful";

            }
        }

        protected void lbtnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SupplierRegistration.aspx");
        }

        protected void btnAdminLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/AdminLogIn.aspx");
        }

        protected void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Customer/CustomerLogIn.aspx");
        }


       

      

       
    }
}