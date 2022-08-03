using ExaminationOnlineSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Configuration
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Question");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Content).IsRequired();
            // builder.HasOne(x => x.Exam).WithMany(q => q.GetQuestions).HasForeignKey(x => x.ExamId);
        }
    }
}
