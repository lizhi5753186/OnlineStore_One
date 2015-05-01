using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OnlineStore.Domain.Model;

namespace OnlineStore.Repositories.EntityFramework
{
    public sealed class OnlineStoreDbContext : DbContext
    {
        #region Ctor
        public OnlineStoreDbContext()
            : base("OnlineStore")
        {
            this.Configuration.AutoDetectChangesEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
        }
        #endregion 

        #region Public Properties

        public DbSet<Product> Products 
        { 
            get { return this.Set<Product>(); }
        }

        public DbSet<Category> Categories
        {
            get { return this.Set<Category>(); }
        }

        // 后面会继续添加属性，针对每个聚合根都会定义一个DbSet的属性
        // ...
        #endregion
    }
}
