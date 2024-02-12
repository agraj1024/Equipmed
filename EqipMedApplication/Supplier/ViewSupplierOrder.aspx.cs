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
    public partial class ViewSupplierOrder : System.Web.UI.Page
    {
        OrderRequestBE objRequest = new OrderRequestBE();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                if (Session["SupplierID"] != null)
                {
                    LoadData();
                    
                }
                else
                {
                    Response.Redirect("SupplierLogIn.aspx");
                }


            }


        }
        void LoadData()
        {
          
            objRequest.SupplierID = (int)Session["SupplierID"];
            OrderBAL objOrderBAL = new OrderBAL();
            List<OrderResponseBE> objGetOrderDetails = objOrderBAL.GetOrderBySupplierID(objRequest);
            grdvSupplierOrders.DataSource = objGetOrderDetails;
            grdvSupplierOrders.DataBind();

        }

        protected void lbtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("SupplierHomepage.aspx");
        }

        protected void lbtnOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewSupplierProduct.aspx");
        }

        protected void lbtnAddProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddProduct.aspx");
        }

        protected void lbtnAddCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCategory.aspx");
        }

    }
}