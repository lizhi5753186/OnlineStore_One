using System;
using System.Collections.Generic;
using System.Linq;
using OnlineStore.Domain.Model;
using OnlineStore.Domain.Repositories;

namespace OnlineStore.Repositories.EntityFramework
{
    // 类别仓储的实现
    public class CategoryRepository :ICategoryRepository
    {
        #region Private Fields

        private readonly IEntityFrameworkRepositoryContext _efContext;

        public CategoryRepository(IRepositoryContext context)
        {
            var efContext = context as IEntityFrameworkRepositoryContext;
            if (efContext != null)
                this._efContext = efContext;
        }

        #endregion
        #region Public Properties

        public IEntityFrameworkRepositoryContext EfContext
        {
            get { return this._efContext; }
        }

        #endregion 

        public void Add(Category aggregateRoot)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            var ctx = this.EfContext.DbContex as OnlineStoreDbContext;
            if (ctx == null)
                return null;
            var query = from c in ctx.Categories
                        select c;
            return query.ToList();
        }

        public Category GetByKey(Guid key)
        {
            return this.EfContext.DbContex.Categories.First(c => c.Id == key);
        }
    }
}