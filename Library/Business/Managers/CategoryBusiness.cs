using Business.Interfaces;
using Data.Interface;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Managers
{
    public class CategoryBusiness : ICategoryBusiness
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryBusiness(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void AddCategory(Category category)
        {
            _categoryRepository.AddCategory(category);
        }

        public ICollection<Category> GetCategoryList()
        {
            return _categoryRepository.GetCategoryList();
        }
    }
}
