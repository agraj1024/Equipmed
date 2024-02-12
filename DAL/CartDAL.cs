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
   public class CartDAL
    {
        static string ConnectionString = "Data Source=BRENDANF\\SQLEXPRESS;Initial Catalog=EquipMedDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;

       public CartResponseBE InsertCart(CartRequestBE objRequest)
       {
           con.Open();
           cmd = new SqlCommand("USP_INS_CART", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@CUSTOMERID", objRequest.CustomerID);
           cmd.Parameters.AddWithValue("@PRODUCTID", objRequest.ProductID);
           cmd.Parameters.AddWithValue("@QUANTITY", objRequest.Quantity);
           int count = cmd.ExecuteNonQuery();
           con.Close();
           CartResponseBE objResponse = new CartResponseBE();
           objResponse.Status = count;
           return (objResponse);

       }
       public List<CartResponseBE> GetCartDetails(CartRequestBE objRequest)
       {
           con.Open();
           cmd = new SqlCommand("USP_GET_CART_DETAILS", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@CUSTOMERID", objRequest.CustomerID);
           //To Retreive Output Parameter from Stored Procedure
           SqlParameter objParameter = cmd.Parameters.Add("@ORDERAMOUNT", SqlDbType.Int);
           objParameter.Direction = ParameterDirection.Output;
           dr = cmd.ExecuteReader();
           List<CartResponseBE> objResponse = new List<CartResponseBE>();
           while (dr.Read())
           {
               CartResponseBE objGetCartDetails = new CartResponseBE();
               objGetCartDetails.ProductName= dr["PRODUCTNAME"].ToString();
               objGetCartDetails.ProductPrice = Convert.ToInt32(dr["PRODUCTPRICE"]);
               objGetCartDetails.ProductStock = Convert.ToInt32(dr["PRODUCTSTOCK"]);
               objGetCartDetails.Quantity = Convert.ToInt32(dr["QUANTITY"]);
               objGetCartDetails.CartID = Convert.ToInt32(dr["CARTID"]);
               objGetCartDetails.TotalAmount = Convert.ToInt32(dr["TOTALAMOUNT"]);
               objResponse.Add(objGetCartDetails);
           }
           dr.Close();
           //int OrderAmount=Convert.ToInt32(cmd.Parameters["@ORDERAMOUNT"].Value);
           con.Close();
           return (objResponse);

       }
       public CartResponseBE DeleteFromCart(CartRequestBE objRequest)
       {
           con.Open();
           cmd = new SqlCommand("USP_DELETE_FROM_CART", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@CARTID", objRequest.CartID);
           int count = cmd.ExecuteNonQuery();
           con.Close();
           CartResponseBE objResponse = new CartResponseBE();
           objResponse.Status = count;
           return (objResponse);

       }
       public CartResponseBE UpdateAddCart(CartRequestBE objRequest)
       {
           con.Open();
           cmd = new SqlCommand("USP_UPDATEADD_CART", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@CARTID", objRequest.CartID);
           cmd.Parameters.AddWithValue("@QUANTITY",objRequest.Quantity);
           int count = cmd.ExecuteNonQuery();
           con.Close();
           CartResponseBE objResponse = new CartResponseBE();
           objResponse.Status = count;
           return (objResponse);

       }

    }

}
