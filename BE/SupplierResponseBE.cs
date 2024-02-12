using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class SupplierResponseBE:BaseResponse
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierEmail { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierPassword { get; set; }
        public string SupplierPhone { get; set; }
    }
}
