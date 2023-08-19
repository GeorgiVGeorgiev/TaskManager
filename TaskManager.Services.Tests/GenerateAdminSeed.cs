namespace TaskManager.Services.Tests
{
    using Microsoft.AspNetCore.Identity;
    using TaskManager.Data;

    using static Common.GeneralApplicationConstants;
    public static class GenerateAdminSeed
    {
        private static IdentityRole<Guid> Role;
        public static void AdminRoleSeed(TaskManagerDbContext dbContext)
        {
            Role = new IdentityRole<Guid>()
            {
                Id = Guid.Parse("CEE24B2C-253F-4640-8326-6CFCBDC17B3E"),
                ConcurrencyStamp = "a11fa4b2-427b-46b9-8d88-2c305c3136f4",
                Name = adminRoleName,
                NormalizedName = adminRoleName.ToUpper(),
            };
            IdentityUserRole<Guid> userrole = new IdentityUserRole<Guid>()
            {
                RoleId = Guid.Parse("CEE24B2C-253F-4640-8326-6CFCBDC17B3E"),
                UserId = Guid.Parse("BCB4F072-ECCA-43C9-AB26-C060C6F364E4")
            };

            dbContext.Roles.Add(Role);
            dbContext.UserRoles.Add(userrole);

            dbContext.SaveChanges();
        }
    }

}