using CatDaily.Business.Models.RequestModel;
using CatDaily.Business.Models.ResponseModel;
using CatDaily.Core.ResponseManager;

namespace CatDaily.Business.Abstract
{
	public interface IAnimalTypeService
	{
		Task<ResponseModel<List<GetAnimalTypeListResponseModel>>> GetAnimalTypeListAsync(GetAnimalTypeListRequestModel request);
		Task<ResponseModel<GetAnimalTypeByIdResponseModel>> GetAnimalTypeByIAsync(GetAnimalTypeByIdRequestModel request);
		Task<ResponseModel<bool>> DeleteAnimalTypeAsync(DeleteAnimalTypeRequestModel request);
		Task<ResponseModel> AddAnimalTypeAsync(AddAnimalTypeRequestModel requestModel);
	}
}
