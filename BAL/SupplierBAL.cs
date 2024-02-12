using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BAL
{
   public class SupplierBAL
    {
        public SupplierResponseBE InsertSupplier(SupplierRequestBE objRequest)
        {
            SupplierDAL objSupplierDAL = new SupplierDAL();
            SupplierResponseBE objResponse = objSupplierDAL.InsertSupplier(objRequest);
            return (objResponse);
        }
        public List<SupplierResponseBE> GetAllSuppliers()
        {
            SupplierDAL objSupplierDAL = new SupplierDAL();
            List<SupplierResponseBE> objResponse = objSupplierDAL.GetAllSuppliers();
            return (objResponse);
        }
        public SupplierResponseBE GetSupplierLoginCredentials(SupplierRequestBE objRequest)
        {
            SupplierDAL objSupplierDAL = new SupplierDAL();
            SupplierResponseBE objResponse = objSupplierDAL.GetSupplierLoginCredentials(objRequest);
            return (objResponse);
        }

    }
}
