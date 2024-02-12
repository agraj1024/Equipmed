using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using BE;

namespace EqipMedApplication.Customer
{
    public partial class OrderSummary : System.Web.UI.Page
    {
        OrderRequestBE objRequest = new OrderRequestBE();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["CustomerID"] != null)
                {
                    string OrderID = Session["OrderID"].ToString();
                    lblOrderResult.Text += "You order has been successfully placed.Your Order Reference Number is " + OrderID;
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

            objRequest.OrderID = (int)Session["OrderID"];
            OrderBAL objOrderBAL = new OrderBAL();
            List<OrderResponseBE> objGetOrderDetails = objOrderBAL.GetOrderByOrderID(objRequest);
            grdvOrderSummary.DataSource = objGetOrderDetails;
            grdvOrderSummary.DataBind();

        }

        protected void ibtnCart_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CustomerCart.aspx");
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerHomepage.aspx");
        }

    }
}