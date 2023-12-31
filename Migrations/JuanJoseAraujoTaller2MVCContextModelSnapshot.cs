﻿// <auto-generated />
using System;
using JuanJoseAraujoTaller2MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JuanJoseAraujoTaller2MVC.Migrations
{
    [DbContext(typeof(JuanJoseAraujoTaller2MVCContext))]
    partial class JuanJoseAraujoTaller2MVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JuanJoseAraujoTaller2MVC.Models.Burger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("WithCheese")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Burger");
                });

            modelBuilder.Entity("JuanJoseAraujoTaller2MVC.Models.Promo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BurgerId")
                        .HasColumnType("int");

                    b.Property<int>("PromoId")
                        .HasColumnType("int");

                    b.Property<string>("PromoName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BurgerId");

                    b.ToTable("Promo");
                });

            modelBuilder.Entity("JuanJoseAraujoTaller2MVC.Models.Promo", b =>
                {
                    b.HasOne("JuanJoseAraujoTaller2MVC.Models.Burger", "Burger")
                        .WithMany("Promo")
                        .HasForeignKey("BurgerId");

                    b.Navigation("Burger");
                });

            modelBuilder.Entity("JuanJoseAraujoTaller2MVC.Models.Burger", b =>
                {
                    b.Navigation("Promo");
                });
#pragma warning restore 612, 618
        }
    }
}
