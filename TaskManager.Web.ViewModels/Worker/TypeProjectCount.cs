using System.ComponentModel.DataAnnotations;

namespace TaskManager.Web.ViewModels.Worker
{
	public class TypeProjectCount
	{
		[Required]
		public string Type { get; set; } = null!;

		[Required]
		public int ProjectCount { get; set; }
	}
}
