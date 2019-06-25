﻿// <auto-generated />
using LCMWebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LCMWebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190625093637_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LCMWebAPI.Models.AlgorithmType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("AlgorithmTypes");
                });

            modelBuilder.Entity("LCMWebAPI.Models.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlgorithmTypeId");

                    b.Property<string>("Inputs")
                        .IsRequired();

                    b.Property<string>("Result");

                    b.Property<string>("SpaceComplexity");

                    b.Property<string>("TimeComplexity");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AlgorithmTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("LCMWebAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LCMWebAPI.Models.History", b =>
                {
                    b.HasOne("LCMWebAPI.Models.AlgorithmType", "AlgorithmType")
                        .WithMany()
                        .HasForeignKey("AlgorithmTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LCMWebAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
