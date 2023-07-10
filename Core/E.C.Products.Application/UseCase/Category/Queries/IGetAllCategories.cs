namespace E.C.Products.Application.UseCase.Category.Queries
{
    public interface IGetAllCategories
    {
        Task<IList<GetAllCategoriesModel>> ExecuteAsync();
    }
}
