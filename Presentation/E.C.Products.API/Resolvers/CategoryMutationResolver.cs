using AutoMapper;
using E.C.Products.Application.UseCase.Categories.Commands;
using E.C.Products.Application.ViewModels.Request;
using E.C.Products.Application.ViewModels.Response;

namespace E.C.Products.API.Resolvers
{
    [ExtendObjectType("Mutation")]
    public class CategoryMutationResolver
    {
        private readonly ICreateCategory _categoryExecuter;
        private readonly IMapper _mapper;

        public CategoryMutationResolver(ICreateCategory categoryExecuter,
            IMapper mapper)
        {
            this._categoryExecuter = categoryExecuter;
            this._mapper = mapper;
        }

        [GraphQLName("createCategory")]
        [GraphQLDescription("Create Category API")]
        //[UseProjection]
        //[UseFiltering]
        //[UseSorting]
        public async Task<CategoryViewModel> CreateCategory(CreateCategoryViewModel category)
        {
            var model = _mapper.Map<CreateCategoryModel>(category);
            return await this._categoryExecuter.ExecuteAsync(model);
        }
    }
}
