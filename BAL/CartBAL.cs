using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BAL
{
    public class CartBAL
    {
         public CartResponseBE InsertCart(CartRequestBE objRequest)
         {
             CartDAL objCartDAL = new CartDAL();
             CartResponseBE objResponse = objCartDAL.InsertCart(objRequest);
             return (objResponse);
         }
         public List<CartResponseBE> GetCartDetails(CartRequestBE objRequest)
         {
             CartDAL objCartDAL = new CartDAL();
             List <CartResponseBE> objResponse = objCartDAL.GetCartDetails(objRequest);
             return (objResponse);
         }
         public CartResponseBE DeleteFromCart(CartRequestBE objRequest)
         {
             CartDAL objCartDAL = new CartDAL();
             CartResponseBE objResponse = objCartDAL.DeleteFromCart(objRequest);
             return (objResponse);
         }
         public CartResponseBE UpdateAddCart(CartRequestBE objRequest)
         {
             CartDAL objCartDAL = new CartDAL();
             CartResponseBE objResponse = objCartDAL.UpdateAddCart(objRequest);
             return (objResponse);
         }

    }
}
