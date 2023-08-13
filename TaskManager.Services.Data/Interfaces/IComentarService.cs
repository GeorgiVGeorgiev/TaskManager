using TaskManager.Web.ViewModels.Comentar;

namespace TaskManager.Services.Data.Interfaces
{
    public interface IComentarService
    {
        Task<IEnumerable<ComentarViewModel>> GetComentarByTaskIdAsync(string Id);
    }
}
