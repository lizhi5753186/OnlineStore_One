
namespace OnlineStore.Repositories.EntityFramework
{
    // IEntityFrameworkRepositoryContext接口的实现
    public class EntityFrameworkRepositoryContext : IEntityFrameworkRepositoryContext
    {
        // 引用我们定义的OnlineStoreDbContext类对象
        public OnlineStoreDbContext DbContex
        {
            get { return new OnlineStoreDbContext(); }
        }
    }
}
