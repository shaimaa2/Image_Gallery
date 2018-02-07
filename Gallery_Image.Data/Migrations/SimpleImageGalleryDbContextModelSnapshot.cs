﻿// <auto-generated />
using Gallery_Image.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Gallery_Image.Data.Migrations
{
    [DbContext(typeof(SimpleImageGalleryDbContext))]
    partial class SimpleImageGalleryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gallery_Image.Data.Model.GalleryImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Title");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.ToTable("GalleryImages");
                });

            modelBuilder.Entity("Gallery_Image.Data.Model.ImageTag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("GalleryImageId");

                    b.HasKey("ID");

                    b.HasIndex("GalleryImageId");

                    b.ToTable("ImageTags");
                });

            modelBuilder.Entity("Gallery_Image.Data.Model.ImageTag", b =>
                {
                    b.HasOne("Gallery_Image.Data.Model.GalleryImage")
                        .WithMany("Tags")
                        .HasForeignKey("GalleryImageId");
                });
#pragma warning restore 612, 618
        }
    }
}
