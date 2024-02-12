using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EqipMedApplication.Customer
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                if (Session["CustomerID"]== null)
                {
                    {
                    Response.Redirect("CustomerLogIn.aspx");
                    }

                }
               
                

            }
        }

        protected void ibtnHome_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CustomerHomePage.aspx");
        }
    }
}