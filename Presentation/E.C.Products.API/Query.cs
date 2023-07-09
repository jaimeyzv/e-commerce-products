using E.C.Products.Application.ViewModels;
using E.C.Products.Persistence.Shared;

namespace E.C.Products.API
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<CategoryViewModel> GetSuperheroes([Service] ECProductsDbContext context) =>
            (IQueryable<CategoryViewModel>) context.Categories;

    }
}
