namespace E.C.Products.Application.Interfaces.Persistence
{
    public interface IRepository<T>
    {
        Task AddAsync(T entity);
    }
}
