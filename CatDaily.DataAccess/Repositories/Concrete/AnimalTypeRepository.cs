using CatDaily.Core.Helper;
using CatDaily.Core.Models;
using CatDaily.Core.SeedWork;
using CatDaily.DataAccess.Context;
using CatDaily.DataAccess.Entity;
using CatDaily.DataAccess.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace CatDaily.DataAccess.Repositories.Concrete
{
    public class AnimalTypeRepository : IAnimalTypeRepository
    {
        private readonly CatDailyDbContext _dbContext;

        public AnimalTypeRepository(CatDailyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<PageResult<AnimalType>> GetAnimalTypeList(PaginationRequestModel requestModel)
        {
            // yöntem 1
            var paginingFilter = _dbContext.AnimalTypes.Where(x=>x.IsActive==true).PaginationFilter(requestModel);
            return paginingFilter;
            //yöntem 2
            /* return await (from animaltypes in _dbContext.AnimalTypes
                      where animaltypes.IsActive == true
                      orderby animaltypes.Name
                      select animaltypes).ToListAsync();*/
        }

        public async Task AddAnimalType(AnimalType animalType)
        {
            _dbContext.AnimalTypes.Add(animalType);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<AnimalType> GetAnimalTypeByIdAsync(int id)
        {
            return await _dbContext.AnimalTypes.FirstOrDefaultAsync(p => p.Id == id);
         
        }

        public async Task<bool> DeleteAnimalTypeAsync(int id)
        {
            var animalType = await _dbContext.AnimalTypes.FindAsync(id);       
            _dbContext.AnimalTypes.Remove(animalType);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<AnimalType>> GetAnimalTypeList(int page, int perPage)
        {
            var totalRowCount = await _dbContext.AnimalTypes.CountAsync(x => x.IsActive == true);
            var skip = (page - 1) * perPage;
            var animalTypes = await _dbContext.AnimalTypes
                .Where(x => x.IsActive == true)
                .OrderBy(x => x.Name)
                .Skip(skip)
                .Take(perPage)
                .ToListAsync();

            return (animalTypes);
        }
    }
}
