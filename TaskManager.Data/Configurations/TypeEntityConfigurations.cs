namespace TaskManager.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TaskManager.Data.Models;
    using Type = TaskManager.Data.Models.Type;
    public class TypeEntityConfigurations : IEntityTypeConfiguration<Type>
    {
        public void Configure(EntityTypeBuilder<Models.Type> builder)
        {
            builder.HasData(this.GemerateData());
        }
        private Type[] GemerateData()
        {
            ICollection<Type> types = new List<Type>();

            Type type = new Type()
            {
                Id = 1,
                Name = "Геодезическо заснемане"
            };
            types.Add(type);

            type = new Type()
            {
                Id = 2,
                Name = "Трасировка"
            };
            types.Add(type);

            type = new Type()
            {
                Id = 3,
                Name = "Вертикално планиране"
            };
            types.Add(type);

            type = new Type()
            {
                Id = 4,
                Name = "Комбинирана скица"
            };
            types.Add(type);

            type = new Type()
            {
                Id = 5,
                Name = "Изменение на план за регулация"
            };
            types.Add(type);

            type = new Type()
            {
                Id = 6,
                Name = "Заснеамне за площ"
            };
            types.Add(type);

            type = new Type()
            {
                Id = 7,
                Name = "Заснемане по чл.19 от ЗУЗСО"
            };
            types.Add(type);

            return types.ToArray();
        }
    }
}
