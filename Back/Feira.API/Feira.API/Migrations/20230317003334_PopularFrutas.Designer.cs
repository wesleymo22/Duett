﻿// <auto-generated />
using Feira.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Feira.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230317003334_PopularFrutas")]
    partial class PopularFrutas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Feira.API.Models.Frutas", b =>
                {
                    b.Property<int>("FrutaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FrutaId"), 1L, 1);

                    b.Property<string>("Fruta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ValorA")
                        .HasColumnType("int");

                    b.Property<int>("ValorB")
                        .HasColumnType("int");

                    b.HasKey("FrutaId");

                    b.ToTable("Frutas");
                });
#pragma warning restore 612, 618
        }
    }
}
