using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BE;

namespace DAL
{

    public class CategoryDAL
    {
        static string ConnectionString = "Data Source=BRENDANF\\SQLEXPRESS;Initial Catalog=EquipMedDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;

        public CategoryResponseBE InsertCategory(CategoryRequestBE objRequest)
        {
            con.Open();
            cmd = new SqlCommand("USP_INS_CATEGORY", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CATEGORYNAME", objRequest.CategoryName);
            cmd.Parameters.AddWithValue("@CATEGORYDESCRIPTION", objRequest.CategoryDescription);
            int count = cmd.ExecuteNonQuery();
            con.Close();
            CategoryResponseBE objResponse = new CategoryResponseBE();
            objResponse.Status = count;
            return (objResponse);

        }
        public List<CategoryResponseBE> GetAllCategories()
        {
            con.Open();
            cmd = new SqlCommand("USP_GET_ALLCATEGORIES", con);
            List<CategoryResponseBE> objResponse = new List<CategoryResponseBE>();
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CategoryResponseBE objGetCategory = new CategoryResponseBE();
                objGetCategory.CategoryID = Convert.ToInt32(dr["CATEGORYID"]);
                objGetCategory.CategoryName = dr["CATEGORYNAME"].ToString();
                objGetCategory.CategoryDescription = dr["CATEGORYDESCRIPTION"].ToString();

                objResponse.Add(objGetCategory);
            }
            return (objResponse);
        }
    }
}
