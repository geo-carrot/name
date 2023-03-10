// <auto-generated />
using System;
using ConsoleApp2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp2.Migrations
{
    [DbContext(typeof(GoodsContext))]
    [Migration("20230309070501_v2")]
    partial class v2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("ConsoleApp2.Category", b =>
                {
                    b.Property<Guid>("IdCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdCategory");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            IdCategory = new Guid("2fdd35fd-df4d-451d-a4ae-25fbdfd475eb"),
                            Name = "овощи"
                        },
                        new
                        {
                            IdCategory = new Guid("311e5b91-1622-4b8b-81f3-59da12a294a9"),
                            Name = "фрукты"
                        });
                });

            modelBuilder.Entity("ConsoleApp2.Good", b =>
                {
                    b.Property<Guid>("IdGood")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CategoryIdCategory")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<double>("Sale")
                        .HasColumnType("REAL");

                    b.HasKey("IdGood");

                    b.HasIndex("CategoryIdCategory");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("ConsoleApp2.Good", b =>
                {
                    b.HasOne("ConsoleApp2.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryIdCategory");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
