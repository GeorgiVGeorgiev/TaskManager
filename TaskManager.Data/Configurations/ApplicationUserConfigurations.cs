namespace TaskManager.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TaskManager.Data.Models;

    using static Common.GeneralApplicationConstants;

    public class ApplicationUserConfigurations : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder
                .HasData(this.GenerateData());
        }
        private string GenerateSecurityStamp(string guidd)
        {
            string? str = string.Concat(Array.ConvertAll(Guid.Parse(guidd).ToByteArray(), b => b.ToString("X2")));
            return str;
        }

        private ApplicationUser[] GenerateData()
        {
            var hasher = new Microsoft.AspNetCore.Identity.PasswordHasher<ApplicationUser>();
            ICollection<ApplicationUser> Users = new List<ApplicationUser>();

            ApplicationUser AdminUser = new ApplicationUser()
            {
                Id = Guid.Parse("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),
                Email = DevelopmentAdminEmail,
                NormalizedEmail = DevelopmentAdminEmail.Normalize(),
                UserName = DevelopmentAdminEmail,
                NormalizedUserName = DevelopmentAdminEmail.Normalize(),
                FirstName = "Георги",
                LastName = "Георгиев",
                SecurityStamp = GenerateSecurityStamp("bcb4f072-ecca-43c9-ab26-c060c6f364e4")
            };

            AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "123456");
            Users.Add(AdminUser);

            string email = "User1@base.bg";
            ApplicationUser BaseUsers = new ApplicationUser()
            {
                Id = Guid.Parse("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"),
                Email = email,
                NormalizedEmail = email.Normalize(),
                UserName = email,
                NormalizedUserName = email.Normalize(),
                FirstName = "Евелина",
                LastName = "Георгиева",
                SecurityStamp = GenerateSecurityStamp("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de")
            };
            BaseUsers.PasswordHash = hasher.HashPassword(BaseUsers, "123456");
            Users.Add(BaseUsers);

             email = "User2@base.bg";
             BaseUsers = new ApplicationUser()
            {
                Id = Guid.Parse("296193d2-f02c-4410-b8fe-9eab4ffb4801"),
                Email = email,
                NormalizedEmail = email.Normalize(),
                UserName = email,
                NormalizedUserName = email.Normalize(),
                FirstName = "Първан",
                LastName = "Георгиев",
                SecurityStamp = GenerateSecurityStamp("296193d2-f02c-4410-b8fe-9eab4ffb4801")

             };
            BaseUsers.PasswordHash = hasher.HashPassword(BaseUsers, "123456");
            Users.Add(BaseUsers);


            email = "Worker1@base.bg";
            ApplicationUser WorkerUser = new ApplicationUser()
            {
                Id = Guid.Parse("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
                Email = email,
                NormalizedEmail = email.Normalize(),
                UserName = email,
                NormalizedUserName = email.Normalize(),
                FirstName = "Първан",
                LastName = "Георгиев",
                SecurityStamp = GenerateSecurityStamp("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801")
            };
            WorkerUser.PasswordHash = hasher.HashPassword(WorkerUser, "123456");
            Users.Add(WorkerUser);

            email = "Worker2@base.bg";
            WorkerUser = new ApplicationUser()
            {
                Id = Guid.Parse("6cef6e21-5151-4e88-be5c-f4f78953bf84"),
                Email = email,
                NormalizedEmail = email.Normalize(),
                UserName = email,
                NormalizedUserName = email.Normalize(),
                FirstName = "Иван",
                LastName = "Иванов",
                SecurityStamp = GenerateSecurityStamp("6cef6e21-5151-4e88-be5c-f4f78953bf84")
            };
            WorkerUser.PasswordHash = hasher.HashPassword(WorkerUser, "123456");
            Users.Add(WorkerUser);

            return Users.ToArray();
        }
    }
}
