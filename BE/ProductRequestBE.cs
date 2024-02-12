using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProductRequestBE:BaseRequest
    {   
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public string ProductImage { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public int ProductID { get; set; }
    }
}
