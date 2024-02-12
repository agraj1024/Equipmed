using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using BE;
namespace EqipMedApplication.Admin
{
    public partial class OrderDetails : System.Web.UI.Page
    {
        OrderRequestBE objRequest = new OrderRequestBE();

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
            OrderBAL objOrderBAL = new OrderBAL();
            List<OrderResponseBE> objGetOrderDetails = objOrderBAL.GetOrderDetails(objRequest);
            grdvOrderDetails.DataSource = objGetOrderDetails;
            grdvOrderDetails.DataBind();

        }
    }
}