namespace TaskManager.Services.Data.Interfaces
{
    using TaskManager.Web.ViewModels.FrontDescriptionType;

    public interface IFrontDescriptionTypeService
    {
        Task<IEnumerable<FrontDescriptionTypeViewModel>> GetAllAsync();
        Task<FrontDescriptionTypeViewModel> GetByIdAsync(int id);
        Task<bool> isExistByIdAsync (int id);
    }
}
