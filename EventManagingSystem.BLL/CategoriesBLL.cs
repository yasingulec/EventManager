using EventManagingSystem.DAL;
using EventManagingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagingSystem.BLL
{
    public class CategoriesBLL
    {
        DataContextModel dc = new DataContextModel();
        public List<Category> GetCategories()
        {
            return dc.Category.ToList();
        }
    }
}
