using TaskManager.Web.ViewModels.Comentar;

namespace TaskManager.Services.Data.Interfaces
{
    public interface IComentarService
    {
        public Task<IEnumerable<ComentarViewModel>> GetComentarByTaskIdAsync(string Id);

        public Task EditComentarByTaskIdAsync(ComentarViewModel comentarViewModel);

        public Task<bool> IsComentarExistById(int comentarId);

        public Task<ComentarViewModel> GetComentarByIdAsync(int Id);

        public Task<string> GetTaskIdByComentarId(int comentarId);

        public Task CreateComentarAsync(ComentarViewModel comentarViewModel);

    }
}
