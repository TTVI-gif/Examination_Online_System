﻿// <auto-generated />
using System;
using ExaminationOnlineSystem.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExaminationOnlineSystem.Migrations
{
    [DbContext(typeof(ExamSystemDbContext))]
    partial class ExamSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ViTT2_API_OnlineTestSystem.Entities.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRight")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "a",
                            IsRight = true,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "b",
                            IsRight = false,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "c",
                            IsRight = false,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 4,
                            Content = "d",
                            IsRight = false,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 5,
                            Content = "a",
                            IsRight = false,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 6,
                            Content = "b",
                            IsRight = true,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 7,
                            Content = "c",
                            IsRight = false,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 8,
                            Content = "d",
                            IsRight = false,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 9,
                            Content = "a",
                            IsRight = true,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 10,
                            Content = "b",
                            IsRight = false,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 11,
                            Content = "c",
                            IsRight = false,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 12,
                            Content = "b",
                            IsRight = false,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 13,
                            Content = "a",
                            IsRight = false,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 14,
                            Content = "b",
                            IsRight = true,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 15,
                            Content = "c",
                            IsRight = false,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 16,
                            Content = "d",
                            IsRight = false,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 17,
                            Content = "a",
                            IsRight = false,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 18,
                            Content = "b",
                            IsRight = false,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 19,
                            Content = "c",
                            IsRight = false,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 20,
                            Content = "d",
                            IsRight = true,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 21,
                            Content = "a",
                            IsRight = true,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 22,
                            Content = "b",
                            IsRight = false,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 23,
                            Content = "c",
                            IsRight = false,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 24,
                            Content = "d",
                            IsRight = false,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 25,
                            Content = "a",
                            IsRight = false,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 26,
                            Content = "b",
                            IsRight = true,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 27,
                            Content = "c",
                            IsRight = false,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 28,
                            Content = "d",
                            IsRight = true,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 29,
                            Content = "a",
                            IsRight = false,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 30,
                            Content = "b",
                            IsRight = true,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 31,
                            Content = "c",
                            IsRight = false,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 32,
                            Content = "d",
                            IsRight = false,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 33,
                            Content = "a",
                            IsRight = false,
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 34,
                            Content = "b",
                            IsRight = false,
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 35,
                            Content = "c",
                            IsRight = true,
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 36,
                            Content = "d",
                            IsRight = false,
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 37,
                            Content = "a",
                            IsRight = false,
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 38,
                            Content = "b",
                            IsRight = true,
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 39,
                            Content = "c",
                            IsRight = false,
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 40,
                            Content = "d",
                            IsRight = false,
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 41,
                            Content = "a",
                            IsRight = false,
                            QuestionId = 11
                        },
                        new
                        {
                            Id = 42,
                            Content = "b",
                            IsRight = false,
                            QuestionId = 11
                        },
                        new
                        {
                            Id = 43,
                            Content = "c",
                            IsRight = true,
                            QuestionId = 11
                        },
                        new
                        {
                            Id = 44,
                            Content = "d",
                            IsRight = false,
                            QuestionId = 11
                        },
                        new
                        {
                            Id = 45,
                            Content = "a",
                            IsRight = false,
                            QuestionId = 12
                        },
                        new
                        {
                            Id = 46,
                            Content = "b",
                            IsRight = false,
                            QuestionId = 12
                        },
                        new
                        {
                            Id = 47,
                            Content = "c",
                            IsRight = false,
                            QuestionId = 12
                        },
                        new
                        {
                            Id = 48,
                            Content = "d",
                            IsRight = true,
                            QuestionId = 12
                        },
                        new
                        {
                            Id = 49,
                            Content = "a",
                            IsRight = false,
                            QuestionId = 13
                        },
                        new
                        {
                            Id = 50,
                            Content = "b",
                            IsRight = true,
                            QuestionId = 13
                        },
                        new
                        {
                            Id = 51,
                            Content = "c",
                            IsRight = true,
                            QuestionId = 13
                        },
                        new
                        {
                            Id = 52,
                            Content = "d",
                            IsRight = false,
                            QuestionId = 13
                        },
                        new
                        {
                            Id = 53,
                            Content = "a",
                            IsRight = false,
                            QuestionId = 14
                        },
                        new
                        {
                            Id = 54,
                            Content = "b",
                            IsRight = false,
                            QuestionId = 14
                        },
                        new
                        {
                            Id = 55,
                            Content = "c",
                            IsRight = true,
                            QuestionId = 14
                        },
                        new
                        {
                            Id = 56,
                            Content = "d",
                            IsRight = false,
                            QuestionId = 14
                        },
                        new
                        {
                            Id = 57,
                            Content = "a",
                            IsRight = true,
                            QuestionId = 15
                        },
                        new
                        {
                            Id = 58,
                            Content = "b",
                            IsRight = false,
                            QuestionId = 15
                        },
                        new
                        {
                            Id = 59,
                            Content = "c",
                            IsRight = false,
                            QuestionId = 15
                        },
                        new
                        {
                            Id = 60,
                            Content = "d",
                            IsRight = false,
                            QuestionId = 15
                        });
                });

            modelBuilder.Entity("ViTT2_API_OnlineTestSystem.Entities.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<int>("QuestionAmount")
                        .HasColumnType("int");

                    b.Property<decimal>("Score")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Exam");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Final C#",
                            Duration = 90,
                            QuestionAmount = 5,
                            Score = 10m
                        },
                        new
                        {
                            Id = 2,
                            Content = "Final SQL",
                            Duration = 90,
                            QuestionAmount = 5,
                            Score = 10m
                        },
                        new
                        {
                            Id = 3,
                            Content = "Final EF",
                            Duration = 90,
                            QuestionAmount = 5,
                            Score = 10m
                        });
                });

            modelBuilder.Entity("ViTT2_API_OnlineTestSystem.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.ToTable("Question");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "1 + 1",
                            ExamId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "2 + 2",
                            ExamId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "1 + 3",
                            ExamId = 3
                        },
                        new
                        {
                            Id = 4,
                            Content = "2 + 2",
                            ExamId = 3
                        },
                        new
                        {
                            Id = 5,
                            Content = "1 + 1",
                            ExamId = 3
                        },
                        new
                        {
                            Id = 6,
                            Content = "Tieng cho sua?",
                            ExamId = 2
                        },
                        new
                        {
                            Id = 7,
                            Content = "Tieng meo keu?",
                            ExamId = 2
                        },
                        new
                        {
                            Id = 8,
                            Content = "2 * 2",
                            ExamId = 2
                        },
                        new
                        {
                            Id = 9,
                            Content = "syntax store procedure",
                            ExamId = 2
                        },
                        new
                        {
                            Id = 10,
                            Content = "Join la gi?",
                            ExamId = 2
                        },
                        new
                        {
                            Id = 11,
                            Content = "DbContext",
                            ExamId = 3
                        },
                        new
                        {
                            Id = 12,
                            Content = "Fluent API",
                            ExamId = 3
                        },
                        new
                        {
                            Id = 13,
                            Content = "Make http request",
                            ExamId = 3
                        },
                        new
                        {
                            Id = 14,
                            Content = "route",
                            ExamId = 3
                        },
                        new
                        {
                            Id = 15,
                            Content = "Data anotation",
                            ExamId = 3
                        });
                });

            modelBuilder.Entity("ViTT2_API_OnlineTestSystem.Entities.QuestionRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("A")
                        .HasColumnType("bit");

                    b.Property<bool>("B")
                        .HasColumnType("bit");

                    b.Property<bool>("C")
                        .HasColumnType("bit");

                    b.Property<bool>("D")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("StudentDoExemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("QuestionRecord");
                });

            modelBuilder.Entity("ViTT2_API_OnlineTestSystem.Entities.StudentDoExam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateDoExam")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<decimal>("Score")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Survey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentDoExam");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateDoExam = new DateTime(2022, 6, 14, 0, 13, 8, 8, DateTimeKind.Local).AddTicks(1977),
                            ExamId = 1,
                            Score = 6m,
                            StudentId = 1,
                            Survey = "good"
                        },
                        new
                        {
                            Id = 2,
                            DateDoExam = new DateTime(2022, 6, 14, 0, 13, 8, 8, DateTimeKind.Local).AddTicks(3141),
                            ExamId = 2,
                            Score = 8m,
                            StudentId = 1,
                            Survey = "good"
                        },
                        new
                        {
                            Id = 3,
                            DateDoExam = new DateTime(2022, 6, 14, 0, 13, 8, 8, DateTimeKind.Local).AddTicks(3146),
                            ExamId = 3,
                            Score = 7m,
                            StudentId = 1,
                            Survey = "good"
                        });
                });

            modelBuilder.Entity("ViTT2_API_OnlineTestSystem.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay")
                        .HasMaxLength(30)
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasMaxLength(30)
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("scoreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDay = new DateTime(2022, 6, 14, 0, 13, 8, 7, DateTimeKind.Local).AddTicks(999),
                            Email = "vi@gmail.com",
                            FirstName = "student",
                            LastName = "student",
                            Password = "8EV+KQXOH/AoAFLogVtXBkaTYSYIENM3TmFxdQ51jFA=",
                            PhoneNumber = "123456789",
                            Role = 0,
                            Salt = "36QMZig4rhy6MqXvLezwsg==",
                            UserName = "student",
                            scoreId = 1
                        },
                        new
                        {
                            Id = 2,
                            BirthDay = new DateTime(2022, 6, 14, 0, 13, 8, 8, DateTimeKind.Local).AddTicks(1167),
                            Email = "teacher@gmail.com",
                            FirstName = "Teacher",
                            LastName = "Teacher",
                            Password = "HJsgtnmQbtXkRBDqlFaV9Izotrt7V/kFBq/S8hup2cg=",
                            PhoneNumber = "123456789",
                            Role = 2,
                            Salt = "JhMo1Weqm04bK5sFMe1lmA==",
                            UserName = "teacher"
                        },
                        new
                        {
                            Id = 3,
                            BirthDay = new DateTime(2022, 6, 14, 0, 13, 8, 8, DateTimeKind.Local).AddTicks(1186),
                            Email = "admin@gmail.com",
                            FirstName = "admin",
                            LastName = "admin",
                            Password = "l9njb+XPV9ttNEzhbHtHDqbf1o63TtffxUzfDj6AlMc=",
                            PhoneNumber = "635478921",
                            Role = 1,
                            Salt = "pdQFAj9pdPRMRLpYijKnaQ==",
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("ViTT2_API_OnlineTestSystem.Entities.Answer", b =>
                {
                    b.HasOne("ViTT2_API_OnlineTestSystem.Entities.Question", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ViTT2_API_OnlineTestSystem.Entities.Question", b =>
                {
                    b.HasOne("ViTT2_API_OnlineTestSystem.Entities.Exam", null)
                        .WithMany("Questions")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ViTT2_API_OnlineTestSystem.Entities.StudentDoExam", b =>
                {
                    b.HasOne("ViTT2_API_OnlineTestSystem.Entities.User", "Student")
                        .WithMany("StudentDoExams")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ViTT2_API_OnlineTestSystem.Entities.Exam", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("ViTT2_API_OnlineTestSystem.Entities.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("ViTT2_API_OnlineTestSystem.Entities.User", b =>
                {
                    b.Navigation("StudentDoExams");
                });
#pragma warning restore 612, 618
        }
    }
}
