using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface ICategoryBusiness
    {
        ICollection<Category> GetCategoryList();
        void AddCategory(Category category);
    }
}
