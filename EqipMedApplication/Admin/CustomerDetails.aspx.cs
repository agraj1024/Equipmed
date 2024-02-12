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
    public partial class CustomerDetails : System.Web.UI.Page
    {
        CustomerRequestBE objRequest = new CustomerRequestBE();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {


                if (Session["AdminName"] != null)
                {
                    LoadData();
                }
                else
                {
                    Response.Redirect("AdminLogIn.aspx");
                }


            }
        }

        void LoadData()
        {
            CustomerBAL objCustomerBAL = new CustomerBAL();
            List<CustomerResponseBE> objGetCustomerDetails = objCustomerBAL.GetCustomerDetails(objRequest);
            grdvCustomerDetails.DataSource = objGetCustomerDetails;
            grdvCustomerDetails.DataBind();

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        { 
            string SearchTerm = txtSearch.Text;
            CustomerBAL objCustomerBAL = new CustomerBAL();
            List<CustomerResponseBE> objGetCustomerDetails = objCustomerBAL.GetSearchCustomer(SearchTerm);
            grdvCustomerDetails.DataSource = objGetCustomerDetails;
            grdvCustomerDetails.DataBind();
        }
    }
}