﻿// <auto-generated />
using System;
using ASPdemo.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPdemo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240328010241_identity327")]
    partial class identity327
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

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

            modelBuilder.Entity("ASPdemo.Entities.Portfolio", b =>
                {
                    b.Property<int>("PortfolioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("PortfolioValue")
                        .HasColumnType("REAL");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");
                    
                    b.Property<string>("WalletAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PortfolioId");

                    b.ToTable("portfolio");
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
            // modelBuilder.Entity("ASPdemo.Entities.User", b =>
            //     {
            //         b.HasOne("ASPdemo.Entities.User", null)
            //             .WithMany("Users")
            //             .HasForeignKey("UserId")
            //             .OnDelete(DeleteBehavior.Cascade)
            //             .IsRequired();
            //     });
            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Roles");
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
             //         ADDITIONS
            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b => //ROLES TO IDENTITYROLECLAIM One-to-Many
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", null)
                        .WithMany("Roles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b => //USERS TO IDENTITYUSERCLAIM One-to-Many
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", null)
                        .WithMany("Users")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
            modelBuilder.Entity("ASPdemo.Entities.Portfolio", b => //PORTFOLIO TO USER - One to One
                {
                    b.HasOne("ASPdemo.Entities.User", null)
                        .WithOne("User")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
            modelBuilder.Entity("ASPdemo.Entities.UsersRoles", b => //USERSROLES RoleId TO USERS One to Many
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany("Users")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
            modelBuilder.Entity("ASPdemo.Entities.UsersRoles", b => //USERSROLES UserId TO ROLES One to Many
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany("Roles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
            //End additions





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
