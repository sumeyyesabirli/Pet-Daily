﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatDaily.Core.Models
{
    public class PaginationRequestModel
    {
        public int Page { get; set; } = 1;
        public int PerPage { get; set; } = 5;
    }
}
