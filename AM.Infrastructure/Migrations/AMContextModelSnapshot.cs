﻿// <auto-generated />
using System;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    [DbContext(typeof(AMContext))]
    partial class AMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AM.ApplicationCore.Domain.Bouquet", b =>
                {
                    b.Property<int>("BouquetCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BouquetCode"), 1L, 1);

                    b.Property<string>("AccompagningMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BouquetType")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("date");

                    b.Property<string>("CustomerCIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BouquetCode");

                    b.HasIndex("CustomerCIN");

                    b.ToTable("Bouquets");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Customer", b =>
                {
                    b.Property<string>("CIN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmailAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("CIN");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Flower", b =>
                {
                    b.Property<int>("FlowerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlowerId"), 1L, 1);

                    b.Property<int>("BouquetFK")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("FlowerId");

                    b.HasIndex("BouquetFK");

                    b.ToTable("Flowers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Flower");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.ArtificialFlower", b =>
                {
                    b.HasBaseType("AM.ApplicationCore.Domain.Flower");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("date");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ArtificialFlower");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.NaturalFlower", b =>
                {
                    b.HasBaseType("AM.ApplicationCore.Domain.Flower");

                    b.Property<string>("Origine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Savage")
                        .HasColumnType("bit");

                    b.Property<int>("Season")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("NaturalFlower");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Bouquet", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Customer", "Customer")
                        .WithMany("Bouquets")
                        .HasForeignKey("CustomerCIN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Flower", b =>
                {
                    b.HasOne("AM.ApplicationCore.Domain.Bouquet", "Bouquet")
                        .WithMany("Flowers")
                        .HasForeignKey("BouquetFK")
                        .IsRequired();

                    b.Navigation("Bouquet");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Bouquet", b =>
                {
                    b.Navigation("Flowers");
                });

            modelBuilder.Entity("AM.ApplicationCore.Domain.Customer", b =>
                {
                    b.Navigation("Bouquets");
                });
#pragma warning restore 612, 618
        }
    }
}
