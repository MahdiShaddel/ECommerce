using ECommerce.ProductsList.Application.Contract.RespondResult;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Products.Api.Response
{
    public static class ResponseUtil
    {
        public static IActionResult ResultMessage<TViewModel>(TViewModel data)
        {
            var result = new CustomeServiceResult<TViewModel>() { Result = data };
            return new JsonResult(result);
        }
        public static IActionResult ResultMessage<TViewModel>(this ICustomeRespondResult<TViewModel> domainServiceResult)
        {
            return new JsonResult(domainServiceResult);
        }
    }
}
