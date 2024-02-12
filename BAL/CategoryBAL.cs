using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
namespace BAL
{
    public class CategoryBAL
    {
        public CategoryResponseBE InsertCategory(CategoryRequestBE objRequest)
        {
            CategoryDAL objCategoryDAL = new CategoryDAL();
            CategoryResponseBE objResponse = objCategoryDAL.InsertCategory(objRequest);
            return (objResponse);
        }
        public List<CategoryResponseBE> GetAllCategories()
        {
            CategoryDAL objCategoryDAL = new CategoryDAL();
            List<CategoryResponseBE> objResponse = objCategoryDAL.GetAllCategories();
            return (objResponse);
        }

    }
}
