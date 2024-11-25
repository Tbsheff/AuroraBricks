﻿// <auto-generated />
using System;
using Intex.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Intex.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20241124192500_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-preview.1.24081.2");

            modelBuilder.Entity("AspNetUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Intex.Models.AspNetRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedName" }, "RoleNameIndex")
                        .IsUnique()
                        .HasFilter("([NormalizedName] IS NOT NULL)");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Intex.Models.AspNetRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetRoleClaims_RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Intex.Models.AspNetUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "NormalizedEmail" }, "EmailIndex");

                    b.HasIndex(new[] { "NormalizedUserName" }, "UserNameIndex")
                        .IsUnique()
                        .HasFilter("([NormalizedUserName] IS NOT NULL)");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Intex.Models.AspNetUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserClaims_UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Intex.Models.AspNetUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserLogins_UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Intex.Models.AspNetUserToken", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Intex.Models.Bank", b =>
                {
                    b.Property<byte>("bank_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("bank_id");

                    b.ToTable("bank", (string)null);
                });

            modelBuilder.Entity("Intex.Models.Card_Type", b =>
                {
                    b.Property<byte>("card_type_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("card_type_id");

                    b.ToTable("card_type", (string)null);
                });

            modelBuilder.Entity("Intex.Models.Category", b =>
                {
                    b.Property<byte>("category_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("category_id");

                    b.ToTable("category", (string)null);
                });

            modelBuilder.Entity("Intex.Models.Customer", b =>
                {
                    b.Property<short>("customer_ID")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("age")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("birth_date")
                        .HasColumnType("TEXT");

                    b.Property<string>("country_of_residence")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("customer_ID");

                    b.ToTable("customer", (string)null);
                });

            modelBuilder.Entity("Intex.Models.Customer_Recommendation", b =>
                {
                    b.Property<int>("customer_id")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_1")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_10")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_2")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_3")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_4")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_5")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_6")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_7")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_8")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_9")
                        .HasColumnType("INTEGER");

                    b.HasKey("customer_id");

                    b.ToTable("customer_recommendation", (string)null);
                });

            modelBuilder.Entity("Intex.Models.Entry_Mode", b =>
                {
                    b.Property<byte>("entry_mode_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("entry_mode_id");

                    b.ToTable("entry_mode", (string)null);
                });

            modelBuilder.Entity("Intex.Models.Line_Item", b =>
                {
                    b.Property<int>("index")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("product_ID")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("qty")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("rating")
                        .HasColumnType("INTEGER");

                    b.Property<int>("transaction_ID")
                        .HasColumnType("INTEGER");

                    b.ToTable("line_item", (string)null);
                });

            modelBuilder.Entity("Intex.Models.Order", b =>
                {
                    b.Property<int>("transaction_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<short>("amount")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("bank_id")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("card_type_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("country_of_transaction")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("customer_ID")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("date")
                        .HasColumnType("TEXT");

                    b.Property<string>("day_of_week")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<byte>("entry_mode_id")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("fraud")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("hour")
                        .HasColumnType("INTEGER");

                    b.Property<string>("shipping_address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<byte>("transaction_type_id")
                        .HasColumnType("INTEGER");

                    b.HasKey("transaction_ID");

                    b.ToTable("order", (string)null);
                });

            modelBuilder.Entity("Intex.Models.Product", b =>
                {
                    b.Property<byte>("product_id")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("category_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(2750)
                        .HasColumnType("TEXT");

                    b.Property<string>("img_link")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<short>("num_parts")
                        .HasColumnType("INTEGER");

                    b.Property<short>("price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("primary_color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("secondary_color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<short>("year")
                        .HasColumnType("INTEGER");

                    b.HasKey("product_id");

                    b.ToTable("product", (string)null);
                });

            modelBuilder.Entity("Intex.Models.Product_Recommendation", b =>
                {
                    b.Property<byte>("product_ID")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_1")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_10")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_2")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_3")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_4")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_5")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_6")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_7")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_8")
                        .HasColumnType("INTEGER");

                    b.Property<byte>("recommendation_9")
                        .HasColumnType("INTEGER");

                    b.ToTable("product_recommendation", (string)null);
                });

            modelBuilder.Entity("Intex.Models.Rating", b =>
                {
                    b.Property<byte>("product_ID")
                        .HasColumnType("INTEGER");

                    b.Property<double>("rating1")
                        .HasColumnType("REAL")
                        .HasColumnName("rating");

                    b.HasKey("product_ID");

                    b.ToTable("rating", (string)null);
                });

            modelBuilder.Entity("Intex.Models.Transaction_Type", b =>
                {
                    b.Property<byte>("transaction_type_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("transaction_type_id");

                    b.ToTable("transaction_type", (string)null);
                });

            modelBuilder.Entity("Intex.Models.User", b =>
                {
                    b.Property<short>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("user_id");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("AspNetUserRole", b =>
                {
                    b.HasOne("Intex.Models.AspNetRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intex.Models.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Intex.Models.AspNetRoleClaim", b =>
                {
                    b.HasOne("Intex.Models.AspNetRole", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Intex.Models.AspNetUserClaim", b =>
                {
                    b.HasOne("Intex.Models.AspNetUser", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Intex.Models.AspNetUserLogin", b =>
                {
                    b.HasOne("Intex.Models.AspNetUser", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Intex.Models.AspNetUserToken", b =>
                {
                    b.HasOne("Intex.Models.AspNetUser", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Intex.Models.Customer", b =>
                {
                    b.HasOne("Intex.Models.User", "User")
                        .WithOne("Customer")
                        .HasForeignKey("Intex.Models.Customer", "customer_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Intex.Models.AspNetRole", b =>
                {
                    b.Navigation("AspNetRoleClaims");
                });

            modelBuilder.Entity("Intex.Models.AspNetUser", b =>
                {
                    b.Navigation("AspNetUserClaims");

                    b.Navigation("AspNetUserLogins");

                    b.Navigation("AspNetUserTokens");
                });

            modelBuilder.Entity("Intex.Models.User", b =>
                {
                    b.Navigation("Customer")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
