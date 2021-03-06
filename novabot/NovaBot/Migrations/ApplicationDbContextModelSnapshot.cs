﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NovaBot.Data;
using NovaBot.Models;

namespace NovaBot.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NovaBot.Models.QuoteModel", b =>
                {
                    b.Property<string>("QuoteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTimeOffset>("Date");

                    b.Property<long>("Downvotes");

                    b.Property<long>("Upvotes");

                    b.Property<string>("UserId");

                    b.HasKey("QuoteId");

                    b.HasIndex("UserId");

                    b.ToTable("Quote");
                });

            modelBuilder.Entity("NovaBot.Models.UserModel", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ProfilePicture")
                        .HasMaxLength(500);

                    b.Property<long>("Ranking");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("NovaBot.Models.QuoteModel", b =>
                {
                    b.HasOne("NovaBot.Models.UserModel", "User")
                        .WithMany("Quotes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
