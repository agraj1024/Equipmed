using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;
using BAL;

namespace EqipMedApplication.Customer
{
    public partial class CustomerLogIn : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            CustomerRequestBE objRequest = new CustomerRequestBE();
            objRequest.CustomerEmail = txtCustomerEmail.Text;
            objRequest.CustomerPassword = txtCustomerPassword.Text;
            CustomerBAL objCustomerBAL = new CustomerBAL();
            CustomerResponseBE objGetCustomer = objCustomerBAL.GetLoginCrednetials(objRequest);
            if (objGetCustomer.Status == 1)
            {
                Session["CustomerID"] = objGetCustomer.CustomerID;
                Session["CustomerName"] = objGetCustomer.CustomerName;
                Response.Redirect("CustomerHomePage.aspx");

            }
            else
            {
               
                lblResult.Text = "Log In Unsuccessful";
             
             }

           
        }


        protected void lbtnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerRegistration.aspx");
        }

        protected void btnAdminLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/AdminLogIn.aspx");
        }

        protected void btnSupplierLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Supplier/SupplierLogIn.aspx");
        }

       
    }
}