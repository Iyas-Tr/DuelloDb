﻿// <auto-generated />
using Duello.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Duello.Migrations
{
    [DbContext(typeof(BudgetDatabase))]
    [Migration("20210428185543_Update")]
    partial class Update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Duello.Budget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("JumlahUang")
                        .HasColumnType("float");

                    b.Property<string>("NamaBudget")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Budgets");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Budget");
                });

            modelBuilder.Entity("Duello.Expense", b =>
                {
                    b.HasBaseType("Duello.Budget");

                    b.HasDiscriminator().HasValue("Expense");
                });

            modelBuilder.Entity("Duello.Income", b =>
                {
                    b.HasBaseType("Duello.Budget");

                    b.HasDiscriminator().HasValue("Income");
                });
#pragma warning restore 612, 618
        }
    }
}
