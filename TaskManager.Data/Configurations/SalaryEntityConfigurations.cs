using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Data.Models;

namespace TaskManager.Data.Configurations
{
    public class SalaryEntityConfigurations : IEntityTypeConfiguration<Salary>
    {
        public void Configure(EntityTypeBuilder<Salary> builder)
        {
            builder.HasData(GenerateData());
        }
        private Salary[] GenerateData()
        {
            ICollection<Salary> salaries = new List<Salary>();

            Salary salary = new Salary()
            {
                Id = 1,
                WorkerId = Guid.Parse("a13c085f-4d96-4244-8ea4-607c4b6989f6"),
                ChangeDate = DateTime.Now,
                NetSalary = 2500,
            };
            salaries.Add(salary);

            salary = new Salary()
            {
                Id = 2,
                WorkerId = Guid.Parse("c6d1253b-2695-4a7f-98d5-a2a87eb3b97a"),
                ChangeDate = DateTime.Now,
                NetSalary = 1000,
            };
            salaries.Add(salary);

            salary = new Salary()
            {
                Id = 3,
                WorkerId = Guid.Parse("acda7da9-d7a0-4fd0-9aca-f6000da77582"),
                ChangeDate = DateTime.Now,
                NetSalary = 1500,
            };
            salaries.Add(salary);

            return salaries.ToArray();
        }
    }
}
