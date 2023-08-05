namespace TaskManager.Web.Infrastructure.Extentions
{
    using System.Security.Claims;
    using static Common.GeneralApplicationConstants;
    public static class ClaimsPrincipalExtentions
    {
        public static string GetId(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);

        }
        public static bool isAdmin(this ClaimsPrincipal user)
        {
            return user.IsInRole(adminRoleName);
        }
    }
}
