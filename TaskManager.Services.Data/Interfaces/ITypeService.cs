using TaskManager.Web.ViewModels.FrontDescriptionType;

namespace TaskManager.Services.Data.Interfaces
{
    using TaskManager.Web.ViewModels.Type;


    public interface ITypeService
    {
        Task<IEnumerable<TypeViewModel>> GetAllTypesAsync();
        Task<bool> IsExistByIdAsync(int id);
        Task AddTypeAsync(TypeViewModel typeViewModel);
        Task EditTypeAsync(TypeViewModel typeViewModel);
        Task<IEnumerable<string>> GetAllTypeNamesAsync();
        Task<TypeViewModel> GetByIdAsync(int id);

    }
}
