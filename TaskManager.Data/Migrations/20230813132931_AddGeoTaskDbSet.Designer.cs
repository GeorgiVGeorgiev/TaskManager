﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskManager.Data;

#nullable disable

namespace TaskManager.Data.Migrations
{
    [DbContext(typeof(TaskManagerDbContext))]
    [Migration("20230813132931_AddGeoTaskDbSet")]
    partial class AddGeoTaskDbSet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TaskManager.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b25435a9-9413-4127-aa3c-5bb3e8b69ccf",
                            Email = "administrator@admin",
                            EmailConfirmed = false,
                            FirstName = "Георги",
                            LastName = "Георгиев",
                            LockoutEnabled = false,
                            NormalizedEmail = "administrator@admin",
                            NormalizedUserName = "administrator@admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEC0giUTeKkkflltft+akQQLmPxlU1FfzaTrUId1rHWbVzIQ7Tv/aHkM6o5yjRxLNdw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "72F0B4BCCAECC943AB26C060C6F364E4",
                            TwoFactorEnabled = false,
                            UserName = "administrator@admin"
                        },
                        new
                        {
                            Id = new Guid("6e70d07b-eaa7-4384-b233-c5ef9c0bf8de"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "46b35ee3-bcf2-47df-89e6-56618e61e8d4",
                            Email = "User1@base.bg",
                            EmailConfirmed = false,
                            FirstName = "Евелина",
                            LastName = "Георгиева",
                            LockoutEnabled = false,
                            NormalizedEmail = "User1@base.bg",
                            NormalizedUserName = "User1@base.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEMpCeP02rmPFsRtMc/0I9ESFp3dXRz/ct6KagaO6Hy1rZfSJzkv+nW0lJNhPN6z9/g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7BD0706EA7EA8443B233C5EF9C0BF8DE",
                            TwoFactorEnabled = false,
                            UserName = "User1@base.bg"
                        },
                        new
                        {
                            Id = new Guid("296193d2-f02c-4410-b8fe-9eab4ffb4801"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a01a8a1c-0251-4fbc-85c1-7b8ece4c5ef4",
                            Email = "User2@base.bg",
                            EmailConfirmed = false,
                            FirstName = "Първан",
                            LastName = "Георгиев",
                            LockoutEnabled = false,
                            NormalizedEmail = "User2@base.bg",
                            NormalizedUserName = "User2@base.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAECKcBHrZGO1V/ZITBB+R5PZB82sNURbXfC3yevpwVk6zZMNOXUs1bI19Famlhiachg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "D29361292CF01044B8FE9EAB4FFB4801",
                            TwoFactorEnabled = false,
                            UserName = "User2@base.bg"
                        },
                        new
                        {
                            Id = new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ac469146-cc87-4030-bff8-0bf8c2b6618b",
                            Email = "Worker1@base.bg",
                            EmailConfirmed = false,
                            FirstName = "Първан",
                            LastName = "Георгиев",
                            LockoutEnabled = false,
                            NormalizedEmail = "Worker1@base.bg",
                            NormalizedUserName = "Worker1@base.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEFCejRsRoyd8uVlw2JCr70OHY5rfIaL4JaPpywDXkJfmuRlng688GAFf9QbFLX2Oyw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "F59E67350BBB6A4DBB376B0BFB32E801",
                            TwoFactorEnabled = false,
                            UserName = "Worker1@base.bg"
                        },
                        new
                        {
                            Id = new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3edb7505-fd18-41ee-9dbb-a672326a70dd",
                            Email = "Worker2@base.bg",
                            EmailConfirmed = false,
                            FirstName = "Иван",
                            LastName = "Иванов",
                            LockoutEnabled = false,
                            NormalizedEmail = "Worker2@base.bg",
                            NormalizedUserName = "Worker2@base.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEGiPMJmzC3BnHlFqpwmF9d1pf4O4hH/V0yuSH0+OlvVRMyWzGw3EAl9hpdhZjk7uEA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "216EEF6C5151884EBE5CF4F78953BF84",
                            TwoFactorEnabled = false,
                            UserName = "Worker2@base.bg"
                        });
                });

            modelBuilder.Entity("TaskManager.Data.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Predstavitel")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("TaskManager.Data.Models.Comentar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2500)
                        .HasColumnType("nvarchar(2500)");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WorkerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Comentars");
                });

            modelBuilder.Entity("TaskManager.Data.Models.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsThere")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("TaskManager.Data.Models.FrontDescriptionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 6)
                        .HasColumnType("decimal(18,6)");

                    b.Property<int>("TermDays")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("FrontDescriptionTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "При липса на одобрени архитектурни, чертежи даващи информация за площта на обекта и липсата на площ в документа за собственост се извършва геодезическо измерване за определяне на площта.",
                            ImageUrl = "https://img.freepik.com/free-photo/architect-working-house-project-table_23-2147953425.jpg?w=1380&t=st=1691324990~exp=1691325590~hmac=bbb3b1d1f939acf6450a6a01c0aebb3d609956630bf866ac07bffec1d699fe39",
                            Price = 300m,
                            TermDays = 3,
                            Title = "Геодезическо заснемане определяне на площ на Самостоятелен обект /Апартамент,Офис.../"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Необхомите документи за нанасяне на самостоятелен обект в сграда са:\nДокумент за собственост.\nОдобрен архитектурен проект",
                            ImageUrl = "https://img.freepik.com/free-photo/crop-hands-using-laptop-drawing-draft_23-2147831931.jpg?w=1380&t=st=1691324467~exp=1691325067~hmac=3a5f8063ec933b2f518ed380be2398257903549bdf04de3951139c5a077bff3b",
                            Price = 200m,
                            TermDays = 7,
                            Title = "Изменение на кадастрална карта по отношение на Самостоятелен обект в Сграда /Апартамент,Офис.../"
                        },
                        new
                        {
                            Id = 3,
                            Description = "При определянето на земни маси е необходимо извършването на геодезическо заснемане.",
                            ImageUrl = "https://img.freepik.com/free-vector/banner-with-low-poly-wireframe-abstract-design_1048-16123.jpg?w=1800&t=st=1691324480~exp=1691325080~hmac=3d9089aae2c1a4ccc71db0863bc6f95d090010fccbc6918c402fabf0145cd8ba",
                            Price = 500m,
                            TermDays = 7,
                            Title = "Определяне на количества на земни маси"
                        },
                        new
                        {
                            Id = 4,
                            Description = "За определяне на ситуационните елементи на терена се извършва топографско заснемане, като същото заснемане може да бъде използвано при проектиране.",
                            ImageUrl = "https://img.freepik.com/free-vector/topographic-map-background_23-2148594890.jpg?w=1380&t=st=1691326192~exp=1691326792~hmac=f5849e8855fc0009236a16c9acca290c904bdf33dd76bfc11c2f675a8dcd8e8b",
                            Price = 400m,
                            TermDays = 7,
                            Title = "Топографско заснемане"
                        },
                        new
                        {
                            Id = 5,
                            Description = "С проекта се моделира съществуващия терен,така че повърхностните води да се отвеждат извън границите на разработката и/или към новопроектирани отводнителни съоръжения (шахти, дерета и др.).",
                            ImageUrl = "https://img.freepik.com/free-photo/beautiful-panorama-green-city-park-dawn_1127-3213.jpg?w=1380&t=st=1691326837~exp=1691327437~hmac=c21356a9b426a41f49927185304207a2d505b6a982c06f88435141207af527b1",
                            Price = 400m,
                            TermDays = 7,
                            Title = "Проект по част Геодезия (Вертикално планиране)"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Трасирането представлява отлагане на терена на всякакъв вид точки: имотни граници, точки от контура на проектна сграда, конструктивни оси на сграда, други",
                            ImageUrl = "https://img.freepik.com/free-photo/pointing-sketch_1098-14323.jpg?w=1380&t=st=1691324499~exp=1691325099~hmac=453468d5ffeb0f7355e7c17d9ee7be6280e7a48de0b659f1a69b2602d7df6d18",
                            Price = 400m,
                            TermDays = 7,
                            Title = "Трасиране"
                        });
                });

            modelBuilder.Entity("TaskManager.Data.Models.GeoTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adrress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("CheckerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdKKKR")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 6)
                        .HasColumnType("decimal(18,6)");

                    b.Property<int>("ProjectNumber")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<Guid>("WorkerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("quantity")
                        .HasPrecision(18, 6)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CheckerId");

                    b.HasIndex("ClientId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.HasIndex("WorkerId");

                    b.ToTable("GeoTasks");
                });

            modelBuilder.Entity("TaskManager.Data.Models.Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("TaskManager.Data.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("TaskManager.Data.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Геодезическо заснемане"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Трасировка"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Вертикално планиране"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Комбинирана скица"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Изменение на план за регулация"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Заснеамне за площ"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Заснемане по чл.19 от ЗУЗСО"
                        });
                });

            modelBuilder.Entity("TaskManager.Data.Models.Worker", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Workers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a13c085f-4d96-4244-8ea4-607c4b6989f6"),
                            PhoneNumber = "0899999999",
                            Position = "Admin",
                            UserId = new Guid("bcb4f072-ecca-43c9-ab26-c060c6f364e4")
                        },
                        new
                        {
                            Id = new Guid("c6d1253b-2695-4a7f-98d5-a2a87eb3b97a"),
                            PhoneNumber = "0888888888",
                            Position = "Мерач",
                            UserId = new Guid("35679ef5-bb0b-4d6a-bb37-6b0bfb32e801")
                        },
                        new
                        {
                            Id = new Guid("acda7da9-d7a0-4fd0-9aca-f6000da77582"),
                            PhoneNumber = "0877777777",
                            Position = "Проектант",
                            UserId = new Guid("6cef6e21-5151-4e88-be5c-f4f78953bf84")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("TaskManager.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("TaskManager.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManager.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("TaskManager.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskManager.Data.Models.Comentar", b =>
                {
                    b.HasOne("TaskManager.Data.Models.GeoTask", "Task")
                        .WithMany("Comentars")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TaskManager.Data.Models.Worker", "Worker")
                        .WithMany()
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("TaskManager.Data.Models.Document", b =>
                {
                    b.HasOne("TaskManager.Data.Models.GeoTask", "Task")
                        .WithMany("Documents")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("TaskManager.Data.Models.GeoTask", b =>
                {
                    b.HasOne("TaskManager.Data.Models.Worker", "CheckEr")
                        .WithMany("Tasks")
                        .HasForeignKey("CheckerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TaskManager.Data.Models.Client", "Client")
                        .WithMany("GeoTasks")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TaskManager.Data.Models.Status", "Status")
                        .WithMany("Tasks")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TaskManager.Data.Models.Type", "Type")
                        .WithMany("Tasks")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TaskManager.Data.Models.Worker", "Worker")
                        .WithMany()
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CheckEr");

                    b.Navigation("Client");

                    b.Navigation("Status");

                    b.Navigation("Type");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("TaskManager.Data.Models.Request", b =>
                {
                    b.HasOne("TaskManager.Data.Models.ApplicationUser", "User")
                        .WithMany("Requests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskManager.Data.Models.Worker", b =>
                {
                    b.HasOne("TaskManager.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TaskManager.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("TaskManager.Data.Models.Client", b =>
                {
                    b.Navigation("GeoTasks");
                });

            modelBuilder.Entity("TaskManager.Data.Models.GeoTask", b =>
                {
                    b.Navigation("Comentars");

                    b.Navigation("Documents");
                });

            modelBuilder.Entity("TaskManager.Data.Models.Status", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("TaskManager.Data.Models.Type", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("TaskManager.Data.Models.Worker", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
