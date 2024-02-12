using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;
using BAL;
namespace EqipMedApplication
{
    public partial class CustomerCart : System.Web.UI.Page
    {
        CartRequestBE objRequest = new CartRequestBE();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
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
            CartBAL objCartBAL = new CartBAL();
            List<CartResponseBE> objGetCartDetails = objCartBAL.GetCartDetails(objRequest);
            grdvCustomerCart.DataSource = objGetCartDetails;
            grdvCustomerCart.DataBind();
            int TotalOrderAmount = 0;
            foreach(var res in objGetCartDetails)
            {
                TotalOrderAmount += res.TotalAmount;
            }

            lblTotalOrderAmount.Text = TotalOrderAmount.ToString();

         

        }

        protected void btnCheckOut_Click(object sender, EventArgs e)
        {
            OrderRequestBE objRequest = new OrderRequestBE();
            objRequest.CustomerID =(int)Session["CustomerID"];
            OrderBAL objOrderBAL = new OrderBAL();
            OrderResponseBE objResponse = objOrderBAL.PlaceOrder(objRequest);
            if(objResponse.OrderID>0)
            {
                Session["OrderID"] = objResponse.OrderID;
                Server.Transfer("OrderSummary.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Checout Unsuccessful');", true);
            }
        }

        protected void btnDeleteCart_Click(object sender, ImageClickEventArgs e)
        {

            ImageButton btn = (ImageButton)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            int rowID = row.RowIndex;
            int key = (int)grdvCustomerCart.DataKeys[rowID].Value;
            objRequest.CartID = key;
            CartBAL objCartBAL = new CartBAL();
            CartResponseBE objResponse = objCartBAL.DeleteFromCart(objRequest);

            LoadData();
        }

        protected void ibtnSubtract_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            int rowID = row.RowIndex;
            int key = (int)grdvCustomerCart.DataKeys[rowID].Value;
            int quantity = Convert.ToInt32(row.Cells[3].Text);
            quantity = quantity - 1;
            CartRequestBE objRequest = new CartRequestBE();
            objRequest.CartID = key;
            objRequest.Quantity = quantity;
            CartBAL objCartBAL = new CartBAL();
            if (quantity > 0)
            {
                CartResponseBE objResponse = objCartBAL.UpdateAddCart(objRequest);
                if (objResponse.Status > 0)
                {
                    LoadData();
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Update Unsuccessful');", true);
                }
            }
            else
            {
                CartResponseBE objResponse = objCartBAL.DeleteFromCart(objRequest);
                LoadData();
            }

            

        }

        protected void ibtnAdd_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            int rowID = row.RowIndex;
            int key = (int)grdvCustomerCart.DataKeys[rowID].Value;
            int quantity = Convert.ToInt32(row.Cells[3].Text);
            quantity = quantity + 1;
            CartRequestBE objRequest = new CartRequestBE();
            objRequest.CartID = key;
            objRequest.Quantity = quantity;
            CartBAL objCartBAL = new CartBAL();
            CartResponseBE objResponse = objCartBAL.UpdateAddCart(objRequest);
                 if (objResponse.Status > 0)
                 {
                     LoadData();
                 }
                 else
                 {
                     ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Update Unsuccessful');", true);
                 }

        }

        protected void btnOrderHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomeeOrderHistory.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CustomerHomepage.aspx");
        }

    }
}  