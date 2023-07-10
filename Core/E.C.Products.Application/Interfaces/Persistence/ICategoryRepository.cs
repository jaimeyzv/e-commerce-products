using E.C.Products.Domain.Entities;

namespace E.C.Products.Application.Interfaces.Persistence
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetById(Guid id);
        Task<IEnumerable<Category>> GetAll();
    }
}
