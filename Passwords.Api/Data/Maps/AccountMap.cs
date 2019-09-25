using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Passwords.Api.Entities;

namespace Passwords.Api.Data.Maps
{
    public class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");

            builder.HasKey(a => a.AccountId);

            builder.Property(a => a.Service).HasColumnType("nvarchar(80)").IsRequired();

            //builder.HasMany(a => a.Contents)
            //    .WithOne(a => a.Account)
            //    .HasForeignKey(a => a.AccountId);
                //.OnDelete(DeleteBehavior.Restrict);
        }
    }
}
