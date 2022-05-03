﻿// <auto-generated />
using System;
using BlogSiteMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogSiteMVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220501094125_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArticleTopic", b =>
                {
                    b.Property<int>("ArticlesId")
                        .HasColumnType("int");

                    b.Property<int>("TopicsId")
                        .HasColumnType("int");

                    b.HasKey("ArticlesId", "TopicsId");

                    b.HasIndex("TopicsId");

                    b.ToTable("ArticleTopic");
                });

            modelBuilder.Entity("BlogSiteMVC.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalReadingTime")
                        .HasColumnType("float");

                    b.Property<int>("UserInformationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserInformationId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("BlogSiteMVC.Models.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("BlogSiteMVC.Models.UserInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("TopicId")
                        .HasColumnType("int");

                    b.Property<int>("UserRegisterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.HasIndex("UserRegisterId")
                        .IsUnique();

                    b.ToTable("UserInformations");
                });

            modelBuilder.Entity("BlogSiteMVC.Models.UserRegister", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRegisters");
                });

            modelBuilder.Entity("ArticleTopic", b =>
                {
                    b.HasOne("BlogSiteMVC.Models.Article", null)
                        .WithMany()
                        .HasForeignKey("ArticlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogSiteMVC.Models.Topic", null)
                        .WithMany()
                        .HasForeignKey("TopicsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogSiteMVC.Models.Article", b =>
                {
                    b.HasOne("BlogSiteMVC.Models.UserInformation", "UserInformation")
                        .WithMany("Articles")
                        .HasForeignKey("UserInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInformation");
                });

            modelBuilder.Entity("BlogSiteMVC.Models.UserInformation", b =>
                {
                    b.HasOne("BlogSiteMVC.Models.Topic", null)
                        .WithMany("UserInformations")
                        .HasForeignKey("TopicId");

                    b.HasOne("BlogSiteMVC.Models.UserRegister", "UserRegister")
                        .WithOne("UserInformation")
                        .HasForeignKey("BlogSiteMVC.Models.UserInformation", "UserRegisterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserRegister");
                });

            modelBuilder.Entity("BlogSiteMVC.Models.Topic", b =>
                {
                    b.Navigation("UserInformations");
                });

            modelBuilder.Entity("BlogSiteMVC.Models.UserInformation", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BlogSiteMVC.Models.UserRegister", b =>
                {
                    b.Navigation("UserInformation");
                });
#pragma warning restore 612, 618
        }
    }
}
