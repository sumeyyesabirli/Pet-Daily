using CatDaily.Core.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatDaily.DataAccess.Entity
{
	public class AnimalType : BaseEntity
	{
        public string Code { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }
    }
}
