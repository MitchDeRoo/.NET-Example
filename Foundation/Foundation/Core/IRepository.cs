namespace Foundation.Core;

public interface IRepository<T>
{
    Task<IEnumerable<T>> GetAll();
    Task<T> Get(Guid id);
    Task<T> Add(T entity);
    Task<T> Update(T entity);
    Task<T> Delete(Guid id);
}