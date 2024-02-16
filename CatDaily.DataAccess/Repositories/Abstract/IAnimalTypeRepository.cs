using CatDaily.Core.Models;
using CatDaily.Core.SeedWork;
using CatDaily.DataAccess.Entity;

namespace CatDaily.DataAccess.Repositories.Abstract
{
    public interface IAnimalTypeRepository : IRepository
    {
        Task<PageResult<AnimalType>> GetAnimalTypeList(PaginationRequestModel requestModel);
        Task<List<AnimalType>> GetAnimalTypeList(int page, int perPage);
        Task<AnimalType> GetAnimalTypeByIdAsync(int id);
        Task AddAnimalType(AnimalType animalType);
        Task<bool> DeleteAnimalTypeAsync(int id);
    }
}
