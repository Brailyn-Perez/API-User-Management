using Microsoft.AspNetCore.Mvc;
namespace Users.Repositories
{
    public interface IBaseRepository<TEntity , T > where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetEntityByIdAsync(int id);
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(int id);   
    }
}
