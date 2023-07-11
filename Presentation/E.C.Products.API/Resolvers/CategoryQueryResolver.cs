using AutoMapper;
using E.C.Products.Application.UseCase.Categories.Queries;
using E.C.Products.Application.ViewModels.Response;
using GraphQLParser.AST;

namespace E.C.Products.API.Resolvers
{
    [ExtendObjectType("Query")]
    public class CategoryQueryResolver
    {
        private readonly IGetAllCategories _categoryExecuter;
        private readonly IMapper _mapper;

        public CategoryQueryResolver(IGetAllCategories categoryExecuter,
            IMapper mapper)
        {
            this._categoryExecuter = categoryExecuter;
            this._mapper = mapper;
        }

        [GraphQLName("categories")]
        [GraphQLDescription("Categories API")]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IQueryable<CategoryViewModel>> GetCategoriesAsync()
        {
            var models = await this._categoryExecuter.ExecuteAsync();
            var viewModels = models.Select(x => _mapper.Map<CategoryViewModel>(x)).AsQueryable();
            return viewModels;
        }
    }
}
