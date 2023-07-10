using AutoMapper;
using E.C.Products.Application.UseCase.Category.Queries;
using E.C.Products.Application.ViewModels;
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
        public async Task<IEnumerable<CategoryViewModel>> GetCategoriesAsync()
        {
            var models = await this._categoryExecuter.ExecuteAsync();
            var viewModels = models.Select(x => _mapper.Map<CategoryViewModel>(x)).ToList();
            return viewModels;
        }

        [GraphQLName("category")]
        [GraphQLDescription("Get Category API")]
        public async Task<CategoryViewModel> GetCategoryByNameAsync(string name)
        {
            var models = await this._categoryExecuter.ExecuteAsync();
            var categoryFound = models.FirstOrDefault(x => x.Equals(name));
            if (categoryFound != null) { 
                return _mapper.Map<CategoryViewModel>(categoryFound); 
            }

            return new CategoryViewModel();
        }
    }
}
