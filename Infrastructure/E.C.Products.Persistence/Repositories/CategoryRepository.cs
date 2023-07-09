using E.C.Products.Application.Interfaces.Persistence;
using E.C.Products.Domain.Entities;
using E.C.Products.Persistence.Shared;

namespace E.C.Products.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private ECProductsDbContext _dbContext;

        public CategoryRepository(ECProductsDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

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
