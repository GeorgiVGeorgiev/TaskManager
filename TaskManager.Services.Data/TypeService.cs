namespace TaskManager.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.Type;

    public class TypeService : ITypeService
    {
        private readonly TaskManagerDbContext dbContext;

        public TypeService(TaskManagerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddTypeAsync(TypeViewModel typeViewModel)
        {
            Type type = new Type()
            {
                Name = typeViewModel.Name,
            };

            await dbContext.Types.AddAsync(type);
            await dbContext.SaveChangesAsync();
        }

        public async Task EditTypeAsync(TypeViewModel typeViewModel)
        {
            Type type = await this.dbContext
                .Types
                .FirstAsync(t => t.Id== typeViewModel.Id);

            type.Name= typeViewModel.Name;

            await this.dbContext.SaveChangesAsync();
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

        public async Task<TypeViewModel> GetByIdAsync(int id)
        {
            Type type = await this.dbContext.Types.FirstAsync(t => t.Id== id);

            TypeViewModel typeViewModel = new TypeViewModel()
            {
                Id = type.Id,
                Name = type.Name,
            };
            return typeViewModel;
        }

        public async Task<bool> IsExistByIdAsync(int id)
        {
            return await this.dbContext.Types.AnyAsync(t => t.Id== id);
        }
    }
}
