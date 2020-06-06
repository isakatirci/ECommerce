using Data.Interface;
using Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository.EntityFramework
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private readonly IUnitOfWork _uow;

        public EfCategoryRepository(IUnitOfWork uow)
        {
            _uow = uow;
        }
    }
}
