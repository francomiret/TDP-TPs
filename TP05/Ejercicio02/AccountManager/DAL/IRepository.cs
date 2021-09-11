using System.Collections.Generic;

namespace Ejercicio02.AccountManager.DAL
{
    public interface IRepository<TEntity> where TEntity : class
    {

        void Add(TEntity pEntity);

        void Remove(TEntity pEntity);

        TEntity Get(int pId);

        IEnumerable<TEntity> GetAll();

    }
}
