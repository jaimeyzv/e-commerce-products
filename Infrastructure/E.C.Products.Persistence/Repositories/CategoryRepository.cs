﻿using E.C.Products.Application.Interfaces.Persistence;
using E.C.Products.Domain.Entities;
using E.C.Products.Persistence.Shared;
using Microsoft.EntityFrameworkCore;

namespace E.C.Products.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private ECProductsDbContext _dbContext;

        public CategoryRepository(ECProductsDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Category> AddAsync(Category entity)
        {
            await this._dbContext.Categories.AddAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await this._dbContext.Categories.ToListAsync();
        }

        public Task<Category> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
