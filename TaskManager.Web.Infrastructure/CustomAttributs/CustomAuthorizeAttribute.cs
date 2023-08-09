namespace TaskManager.Web.Infrastructure.CustomAttributs
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.Infrastructure.Extentions;

    public sealed class CustomAuthorizeAttribute : Attribute, IAuthorizationFilter
    {

        public async void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context != null)
            {
                string userId = context.HttpContext.User.GetId();

                IUserService? userService = context.HttpContext
                    .RequestServices
                    .GetService(typeof(IUserService)) as IUserService;



                bool isUserWorker = await userService!.IsUserWorkerByIdAsync(userId);

                if (!isUserWorker)
                {
                    context.Result = new UnauthorizedResult();
                    return;
                }
                return;
                
            }
        }
    }
}
