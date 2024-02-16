using AutoMapper;
using CatDaily.Business.Abstract;
using CatDaily.Business.Models.RequestModel;
using CatDaily.Business.Models.ResponseModel;
using CatDaily.Core.ResponseManager;
using CatDaily.DataAccess.Entity;
using CatDaily.DataAccess.Repositories.Abstract;

namespace CatDaily.Business.Concrete
{
    public class AnimalTypeService : IAnimalTypeService
	{
		private readonly IAnimalTypeRepository _animalTypeRepository;
        private readonly IMapper _mapper;

        public AnimalTypeService(IAnimalTypeRepository animalTypeRepository, IMapper mapper)
        {
            _animalTypeRepository = animalTypeRepository;
            _mapper = mapper;
        }

        public async Task<ResponseModel<List<GetAnimalTypeListResponseModel>>> GetAnimalTypeListAsync(GetAnimalTypeListRequestModel request)
		{
			var data = await _animalTypeRepository.GetAnimalTypeList();
			// auto mapper...
			var mappedData = _mapper.Map<List<GetAnimalTypeListResponseModel>>(data);

            return ResponseManager.CreateSuccess(mappedData);
        }

        public async Task<ResponseModel> AddAnimalTypeAsync(AddAnimalTypeRequestModel requestModel)
        {
            var mappedData = _mapper.Map<AnimalType>(requestModel);
            await _animalTypeRepository.AddAnimalType(mappedData);
          
            return ResponseManager.CreateSuccess("Animal Type Adding Success");
        }     

        public async Task<ResponseModel<GetAnimalTypeByIdResponseModel>> GetAnimalTypeByIAsync(GetAnimalTypeByIdRequestModel request)
        {

            var data = await _animalTypeRepository.GetAnimalTypeByIdAsync(request.Id);
            var mappedData = _mapper.Map<GetAnimalTypeByIdResponseModel>(data);

            return ResponseManager.CreateSuccess(mappedData);
        }

        public async Task<ResponseModel<bool>> DeleteAnimalTypeAsync(DeleteAnimalTypeRequestModel request)
        {
            var data = await _animalTypeRepository.DeleteAnimalTypeAsync(request.Id);
            return ResponseManager.CreateSuccess(data);
        }
    }
}
