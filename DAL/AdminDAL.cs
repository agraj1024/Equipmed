using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class AdminDAL
    {
        static string ConnectionString = "Data Source=BRENDANF\\SQLEXPRESS;Initial Catalog=EquipMedDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;

        public AdminResponseBE GetAdminLoginCredentials(AdminRequestBE objRequest)
        {
            con.Open();
            cmd = new SqlCommand("USP_GET_ADMIN_LOGIN_CREDENTIALS", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ADMINNAME", objRequest.AdminName);
            cmd.Parameters.AddWithValue("@ADMINPASSWORD", objRequest.AdminPassword);
            dr = cmd.ExecuteReader();
            AdminResponseBE objResponse = new AdminResponseBE();
            if (dr.Read())
            {
                objResponse.AdminName = dr["ADMINNAME"].ToString();
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
