using E.C.Products.Application.Interfaces.Persistence;
using E.C.Products.Domain.Entities;

namespace E.C.Products.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task AddAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
