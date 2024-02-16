﻿using CatDaily.Core.ResponseManager;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CatDaily.Core.SeedWork
{
	[Route("api/[controller]")]
	[ApiController]
	public class BaseController : ControllerBase
	{
        protected IActionResult HandleResponse(ResponseModel responseModel)
		{
			if (responseModel.StatusCode == System.Net.HttpStatusCode.OK)
			{
				return Ok(responseModel);
			}
			else if (responseModel.StatusCode == System.Net.HttpStatusCode.BadRequest)
			{
				return BadRequest(responseModel);
			}
			else
				return StatusCode(500, responseModel);
        }

        protected  IActionResult HandleResponse<T>(ResponseModel<T> responseModel)
        {
            if (responseModel.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Ok(responseModel);
            }
            else if (responseModel.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                return BadRequest(responseModel);
            }
            else
                return StatusCode(500, responseModel);
        }
    }
}