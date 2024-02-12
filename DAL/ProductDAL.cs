using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BE;
using ELogging;
namespace DAL
{
    public class ProductDAL
    { 
        static string ConnectionString = "Data Source=BRENDANF\\SQLEXPRESS;Initial Catalog=EquipMedDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;

        public ProductResponseBE InsertProduct(ProductRequestBE objRequest)
        {
            con.Open();
            cmd = new SqlCommand("USP_INS_Product", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRODUCTNAME", objRequest.ProductName);
            cmd.Parameters.AddWithValue("@PRODUCTDESCRIPTION", objRequest.ProductDescription);
            cmd.Parameters.AddWithValue("@PRODUCTPRICE", objRequest.ProductPrice);
            cmd.Parameters.AddWithValue("@PRODUCTSTOCK", objRequest.ProductStock);
            cmd.Parameters.AddWithValue("@PRODUCTIMAGE", objRequest.ProductImage);
            cmd.Parameters.AddWithValue("@SUPPLIERID", objRequest.SupplierID);
            cmd.Parameters.AddWithValue("@CATEGORYID", objRequest.CategoryID);
            int count = cmd.ExecuteNonQuery();
            con.Close();
            ProductResponseBE objResponse = new ProductResponseBE();
            objResponse.Status = count;
            return (objResponse);

        }

        public  List <ProductResponseBE> GetAllProducts()
        {
            con.Open();
            cmd = new SqlCommand("USP_GET_ALLPRODUCTS", con);
            cmd.CommandType = CommandType.StoredProcedure;
            dr= cmd.ExecuteReader();
            List<ProductResponseBE> objResponse = new List<ProductResponseBE>();
            while (dr.Read())
            {
                ProductResponseBE objGetProduct = new ProductResponseBE();
                objGetProduct.ProductID = Convert.ToInt32(dr["PRODUCTID"]); 
                objGetProduct.ProductName = dr["PRODUCTNAME"].ToString();
                objGetProduct.ProductDescription = dr["PRODUCTDESCRIPTION"].ToString();
                objGetProduct.ProductPrice = Convert.ToDouble(dr["PRODUCTPRICE"]);
                objGetProduct.ProductStock = Convert.ToInt32(dr["PRODUCTSTOCK"]);
                objGetProduct.ProductImage = dr["PRODUCTIMAGE"].ToString();
                objGetProduct.CategoryID = Convert.ToInt32(dr["CATEGORYID"]); 
                objGetProduct.SupplierID = Convert.ToInt32(dr["SUPPLIERID"]); 

                objResponse.Add(objGetProduct);
            }
            dr.Close();
            con.Close();
            return (objResponse);

        }
        public ProductResponseBE GetProductByID(ProductRequestBE objRequest)
        {
            ProductResponseBE objResponse = new ProductResponseBE();

            try
            {
                con.Open();
                cmd = new SqlCommand("USP_GET_PRODUCTBYID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PRODUCTID", objRequest.ProductID);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objResponse.ProductName = dr["PRODUCTNAME"].ToString();
                    objResponse.ProductDescription = dr["PRODUCTDESCRIPTION"].ToString();
                    objResponse.ProductPrice = Convert.ToDouble(dr["PRODUCTPRICE"]);
                    objResponse.ProductStock = Convert.ToInt32(dr["PRODUCTSTOCK"]);
                    objResponse.ProductImage = dr["PRODUCTIMAGE"].ToString();
                    objResponse.CategoryID = Convert.ToInt32(dr["CATEGORYID"]);
                    objResponse.SupplierID = Convert.ToInt32(dr["SUPPLIERID"]);
                    objResponse.SupplierName = dr["SUPPLIERNAME"].ToString();

                }

                dr.Close();
                con.Close();
            }
            catch (Exception e)
            {
                LogManager.Log(e);
                throw;
            }

            return (objResponse);

        }
        public List<ProductResponseBE> GetSearchProduct(string SearchTerm)
        {
            con.Open();
            cmd = new SqlCommand("USP_SEARCH_PRODUCTS", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SEARCH_TERM", SearchTerm);
            dr = cmd.ExecuteReader();
            List<ProductResponseBE> objResponse = new List<ProductResponseBE>();
            while (dr.Read())
            {
                ProductResponseBE objGetProduct = new ProductResponseBE();
                objGetProduct.ProductID = Convert.ToInt32(dr["PRODUCTID"]);
                objGetProduct.ProductName = dr["PRODUCTNAME"].ToString();
                objGetProduct.ProductDescription = dr["PRODUCTDESCRIPTION"].ToString();
                objGetProduct.ProductPrice = Convert.ToDouble(dr["PRODUCTPRICE"]);
                objGetProduct.ProductStock = Convert.ToInt32(dr["PRODUCTSTOCK"]);
                objGetProduct.ProductImage = dr["PRODUCTIMAGE"].ToString();
                objGetProduct.CategoryID = Convert.ToInt32(dr["CATEGORYID"]);
                objGetProduct.SupplierID = Convert.ToInt32(dr["SUPPLIERID"]);

                objResponse.Add(objGetProduct);
            }
            dr.Close();
            con.Close();
            return (objResponse);

        }
        public List<ProductResponseBE> GetProductBySupplierID(ProductRequestBE objRequest)
        {
            List<ProductResponseBE> objResponse = new List<ProductResponseBE>();

            try
            {
                con.Open();
                cmd = new SqlCommand("USP_GET_PRODUCT_BYSUPPLIERID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SUPPLIERID", objRequest.SupplierID);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ProductResponseBE objGetProduct = new ProductResponseBE();
                    objGetProduct.ProductID = Convert.ToInt32(dr["PRODUCTID"]);
                    objGetProduct.ProductName = dr["PRODUCTNAME"].ToString();
                    objGetProduct.ProductDescription = dr["PRODUCTDESCRIPTION"].ToString();
                    objGetProduct.ProductPrice = Convert.ToDouble(dr["PRODUCTPRICE"]);
                    objGetProduct.ProductStock = Convert.ToInt32(dr["PRODUCTSTOCK"]);
                    objGetProduct.ProductImage = dr["PRODUCTIMAGE"].ToString();
                    objGetProduct.CategoryID = Convert.ToInt32(dr["CATEGORYID"]);
                    objGetProduct.SupplierID = Convert.ToInt32(dr["SUPPLIERID"]);
                    objResponse.Add(objGetProduct);

                }

                dr.Close();
                con.Close();
            }
            catch (Exception e)
            {
                LogManager.Log(e);
                throw;
            }

            return (objResponse);

        }

        public ProductResponseBE UpdateSupplierProduct(ProductRequestBE objRequest)
        {
            con.Open();
            cmd = new SqlCommand("USP_UPDATE_SUPPLIER_PRODUCT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRODUCTID", objRequest.ProductID);
            cmd.Parameters.AddWithValue("@PRODUCTNAME", objRequest.ProductName);
            cmd.Parameters.AddWithValue("@PRODUCTDESCRIPTION", objRequest.ProductDescription);
            cmd.Parameters.AddWithValue("@PRODUCTPRICE", objRequest.ProductPrice);
            cmd.Parameters.AddWithValue("@PRODUCTSTOCK", objRequest.ProductStock);
            cmd.Parameters.AddWithValue("@PRODUCTIMAGE", objRequest.ProductImage);
            cmd.Parameters.AddWithValue("@SUPPLIERID", objRequest.SupplierID);
            cmd.Parameters.AddWithValue("@CATEGORYID", objRequest.CategoryID);
            int count = cmd.ExecuteNonQuery();
            con.Close();
            ProductResponseBE objResponse = new ProductResponseBE();
            objResponse.Status = count;
            return (objResponse);

        }
     
    }

}
