using Core.DataAccess;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interface
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategoryList();
    }
}
