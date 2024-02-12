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
    public partial class SupplierDetails : System.Web.UI.Page

    {
        List<SupplierResponseBE> objGetSupplierDetails;
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
            SupplierBAL objSupplierBAL = new SupplierBAL();
            objGetSupplierDetails = objSupplierBAL.GetAllSuppliers();
            grdvSupplierDetails.DataSource = objGetSupplierDetails;
            grdvSupplierDetails.DataBind();

        }
    }
}