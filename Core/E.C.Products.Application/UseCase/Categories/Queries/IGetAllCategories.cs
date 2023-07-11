namespace E.C.Products.Application.UseCase.Categories.Queries
{
    public interface IGetAllCategories
    {
        Task<IList<GetAllCategoriesModel>> ExecuteAsync();
    }
}
