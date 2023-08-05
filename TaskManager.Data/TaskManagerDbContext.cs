namespace TaskManager.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System.Reflection;
    using TaskManager.Data.Models;

    public class TaskManagerDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>,Guid>
    {
        public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options)
            : base(options)
        {

        }
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Comentar> Comentars { get; set; } = null!;
        public DbSet<Document> Documents { get; set; } = null!;
        public DbSet<FrontDescriptionType> FrontDescriptionTypes { get; set; } = null!;
        public DbSet<Request> Requests { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;
        public DbSet<Type> Types { get; set; } = null!;
        public DbSet<Worker> Workers { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(TaskManagerDbContext)) ??
                Assembly.GetExecutingAssembly();

            builder.ApplyConfigurationsFromAssembly(configAssembly);

            base.OnModelCreating(builder);

        }
    }
}