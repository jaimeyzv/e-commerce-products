using AutoMapper;
using E.C.Products.Application.Interfaces.Persistence;

namespace E.C.Products.Application.UseCase.Category.Queries
{
    public class GetAllCategories : IGetAllCategories
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllCategories(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IList<GetAllCategoriesModel>> ExecuteAsync()
        {
            var esignatureRecipients = await this._unitOfWork
                .Categories
                .GetAll();

            var models = esignatureRecipients.Select(x => _mapper.Map<GetAllCategoriesModel>(x)).ToList();

            return models;
        }
    }
}
