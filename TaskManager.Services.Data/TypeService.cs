namespace TaskManager.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TaskManager.Data;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Type;

    public class TypeService : ITypeService
    {
        private readonly TaskManagerDbContext dbContext;

        public TypeService(TaskManagerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<TypeViewModel>> GetAllTypesAsync()
        {
            IEnumerable<TypeViewModel> types = await this.dbContext
                .Types
                .Select(t => new TypeViewModel
                {
                    Id = t.Id,
                    Name = t.Name,
                })
                .ToArrayAsync();

            return types;
        }
    }
}
