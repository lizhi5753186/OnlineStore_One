using OnlineStore.Domain.Specifications;
using OnlineStore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Repositories
{
    // 仓储接口
    public interface IRepository<TAggregateRoot> 
        where TAggregateRoot :class, IAggregateRoot
    {
        void Add(TAggregateRoot aggregateRoot);

        IEnumerable<TAggregateRoot> GetAll();

        // 根据聚合根的ID值，从仓储中读取聚合根
        TAggregateRoot GetByKey(Guid key);
    }
}
