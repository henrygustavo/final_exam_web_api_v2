namespace Exam.Domain.Repository.Common
{
    using System.Collections.Generic;

    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        
        IEnumerable<TEntity> GetAll();

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}
