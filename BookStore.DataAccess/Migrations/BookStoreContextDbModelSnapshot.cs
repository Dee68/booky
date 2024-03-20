﻿// <auto-generated />
using BookStore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.DataAccess.Migrations
{
    [DbContext(typeof(BookStoreContextDb))]
    partial class BookStoreContextDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStore.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "History"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Programming"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Mathematics"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Action"
                        });
                });

            modelBuilder.Entity("BookStore.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Charles C. Mann",
                            CategoryId = 1,
                            Description = "In this groundbreaking work of science, history, and archaeology, Charles C. Mann radically alters our understanding of the Americas before the arrival of Columbus in 1492.",
                            ISBN = "98767114J3900",
                            ImageUrl = "",
                            ListPrice = 16.0,
                            Price = 18.0,
                            Price100 = 12.0,
                            Price50 = 14.0,
                            Title = "1491:New Revelations of the Americas Before Columbus"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Eric Temple Bell",
                            CategoryId = 3,
                            Description = "Here is the classic, much-read introduction to the craft and history of mathematics by E.T. Bell, a leading figure in mathematics in America for half a century.",
                            ISBN = "9780075549437",
                            ImageUrl = "",
                            ListPrice = 30.0,
                            Price = 27.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Title = "Men Of Mathematics"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Albert Einstein, Nigel Calder",
                            CategoryId = 3,
                            Description = "According to Einstein himself, this book is intended \"to give an exact insight into the theory of Relativity to those readers who, from a general scientific and philosophical point of view, are interested in the theory, but who are not conversant with the mathematical apparatus of theoretical physics.",
                            ISBN = "9785375549437",
                            ImageUrl = "",
                            ListPrice = 30.0,
                            Price = 27.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Title = "Relativity: The Special and the General Theory"
                        });
                });

            modelBuilder.Entity("BookStore.Models.Product", b =>
                {
                    b.HasOne("BookStore.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
