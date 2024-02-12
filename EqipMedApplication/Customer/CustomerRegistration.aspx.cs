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
    public partial class CustomerRegistration : System.Web.UI.Page
    {
        CustomerRequestBE objRequest = new CustomerRequestBE();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            objRequest.CustomerName = txtCustomerName.Text;
            objRequest.CustomerEmail = txtCustomerEmail.Text;
            objRequest.CustomerPassword = txtCustomerPassword.Text;
            objRequest.CustomerAddress = txtCustomerAddress.Text;
            objRequest.CustomerPhone = txtCustomerPhone.Text;
            objRequest.CustomerDOB = txtDOB.Text;
           CustomerBAL objCustomerBAL = new CustomerBAL();
           CustomerResponseBE objResponse= objCustomerBAL.InsertCustomer(objRequest);
           if (objResponse.Status == 1)
           {
               lblDisplay.Text = "Registration Successful";
           }
           else if(objResponse.Status==-1)
           {
               lblDisplay.Text = "This Email is already registered ";
           }
           else
           {
               lblDisplay.Text = "Registration Unsuccessul ";
           }
            
        }

        protected void lbtnLogIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerLogIn.aspx");
        }
    }
}