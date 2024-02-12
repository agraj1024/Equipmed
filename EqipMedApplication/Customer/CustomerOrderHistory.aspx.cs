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
    public partial class CustomerOrderHistory : System.Web.UI.Page
    {
         OrderRequestBE objRequest = new OrderRequestBE();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                if (Session["CustomerID"] != null)
                {
                    LoadData();

                }
                else
                {
                    Response.Redirect("CustomerLogIn.aspx");
                }

            }

        }

        void LoadData()
        {

            objRequest.CustomerID = (int)Session["CustomerID"];
            OrderBAL objOrderBAL = new OrderBAL();
            List<OrderResponseBE> objGetOrderDetails = objOrderBAL.GetOrderByCustomerID(objRequest);
            grdvOrderHistory.DataSource = objGetOrderDetails;
            grdvOrderHistory.DataBind();

        }

        protected void btnCart_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CustomerCart.aspx");
        }

        protected void ibtnHome_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CustomerHomePage.aspx");
        }

    }
}