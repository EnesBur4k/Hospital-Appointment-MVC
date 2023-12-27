﻿// <auto-generated />
using System;
using B221210351.EFContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace B221210351.Migrations
{
    [DbContext(typeof(HastaneDbContext))]
    partial class HastaneDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("B221210351.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentId"), 1L, 1);

                    b.Property<int?>("AppUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AppointmentState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PoliclinicId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PoliclinicId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("B221210351.Models.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "668fd4a3-a6a8-4cd5-a468-cbab5619851d",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "49c8fe65-e3ac-4d2c-a496-b29bc7bdd25c",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("B221210351.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.Property<DateTime>("PatientBirthDay")
                        .HasColumnType("datetime2");

                    b.Property<bool>("PatientGender")
                        .HasColumnType("bit");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientPersonalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientSurname")
                        .IsRequired()
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

            modelBuilder.Entity("B221210351.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "İç Hastalıkları Anabilim Dalı"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "Kardiyoloji Anabilim Dalı"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "Göğüs Hastalıkları Anabilim Dalı"
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentName = "Çocuk Sağlığı ve Hastalıkları Anabilim Dalı"
                        },
                        new
                        {
                            DepartmentId = 5,
                            DepartmentName = "Ruh Sağlığı ve Hastalıkları Anabilim Dalı"
                        },
                        new
                        {
                            DepartmentId = 6,
                            DepartmentName = "Nöroloji Anabilim Dalı"
                        },
                        new
                        {
                            DepartmentId = 7,
                            DepartmentName = "Deri ve Zührevi Anabilim Dalı"
                        },
                        new
                        {
                            DepartmentId = 8,
                            DepartmentName = "Genel Cerrahi Anabilim Dalı"
                        });
                });

            modelBuilder.Entity("B221210351.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"), 1L, 1);

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<int>("PoliclinicId")
                        .HasColumnType("int");

                    b.HasKey("DoctorId");

                    b.HasIndex("PoliclinicId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            DoctorName = "Asım",
                            DoctorSurname = "Bar",
                            Gender = true,
                            PoliclinicId = 1
                        },
                        new
                        {
                            DoctorId = 2,
                            DoctorName = "Basım",
                            DoctorSurname = "Bar",
                            Gender = true,
                            PoliclinicId = 2
                        },
                        new
                        {
                            DoctorId = 3,
                            DoctorName = "Casım",
                            DoctorSurname = "Bar",
                            Gender = true,
                            PoliclinicId = 3
                        },
                        new
                        {
                            DoctorId = 4,
                            DoctorName = "Dasım",
                            DoctorSurname = "Bar",
                            Gender = true,
                            PoliclinicId = 4
                        },
                        new
                        {
                            DoctorId = 5,
                            DoctorName = "Esim",
                            DoctorSurname = "Bar",
                            Gender = true,
                            PoliclinicId = 5
                        },
                        new
                        {
                            DoctorId = 6,
                            DoctorName = "Fesim",
                            DoctorSurname = "Bar",
                            Gender = true,
                            PoliclinicId = 6
                        },
                        new
                        {
                            DoctorId = 7,
                            DoctorName = "Kesim",
                            DoctorSurname = "Bar",
                            Gender = true,
                            PoliclinicId = 7
                        },
                        new
                        {
                            DoctorId = 8,
                            DoctorName = "Lesim",
                            DoctorSurname = "Bar",
                            Gender = true,
                            PoliclinicId = 8
                        },
                        new
                        {
                            DoctorId = 9,
                            DoctorName = "Tesim",
                            DoctorSurname = "Bar",
                            Gender = true,
                            PoliclinicId = 9
                        },
                        new
                        {
                            DoctorId = 10,
                            DoctorName = "Resim",
                            DoctorSurname = "Bar",
                            Gender = true,
                            PoliclinicId = 10
                        });
                });

            modelBuilder.Entity("B221210351.Models.Policlinic", b =>
                {
                    b.Property<int>("PoliclinicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PoliclinicId"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("PoliclinicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PoliclinicId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Policlinics");

                    b.HasData(
                        new
                        {
                            PoliclinicId = 1,
                            DepartmentId = 1,
                            PoliclinicName = "Endokrinoloji ve Metabolizma Kliniği"
                        },
                        new
                        {
                            PoliclinicId = 2,
                            DepartmentId = 1,
                            PoliclinicName = "Gastroenteroloji Kliniği"
                        },
                        new
                        {
                            PoliclinicId = 3,
                            DepartmentId = 2,
                            PoliclinicName = "Kardiyoloji Kliniği"
                        },
                        new
                        {
                            PoliclinicId = 4,
                            DepartmentId = 3,
                            PoliclinicName = "Göğüs Hastalıkları Kliniği"
                        },
                        new
                        {
                            PoliclinicId = 5,
                            DepartmentId = 4,
                            PoliclinicName = "Çocuk Gastroenterolojisi Kliniği"
                        },
                        new
                        {
                            PoliclinicId = 6,
                            DepartmentId = 4,
                            PoliclinicName = "Çocuk Kardiyolojisi Kliniği"
                        },
                        new
                        {
                            PoliclinicId = 7,
                            DepartmentId = 5,
                            PoliclinicName = "Ruh Sağlığı ve Hastalıkları Kliniği"
                        },
                        new
                        {
                            PoliclinicId = 8,
                            DepartmentId = 6,
                            PoliclinicName = "Nöroloji Kliniği"
                        },
                        new
                        {
                            PoliclinicId = 9,
                            DepartmentId = 7,
                            PoliclinicName = "Deri ve Zührevi Hastalıklar Kliniği"
                        },
                        new
                        {
                            PoliclinicId = 10,
                            DepartmentId = 8,
                            PoliclinicName = "Genel Cerrahi Kliniği"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("B221210351.Models.Appointment", b =>
                {
                    b.HasOne("B221210351.Models.AppUser", "AppUser")
                        .WithMany("Appointments")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("B221210351.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("B221210351.Models.Policlinic", "Policlinic")
                        .WithMany("Appointments")
                        .HasForeignKey("PoliclinicId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Doctor");

                    b.Navigation("Policlinic");
                });

            modelBuilder.Entity("B221210351.Models.Doctor", b =>
                {
                    b.HasOne("B221210351.Models.Policlinic", "Policlinic")
                        .WithMany("Doctors")
                        .HasForeignKey("PoliclinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Policlinic");
                });

            modelBuilder.Entity("B221210351.Models.Policlinic", b =>
                {
                    b.HasOne("B221210351.Models.Department", "Department")
                        .WithMany("Policlinics")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("B221210351.Models.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("B221210351.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("B221210351.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("B221210351.Models.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("B221210351.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("B221210351.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("B221210351.Models.AppUser", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("B221210351.Models.Department", b =>
                {
                    b.Navigation("Policlinics");
                });

            modelBuilder.Entity("B221210351.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("B221210351.Models.Policlinic", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Doctors");
                });
#pragma warning restore 612, 618
        }
    }
}
