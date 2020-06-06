using Data.Interface;
using Data.UnitOfWork;
using System;
using System.Collections.Generic;
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
    }
}
