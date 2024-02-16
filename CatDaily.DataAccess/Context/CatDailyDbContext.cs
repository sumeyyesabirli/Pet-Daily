using CatDaily.Core.SeedWork;
using CatDaily.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace CatDaily.DataAccess.Context
{
	public class CatDailyDbContext : DbContext
	{
		public CatDailyDbContext(DbContextOptions options) : base(options)
		{
			AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
		}

		public DbSet<User> Users { get; set; }
		public DbSet<AnimalType> AnimalTypes { get; set; }
		public DbSet<Animal> Animals { get; set; }

		public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			OnBeforeSaving();
			return base.SaveChangesAsync(cancellationToken);
		}

		public override int SaveChanges()
		{
			OnBeforeSaving();
			return base.SaveChanges();
		}

		private void OnBeforeSaving()
		{
			var entries = ChangeTracker.Entries()
				.Where(e => e.Entity is BaseEntity && (
					e.State == EntityState.Added
					|| e.State == EntityState.Modified));

			foreach (var entry in entries)
			{
				if (entry.State == EntityState.Added)
				{
					((BaseEntity)entry.Entity).CreatedDate = DateTime.UtcNow;
				}
				else if(entry.State == EntityState.Modified)
				{
					((BaseEntity)entry.Entity).UpdatedDate = DateTime.UtcNow;
				}

			}
		}
	}
}
