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
    public partial class CategoryDetails : System.Web.UI.Page

    {
        List<CategoryResponseBE> objGetCategory;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadData();
            }

        }

        public void LoadData()
        {
            CategoryBAL objCategoryBAL = new CategoryBAL();
            objGetCategory= objCategoryBAL.GetAllCategories();
            grdvCategoryDetails.DataSource = objGetCategory;
            grdvCategoryDetails.DataBind();
          
        }         
    }
}