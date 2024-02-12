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
    public partial class CustomerHomePage : System.Web.UI.Page
    {
        List<ProductResponseBE> objGetProduct;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if(!IsPostBack)
            {
                
                
                    if (Session["CustomerID"] != null)
                    {
                         LoadData();
                         lblCustomerName.Text = "Welcome " + Session["CustomerName"].ToString();
                    }
                    else
                    {
                        Response.Redirect("CustomerLogIn.aspx");
                    }
                
               
            }

        }
        
        public void LoadData()
        {
            ProductBAL objProductBAL = new ProductBAL();
            objGetProduct= objProductBAL.GetAllProducts();
            dtlGetProductView.DataSource = objGetProduct;
            dtlGetProductView.DataBind();
          
        }

        protected void lbtnProdView_Command(object sender, CommandEventArgs e)
        {
            string ProductID = e.CommandArgument.ToString();
            Response.Redirect("ProductDescription.aspx?ProductID="+ProductID);
        }

        protected void lbtnAddToCart_Command(object sender, CommandEventArgs e)
        {
            CartRequestBE objRequest = new CartRequestBE();
            CartBAL objCartBAL = new CartBAL();
            objRequest.CustomerID = (int)Session["CustomerID"];
            objRequest.ProductID = Convert.ToInt32(e.CommandArgument);
            objRequest.Quantity = 1;
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

            

        protected void lbtnDurable_Click(object sender, EventArgs e)
        {
            LoadData();
            var result = from res in objGetProduct
                         where res.CategoryID == 5
                         select res;
            dtlGetProductView.DataSource = result;
            dtlGetProductView.DataBind();

        }

        protected void lbtnDiagonostic_Click(object sender, EventArgs e)
        {
            LoadData();
            var result = from res in objGetProduct
                         where res.CategoryID == 6
                         select res;
            dtlGetProductView.DataSource = result;
            dtlGetProductView.DataBind();
        }

        protected void lbtnElectronic_Click(object sender, EventArgs e)
        {
             LoadData();
            var result = from res in objGetProduct
                         where res.CategoryID == 7
                         select res;
            dtlGetProductView.DataSource = result;
            dtlGetProductView.DataBind();
        }

        protected void lbtnAcute_Click(object sender, EventArgs e)
        {
            LoadData();
            var result = from res in objGetProduct
                         where res.CategoryID == 8
                         select res;
            dtlGetProductView.DataSource = result;
            dtlGetProductView.DataBind();
        }

        protected void lbtnProcedural_Click(object sender, EventArgs e)
        {
            LoadData();
            var result = from res in objGetProduct
                         where res.CategoryID == 9
                         select res;
            dtlGetProductView.DataSource = result;
            dtlGetProductView.DataBind();
        }

       
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string SearchTerm = txtSearch.Text;
            ProductBAL objProductBAL = new ProductBAL();
            objGetProduct = objProductBAL.GetSearchProduct(SearchTerm);
            dtlGetProductView.DataSource = objGetProduct;
            dtlGetProductView.DataBind();
        }

        protected void ibtnCart_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("CustomerCart.aspx");
        }

        protected void btnOrderHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerOrderHistory.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("CustomerLogIn.aspx");

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("About.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }


       

        


      
    }
}