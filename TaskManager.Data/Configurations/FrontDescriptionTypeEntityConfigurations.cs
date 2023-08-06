namespace TaskManager.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TaskManager.Data.Models;
    public class FrontDescriptionTypeEntityConfigurations : IEntityTypeConfiguration<FrontDescriptionType>
    {
        public void Configure(EntityTypeBuilder<FrontDescriptionType> builder)
        {
            builder
                .Property(fd => fd.Price)
                .HasPrecision(18, 6);

            builder
                .HasData(this.GenerateData());
        }
        private FrontDescriptionType[] GenerateData()
        {
            ICollection<FrontDescriptionType> frontDescriptionTypes = new List<FrontDescriptionType>();

            FrontDescriptionType type = new FrontDescriptionType()
            {
                Id = 1,
                Title = "Геодезическо заснемане определяне на площ на Самостоятелен обект /Апартамент,Офис.../",
                Description = "При липса на одобрени архитектурни, чертежи даващи информация за площта на обекта и липсата на площ в документа за собственост се извършва геодезическо измерване за определяне на площта.",
                Price = 300,
                TermDays = 3,
                ImageUrl = "https://img.freepik.com/free-photo/architect-working-house-project-table_23-2147953425.jpg?w=1380&t=st=1691324990~exp=1691325590~hmac=bbb3b1d1f939acf6450a6a01c0aebb3d609956630bf866ac07bffec1d699fe39"
            };
            frontDescriptionTypes.Add(type);

            type = new FrontDescriptionType()
            {
                Id = 2,
                Title = "Изменение на кадастрална карта по отношение на Самостоятелен обект в Сграда /Апартамент,Офис.../",
                Description = "Необхомите документи за нанасяне на самостоятелен обект в сграда са:\nДокумент за собственост.\nОдобрен архитектурен проект",
                Price = 200,
                TermDays = 7,
                ImageUrl = "https://img.freepik.com/free-photo/crop-hands-using-laptop-drawing-draft_23-2147831931.jpg?w=1380&t=st=1691324467~exp=1691325067~hmac=3a5f8063ec933b2f518ed380be2398257903549bdf04de3951139c5a077bff3b"
            };
            frontDescriptionTypes.Add(type);

            type = new FrontDescriptionType()
            {
                Id = 3,
                Title = "Определяне на количества на земни маси",
                Description = "При определянето на земни маси е необходимо извършването на геодезическо заснемане.",
                Price = 500,
                TermDays = 7,
                ImageUrl = "https://img.freepik.com/free-vector/banner-with-low-poly-wireframe-abstract-design_1048-16123.jpg?w=1800&t=st=1691324480~exp=1691325080~hmac=3d9089aae2c1a4ccc71db0863bc6f95d090010fccbc6918c402fabf0145cd8ba"
            };
            frontDescriptionTypes.Add(type);

            type = new FrontDescriptionType()
            {
                Id = 4,
                Title = "Топографско заснемане",
                Description = "За определяне на ситуационните елементи на терена се извършва топографско заснемане, като същото заснемане може да бъде използвано при проектиране.",
                Price = 400,
                TermDays = 7,
                ImageUrl = "https://img.freepik.com/free-vector/topographic-map-background_23-2148594890.jpg?w=1380&t=st=1691326192~exp=1691326792~hmac=f5849e8855fc0009236a16c9acca290c904bdf33dd76bfc11c2f675a8dcd8e8b"
            };
            frontDescriptionTypes.Add(type);

            type = new FrontDescriptionType()
            {
                Id = 5,
                Title = "Проект по част Геодезия (Вертикално планиране)",
                Description = "С проекта се моделира съществуващия терен,така че повърхностните води да се отвеждат извън границите на разработката и/или към новопроектирани отводнителни съоръжения (шахти, дерета и др.).",
                Price = 400,
                TermDays = 7,
                ImageUrl = "https://img.freepik.com/free-photo/beautiful-panorama-green-city-park-dawn_1127-3213.jpg?w=1380&t=st=1691326837~exp=1691327437~hmac=c21356a9b426a41f49927185304207a2d505b6a982c06f88435141207af527b1"
            };
            frontDescriptionTypes.Add(type);

            type = new FrontDescriptionType()
            {
                Id = 6,
                Title = "Трасиране",
                Description = "Трасирането представлява отлагане на терена на всякакъв вид точки: имотни граници, точки от контура на проектна сграда, конструктивни оси на сграда, други",
                Price = 400,
                TermDays = 7,
                ImageUrl = "https://img.freepik.com/free-photo/pointing-sketch_1098-14323.jpg?w=1380&t=st=1691324499~exp=1691325099~hmac=453468d5ffeb0f7355e7c17d9ee7be6280e7a48de0b659f1a69b2602d7df6d18"
            };
            frontDescriptionTypes.Add(type);

            return frontDescriptionTypes.ToArray();
        }
    }
}
