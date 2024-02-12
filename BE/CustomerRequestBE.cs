using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CustomerRequestBE:BaseRequest
    {
       public int CustomerID { get; set; }
       public string CustomerName{get;set;}
       public string CustomerEmail { get; set; }
       public string CustomerAddress { get; set; }
       public string CustomerPassword { get; set; }
       public string CustomerDOB { get; set; }
       public string CustomerPhone { get; set; }
       public int ProductID { get; set; }
       public int Quantity { get; set; }

    }
}
