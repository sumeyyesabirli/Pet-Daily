using CatDaily.Core.ResponseManager;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CatDaily.Core.Middleware
{

    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError;

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)statusCode;
            string errorMessage = $"Bir hata oluştu. Hata mesajı :  {exception.Message}";

            var responseModel = new ResponseModel
            {

                Message = errorMessage,
                StatusCode = statusCode
            };

            var jsonResponse = JsonConvert.SerializeObject(responseModel);

            await context.Response.WriteAsync(jsonResponse);
        }
    }
}
