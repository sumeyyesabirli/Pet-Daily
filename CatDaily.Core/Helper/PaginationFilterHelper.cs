using CatDaily.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatDaily.Core.Helper
{
    public static class PaginationFilterHelper
    {
        public static PageResult<T> PaginationFilter<T>(this IQueryable<T> query, PaginationRequestModel requestModel)
        {
            var totalCount=query.Count();
            query = query.Pagining(requestModel.Page, requestModel.PerPage);
            var data = query.ToList();
            return new PageResult<T>
            {
                Data = data,
                Count = data.Count,
                TotalCount = totalCount,
            };
        }

        private static IQueryable<T> Pagining<T>(this IQueryable<T> query ,int page,int perPage)
        {
            return query.Skip((page-1)*perPage).Take(perPage);
        }
    }
}
