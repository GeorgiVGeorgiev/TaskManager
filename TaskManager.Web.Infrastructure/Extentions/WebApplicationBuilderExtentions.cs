namespace TaskManager.Web.Infrastructure.Extentions
{
    using Microsoft.Extensions.DependencyInjection;
    using System.Reflection;
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
    }
}
