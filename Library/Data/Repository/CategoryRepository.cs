using Data.Interface;
using Data.UnitOfWork;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly IUnitOfWork _uow;

        public CategoryRepository(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void AddCategory(Category category)
        {
            _uow.Category.Insert(category);

            _uow.SaveChanges();
        }

        public ICollection<Category> GetCategoryList()
        {
            return _uow.Category.TableNoTracking.ToList();
        }
    }
}
