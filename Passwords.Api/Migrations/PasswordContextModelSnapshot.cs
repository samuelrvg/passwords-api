﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Passwords.Api.Data.Context;

namespace Passwords.Api.Migrations
{
    [DbContext(typeof(PasswordContext))]
    partial class PasswordContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Passwords.Api.Entities.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Service")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("AccountId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Passwords.Api.Entities.Content", b =>
                {
                    b.Property<int>("ContentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(800)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("ContentId");

                    b.HasIndex("AccountId");

                    b.ToTable("Content");
                });

            modelBuilder.Entity("Passwords.Api.Entities.Content", b =>
                {
                    b.HasOne("Passwords.Api.Entities.Account", "Account")
                        .WithMany("Contents")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
