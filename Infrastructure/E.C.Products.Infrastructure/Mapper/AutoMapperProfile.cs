using AutoMapper;
using E.C.Products.Application.UseCase.Categories.Commands;
using E.C.Products.Application.UseCase.Categories.Queries;
using E.C.Products.Application.ViewModels.Request;
using E.C.Products.Application.ViewModels.Response;
using E.C.Products.Domain.Entities;

namespace E.C.Products.Infrastructure.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, GetAllCategoriesModel>().ReverseMap();
            CreateMap<GetAllCategoriesModel, CategoryViewModel>().ReverseMap();
            CreateMap<Category, CreateCategoryModel>().ReverseMap();
            CreateMap<CreateCategoryModel, CreateCategoryViewModel>().ReverseMap();
            CreateMap<Category, CategoryViewModel>().ReverseMap();
        }
    }
}
