using CSharpFunctionalExtensions;
using Microsoft.AspNetCore.Mvc;

namespace EdmxConv.Controllers
{
    public abstract class BaseApiController : Controller
    {
        protected IActionResult MapToHttpResponse<T>(Result<T> result) =>
            result.IsSuccess
                ? (IActionResult)Ok(result.Value)
                : (IActionResult)BadRequest(result.Error);

        protected IActionResult MapToHttpResponse(Result result) =>
            result.IsSuccess
                ? (IActionResult)Ok()
                : (IActionResult)BadRequest(result.Error);
    }
}