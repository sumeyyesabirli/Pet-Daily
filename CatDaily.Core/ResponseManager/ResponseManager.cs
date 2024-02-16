using System.Net;

namespace CatDaily.Core.ResponseManager
{
    public static class ResponseManager
	{
        #region Success
        public static ResponseModel CreateSuccess(string message = "Succes")
		{
			return new ResponseModel
			{
				Message = message,
				StatusCode = System.Net.HttpStatusCode.OK,
			};
		}


		public static ResponseModel<T> CreateSuccess<T>(T data, string message = "Success")
		{
			return new ResponseModel<T>
			{
				Data = data,
				Message = message,
				StatusCode = System.Net.HttpStatusCode.OK
			};
		}
        #endregion

        #region Error
		public static ResponseModel CreateError(string message)
		{
			return new ResponseModel
			{
				Message = message,
				StatusCode = System.Net.HttpStatusCode.BadRequest
			};
		}
		// 400, 401, 404, 500 (kodsal bir şey varsa daha doğrusu sistemsel... exception handler -> middelware)
        public static ResponseModel CreateError(string message, HttpStatusCode httpStatusCode)
        {
            return new ResponseModel
            {
                Message = message,
                StatusCode = httpStatusCode
            };
        }

        public static ResponseModel<T> CreateError<T>(string message, HttpStatusCode httpStatusCode)
        {
            return new ResponseModel<T>
            {
                Message = message,
                StatusCode = httpStatusCode
            };
        }

        public static ResponseModel<T> CreateError<T>(string message)
        {
            return new ResponseModel<T>
            {
                Message = message,
                StatusCode = HttpStatusCode.BadRequest
            };
        }
        #endregion
    }
}
