﻿// <auto-generated />
using System;
using BitBrushAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BitBrushAPI.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20240327190808_DBInit")]
    partial class DBInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BitBrushAPI.Data.Collection", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("creatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("creatorId");

                    b.ToTable("tblCollection", (string)null);
                });

            modelBuilder.Entity("BitBrushAPI.Data.Maillist", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tblMaillist", (string)null);
                });

            modelBuilder.Entity("BitBrushAPI.Data.Product", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("collectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("creatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ownerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("sellingStatus")
                        .HasColumnType("bit");

                    b.Property<string>("thumbnailUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("collectionId");

                    b.HasIndex("creatorId");

                    b.HasIndex("ownerId");

                    b.ToTable("tblProduct", (string)null);
                });

            modelBuilder.Entity("BitBrushAPI.Data.ProductTag", b =>
                {
                    b.Property<Guid>("productId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("tagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("productId", "tagId");

                    b.HasIndex("tagId");

                    b.ToTable("tblProductTag", (string)null);
                });

            modelBuilder.Entity("BitBrushAPI.Data.Tag", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tblTag", (string)null);
                });

            modelBuilder.Entity("BitBrushAPI.Data.Transaction", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("buyerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("hash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("productId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("sellerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("time")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("buyerId");

                    b.HasIndex("productId");

                    b.HasIndex("sellerId");

                    b.ToTable("tblTransaction", (string)null);
                });

            modelBuilder.Entity("BitBrushAPI.Data.User", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<DateTime>("joinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("id");

                    b.ToTable("tblUser", (string)null);
                });

            modelBuilder.Entity("BitBrushAPI.Data.UserAccount", b =>
                {
                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("walletId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("tblUserAccount", (string)null);
                });

            modelBuilder.Entity("BitBrushAPI.Data.Collection", b =>
                {
                    b.HasOne("BitBrushAPI.Data.User", "creator")
                        .WithMany()
                        .HasForeignKey("creatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("creator");
                });

            modelBuilder.Entity("BitBrushAPI.Data.Product", b =>
                {
                    b.HasOne("BitBrushAPI.Data.Collection", "collection")
                        .WithMany("products")
                        .HasForeignKey("collectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BitBrushAPI.Data.User", "creator")
                        .WithMany("createdProduct")
                        .HasForeignKey("creatorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("BitBrushAPI.Data.User", "owner")
                        .WithMany("ownedProduct")
                        .HasForeignKey("ownerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("collection");

                    b.Navigation("creator");

                    b.Navigation("owner");
                });

            modelBuilder.Entity("BitBrushAPI.Data.ProductTag", b =>
                {
                    b.HasOne("BitBrushAPI.Data.Product", "product")
                        .WithMany("tags")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BitBrushAPI.Data.Tag", "tag")
                        .WithMany("products")
                        .HasForeignKey("tagId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("tag");
                });

            modelBuilder.Entity("BitBrushAPI.Data.Transaction", b =>
                {
                    b.HasOne("BitBrushAPI.Data.User", "buyer")
                        .WithMany("transactions")
                        .HasForeignKey("buyerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BitBrushAPI.Data.Product", "product")
                        .WithMany("transactions")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BitBrushAPI.Data.User", "seller")
                        .WithMany()
                        .HasForeignKey("sellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("buyer");

                    b.Navigation("product");

                    b.Navigation("seller");
                });

            modelBuilder.Entity("BitBrushAPI.Data.UserAccount", b =>
                {
                    b.HasOne("BitBrushAPI.Data.User", "user")
                        .WithOne("userAccount")
                        .HasForeignKey("BitBrushAPI.Data.UserAccount", "userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("BitBrushAPI.Data.Collection", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("BitBrushAPI.Data.Product", b =>
                {
                    b.Navigation("tags");

                    b.Navigation("transactions");
                });

            modelBuilder.Entity("BitBrushAPI.Data.Tag", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("BitBrushAPI.Data.User", b =>
                {
                    b.Navigation("createdProduct");

                    b.Navigation("ownedProduct");

                    b.Navigation("transactions");

                    b.Navigation("userAccount")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
