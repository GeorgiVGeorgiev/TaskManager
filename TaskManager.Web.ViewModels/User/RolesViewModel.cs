using System.ComponentModel.DataAnnotations;

namespace TaskManager.Web.ViewModels.User
{
    using static Common.ErrorMessageBulgarian;

    public class RolesViewModel
    {
        [Required(ErrorMessage =RequiredErrorMessage)]
        public string Id { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public string Name { get; set; } = null!;
    }
}
