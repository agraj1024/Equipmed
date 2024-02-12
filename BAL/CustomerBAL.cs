using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;


namespace BAL
{
    public class CustomerBAL
    {
         public CustomerResponseBE InsertCustomer(CustomerRequestBE objRequest)
        {
            CustomerDAL objCustomerDAL = new CustomerDAL();
            CustomerResponseBE objResponse=  objCustomerDAL.InsertCustomer(objRequest);
            return (objResponse);
        }

         public CustomerResponseBE GetLoginCrednetials(CustomerRequestBE objRequest)
         {
                CustomerDAL objCustomerDAL = new CustomerDAL();
                CustomerResponseBE objResponse = objCustomerDAL.GetLoginCredentials(objRequest);
                return (objResponse);
         }
         public List<CustomerResponseBE> GetCustomerDetails(CustomerRequestBE objRequest)
         {
             CustomerDAL objCustomerDAL = new CustomerDAL();
             List<CustomerResponseBE> objResponse = objCustomerDAL.GetCustomerDetails(objRequest);
             return (objResponse);
         }
         public List<CustomerResponseBE> GetSearchCustomer(string SearchTerm)
         {
             CustomerDAL objCustomerDAL = new CustomerDAL();
             List<CustomerResponseBE> objResponse = objCustomerDAL.GetSearchCustomer(SearchTerm);
             return (objResponse);
         }

    }

}
