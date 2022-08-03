using ExaminationOnlineSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExaminationOnlineSystem.Configuration
{
    public class QuestionRecordConfiguration : IEntityTypeConfiguration<QuestionRecord>
    {
        public void Configure(EntityTypeBuilder<QuestionRecord> builder)
        {
            builder.ToTable("QuestionRecord");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.A).IsRequired();
            builder.Property(x => x.B).IsRequired();
            builder.Property(x => x.C).IsRequired();
            builder.Property(x => x.D).IsRequired();
        }
    }
}
