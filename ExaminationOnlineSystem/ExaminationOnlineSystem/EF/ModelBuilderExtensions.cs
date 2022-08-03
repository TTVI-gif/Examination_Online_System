using ExaminationOnlineSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ExaminationOnlineSystem.EF
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //seed data for Exam
            modelBuilder.Entity<Exam>().HasData(
                new Exam
                {
                    Id = 1,
                    Content = "Final C#",
                    Duration = 90,
                    Score = 10,
                    QuestionAmount = 5
                },
                new Exam
                {
                    Id = 2,
                    Content = "Final SQL",
                    Duration = 90,
                    Score = 10,
                    QuestionAmount = 5
                },
                new Exam
                {
                    Id = 3,
                    Content = "Final EF",
                    Duration = 90,
                    Score = 10,
                    QuestionAmount = 5
                }); ;

            //seed data for Question
            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    Content = "1 + 1",
                    ExamId = 1
                },
                new Question
                {
                    Id = 2,
                    Content = "2 + 2",
                    ExamId = 1
                },
                new Question
                {
                    Id = 3,
                    Content = "1 + 3",
                    ExamId = 3
                },
                new Question
                {
                    Id = 4,
                    Content = "2 + 2",
                    ExamId = 3
                },
                new Question
                {
                    Id = 5,
                    Content = "1 + 1",
                    ExamId = 3
                },
                new Question
                {
                    Id = 6,
                    Content = "Tieng cho sua?",
                    ExamId = 2
                },
                new Question
                {
                    Id = 7,
                    Content = "Tieng meo keu?",
                    ExamId = 2
                },
                new Question
                {
                    Id = 8,
                    Content = "2 * 2",
                    ExamId = 2
                },
                new Question
                {
                    Id = 9,
                    Content = "syntax store procedure",
                    ExamId = 2
                },
                new Question
                {
                    Id = 10,
                    Content = "Join la gi?",
                    ExamId = 2
                },
                new Question
                {
                    Id = 11,
                    Content = "DbContext",
                    ExamId = 3
                },
                new Question
                {
                    Id = 12,
                    Content = "Fluent API",
                    ExamId = 3
                },
                new Question
                {
                    Id = 13,
                    Content = "Make http request",
                    ExamId = 3
                },
                new Question
                {
                    Id = 14,
                    Content = "route",
                    ExamId = 3
                },
                new Question
                {
                    Id = 15,
                    Content = "Data anotation",
                    ExamId = 3
                });

            modelBuilder.Entity<Answer>().HasData(
                //answer cau 1
                new Answer
                {
                    Id = 1,
                    Content = "a",
                    IsRight = true,
                    QuestionId = 1
                },
                new Answer
                {
                    Id = 2,
                    Content = "b",
                    IsRight = false,
                    QuestionId = 1
                },
                new Answer
                {
                    Id = 3,
                    Content = "c",
                    IsRight = false,
                    QuestionId = 1
                },
                new Answer
                {
                    Id = 4,
                    Content = "d",
                    IsRight = false,
                    QuestionId = 1
                },
                //answer cau 2
                new Answer
                {
                    Id = 5,
                    Content = "a",
                    IsRight = false,
                    QuestionId = 2
                },
                new Answer
                {
                    Id = 6,
                    Content = "b",
                    IsRight = true,
                    QuestionId = 2
                },
                new Answer
                {
                    Id = 7,
                    Content = "c",
                    IsRight = false,
                    QuestionId = 2
                },
                new Answer
                {
                    Id = 8,
                    Content = "d",
                    IsRight = false,
                    QuestionId = 2
                },
                //answer cau 3
                new Answer
                {
                    Id = 9,
                    Content = "a",
                    IsRight = true,
                    QuestionId = 3
                },
                new Answer
                {
                    Id = 10,
                    Content = "b",
                    IsRight = false,
                    QuestionId = 3
                },
                new Answer
                {
                    Id = 11,
                    Content = "c",
                    IsRight = false,
                    QuestionId = 3
                },
                new Answer
                {
                    Id = 12,
                    Content = "b",
                    IsRight = false,
                    QuestionId = 3
                },
                //answer cau 4
                new Answer
                {
                    Id = 13,
                    Content = "a",
                    IsRight = false,
                    QuestionId = 4
                },
                new Answer
                {
                    Id = 14,
                    Content = "b",
                    IsRight = true,
                    QuestionId = 4
                },
                new Answer
                {
                    Id = 15,
                    Content = "c",
                    IsRight = false,
                    QuestionId = 4
                },
                new Answer
                {
                    Id = 16,
                    Content = "d",
                    IsRight = false,
                    QuestionId = 4
                },
                //answer cau 5
                new Answer
                {
                    Id = 17,
                    Content = "a",
                    IsRight = false,
                    QuestionId = 5
                },
                new Answer
                {
                    Id = 18,
                    Content = "b",
                    IsRight = false,
                    QuestionId = 5
                },
                new Answer
                {
                    Id = 19,
                    Content = "c",
                    IsRight = false,
                    QuestionId = 5
                },
                new Answer
                {
                    Id = 20,
                    Content = "d",
                    IsRight = true,
                    QuestionId = 5
                },
                //answer cau 6
                new Answer
                {
                    Id = 21,
                    Content = "a",
                    IsRight = true,
                    QuestionId = 6
                },
                new Answer
                {
                    Id = 22,
                    Content = "b",
                    IsRight = false,
                    QuestionId = 6
                },
                new Answer
                {
                    Id = 23,
                    Content = "c",
                    IsRight = false,
                    QuestionId = 6
                },
                new Answer
                {
                    Id = 24,
                    Content = "d",
                    IsRight = false,
                    QuestionId = 6
                },
                //answer cau 7
                new Answer
                {
                    Id = 25,
                    Content = "a",
                    IsRight = false,
                    QuestionId = 7
                },
                new Answer
                {
                    Id = 26,
                    Content = "b",
                    IsRight = true,
                    QuestionId = 7
                },
                new Answer
                {
                    Id = 27,
                    Content = "c",
                    IsRight = false,
                    QuestionId = 7
                },
                new Answer
                {
                    Id = 28,
                    Content = "d",
                    IsRight = true,
                    QuestionId = 7
                },
                //answer cau 8
                new Answer
                {
                    Id = 29,
                    Content = "a",
                    IsRight = false,
                    QuestionId = 8
                },
                new Answer
                {
                    Id = 30,
                    Content = "b",
                    IsRight = true,
                    QuestionId = 8
                },
                new Answer
                {
                    Id = 31,
                    Content = "c",
                    IsRight = false,
                    QuestionId = 8
                },
                new Answer
                {
                    Id = 32,
                    Content = "d",
                    IsRight = false,
                    QuestionId = 8
                },
                //answer cau 9
                new Answer
                {
                    Id = 33,
                    Content = "a",
                    IsRight = false,
                    QuestionId = 9
                },
                new Answer
                {
                    Id = 34,
                    Content = "b",
                    IsRight = false,
                    QuestionId = 9
                },
                new Answer
                {
                    Id = 35,
                    Content = "c",
                    IsRight = true,
                    QuestionId = 9
                },
                new Answer
                {
                    Id = 36,
                    Content = "d",
                    IsRight = false,
                    QuestionId = 9
                },
                //answer cau 10
                new Answer
                {
                    Id = 37,
                    Content = "a",
                    IsRight = false,
                    QuestionId = 10
                },
                new Answer
                {
                    Id = 38,
                    Content = "b",
                    IsRight = true,
                    QuestionId = 10
                },
                new Answer
                {
                    Id = 39,
                    Content = "c",
                    IsRight = false,
                    QuestionId = 10
                },
                new Answer
                {
                    Id = 40,
                    Content = "d",
                    IsRight = false,
                    QuestionId = 10
                },
                //answer cau 11
                new Answer
                {
                    Id = 41,
                    Content = "a",
                    IsRight = false,
                    QuestionId = 11
                },
                new Answer
                {
                    Id = 42,
                    Content = "b",
                    IsRight = false,
                    QuestionId = 11
                },
                new Answer
                {
                    Id = 43,
                    Content = "c",
                    IsRight = true,
                    QuestionId = 11
                },
                new Answer
                {
                    Id = 44,
                    Content = "d",
                    IsRight = false,
                    QuestionId = 11
                },
                //answer cau 12
                new Answer
                {
                    Id = 45,
                    Content = "a",
                    IsRight = false,
                    QuestionId = 12
                },
                new Answer
                {
                    Id = 46,
                    Content = "b",
                    IsRight = false,
                    QuestionId = 12
                },
                new Answer
                {
                    Id = 47,
                    Content = "c",
                    IsRight = false,
                    QuestionId = 12
                },
                new Answer
                {
                    Id = 48,
                    Content = "d",
                    IsRight = true,
                    QuestionId = 12
                },
                //answer cau 13
                new Answer
                {
                    Id = 49,
                    Content = "a",
                    IsRight = false,
                    QuestionId = 13
                },
                new Answer
                {
                    Id = 50,
                    Content = "b",
                    IsRight = true,
                    QuestionId = 13
                },
                new Answer
                {
                    Id = 51,
                    Content = "c",
                    IsRight = true,
                    QuestionId = 13
                },
                new Answer
                {
                    Id = 52,
                    Content = "d",
                    IsRight = false,
                    QuestionId = 13
                },
                //answer cau 14
                new Answer
                {
                    Id = 53,
                    Content = "a",
                    IsRight = false,
                    QuestionId = 14
                },
                new Answer
                {
                    Id = 54,
                    Content = "b",
                    IsRight = false,
                    QuestionId = 14
                },
                new Answer
                {
                    Id = 55,
                    Content = "c",
                    IsRight = true,
                    QuestionId = 14
                },
                new Answer
                {
                    Id = 56,
                    Content = "d",
                    IsRight = false,
                    QuestionId = 14
                },
                //answer cau 15
                new Answer
                {
                    Id = 57,
                    Content = "a",
                    IsRight = true,
                    QuestionId = 15
                },
                new Answer
                {
                    Id = 58,
                    Content = "b",
                    IsRight = false,
                    QuestionId = 15
                },
                new Answer
                {
                    Id = 59,
                    Content = "c",
                    IsRight = false,
                    QuestionId = 15
                },
                new Answer
                {
                    Id = 60,
                    Content = "d",
                    IsRight = false,
                    QuestionId = 15
                });

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "student",
                    LastName = "student",
                    BirthDay = DateTime.Now,
                    UserName = "student",
                    Password = "8EV+KQXOH/AoAFLogVtXBkaTYSYIENM3TmFxdQ51jFA=",
                    Role = Enum.Role.Student,
                    PhoneNumber = "123456789",
                    Email = "vi@gmail.com",
                    scoreId = 1,
                    Salt = "36QMZig4rhy6MqXvLezwsg=="
                },
                new User
                {
                    Id = 2,
                    FirstName = "Teacher",
                    LastName = "Teacher",
                    BirthDay = DateTime.Now,
                    UserName = "teacher",
                    Password = "HJsgtnmQbtXkRBDqlFaV9Izotrt7V/kFBq/S8hup2cg=",
                    Role = Enum.Role.Teacher,
                    PhoneNumber = "123456789",
                    Email = "teacher@gmail.com",
                    Salt = "JhMo1Weqm04bK5sFMe1lmA=="
                },
                new User
                {
                    Id = 3,
                    FirstName = "admin",
                    LastName = "admin",
                    BirthDay = DateTime.Now,
                    UserName = "admin",
                    Password = "l9njb+XPV9ttNEzhbHtHDqbf1o63TtffxUzfDj6AlMc=",
                    Role = Enum.Role.Admin,
                    PhoneNumber = "635478921",
                    Email = "admin@gmail.com",
                    Salt = "pdQFAj9pdPRMRLpYijKnaQ=="
                });

            modelBuilder.Entity<StudentDoExam>().HasData(
               new StudentDoExam
               {
                   Id = 1,
                   DateDoExam = DateTime.Now,
                   Score = 6,
                   Survey = "good",
                   StudentId = 1,
                   ExamId = 1,
               },
               new StudentDoExam
               {
                   Id = 2,
                   DateDoExam = DateTime.Now,
                   Score = 8,
                   Survey = "good",
                   StudentId = 1,
                   ExamId = 2,
               },
               new StudentDoExam
               {
                   Id = 3,
                   DateDoExam = DateTime.Now,
                   Score = 7,
                   Survey = "good",
                   StudentId = 1,
                   ExamId = 3,
               });




        }
    }
}
