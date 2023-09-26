using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RestFulAPI.Models;
using RestFulAPI.Repositories;

namespace RestFulAPI.Filter
{
    public class ShirtIDValidateAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var shirtId = context.ActionArguments["id"] as int?;
            if (shirtId.HasValue)
            {
                if(shirtId.Value <= 0)
                {
                    context.ModelState.AddModelError("ShirtId", "Shirt Id is invalid");
                    context.Result = new BadRequestObjectResult(context.ModelState);

                }
                else if (!ShirtRepository.IsShirtExist(shirtId.Value))
                {
                    context.ModelState.AddModelError("ShirtId", "Shirt Id does not exist");
                    context.Result = new NotFoundObjectResult(context.ModelState);
                }
            }
        }
    }
}
