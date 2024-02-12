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
    public class CustomerDAL
    {
        static string ConnectionString = "Data Source=BRENDANF\\SQLEXPRESS;Initial Catalog=EquipMedDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;

        public CustomerResponseBE InsertCustomer(CustomerRequestBE objRequest)
        {
                con.Open();
                cmd = new SqlCommand("USP_INS_CUSTOMER", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CUSTOMERNAME", objRequest.CustomerName);
                cmd.Parameters.AddWithValue("@CUSTOMERADDRESS", objRequest.CustomerAddress);
                cmd.Parameters.AddWithValue("@CUSTOMEREMAIL", objRequest.CustomerEmail);
                cmd.Parameters.AddWithValue("@CUSTOMERCONTACT", objRequest.CustomerPhone);
                cmd.Parameters.AddWithValue("@CUSTOMERDOB", objRequest.CustomerDOB);
                cmd.Parameters.AddWithValue("@CUSTOMERPASSWORD", objRequest.CustomerPassword);
                SqlParameter objParameter = cmd.Parameters.Add("@STATUS", SqlDbType.Int);
                objParameter.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                con.Close();
                CustomerResponseBE objResponse = new CustomerResponseBE();
                objResponse.Status = Convert.ToInt32(cmd.Parameters["@STATUS"].Value);
           
                return (objResponse);
            
        }
         public CustomerResponseBE GetLoginCredentials(CustomerRequestBE objRequest)
        {
            con.Open();
            cmd = new SqlCommand("USP_GET_LOGIN_CREDENTIALS", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CUSTOMEREMAIL", objRequest.CustomerEmail);
            cmd.Parameters.AddWithValue("@CUSTOMERPASSWORD", objRequest.CustomerPassword);
             dr = cmd.ExecuteReader();
            CustomerResponseBE objResponse = new CustomerResponseBE();
            if (dr.Read())
            {
                objResponse.CustomerName = dr["CUSTOMERNAME"].ToString();
                objResponse.CustomerID = Convert.ToInt32(dr["CUSTOMERID"]);
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
         public List<CustomerResponseBE> GetCustomerDetails(CustomerRequestBE objRequest)
         {
             con.Open();
             cmd = new SqlCommand("USP_GET_CUSTOMER_DETAILS", con);
             cmd.CommandType = CommandType.StoredProcedure;
             dr = cmd.ExecuteReader();
             List<CustomerResponseBE> objResponse = new List<CustomerResponseBE>();
             while (dr.Read())
             {
                 CustomerResponseBE objGetCustomerDetails = new CustomerResponseBE();
                 objGetCustomerDetails.CustomerName = dr["CUSTOMERNAME"].ToString();
                 objGetCustomerDetails.CustomerID = Convert.ToInt32(dr["CUSTOMERID"]);
                 objGetCustomerDetails.CustomerEmail = dr["CUSTOMEREMAIL"].ToString();
                 objGetCustomerDetails.CustomerPhone = dr["CUSTOMERCONTACT"].ToString();
                 objGetCustomerDetails.CustomerAddress = dr["CUSTOMERADDRESS"].ToString();
                 objGetCustomerDetails.CustomerDOB =Convert.ToDateTime(dr["CUSTOMERDOB"]).ToString("yyyy-MM-dd");
                 objResponse.Add(objGetCustomerDetails);

             }

             dr.Close();
             con.Close();
             return (objResponse);

         }
         public List<CustomerResponseBE> GetSearchCustomer(string SearchTerm)
         {
             con.Open();
             cmd = new SqlCommand("USP_SEARCH_CUSTOMERS", con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@SEARCH_TERM", SearchTerm);
             dr = cmd.ExecuteReader();
             List<CustomerResponseBE> objResponse = new List<CustomerResponseBE>();
             while (dr.Read())
             {
                 CustomerResponseBE objGetCustomer = new CustomerResponseBE();
                 objGetCustomer.CustomerID = Convert.ToInt32(dr["CUSTOMERID"]);
                 objGetCustomer.CustomerName = dr["CUSTOMERNAME"].ToString();
                 objGetCustomer.CustomerAddress= dr["CUSTOMERADDRESS"].ToString();
                 objGetCustomer.CustomerPhone = dr["CUSTOMERCONTACT"].ToString();
                 objGetCustomer.CustomerEmail = dr["CUSTOMEREMAIL"].ToString();
                 objGetCustomer.CustomerDOB= dr["CUSTOMERDOB"].ToString();

                 objResponse.Add(objGetCustomer);
             }
             dr.Close();
             con.Close();
             return (objResponse);

         }
        
    }
}
