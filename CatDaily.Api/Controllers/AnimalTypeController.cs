using CatDaily.Business.Abstract;
using CatDaily.Business.Models.RequestModel;
using CatDaily.Core.Extensions;
using CatDaily.Core.SeedWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace CatDaily.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AnimalTypeController : BaseController
	{
        private readonly IAnimalTypeService _animalTypeService;

		public AnimalTypeController(IAnimalTypeService animalTypeService)
		{
			_animalTypeService = animalTypeService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAnimalTypes([FromQuery] GetAnimalTypeListRequestModel request)
		{
			var result = await _animalTypeService.GetAnimalTypeListAsync(request);
			//var result2 = await _animalAnanSservice.GetAnan();
			return HandleResponse(result);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetAnimalTypeById([FromRoute] int id)
		{
			var result = await _animalTypeService.GetAnimalTypeByIAsync(new GetAnimalTypeByIdRequestModel
			{
				Id = id
			});
			return HandleResponse(result);
		}

		[HttpPost]
		public async Task<IActionResult> AddAnimalType([FromBody] AddAnimalTypeRequestModel request)
		{
			var result = await _animalTypeService.AddAnimalTypeAsync(request);
			return HandleResponse(result);
		}

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimalType([FromRoute] int id)
        {
            var result = await _animalTypeService.DeleteAnimalTypeAsync(new DeleteAnimalTypeRequestModel
            {
                Id = id
            });
            return HandleResponse(result);
        }


    }
}
