﻿namespace E.C.Products.Application.UseCase.Categories.Queries
{
    public class GetAllCategoriesModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
