using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BAL
{
    public class ProductBAL
    {
        ProductDAL objProductDAL = new ProductDAL();

        public ProductResponseBE InsertProduct(ProductRequestBE objRequest)
        {
            ProductResponseBE objResponse = objProductDAL.InsertProduct(objRequest);
            return (objResponse);
        }

        public List<ProductResponseBE> GetSearchProduct(string SearchTerm)
        {
            List<ProductResponseBE> objResponse = objProductDAL.GetSearchProduct(SearchTerm);
            return (objResponse);
        }
        public List<ProductResponseBE> GetAllProducts()
        {
            List<ProductResponseBE> objResponse = objProductDAL.GetAllProducts();
            return (objResponse);
        }


        public ProductResponseBE GetProductByID(ProductRequestBE objRequest)
        {
            ProductResponseBE objResponse;
            try
            {
                objResponse = objProductDAL.GetProductByID(objRequest);
            }
            catch (Exception)
            {
                
                throw;
            }
            return (objResponse);
        }
        public List<ProductResponseBE> GetProductBySupplierID(ProductRequestBE objRequest)
        {
            List<ProductResponseBE> objResponse;
            try
            {
                objResponse = objProductDAL.GetProductBySupplierID(objRequest);
            }
            catch (Exception)
            {

                throw;
            }
            return (objResponse);
        }

        public ProductResponseBE UpdateSupplierProduct(ProductRequestBE objRequest)
        {
            ProductResponseBE objResponse = objProductDAL.UpdateSupplierProduct(objRequest);
            return (objResponse);
        }
     
    }
}
