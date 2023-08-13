namespace TaskManager.Services.Data.Interfaces
{
    using TaskManager.Web.ViewModels.Type;


    public interface ITypeService
    {
        Task<IEnumerable<TypeViewModel>> GetAllTypesAsync();

    }
}
