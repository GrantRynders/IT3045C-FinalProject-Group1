﻿// <auto-generated />
using System;
using ASPdemo.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPdemo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("ASPdemo.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AvgPriceChange")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CMCCategoryId")
                        .IsRequired()
                        .HasColumnType("TEXT");

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

                    b.Property<string>("MarketCap")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MarketCapChange")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumTokens")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Volume")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VolumeChange")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ASPdemo.Entities.CurrenciesPortfolios", b =>
                {
                    b.Property<int>("CurrenciesPortfoliosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CurrenciesPortfoliosId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("PortfolioId");

                    b.ToTable("CurrenciesPortfolios");
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

                    b.Property<double?>("MarketCap")
                        .HasColumnType("REAL");

                    b.Property<double?>("PercentChange1hr")
                        .HasColumnType("REAL");

                    b.Property<double?>("PercentChange24Hr")
                        .HasColumnType("REAL");

                    b.Property<double?>("PercentChange7d")
                        .HasColumnType("REAL");

                    b.Property<double?>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Slug")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Symbol")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<double?>("TotalSupply")
                        .HasColumnType("REAL");

                    b.Property<double?>("Volume24")
                        .HasColumnType("REAL");

                    b.HasKey("CurrencyId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("ASPdemo.Entities.Portfolio", b =>
                {
                    b.Property<int>("PortfolioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("PortfolioValue")
                        .HasColumnType("REAL");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WalletAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PortfolioId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Portfolios");
                });

            modelBuilder.Entity("ASPdemo.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<int>("PermissionsLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ASPdemo.Entities.UsersRoles", b =>
                {
                    b.Property<int>("UsersRolesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("UsersRolesId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("IdentityRole");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("IdentityRoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("IdentityUserClaim");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<string>("RolesId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UsersId")
                        .HasColumnType("TEXT");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("ASPdemo.Entities.Role", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ASPdemo.Entities.CurrenciesPortfolios", b =>
                {
                    b.HasOne("ASPdemo.Entities.Currency", "currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASPdemo.Entities.Portfolio", "portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("currency");

                    b.Navigation("portfolio");
                });

            modelBuilder.Entity("ASPdemo.Entities.Currency", b =>
                {
                    b.HasOne("ASPdemo.Entities.Category", null)
                        .WithMany("Coins")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASPdemo.Entities.Portfolio", b =>
                {
                    b.HasOne("ASPdemo.Entities.User", "user")
                        .WithOne("portfolio")
                        .HasForeignKey("ASPdemo.Entities.Portfolio", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("ASPdemo.Entities.UsersRoles", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", "role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASPdemo.Entities.User", "user")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("role");

                    b.Navigation("user");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("ASPdemo.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASPdemo.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASPdemo.Entities.Role", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithOne()
                        .HasForeignKey("ASPdemo.Entities.Role", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASPdemo.Entities.Category", b =>
                {
                    b.Navigation("Coins");
                });

            modelBuilder.Entity("ASPdemo.Entities.User", b =>
                {
                    b.Navigation("portfolio")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
