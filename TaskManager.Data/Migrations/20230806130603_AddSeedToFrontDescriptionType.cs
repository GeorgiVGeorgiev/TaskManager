using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Data.Migrations
{
    public partial class AddSeedToFrontDescriptionType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FrontDescriptionTypes",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "TermDays", "Title" },
                values: new object[,]
                {
                    { 1, "При липса на одобрени архитектурни, чертежи даващи информация за площта на обекта и липсата на площ в документа за собственост се извършва геодезическо измерване за определяне на площта.", "https://img.freepik.com/free-photo/architect-working-house-project-table_23-2147953425.jpg?w=1380&t=st=1691324990~exp=1691325590~hmac=bbb3b1d1f939acf6450a6a01c0aebb3d609956630bf866ac07bffec1d699fe39", 300m, 3, "Геодезическо заснемане определяне на площ на Самостоятелен обект /Апартамент,Офис.../" },
                    { 2, "Необхомите документи за нанасяне на самостоятелен обект в сграда са:\nДокумент за собственост.\nОдобрен архитектурен проект", "https://img.freepik.com/free-photo/crop-hands-using-laptop-drawing-draft_23-2147831931.jpg?w=1380&t=st=1691324467~exp=1691325067~hmac=3a5f8063ec933b2f518ed380be2398257903549bdf04de3951139c5a077bff3b", 200m, 7, "Изменение на кадастрална карта по отношение на Самостоятелен обект в Сграда /Апартамент,Офис.../" },
                    { 3, "При определянето на земни маси е необходимо извършването на геодезическо заснемане.", "https://img.freepik.com/free-vector/banner-with-low-poly-wireframe-abstract-design_1048-16123.jpg?w=1800&t=st=1691324480~exp=1691325080~hmac=3d9089aae2c1a4ccc71db0863bc6f95d090010fccbc6918c402fabf0145cd8ba", 500m, 7, "Определяне на количества на земни маси" },
                    { 4, "За определяне на ситуационните елементи на терена се извършва топографско заснемане, като същото заснемане може да бъде използвано при проектиране.", "https://img.freepik.com/free-vector/topographic-map-background_23-2148594890.jpg?w=1380&t=st=1691326192~exp=1691326792~hmac=f5849e8855fc0009236a16c9acca290c904bdf33dd76bfc11c2f675a8dcd8e8b", 400m, 7, "Топографско заснемане" },
                    { 5, "С проекта се моделира съществуващия терен,така че повърхностните води да се отвеждат извън границите на разработката и/или към новопроектирани отводнителни съоръжения (шахти, дерета и др.).", "https://img.freepik.com/free-photo/beautiful-panorama-green-city-park-dawn_1127-3213.jpg?w=1380&t=st=1691326837~exp=1691327437~hmac=c21356a9b426a41f49927185304207a2d505b6a982c06f88435141207af527b1", 400m, 7, "Проект по част Геодезия (Вертикално планиране)" },
                    { 6, "Трасирането представлява отлагане на терена на всякакъв вид точки: имотни граници, точки от контура на проектна сграда, конструктивни оси на сграда, други", "https://img.freepik.com/free-photo/pointing-sketch_1098-14323.jpg?w=1380&t=st=1691324499~exp=1691325099~hmac=453468d5ffeb0f7355e7c17d9ee7be6280e7a48de0b659f1a69b2602d7df6d18", 400m, 7, "Трасиране" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FrontDescriptionTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FrontDescriptionTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FrontDescriptionTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FrontDescriptionTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FrontDescriptionTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FrontDescriptionTypes",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
