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
    public class SupplierDAL
    {
        static string ConnectionString = "Data Source=BRENDANF\\SQLEXPRESS;Initial Catalog=EquipMedDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        public SupplierResponseBE InsertSupplier(SupplierRequestBE objRequest)
        {
            con.Open();
            cmd = new SqlCommand("USP_INS_SUPPLIER", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SUPPLIERNAME", objRequest.SupplierName);
            cmd.Parameters.AddWithValue("@SUPPLIERADDRESS", objRequest.SupplierAddress);
            cmd.Parameters.AddWithValue("@SUPPLIEREMAIL", objRequest.SupplierEmail);
            cmd.Parameters.AddWithValue("@SUPPLIERCONTACT", objRequest.SupplierPhone);
            cmd.Parameters.AddWithValue("@SUPPLIERPASSWORD", objRequest.SupplierPassword);
            SqlParameter objParameter = cmd.Parameters.Add("@STATUS", SqlDbType.Int);
            objParameter.Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            con.Close();
            SupplierResponseBE objResponse = new SupplierResponseBE();
            objResponse.Status = Convert.ToInt32(cmd.Parameters["@STATUS"].Value);
            return (objResponse);

        }
        public List<SupplierResponseBE> GetAllSuppliers()
        {
            con.Open();
            cmd = new SqlCommand("USP_GET_ALLSUPPLIERS", con);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            List<SupplierResponseBE> objResponse = new List<SupplierResponseBE>();
            while (dr.Read())
            {
                SupplierResponseBE objGetSupplier = new SupplierResponseBE();
                objGetSupplier.SupplierID = Convert.ToInt32(dr["SUPPLIERID"]);
                objGetSupplier.SupplierName = dr["SUPPLIERNAME"].ToString();
                objGetSupplier.SupplierAddress = dr["SUPPLIERADDRESS"].ToString();
                objGetSupplier.SupplierEmail =dr["SUPPLIEREMAIL"].ToString();
                objGetSupplier.SupplierPhone = dr["SUPPLIERCONTACT"].ToString();

                objResponse.Add(objGetSupplier);
            }
            dr.Close();
            con.Close();
            return (objResponse);

        }
        public SupplierResponseBE GetSupplierLoginCredentials(SupplierRequestBE objRequest)
        {
            con.Open();
            cmd = new SqlCommand("USP_GET_SUPPLIER_LOGIN_CREDENTIALS", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SUPPLIEREMAIL", objRequest.SupplierEmail);
            cmd.Parameters.AddWithValue("@SUPPLIERPASSWORD", objRequest.SupplierPassword);
            dr = cmd.ExecuteReader();
            SupplierResponseBE objResponse = new SupplierResponseBE();
            if (dr.Read())
            {
                objResponse.SupplierName = dr["SUPPLIERNAME"].ToString();
                objResponse.SupplierID = Convert.ToInt32(dr["SUPPLIERID"]);
                objResponse.Status = 1;
            }
            else
            {
                objResponse.Status = -1;
            }

            dr.Close();
            con.Close();
            return (objResponse);

        }

    }
}
