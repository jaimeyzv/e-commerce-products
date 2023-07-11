using AutoMapper;
using E.C.Products.Application.Interfaces.Persistence;
using E.C.Products.Application.ViewModels.Response;
using E.C.Products.Domain.Entities;

namespace E.C.Products.Application.UseCase.Categories.Commands
{
    public class CreateCategory : ICreateCategory
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCategory(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        async Task<CategoryViewModel> ICreateCategory.ExecuteAsync(CreateCategoryModel model)
        {
            var entity = _mapper.Map<Category>(model);
            var result = await this._unitOfWork.Categories.AddAsync(entity);
            var viewModel = _mapper.Map<CategoryViewModel>(result);
            await this._unitOfWork.SaveChangesAsync();

            return viewModel;
        }
    }
}
