﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniProj.Data;

#nullable disable

namespace UniProj.Migrations
{
    [DbContext(typeof(WebShopContext))]
    partial class WebShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("UniProj.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("UniProj.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("UniProj.Models.CategoryProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("IdCategory")
                        .HasColumnType("int");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("CategoryProduct", (string)null);
                });

            modelBuilder.Entity("UniProj.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NrPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("UniProj.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("IdAddress")
                        .HasColumnType("int");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("IdWorker")
                        .HasColumnType("int");

                    b.Property<string>("OrderDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ClientId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("UniProj.Models.OrderProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdOrder")
                        .HasColumnType("int");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProduct", (string)null);
                });

            modelBuilder.Entity("UniProj.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Position", (string)null);
                });

            modelBuilder.Entity("UniProj.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("UniProj.Models.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPosition")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdPosition");

                    b.ToTable("Worker", (string)null);
                });

            modelBuilder.Entity("UniProj.Models.CategoryProduct", b =>
                {
                    b.HasOne("UniProj.Models.Category", "Category")
                        .WithMany("CategorieProducts")
                        .HasForeignKey("CategoryId");

                    b.HasOne("UniProj.Models.Product", "Product")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("ProductId");

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("UniProj.Models.Order", b =>
                {
                    b.HasOne("UniProj.Models.Address", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("AddressId");

                    b.HasOne("UniProj.Models.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId");

                    b.HasOne("UniProj.Models.Worker", "Worker")
                        .WithMany("Orders")
                        .HasForeignKey("WorkerId");

                    b.Navigation("Address");

                    b.Navigation("Client");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("UniProj.Models.OrderProduct", b =>
                {
                    b.HasOne("UniProj.Models.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId");

                    b.HasOne("UniProj.Models.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("UniProj.Models.Worker", b =>
                {
                    b.HasOne("UniProj.Models.Position", "Position")
                        .WithMany("Workers")
                        .HasForeignKey("IdPosition")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Position");
                });

            modelBuilder.Entity("UniProj.Models.Address", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("UniProj.Models.Category", b =>
                {
                    b.Navigation("CategorieProducts");
                });

            modelBuilder.Entity("UniProj.Models.Client", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("UniProj.Models.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("UniProj.Models.Position", b =>
                {
                    b.Navigation("Workers");
                });

            modelBuilder.Entity("UniProj.Models.Product", b =>
                {
                    b.Navigation("CategoryProducts");

                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("UniProj.Models.Worker", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}