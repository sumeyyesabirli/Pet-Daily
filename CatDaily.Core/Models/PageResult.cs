using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatDaily.Core.Models
{
    public class PageResult<T>
    {
        public int Count { get; set; }
        public int TotalCount { get; set; }
        public IEnumerable Data { get; set; }
    }
}
