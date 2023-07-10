using AutoMapper;
using E.C.Products.Application.UseCase.Category.Queries;
using E.C.Products.Application.ViewModels;
using E.C.Products.Domain.Entities;

namespace E.C.Products.Infrastructure.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, GetAllCategoriesModel>().ReverseMap();
            CreateMap<GetAllCategoriesModel, CategoryViewModel>().ReverseMap();
        }
    }
}
