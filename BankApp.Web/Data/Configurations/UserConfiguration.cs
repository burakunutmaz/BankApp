using Microsoft.EntityFrameworkCore;
using BankApp.Web.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BankApp.Web.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.Surname).HasMaxLength(100);
            builder.Property(x => x.Surname).IsRequired();

            builder.HasMany(x => x.Accounts).WithOne(x => x.user).HasForeignKey(x => x.UserId);
        }
    }
}
