﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MuhmadOmarHajHamdo.Context;

#nullable disable

namespace MuhmadOmarHajHamdo.Entities
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240517205505_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MuhmadOmarHajHamdo.Entities.employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BirthYear")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id")
                        .HasName("Id");

                    b.HasIndex(new[] { "Name" }, "UQ__employee__737584F665429F01")
                        .IsUnique();

                    b.HasIndex(new[] { "PhoneNumber" }, "UQ__employee__85FB4E3895EBB785")
                        .IsUnique()
                        .HasFilter("[PhoneNumber] IS NOT NULL");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("MuhmadOmarHajHamdo.Entities.salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<double>("Mount")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__salaries__3214EC072BCA6AD6");

                    b.HasIndex("UserId");

                    b.ToTable("salaries");
                });

            modelBuilder.Entity("MuhmadOmarHajHamdo.Entities.test", b =>
                {
                    b.Property<int>("column_name")
                        .HasColumnType("int");

                    b.HasKey("column_name")
                        .HasName("tests_pk");

                    b.ToTable("tests");
                });

            modelBuilder.Entity("MuhmadOmarHajHamdo.Entities.salary", b =>
                {
                    b.HasOne("MuhmadOmarHajHamdo.Entities.employee", "User")
                        .WithMany("salaries")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("employeeId__fk");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MuhmadOmarHajHamdo.Entities.employee", b =>
                {
                    b.Navigation("salaries");
                });
#pragma warning restore 612, 618
        }
    }
}
