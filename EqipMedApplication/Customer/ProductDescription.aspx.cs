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
    public partial class ProductDescription : System.Web.UI.Page
    {
        ProductRequestBE objRequest = new ProductRequestBE();

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

            try
            {
                objRequest.ProductID = Convert.ToInt32(Request.QueryString["ProductID"]);
                ProductBAL objProductBAL = new ProductBAL();
                ProductResponseBE objGetProduct = objProductBAL.GetProductByID(objRequest);
                imgProduct.ImageUrl = objGetProduct.ProductImage;
                lblProductDescription.Text = objGetProduct.ProductDescription.ToString();
                lblProductName.Text = objGetProduct.ProductDescription.ToString();
                lblProductPrice.Text = objGetProduct.ProductPrice.ToString();
                lblProductStock.Text = objGetProduct.ProductStock.ToString();
                lblSupplierName.Text = objGetProduct.SupplierName.ToString();
             
            }
            catch (Exception e1)
            {
                
                ClientScript.RegisterStartupScript(this.GetType(),"myalert", "alert('" +e1.Message+ "');", true);
                
            }
           

        }

       protected void btnProductCart_Click(object sender, EventArgs e)
       {
           CartRequestBE objRequest = new CartRequestBE();
           CartBAL objCartBAL = new CartBAL();
           objRequest.CustomerID = (int)Session["CustomerID"];
           objRequest.ProductID = Convert.ToInt32(Request.QueryString["ProductID"]);
           objRequest.Quantity = Convert.ToInt32(txtQuantity.Text); ;
           CartResponseBE objResponse = objCartBAL.InsertCart(objRequest);
           if (objResponse.Status > 0)
           {
               ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Product has been added to cart');", true);
           }
           else
           {
               ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Error');", true);
           }
       }

       protected void ibtnAdd_Click(object sender, ImageClickEventArgs e)
       {
           int quantity = Convert.ToInt32(txtQuantity.Text);
           quantity = quantity + 1;
           txtQuantity.Text = quantity.ToString();
       }

       protected void ibtnSubtract_Click(object sender, ImageClickEventArgs e)
       {
           int quantity = Convert.ToInt32(txtQuantity.Text);
           if (quantity > 1)
           {
               quantity = quantity - 1;
               txtQuantity.Text = quantity.ToString();
           }
          
       }


       protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
       {
           Response.Redirect("CustomerCart.aspx");
       }

       protected void ibtnHome_Click(object sender, ImageClickEventArgs e)
       {
           Response.Redirect("CustomerHomePage.aspx");
       }

       protected void btnOrderHistory_Click(object sender, EventArgs e)
       {
           Response.Redirect("CustomerOrderHistory.aspx");
       }

       
    }
}