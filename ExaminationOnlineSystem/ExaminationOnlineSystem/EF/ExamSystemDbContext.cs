using ExaminationOnlineSystem.Configuration;
using ExaminationOnlineSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.EF
{
    public class ExamSystemDbContext : DbContext, IExamSystemDbContext
    {
        public ExamSystemDbContext(DbContextOptions<ExamSystemDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new StudentDoExamConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionRecordConfiguration());
            modelBuilder.ApplyConfiguration(new ExamConfiguration());
            modelBuilder.ApplyConfiguration(new AnswerConfiguration());

            //seeding data
            modelBuilder.Seed();
        }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        DbSet<User> Users { get; set; }
        DbSet<StudentDoExam> StudentDoExams { get; set; }
        DbSet<QuestionRecord> QuestionRecords { get; set; }
        DbSet<Question> Questions { get; set; }
        DbSet<Exam> Exams { get; set; }
        DbSet<Answer> Answers { get; set; }
    }
}
