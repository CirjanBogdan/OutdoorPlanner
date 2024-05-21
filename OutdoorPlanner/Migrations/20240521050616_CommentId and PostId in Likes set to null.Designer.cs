﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OutdoorPlanner.Data;

#nullable disable

namespace OutdoorPlanner.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240521050616_CommentId and PostId in Likes set to null")]
    partial class CommentIdandPostIdinLikessettonull
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

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

            modelBuilder.Entity("OutdoorPlanner.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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
                });

            modelBuilder.Entity("OutdoorPlanner.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LikesNumber")
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("OutdoorPlanner.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("City")
                        .HasColumnType("int");

                    b.Property<int?>("CloudsValue")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Forcasted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Rain")
                        .HasColumnType("bit");

                    b.Property<int>("Temperature")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 1,
                            City = 2,
                            Date = new DateTime(2024, 5, 22, 9, 6, 15, 600, DateTimeKind.Local).AddTicks(9130),
                            Description = "Description",
                            Forcasted = false,
                            Name = "Untold Festival",
                            Rain = false,
                            Temperature = 0
                        },
                        new
                        {
                            Id = 2,
                            Category = 1,
                            City = 7,
                            Date = new DateTime(2024, 5, 24, 2, 6, 15, 600, DateTimeKind.Local).AddTicks(9192),
                            Description = "Massif Festival",
                            Forcasted = false,
                            Name = "Massif",
                            Rain = false,
                            Temperature = 0
                        },
                        new
                        {
                            Id = 3,
                            Category = 0,
                            City = 0,
                            Date = new DateTime(2024, 5, 24, 20, 6, 15, 600, DateTimeKind.Local).AddTicks(9195),
                            Description = "Description",
                            Forcasted = false,
                            Name = "Smiley Concert",
                            Rain = false,
                            Temperature = 0
                        },
                        new
                        {
                            Id = 4,
                            Category = 2,
                            City = 0,
                            Date = new DateTime(2024, 5, 25, 8, 6, 15, 600, DateTimeKind.Local).AddTicks(9198),
                            Description = "Biggest Food Festival",
                            Forcasted = false,
                            Name = "Bucharest Food Festival",
                            Rain = false,
                            Temperature = 0
                        },
                        new
                        {
                            Id = 5,
                            Category = 2,
                            City = 11,
                            Date = new DateTime(2024, 5, 22, 12, 6, 15, 600, DateTimeKind.Local).AddTicks(9201),
                            Description = "Food",
                            Forcasted = false,
                            Name = "Transylvania Brunch",
                            Rain = false,
                            Temperature = 0
                        },
                        new
                        {
                            Id = 6,
                            Category = 2,
                            City = 5,
                            Date = new DateTime(2024, 5, 24, 11, 6, 15, 600, DateTimeKind.Local).AddTicks(9204),
                            Description = "",
                            Forcasted = false,
                            Name = "International Wine Festival of Romania",
                            Rain = false,
                            Temperature = 0
                        },
                        new
                        {
                            Id = 7,
                            Category = 1,
                            City = 2,
                            Date = new DateTime(2024, 5, 21, 17, 6, 15, 600, DateTimeKind.Local).AddTicks(9207),
                            Description = "",
                            Forcasted = false,
                            Name = "Electric Castle",
                            Rain = false,
                            Temperature = 0
                        },
                        new
                        {
                            Id = 8,
                            Category = 0,
                            City = 4,
                            Date = new DateTime(2024, 5, 21, 8, 6, 15, 600, DateTimeKind.Local).AddTicks(9210),
                            Description = "",
                            Forcasted = false,
                            Name = "Past Event",
                            Rain = false,
                            Temperature = 0
                        });
                });

            modelBuilder.Entity("OutdoorPlanner.Models.Invitation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int?>("EventViewModelId")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("EventViewModelId");

                    b.ToTable("Invitations");
                });

            modelBuilder.Entity("OutdoorPlanner.Models.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CommentId")
                        .HasColumnType("int");

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("OutdoorPlanner.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CommentsNumber")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Edited")
                        .HasColumnType("bit");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("LikesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("OutdoorPlanner.Models.UserInvitation", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("InvitationId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "InvitationId");

                    b.HasIndex("InvitationId");

                    b.ToTable("UserInvitations");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.CommentCreateBindingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CommentCreateBindingModel");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.CommentViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CommentsAndPostViewModelId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LikesNumber")
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CommentsAndPostViewModelId");

                    b.ToTable("CommentViewModel");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.CommentsAndPostViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("PostViewModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostViewModelId");

                    b.ToTable("CommentsAndPostViewModel");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.CreateInvitationBindingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CreateInvitationBindingModel");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.EventViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("City")
                        .HasColumnType("int");

                    b.Property<int>("CloudsValue")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Forcasted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Rain")
                        .HasColumnType("bit");

                    b.Property<int>("Temperature")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EventViewModel");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.InvitationViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("EventName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InvitationId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InvitationViewModel");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.PostCreateBindingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int?>("EventViewModelId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EventViewModelId");

                    b.ToTable("PostCreateBindingModel");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.PostEditBindingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Edited")
                        .HasColumnType("bit");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int?>("EventViewModelId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EventViewModelId");

                    b.ToTable("PostEditBindingModel");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.PostViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CommentsNumber")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Edited")
                        .HasColumnType("bit");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("LikesNumber")
                        .HasColumnType("int");

                    b.Property<int?>("PostsEventViewModelId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PostsEventViewModelId");

                    b.ToTable("PostViewModel");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.PostsEventViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EventViewModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventViewModelId");

                    b.ToTable("PostsEventViewModel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OutdoorPlanner.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OutdoorPlanner.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OutdoorPlanner.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OutdoorPlanner.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OutdoorPlanner.Models.Comment", b =>
                {
                    b.HasOne("OutdoorPlanner.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OutdoorPlanner.Models.ApplicationUser", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OutdoorPlanner.Models.Event", b =>
                {
                    b.HasOne("OutdoorPlanner.Models.ApplicationUser", "User")
                        .WithMany("Events")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OutdoorPlanner.Models.Invitation", b =>
                {
                    b.HasOne("OutdoorPlanner.Models.Event", "Event")
                        .WithMany("Invitations")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OutdoorPlanner.ViewModels.EventViewModel", null)
                        .WithMany("Invitations")
                        .HasForeignKey("EventViewModelId");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("OutdoorPlanner.Models.Like", b =>
                {
                    b.HasOne("OutdoorPlanner.Models.Comment", "Comment")
                        .WithMany("Likes")
                        .HasForeignKey("CommentId");

                    b.HasOne("OutdoorPlanner.Models.Post", "Post")
                        .WithMany("Likes")
                        .HasForeignKey("PostId");

                    b.HasOne("OutdoorPlanner.Models.ApplicationUser", "User")
                        .WithMany("Likes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OutdoorPlanner.Models.Post", b =>
                {
                    b.HasOne("OutdoorPlanner.Models.Event", "Event")
                        .WithMany("Posts")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OutdoorPlanner.Models.ApplicationUser", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId");

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OutdoorPlanner.Models.UserInvitation", b =>
                {
                    b.HasOne("OutdoorPlanner.Models.Invitation", "Invitation")
                        .WithMany("UserInvitation")
                        .HasForeignKey("InvitationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OutdoorPlanner.Models.ApplicationUser", "User")
                        .WithMany("UserInvitations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invitation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.CommentViewModel", b =>
                {
                    b.HasOne("OutdoorPlanner.ViewModels.CommentsAndPostViewModel", null)
                        .WithMany("CommentsListViewModel")
                        .HasForeignKey("CommentsAndPostViewModelId");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.CommentsAndPostViewModel", b =>
                {
                    b.HasOne("OutdoorPlanner.ViewModels.PostViewModel", "PostViewModel")
                        .WithMany()
                        .HasForeignKey("PostViewModelId");

                    b.Navigation("PostViewModel");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.PostCreateBindingModel", b =>
                {
                    b.HasOne("OutdoorPlanner.ViewModels.EventViewModel", "EventViewModel")
                        .WithMany()
                        .HasForeignKey("EventViewModelId");

                    b.Navigation("EventViewModel");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.PostEditBindingModel", b =>
                {
                    b.HasOne("OutdoorPlanner.ViewModels.EventViewModel", "EventViewModel")
                        .WithMany()
                        .HasForeignKey("EventViewModelId");

                    b.Navigation("EventViewModel");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.PostViewModel", b =>
                {
                    b.HasOne("OutdoorPlanner.ViewModels.PostsEventViewModel", null)
                        .WithMany("PostsList")
                        .HasForeignKey("PostsEventViewModelId");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.PostsEventViewModel", b =>
                {
                    b.HasOne("OutdoorPlanner.ViewModels.EventViewModel", "EventViewModel")
                        .WithMany()
                        .HasForeignKey("EventViewModelId");

                    b.Navigation("EventViewModel");
                });

            modelBuilder.Entity("OutdoorPlanner.Models.ApplicationUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Events");

                    b.Navigation("Likes");

                    b.Navigation("Posts");

                    b.Navigation("UserInvitations");
                });

            modelBuilder.Entity("OutdoorPlanner.Models.Comment", b =>
                {
                    b.Navigation("Likes");
                });

            modelBuilder.Entity("OutdoorPlanner.Models.Event", b =>
                {
                    b.Navigation("Invitations");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("OutdoorPlanner.Models.Invitation", b =>
                {
                    b.Navigation("UserInvitation");
                });

            modelBuilder.Entity("OutdoorPlanner.Models.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Likes");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.CommentsAndPostViewModel", b =>
                {
                    b.Navigation("CommentsListViewModel");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.EventViewModel", b =>
                {
                    b.Navigation("Invitations");
                });

            modelBuilder.Entity("OutdoorPlanner.ViewModels.PostsEventViewModel", b =>
                {
                    b.Navigation("PostsList");
                });
#pragma warning restore 612, 618
        }
    }
}