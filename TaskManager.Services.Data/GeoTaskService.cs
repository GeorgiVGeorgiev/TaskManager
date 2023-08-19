namespace TaskManager.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;
    using TaskManager.Data;
    using TaskManager.Data.Models;
    using TaskManager.Services.Data.Interfaces;
    using TaskManager.Web.ViewModels.GeoTask;
    using static Common.EntityValidationConstants.GeoTask;
    public class GeoTaskService : IGeoTaskService
    {
        private readonly TaskManagerDbContext dbContext;

        public GeoTaskService(TaskManagerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

		public async Task<IEnumerable<TaskViewModel>> GetAllGeoTaskAsync()
        {
            IEnumerable<TaskViewModel> tasks = await this.dbContext
                .GeoTasks
                .Include(t => t.Client)
                .Include(t => t.Status)
                .Include(t => t.Type)
                .Select(t => new TaskViewModel
                {
                    Id = t.Id.ToString(),
                    Number = t.ProjectNumber,
                    EndDate = t.EndDate,
                    ClientName = t.Client.Name,
                    price = t.Price,
                    quantity = t.quantity,
                    status = t.Status.Name,
                    TaskType = t.Type.Name                   
              })
                .OrderBy(t => t.Number)
                .ToArrayAsync();

            return tasks;
        }

        public async Task<EditGeoTaskViewModel> GetGeoTaskByIdAsync(string Id)
        {
            GeoTask geoTask = await this.dbContext
                .GeoTasks
                .FirstAsync(gt => gt.Id.ToString() == Id);

            EditGeoTaskViewModel editGeoTaskViewModel = new EditGeoTaskViewModel()
            {
                Id = geoTask.Id.ToString(),
                Adrress = geoTask.Adrress,
                ProjectNumber = geoTask.ProjectNumber,
                Price = geoTask.Price,
                CreateDate = geoTask.CreateDate,
                EndDate = geoTask.EndDate,
                IdKKKR = geoTask.IdKKKR,
                quantity = geoTask.quantity,
                Note = geoTask.Note,
                ClientId = geoTask.ClientId.ToString(),
                WorkerId = geoTask.WorkerId.ToString(),
                CheckerId = geoTask.CheckerId.ToString(),
                StatusId = geoTask.StatusId,
                TypeId = geoTask.TypeId,
            };

            return editGeoTaskViewModel;
        }

        public async Task<bool> IsTaskExistByIdAsync(string Id)
        {
            return await this.dbContext
                .GeoTasks
                .AnyAsync(gt => gt.Id.ToString() == Id);
        }
		public async Task EditGeoTaskByIdAsync(EditGeoTaskViewModel editGeoTaskViewModel)
		{
			string taskId = editGeoTaskViewModel.Id;

            GeoTask geoTask = await this.dbContext
                .GeoTasks
                .FirstAsync(gt => gt.Id.ToString() == taskId);

            geoTask.IdKKKR = editGeoTaskViewModel.IdKKKR;
            geoTask.StatusId = editGeoTaskViewModel.StatusId;
            geoTask.WorkerId = Guid.Parse(editGeoTaskViewModel.WorkerId);
            geoTask.CreateDate= editGeoTaskViewModel.CreateDate;
            geoTask.EndDate= editGeoTaskViewModel.EndDate;
            geoTask.TypeId = editGeoTaskViewModel.TypeId;
            geoTask.Note= editGeoTaskViewModel.Note;
            geoTask.quantity= editGeoTaskViewModel.quantity;
            geoTask.ClientId =Guid.Parse(editGeoTaskViewModel.ClientId);
            geoTask.Price= editGeoTaskViewModel.Price;
            

            await this.dbContext.SaveChangesAsync();
		}

        public async Task<EditGeoTaskViewModel> AddNewTask()
        {
            int projectNumberr = await this.dbContext.GeoTasks.CountAsync();
            GeoTask geoTask = new GeoTask()
            {
                Id = Guid.NewGuid(),
                IdKKKR = IkkrDefautValue,
                StatusId = 1,
                WorkerId = Guid.Parse("A13C085F-4D96-4244-8EA4-607C4B6989F6"),
                CheckerId= Guid.Parse("A13C085F-4D96-4244-8EA4-607C4B6989F6"),
                CreateDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow,
                TypeId = 1,
                Note = NoteDefautValue,
                quantity = 1,
                ClientId = Guid.Parse("3E05C605-D947-4C9E-AC82-E4746822BA7D"),
                Price = 100,
                ProjectNumber = projectNumberr + 1,
                Adrress=AdresDefautValue
        };
            await this.dbContext.GeoTasks.AddAsync(geoTask);
            await this.dbContext.SaveChangesAsync();

            EditGeoTaskViewModel editGeoTaskViewModel = new EditGeoTaskViewModel()
            {
				Id = geoTask.Id.ToString(),
				Adrress = geoTask.Adrress,
				ProjectNumber = geoTask.ProjectNumber,
				Price = geoTask.Price,
				CreateDate = geoTask.CreateDate,
				EndDate = geoTask.EndDate,
				IdKKKR = geoTask.IdKKKR,
				quantity = geoTask.quantity,
				Note = geoTask.Note,
				ClientId = geoTask.ClientId.ToString(),
				WorkerId = geoTask.WorkerId.ToString(),
				CheckerId = geoTask.CheckerId.ToString(),
				StatusId = geoTask.StatusId,
				TypeId = geoTask.TypeId,
			};

            return editGeoTaskViewModel;
		}

        public async Task<IEnumerable<TaskViewModel>> GetMyTaskByWorkerIdAsync(string workerId)
        {
            IEnumerable<TaskViewModel> taskViewModels = await this.dbContext
                .GeoTasks
                .Include(t => t.Client)
                .Include(t => t.Status)
                .Include(t => t.Type)
                .Where(gt => gt.WorkerId.ToString() == workerId && gt.Status.Name != "Приключена")
                .Select(t => new TaskViewModel
                {
                    Id = t.Id.ToString(),
                    Number = t.ProjectNumber,
                    EndDate = t.EndDate,
                    ClientName = t.Client.Name,
                    price = t.Price,
                    quantity = t.quantity,
                    status = t.Status.Name,
                    TaskType = t.Type.Name
                })
                .OrderByDescending(t => t.Number)
                .ToArrayAsync();

            return taskViewModels;
        }

        public async Task<AllGeoTaskFilteredAndPageServiceModel> GetAllGeoTaskFilteredAsync(AllTaskQueryModel allTaskQueryModel)
        {
            IQueryable<GeoTask> geoTasksQuery = this.dbContext
                .GeoTasks
                .Include(t => t.Client)
                .Include(t => t.Status)
                .Include(t => t.Type)
                .OrderByDescending(t => t.ProjectNumber)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(allTaskQueryModel.Type))
            {
                geoTasksQuery = geoTasksQuery
                    .Where(h => h.Type.Name == allTaskQueryModel.Type);
            }
            if(!string.IsNullOrWhiteSpace(allTaskQueryModel.SearchString))
            {
                geoTasksQuery = geoTasksQuery
                    .Where(t => t.Client.Name.ToLower().Contains(allTaskQueryModel.SearchString.ToLower())
                    || t.Adrress.ToLower().Contains(allTaskQueryModel.SearchString.ToLower())
                    || t.Note.ToLower().Contains(allTaskQueryModel.SearchString.ToLower())
                    || t.ProjectNumber.ToString().ToLower().Contains(allTaskQueryModel.SearchString.ToLower())
                    );
            }

            IEnumerable<TaskViewModel> allGeoTasksModel = await geoTasksQuery
                .Skip((allTaskQueryModel.CurrentPage - 1) * allTaskQueryModel.TaskPerPage)
                .Take(allTaskQueryModel.TaskPerPage)
                .Select(t => new TaskViewModel
                {
                    Id = t.Id.ToString(),
                    Number = t.ProjectNumber,
                    EndDate = t.EndDate,
                    ClientName = t.Client.Name,
                    price = t.Price,
                    quantity = t.quantity,
                    status = t.Status.Name,
                    TaskType = t.Type.Name
                })
                .ToArrayAsync();

            int totalTasks = geoTasksQuery.Count();

            return new AllGeoTaskFilteredAndPageServiceModel()
            {
                Tasks = allGeoTasksModel,
                TotalTasks = totalTasks,
            };
        }
    }
}

