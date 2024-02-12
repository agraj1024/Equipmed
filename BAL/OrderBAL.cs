using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BAL
{
    public class OrderBAL
    {
        public OrderResponseBE PlaceOrder(OrderRequestBE objRequest)
        {
            OrderDAL objOrderDAL = new OrderDAL();
            OrderResponseBE objResponse = objOrderDAL.PlaceOrder(objRequest);
            return (objResponse);
        }
        public List<OrderResponseBE> GetOrderDetails(OrderRequestBE objRequest)
        {
            OrderDAL objOrderDAL = new OrderDAL();
            List<OrderResponseBE> objResponse = objOrderDAL.GetOrderDetails(objRequest);
            return (objResponse);
        }
        public List<OrderResponseBE> GetOrderBySupplierID(OrderRequestBE objRequest)
        {
            OrderDAL objOrderDAL = new OrderDAL();
            List<OrderResponseBE> objResponse = objOrderDAL.GetOrderBySupplierID(objRequest);
            return (objResponse);
        }
        public List<OrderResponseBE> GetOrderByCustomerID(OrderRequestBE objRequest)
        {
            OrderDAL objOrderDAL = new OrderDAL();
            List<OrderResponseBE> objResponse = objOrderDAL.GetOrderByCustomerID(objRequest);
            return (objResponse);
        }
        public List<OrderResponseBE> GetOrderByOrderID(OrderRequestBE objRequest)
        {
            OrderDAL objOrderDAL = new OrderDAL();
            List<OrderResponseBE> objResponse = objOrderDAL.GetOrderByOrderID(objRequest);
            return (objResponse);
        }
    }
}
