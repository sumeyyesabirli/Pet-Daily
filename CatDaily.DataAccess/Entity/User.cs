using CatDaily.Core.SeedWork;

namespace CatDaily.DataAccess.Entity
{
	public class User : BaseEntity
	{
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Description { get; set; }
        public bool Gender { get; set; } // 0 ise kadın 1 ise erkek!
        public virtual ICollection<Animal> Animals { get; set; }
    }
}
