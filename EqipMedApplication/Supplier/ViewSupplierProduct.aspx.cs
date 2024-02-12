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
    public partial class ViewSupplierProduct : System.Web.UI.Page
    {
        List<ProductResponseBE> objGetProduct;

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

        public void LoadData()
        {
            ProductRequestBE objRequest = new ProductRequestBE();
            objRequest.SupplierID = (int)Session["SupplierID"];
            ProductBAL objProductBAL = new ProductBAL();
            objGetProduct = objProductBAL.GetProductBySupplierID(objRequest);
            grdvSupplierProducts.DataSource = objGetProduct;
            grdvSupplierProducts.DataBind();

        }

        protected void lbtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("SupplierHomePage.aspx");
        }


        protected void lbtnAddCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCategory.aspx");
        }

        protected void lbtnAddProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddProduct.aspx");
        }

        protected void ibtnEdit_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            int rowID = row.RowIndex;
            int key = (int)grdvSupplierProducts.DataKeys[rowID].Value;

            string ProductID = row.Cells[0].Text;
            string ProductName = row.Cells[1].Text;
            string ProductDescription = row.Cells[2].Text;
            string ProductPrice = row.Cells[3].Text;
            string ProductStock = row.Cells[4].Text;
            string CategoryID=row.Cells[5].Text;
            string ImagePath=row.Cells[6].Text;

            ModalPopupExtender1.Show();

            TextBox1.Text = ProductID;
            TextBox2.Text = ProductName;
            TextBox3.Text = ProductDescription;
            TextBox4.Text = ProductPrice; 
            TextBox5.Text = ProductStock;
            TextBox6.Text = CategoryID;
            TextBox7.Text = ImagePath;
        }

        protected void btnPopUpdate_Click(object sender, EventArgs e)
        {
            ProductRequestBE objRequest = new ProductRequestBE();
            objRequest.ProductID = Convert.ToInt32(TextBox1.Text);
            objRequest.ProductName = TextBox2.Text;
            objRequest.ProductDescription = TextBox3.Text;
            objRequest.ProductPrice = Convert.ToDouble(TextBox4.Text);
            objRequest.ProductStock = Convert.ToInt32(TextBox5.Text);
            objRequest.CategoryID = Convert.ToInt32(TextBox6.Text);
            objRequest.ProductImage = TextBox7.Text;
            ProductBAL objSupplierBAL = new ProductBAL();
            ProductResponseBE objResponse = objSupplierBAL.UpdateSupplierProduct(objRequest);
            if (objResponse.Status > 0)
            {
                lblDisplay.Text = " Product Updated Successfully";
            }
            else
            {
                lblDisplay.Text = "Product Update Unsuccessful";
            }

            LoadData();
        }

        protected void lbtnOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewSupplierOrder.aspx");
        }


       
    }
}