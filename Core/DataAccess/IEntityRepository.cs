using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;

namespace Core.DataAccess
{
    // generic constraint
    // where T : class sadece referans tip olabilir.
    // IEntity: IEntity veya IEntity implement eden bir nesne olabilir
    // new: new lenebilen bir nesne olabilir. Interface newlenemez
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
