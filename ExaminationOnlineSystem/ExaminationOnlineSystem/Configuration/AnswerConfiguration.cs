using ExaminationOnlineSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExaminationOnlineSystem.Configuration
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.ToTable("Answer");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.IsRight).IsRequired();
            // builder.HasOne(x => x.Question).WithMany(aw => aw.Answers).HasForeignKey(x => x.QuestionId);
        }
    }
}
