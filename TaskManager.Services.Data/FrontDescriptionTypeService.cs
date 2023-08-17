namespace TaskManager.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.FrontDescriptionType;

    public class FrontDescriptionTypeService : IFrontDescriptionTypeService
    {
        private readonly TaskManagerDbContext dbContext;
        public FrontDescriptionTypeService(TaskManagerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddFrondDescriptionTypeAsync(FrontDescriptionTypeViewModel model)
        {
            FrontDescriptionType frontDescriptionType = new FrontDescriptionType()
            {
                ImageUrl= model.ImageUrl,
                Description= model.Description,
                TermDays= model.TermDays,
                Price= model.Price,
                Title= model.Title,
            };

             await this.dbContext.FrontDescriptionTypes.AddAsync(frontDescriptionType);
             await this.dbContext.SaveChangesAsync();
        }

        public async Task EditFrontDescriptionTypeAsync(FrontDescriptionTypeViewModel model)
        {
            FrontDescriptionType frontDescriptionType = await this.dbContext
                .FrontDescriptionTypes
                .FirstAsync(f => f.Id == model.Id);

            frontDescriptionType.ImageUrl = model.ImageUrl;
            frontDescriptionType.Description = model.Description;
            frontDescriptionType.TermDays = model.TermDays;
            frontDescriptionType.Price = model.Price;
            frontDescriptionType.Title = model.Title;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<FrontDescriptionTypeViewModel>> GetAllAsync()
        {
            IEnumerable<FrontDescriptionTypeViewModel> FrontTypes = await this.dbContext
                .FrontDescriptionTypes
                .Select(x => new FrontDescriptionTypeViewModel
                {
                    Id= x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    ImageUrl = x.ImageUrl,
                    Price = x.Price,
                    TermDays = x.TermDays,
                })
                .ToArrayAsync();

            return FrontTypes;
        }

        public async Task<FrontDescriptionTypeViewModel> GetByIdAsync(int id)
        {
            FrontDescriptionType frontType = await this.dbContext
                .FrontDescriptionTypes
                .FirstAsync(x => x.Id == id);

            FrontDescriptionTypeViewModel viewModel = new FrontDescriptionTypeViewModel()
            {
                Id = frontType.Id,
                Title = frontType.Title,
                Description = frontType.Description,
                ImageUrl = frontType.ImageUrl,
                Price = frontType.Price,
                TermDays = frontType.TermDays,
            };
            return viewModel;
        }

        public async Task<bool> isExistByIdAsync(int id)
        {
            bool frontType = await this.dbContext
                .FrontDescriptionTypes
                .AnyAsync(x => x.Id == id);

            return frontType;
        }
    }
}
