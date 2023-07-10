using E.C.Products.Application.Interfaces.Persistence;
using E.C.Products.Persistence.Repositories;

namespace E.C.Products.Persistence.Shared
{
    public class UnitOfWork : IUnitOfWork
    {
        private ICategoryRepository _categories;

        private readonly ECProductsDbContext _dbContext;

        public UnitOfWork(ECProductsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ICategoryRepository Categories => _categories = _categories ?? new CategoryRepository(this._dbContext);
        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
