﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YoloViewModel;

#nullable disable

namespace YoloViewModel.Migrations
{
    [DbContext(typeof(ImageLibrary))]
    [Migration("20231108153045_Ids")]
    partial class Ids
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("YoloViewModel.StoredImage", b =>
                {
                    b.Property<string>("sourcePath")
                        .HasColumnType("TEXT");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("ImageData")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<double>("confidence")
                        .HasColumnType("REAL");

                    b.Property<string>("detectedClass")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("sourcePath");

                    b.ToTable("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
