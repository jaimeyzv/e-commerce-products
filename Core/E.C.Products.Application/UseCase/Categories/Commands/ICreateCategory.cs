using E.C.Products.Application.ViewModels.Response;

namespace E.C.Products.Application.UseCase.Categories.Commands
{
    public interface ICreateCategory
    {
        Task<CategoryViewModel> ExecuteAsync(CreateCategoryModel model);
    }
}
