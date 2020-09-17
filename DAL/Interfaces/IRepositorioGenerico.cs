using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepositorioGenerico<TEntity> where TEntity: class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetId(int id);
        Task<TEntity> GetId(string id);
        Task Insert(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(int id);
        Task Delete(string id);
    }
}
