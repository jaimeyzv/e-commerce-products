namespace E.C.Products.Application.Interfaces.Persistence
{
    public interface IUnitOfWork
    {
        ICategoryRepository Categories { get; }
        Task<int> SaveChangesAsync();
    }
}
