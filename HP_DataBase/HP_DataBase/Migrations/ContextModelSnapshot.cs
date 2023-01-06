﻿// <auto-generated />
using System;
using HP_DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HPDataBase.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HP_DataBase.Entity.EducationObjekt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EducationObjekts");
                });

            modelBuilder.Entity("HP_DataBase.Entity.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Element")
                        .HasColumnType("text");

                    b.Property<string>("Founder")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("ShoolNames")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ShoolNames");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("HP_DataBase.Entity.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<int?>("EducationObjektId")
                        .HasColumnType("integer");

                    b.Property<int>("FacultyId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("SecondName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EducationObjektId");

                    b.HasIndex("FacultyId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("HP_DataBase.Entity.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("HP_DataBase.Entity.Wand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Material")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("Wands");
                });

            modelBuilder.Entity("HP_DataBase.Entity.Faculty", b =>
                {
                    b.HasOne("HP_DataBase.Entity.School", "School")
                        .WithMany("Faculties")
                        .HasForeignKey("ShoolNames")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("HP_DataBase.Entity.Person", b =>
                {
                    b.HasOne("HP_DataBase.Entity.EducationObjekt", null)
                        .WithMany("People")
                        .HasForeignKey("EducationObjektId");

                    b.HasOne("HP_DataBase.Entity.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("HP_DataBase.Entity.Wand", b =>
                {
                    b.HasOne("HP_DataBase.Entity.Person", "Person")
                        .WithOne("Wand")
                        .HasForeignKey("HP_DataBase.Entity.Wand", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("HP_DataBase.Entity.EducationObjekt", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("HP_DataBase.Entity.Person", b =>
                {
                    b.Navigation("Wand");
                });

            modelBuilder.Entity("HP_DataBase.Entity.School", b =>
                {
                    b.Navigation("Faculties");
                });
#pragma warning restore 612, 618
        }
    }
}
