using AutoMapper;
using CatDaily.Business.Abstract;
using CatDaily.Business.Concrete;
using CatDaily.Business.Pofile;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CatDaily.Business
{
	public static class ServiceRegistration
	{
		public static void BusinessAccessRegister(this IServiceCollection services)
		{
            var assembly = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assembly);
            services.AddScoped<IAnimalTypeService, AnimalTypeService>();
        }
	}
}