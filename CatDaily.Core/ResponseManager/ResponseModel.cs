﻿using CatDaily.Core.SeedWork;
using System.Net;

namespace CatDaily.Core.ResponseManager
{
	public class ResponseModel<T>
	{
        public HttpStatusCode StatusCode { get; set; }
        public string? Message { get; set; }
        public T Data { get; set; }
        public int Count { get; set; }
        public int TotalCount { get; set; }

    }

    public class ResponseModel
    {
        public HttpStatusCode StatusCode { get; set; }
        public string? Message { get; set; }
     
    }
}
