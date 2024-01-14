using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Web.ViewModels.Worker
{
    public class MonthlyProjectCount
    {
        public string MonthName { get; set; } = null!;

        public string Date { get; set; } = null!;

        public int ProjectCount { get; set; }
    }
}
