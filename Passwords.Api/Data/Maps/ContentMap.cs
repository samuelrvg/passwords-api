using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Passwords.Api.Entities;

namespace Passwords.Api.Data.Maps
{
    public class ContentMap : IEntityTypeConfiguration<Content>
    {
        public void Configure(EntityTypeBuilder<Content> builder)
        {
            builder.ToTable("Content");

            builder.HasKey(c => c.ContentId);

            builder.Property(c => c.Login).HasColumnType("nvarchar(80)").IsRequired();
            builder.Property(c => c.Password).HasColumnType("nvarchar(80)").IsRequired();
            builder.Property(c => c.Cpf).HasColumnType("nvarchar(11)");
            builder.Property(c => c.Observacao).HasColumnType("nvarchar(800)");

            //builder.HasOne(c => c.Account)
                //.WithMany(c => c.Contents)
                //.HasForeignKey(e => e.ContentId);
        }
    }
}
