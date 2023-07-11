namespace E.C.Products.Application.UseCase.Categories.Commands
{
    public class CreateCategoryModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
