using CatDaily.DataAccess.Context;
using CatDaily.DataAccess.Repositories.Abstract;
using CatDaily.DataAccess.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace CatDaily.DataAccess
{
	public static class ServiceRegistration
	{
		public static void DataAccessRegister(this IServiceCollection services, IConfiguration configuration)
		{
			var connectionString = configuration.GetSection("ConnectionString").Value;
			services.AddDbContext<CatDailyDbContext>(x =>
			{
				x.UseNpgsql(connectionString);
				x.UseLazyLoadingProxies(false);
				x.EnableSensitiveDataLogging();
			});
			services.TryAddScoped<DbContext, CatDailyDbContext>();

			services.AddRepositories();
		}

		private static void AddRepositories(this IServiceCollection services)
		{
            services.AddScoped<IAnimalTypeRepository, AnimalTypeRepository>();
        }
    }
}