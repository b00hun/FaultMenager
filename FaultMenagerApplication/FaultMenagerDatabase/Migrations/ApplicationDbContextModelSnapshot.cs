﻿// <auto-generated />
using FaultMenagerBLL.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FaultMenager_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FaultMenager_Models.Models.Fault", b =>
                {
                    b.Property<int>("FaultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FaultId"), 1L, 1);

                    b.Property<int>("Category")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Desription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("FaultId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Faults");
                });

            modelBuilder.Entity("FaultMenager_Models.Models.Menager", b =>
                {
                    b.Property<int>("MenagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenagerId"), 1L, 1);

                    b.Property<string>("MenagerMail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MenagerName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("MenagerPhoneNumber")
                        .HasMaxLength(9)
                        .HasColumnType("int");

                    b.Property<string>("MenagerSurname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("MenagerId");

                    b.ToTable("Menagers");
                });

            modelBuilder.Entity("FaultMenager_Models.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"), 1L, 1);

                    b.Property<string>("ProjectAdress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("FaultMenager_Models.Models.RelationTables.ProjectMenager", b =>
                {
                    b.Property<int>("MenagerId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("MenagerId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectMenagers");
                });

            modelBuilder.Entity("FaultMenager_Models.Models.Fault", b =>
                {
                    b.HasOne("FaultMenager_Models.Models.Project", "Project")
                        .WithMany("Faults")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("FaultMenager_Models.Models.RelationTables.ProjectMenager", b =>
                {
                    b.HasOne("FaultMenager_Models.Models.Menager", "Menager")
                        .WithMany("ProjectMenagers")
                        .HasForeignKey("MenagerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FaultMenager_Models.Models.Project", "Project")
                        .WithMany("ProjectMenagers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menager");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("FaultMenager_Models.Models.Menager", b =>
                {
                    b.Navigation("ProjectMenagers");
                });

            modelBuilder.Entity("FaultMenager_Models.Models.Project", b =>
                {
                    b.Navigation("Faults");

                    b.Navigation("ProjectMenagers");
                });
#pragma warning restore 612, 618
        }
    }
}
