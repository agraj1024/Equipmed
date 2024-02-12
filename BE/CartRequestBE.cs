using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CartRequestBE:BaseRequest
    {
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public int CartID { get; set; }
        public int TotalAmount { get; set; }
    }
}
