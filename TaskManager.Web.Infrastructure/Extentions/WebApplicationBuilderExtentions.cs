namespace TaskManager.Web.Infrastructure.Extentions
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using System.Reflection;
    using TaskManager.Data.Models;
    using static Common.GeneralApplicationConstants;
    using Type = System.Type;

    public static class WebApplicationBuilderExtentions
    {
        /// <summary>
        /// This method register all services with their interfaces and implementation of given assembly.
        /// 
        /// </summary>
        /// <param name="serviceType">Type of random service inplementation.</param>
        public static void AddApplicationServices(this IServiceCollection services, Type serviceType)
        {
            Assembly? serviceAssembly = Assembly.GetAssembly(serviceType);

            if (serviceAssembly == null)
            {
                throw new InvalidOperationException("Invalid service type provided!");
            }

            Type[] serviceTypes = serviceAssembly
                .GetTypes()
                .Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
                .ToArray();

            foreach (Type implementationType in serviceTypes)
            {
                Type? interfaceType = implementationType
                    .GetInterface($"I{implementationType.Name}");

                if (interfaceType == null)
                {
                    throw new InvalidOperationException($"No interface is provided for the service with name: {implementationType.Name}");
                }
                services.AddScoped(interfaceType, implementationType);
            }
        }
        public static IApplicationBuilder SeedAdministrator(this IApplicationBuilder app, string Email)
        {
            using IServiceScope scopeService = app.ApplicationServices.CreateScope();

            IServiceProvider serviceProvider = scopeService.ServiceProvider;

            UserManager<ApplicationUser> userManager =
                serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            RoleManager<IdentityRole<Guid>> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

            Task.Run(async () =>
            {
                if (await roleManager.RoleExistsAsync(adminRoleName))
                {
                    return;
                }
                IdentityRole<Guid> role = new IdentityRole<Guid>(adminRoleName);
                await roleManager.CreateAsync(role);

                ApplicationUser adminUser =
                    await userManager.FindByEmailAsync(Email);

                await userManager.AddToRoleAsync(adminUser, adminRoleName);
            })
                .GetAwaiter()
                .GetResult();

            return app;
        }
    }
}
