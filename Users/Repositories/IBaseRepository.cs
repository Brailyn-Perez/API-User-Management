using Users.ResultPattern;

namespace Users.Repositories
{
    public interface IBaseRepository<TEntity , T > where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetEntityByIdAsync(int id);
        Task<OperationResult<T>> CreateAsync(TEntity entity);
        Task<OperationResult<T>> UpdateAsync(TEntity entity);
        Task<OperationResult<T>> DeleteAsync(int id);   
    }
}
