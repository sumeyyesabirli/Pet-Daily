using CatDaily.Core.SeedWork;

namespace CatDaily.DataAccess.Entity
{
	public class Animal : BaseEntity
	{
        public int AnimalTypeId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string? Description { get; set; }
        public float Weight { get; set; }
        public int UserId { get; set; }
        public virtual AnimalType AnimalType { get; set; }
        public virtual User User { get; set; }
    }
}
