﻿//// <auto-generated />
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Infrastructure;
//using Microsoft.EntityFrameworkCore.Metadata;
//using Microsoft.EntityFrameworkCore.Migrations;
//using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
//using RentMovies.Ifraestructure;
//using RentMovies.Domain.Entities;

//#nullable disable

//namespace RentMovies.Web.Migrations
//{
//    [DbContext(typeof(DataContext))]
//    [Migration("20250326031938_init")]
//    partial class init
//    {
//        /// <inheritdoc />
//        protected override void BuildTargetModel(ModelBuilder modelBuilder)
//        {
//#pragma warning disable 612, 618
//            modelBuilder
//                .HasAnnotation("ProductVersion", "8.0.11")
//                .HasAnnotation("Relational:MaxIdentifierLength", 128);

//            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

//            modelBuilder.Entity("RentMovies.Web.Models.Category", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int");

//                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

//                    b.Property<string>("Name")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.HasKey("Id");

//                    b.ToTable("Categories");
//                });

//            modelBuilder.Entity("RentMovies.Web.Models.Movie", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int");

//                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

//                    b.Property<string>("Category")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("Description")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("Title")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.HasKey("Id");

//                    b.ToTable("Movies");
//                });
//#pragma warning restore 612, 618
//        }
//    }
//}
