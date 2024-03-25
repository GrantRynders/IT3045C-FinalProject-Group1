﻿// <auto-generated />
using ASPdemo.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPdemo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240325205852_PortfolioCreate")]
    partial class PortfolioCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("ASPdemo.Entities.Airdrop", b =>
                {
                    b.Property<int>("AirdropId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EndDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalPrize")
                        .HasColumnType("REAL");

                    b.Property<double>("WinnerCount")
                        .HasColumnType("REAL");

                    b.HasKey("AirdropId");

                    b.ToTable("Airdrops");
                });

            modelBuilder.Entity("ASPdemo.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("AvgPriceChange")
                        .HasColumnType("REAL");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<double>("LastUpdated")
                        .HasColumnType("REAL");

                    b.Property<double>("MarketCap")
                        .HasColumnType("REAL");

                    b.Property<double>("MarketCapChange")
                        .HasColumnType("REAL");

                    b.Property<int>("NumTokens")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Volume")
                        .HasColumnType("REAL");

                    b.Property<double>("VolumeChange")
                        .HasColumnType("REAL");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ASPdemo.Entities.CurrenciesCategories", b =>
                {
                    b.Property<int>("CurrenciesCategoriesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CurrenciesCategoriesId");

                    b.ToTable("CurrenciesCategories");
                });

            modelBuilder.Entity("ASPdemo.Entities.Currency", b =>
                {
                    b.Property<int>("CurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CurrencyName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Slug")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Symbol")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("CurrencyId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("ASPdemo.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("PermissionsLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ASPdemo.Entities.Currency", b =>
                {
                    b.HasOne("ASPdemo.Entities.Category", null)
                        .WithMany("Coins")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASPdemo.Entities.Category", b =>
                {
                    b.Navigation("Coins");
                });
#pragma warning restore 612, 618
        }
    }
}
