using ExaminationOnlineSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExaminationOnlineSystem.Configuration
{
    public class StudentDoExamConfiguration : IEntityTypeConfiguration<StudentDoExam>
    {
        public void Configure(EntityTypeBuilder<StudentDoExam> builder)
        {
            builder.ToTable("StudentDoExam");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DateDoExam).IsRequired();
            builder.Property(x => x.Score).IsRequired();
            builder.Property(x => x.Survey).IsRequired();
            builder.HasOne(s => s.Student).WithMany(std => std.StudentDoExams).HasForeignKey(x => x.StudentId);
        }
    }
}
