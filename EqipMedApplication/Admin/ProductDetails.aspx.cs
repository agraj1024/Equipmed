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
    public partial class ProductDetails : System.Web.UI.Page
    {
        List<ProductResponseBE> objGetProduct;
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
            public void LoadData()
        {
            ProductBAL objProductBAL = new ProductBAL();
            objGetProduct= objProductBAL.GetAllProducts();
            grdvProductDetails.DataSource = objGetProduct;
            grdvProductDetails.DataBind();
          
        }
        
    }
}