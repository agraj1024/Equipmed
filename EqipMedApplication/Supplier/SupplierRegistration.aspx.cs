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
    public partial class SupplierRegistration : System.Web.UI.Page
    {
        SupplierRequestBE objRequest = new SupplierRequestBE();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            objRequest.SupplierName = txtSupplierName.Text;
            objRequest.SupplierEmail = txtSupplierEmail.Text;
            objRequest.SupplierPassword = txtSupplierPassword.Text;
            objRequest.SupplierAddress = txtSupplierAddress.Text;
            objRequest.SupplierPhone = txtSupplierPhone.Text;
            SupplierBAL objSupplierBAL = new SupplierBAL();
            SupplierResponseBE objResponse = objSupplierBAL.InsertSupplier(objRequest);
            if (objResponse.Status == 1)
            {
                lblDisplay.Text = "Registration Successful";
            }
            else if (objResponse.Status == -1)
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
            Response.Redirect("SupplierLogIn.aspx");
        }

    }
}