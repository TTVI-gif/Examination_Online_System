using ExaminationOnlineSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExaminationOnlineSystem.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.BirthDay).IsRequired().HasMaxLength(30);
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Role).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Salt).IsRequired().HasMaxLength(200);
        }
    }
}
