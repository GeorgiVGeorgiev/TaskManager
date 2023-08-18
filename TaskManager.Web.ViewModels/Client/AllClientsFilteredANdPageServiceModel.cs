using TaskManager.Web.ViewModels.GeoTask;

namespace TaskManager.Web.ViewModels.Client
{
    public class AllClientsFilteredANdPageServiceModel
    {
        public int TotalClients { get; set; }

        public IEnumerable<ClientViewModel> Clients { get; set; } = new HashSet<ClientViewModel>();
    }
}
