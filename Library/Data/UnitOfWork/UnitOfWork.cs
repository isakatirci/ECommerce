using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Core.Entities;
using Data.Repository.EntityFramework.Contexts;
using Entities.Models;
using System;

namespace Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ECommerceContext _dbContext;


        #region Lazy
        private readonly Lazy<IRepository<Category>> _category;
        #endregion

        #region RepoInitiate
        public IRepository<Category> Category => _category.Value;


        #endregion

        #region Ctor
        public UnitOfWork(ECommerceContext context)
        {
            _dbContext = context;

            if (context == null)
            {
                throw new ArgumentNullException("Db Context Can Not Be Null");
            }

            _category = CreateRepo<Category>();
        }

        #endregion

        #region Methods
        public void SaveChanges()
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            try
            {
                _dbContext.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        private Lazy<IRepository<TModel>> CreateRepo<TModel>() where TModel : class, IEntity, new()
        {
            return new Lazy<IRepository<TModel>>(() => new EfRepositoryBase<TModel>(_dbContext));
        }

        public void Dispose()
        {
            _dbContext.Dispose();
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
