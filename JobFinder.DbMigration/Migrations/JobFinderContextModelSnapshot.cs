﻿// <auto-generated />
using JobFinder.Domain.Common;
using JobFinder.Domain.Users;
using JobFinder.Infrastructure.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace JobFinder.DbMigration.Migrations
{
    [DbContext(typeof(JobFinderContext))]
    partial class JobFinderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JobFinder.Domain.Applications.Entities.JobApplication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ProfessionId");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionId");

                    b.HasIndex("UserId");

                    b.ToTable("JobApplication","JobFinder");
                });

            modelBuilder.Entity("JobFinder.Domain.CVs.Entities.CV", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AboutYou");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("RoleTitle");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("CV","JobFinder");
                });

            modelBuilder.Entity("JobFinder.Domain.CVs.Entities.CVCertificate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CVId");

                    b.Property<string>("CertificateName");

                    b.Property<DateTime>("FinishDate");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("CVCertificate");
                });

            modelBuilder.Entity("JobFinder.Domain.CVs.Entities.CVEducation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CVId");

                    b.Property<string>("Description");

                    b.Property<DateTime>("FinishDate");

                    b.Property<string>("SchoolName");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("CVEducation");
                });

            modelBuilder.Entity("JobFinder.Domain.CVs.Entities.CVExperience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CVId");

                    b.Property<string>("Company");

                    b.Property<string>("Description");

                    b.Property<DateTime>("FinishDate");

                    b.Property<string>("Role");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("CVExperience");
                });

            modelBuilder.Entity("JobFinder.Domain.CVs.Entities.CVSkill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CVId");

                    b.Property<string>("Skill");

                    b.Property<int>("SkillLevel");

                    b.HasKey("Id");

                    b.HasIndex("CVId");

                    b.ToTable("CVSkill");
                });

            modelBuilder.Entity("JobFinder.Domain.Offers.Entities.Offer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ProfessionId");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionId");

                    b.HasIndex("UserId");

                    b.ToTable("Offer","JobFinder");
                });

            modelBuilder.Entity("JobFinder.Domain.Professions.Entities.Profession", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CategoryId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Profession","JobFinder");
                });

            modelBuilder.Entity("JobFinder.Domain.Professions.Entities.ProfessionCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ProfessionCategory","JobFinder");
                });

            modelBuilder.Entity("JobFinder.Domain.Professions.Entities.ProposedSkill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<Guid>("ProfessionId");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionId");

                    b.ToTable("ProposedSkill","JobFinder");
                });

            modelBuilder.Entity("JobFinder.Domain.Users.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Email");

                    b.Property<DateTime>("LastLoginDate");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Salt");

                    b.Property<string>("Surname");

                    b.Property<int>("UserType");

                    b.HasKey("Id");

                    b.ToTable("User","JobFinder");
                });

            modelBuilder.Entity("JobFinder.Domain.Applications.Entities.JobApplication", b =>
                {
                    b.HasOne("JobFinder.Domain.Professions.Entities.Profession", "Profession")
                        .WithMany()
                        .HasForeignKey("ProfessionId");

                    b.HasOne("JobFinder.Domain.Users.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("JobFinder.Domain.CVs.Entities.CVCertificate", b =>
                {
                    b.HasOne("JobFinder.Domain.CVs.Entities.CV")
                        .WithMany("Certifications")
                        .HasForeignKey("CVId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JobFinder.Domain.CVs.Entities.CVEducation", b =>
                {
                    b.HasOne("JobFinder.Domain.CVs.Entities.CV")
                        .WithMany("Educations")
                        .HasForeignKey("CVId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JobFinder.Domain.CVs.Entities.CVExperience", b =>
                {
                    b.HasOne("JobFinder.Domain.CVs.Entities.CV")
                        .WithMany("Experience")
                        .HasForeignKey("CVId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JobFinder.Domain.CVs.Entities.CVSkill", b =>
                {
                    b.HasOne("JobFinder.Domain.CVs.Entities.CV")
                        .WithMany("Skills")
                        .HasForeignKey("CVId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JobFinder.Domain.Offers.Entities.Offer", b =>
                {
                    b.HasOne("JobFinder.Domain.Professions.Entities.Profession", "Profession")
                        .WithMany()
                        .HasForeignKey("ProfessionId");

                    b.HasOne("JobFinder.Domain.Users.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("JobFinder.Domain.Professions.Entities.Profession", b =>
                {
                    b.HasOne("JobFinder.Domain.Professions.Entities.ProfessionCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("JobFinder.Domain.Professions.Entities.ProposedSkill", b =>
                {
                    b.HasOne("JobFinder.Domain.Professions.Entities.Profession")
                        .WithMany("ProposedSkills")
                        .HasForeignKey("ProfessionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
