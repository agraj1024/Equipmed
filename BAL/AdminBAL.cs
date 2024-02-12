using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BAL
{
    public class AdminBAL
    {
        public AdminResponseBE GetAdminLoginCrednetials(AdminRequestBE objRequest)
        {
            AdminDAL objAdminDAL = new AdminDAL();
            AdminResponseBE objResponse = objAdminDAL.GetAdminLoginCredentials(objRequest);
            return (objResponse);
        }
    }
}
