using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
    public class OrderDAL
    {
        static string ConnectionString = ConfigurationManager.ConnectionStrings["EquipMedDBConnectionString"].ToString();
        SqlConnection con = new SqlConnection(ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;

        public OrderResponseBE PlaceOrder(OrderRequestBE objRequest)
        {
            con.Open();
            cmd = new SqlCommand("USP_PLACE_ORDER", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CUSTOMERID", objRequest.CustomerID);
            //To Retreive Output Parameter from Stored Procedure
            SqlParameter objParameter = cmd.Parameters.Add("@ORDERID", SqlDbType.Int);
            objParameter.Direction = ParameterDirection.Output;
            int count = cmd.ExecuteNonQuery();
            con.Close();
            OrderResponseBE objResponse = new OrderResponseBE();
            objResponse.OrderID= Convert.ToInt32(cmd.Parameters["@ORDERID"].Value);
            return (objResponse);

        }

        public List<OrderResponseBE> GetOrderDetails(OrderRequestBE objRequest)
        {
            con.Open();
            cmd = new SqlCommand("USP_GET_ORDER_DETAILS", con);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            List<OrderResponseBE> objResponse = new List<OrderResponseBE>();
            while (dr.Read())
            {
                OrderResponseBE objGetOrderDetails = new OrderResponseBE();
                objGetOrderDetails.CustomerName = dr["CUSTOMERNAME"].ToString();
                objGetOrderDetails.OrderID = Convert.ToInt32(dr["ORDERID"]);
                objGetOrderDetails.ProductName = dr["PRODUCTNAME"].ToString();
                objGetOrderDetails.Quantity = Convert.ToInt32(dr["QUANTITY"]);
                objGetOrderDetails.ProductPrice = Convert.ToDouble(dr["PRODUCTPRICE"]);
                objGetOrderDetails.OrderDate = Convert.ToDateTime(dr["ORDERDATE"]).ToString("yyyy-MM-dd");
                objGetOrderDetails.TotalAmount = Convert.ToInt32(dr["TOTALAMOUNT"]);
                objResponse.Add(objGetOrderDetails);

            }
            return (objResponse);

        }
        public List<OrderResponseBE> GetOrderBySupplierID(OrderRequestBE objRequest)
        {
            con.Open();
            cmd = new SqlCommand("USP_GET_ORDER_BYSUPPLIERID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SUPPLIERID", objRequest.SupplierID);
            dr = cmd.ExecuteReader();
            List<OrderResponseBE> objResponse = new List<OrderResponseBE>();
            while (dr.Read())
            {
                OrderResponseBE objGetOrderDetails = new OrderResponseBE();
                objGetOrderDetails.CustomerName = dr["CUSTOMERNAME"].ToString();
                objGetOrderDetails.OrderID = Convert.ToInt32(dr["ORDERID"]);
                objGetOrderDetails.ProductName = dr["PRODUCTNAME"].ToString();
                objGetOrderDetails.Quantity = Convert.ToInt32(dr["QUANTITY"]);
                objGetOrderDetails.ProductPrice = Convert.ToDouble(dr["PRODUCTPRICE"]);
                objGetOrderDetails.OrderDate = Convert.ToDateTime(dr["ORDERDATE"]).ToString("yyyy-MM-dd");
                objGetOrderDetails.TotalAmount = Convert.ToInt32(dr["TOTALAMOUNT"]);
                objResponse.Add(objGetOrderDetails);

            }
            return (objResponse);

        }
        public List<OrderResponseBE> GetOrderByCustomerID(OrderRequestBE objRequest)
        {
            con.Open();
            cmd = new SqlCommand("USP_GET_ORDER_BYCUSTOMERID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CUSTOMERID", objRequest.CustomerID);
            dr = cmd.ExecuteReader();
            List<OrderResponseBE> objResponse = new List<OrderResponseBE>();
            while (dr.Read())
            {
                OrderResponseBE objGetOrderDetails = new OrderResponseBE();
                objGetOrderDetails.OrderID = Convert.ToInt32(dr["ORDERID"]);
                objGetOrderDetails.ProductName = dr["PRODUCTNAME"].ToString();
                objGetOrderDetails.Quantity = Convert.ToInt32(dr["QUANTITY"]);
                objGetOrderDetails.ProductPrice = Convert.ToDouble(dr["PRODUCTPRICE"]);
                objGetOrderDetails.OrderDate = Convert.ToDateTime(dr["ORDERDATE"]).ToString("yyyy-MM-dd");
                objGetOrderDetails.TotalAmount = Convert.ToInt32(dr["TOTALAMOUNT"]);
                objResponse.Add(objGetOrderDetails);

            }
            return (objResponse);

        }
        public List<OrderResponseBE> GetOrderByOrderID(OrderRequestBE objRequest)
        {
            con.Open();
            cmd = new SqlCommand("USP_GET_ORDER_BYORDERID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ORDERID", objRequest.OrderID);
            dr = cmd.ExecuteReader();
            List<OrderResponseBE> objResponse = new List<OrderResponseBE>();
            while (dr.Read())
            {
                OrderResponseBE objGetOrderDetails = new OrderResponseBE();
                objGetOrderDetails.OrderID = Convert.ToInt32(dr["ORDERID"]);
                objGetOrderDetails.ProductName = dr["PRODUCTNAME"].ToString();
                objGetOrderDetails.Quantity = Convert.ToInt32(dr["QUANTITY"]);
                objGetOrderDetails.ProductPrice = Convert.ToDouble(dr["PRODUCTPRICE"]);
                objGetOrderDetails.OrderDate = Convert.ToDateTime(dr["ORDERDATE"]).ToString("yyyy-MM-dd");
                objGetOrderDetails.TotalAmount = Convert.ToInt32(dr["TOTALAMOUNT"]);
                objResponse.Add(objGetOrderDetails);

            }
            return (objResponse);

        }

    }
}
