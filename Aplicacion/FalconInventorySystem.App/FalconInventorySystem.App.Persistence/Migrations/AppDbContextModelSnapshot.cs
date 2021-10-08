﻿// <auto-generated />
using System;
using FalconInventorySystem.App.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FalconInventorySystem.App.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.BillOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Client")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("OrderCreationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BillOrders");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.BillOrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("BillOrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BillOrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StateId");

                    b.ToTable("BillOrderItems");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.ItemTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("BillOrderItemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observation")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("PurchaseOrderItemId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WarehouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BillOrderItemId");

                    b.HasIndex("PurchaseOrderItemId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("ItemTransactions");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.PurchaseOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumberOrder")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("OrderCreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<double>("Tax")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("PurchaseOrders");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.PurchaseOrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("PurchaseOrderId")
                        .HasColumnType("int");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<double>("UnitValue")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("PurchaseOrderId");

                    b.HasIndex("StateId");

                    b.ToTable("PurchaseOrderItems");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("MaximumCapacity")
                        .HasColumnType("float");

                    b.Property<double>("MinimumCapacity")
                        .HasColumnType("float");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.BillOrderItem", b =>
                {
                    b.HasOne("FalconInventorySystem.App.Domain.Entities.BillOrder", "BillOrder")
                        .WithMany("BillOrderItems")
                        .HasForeignKey("BillOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FalconInventorySystem.App.Domain.Entities.Product", "Product")
                        .WithMany("BillOrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FalconInventorySystem.App.Domain.Entities.State", "State")
                        .WithMany("BillOrderItems")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BillOrder");

                    b.Navigation("Product");

                    b.Navigation("State");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.ItemTransaction", b =>
                {
                    b.HasOne("FalconInventorySystem.App.Domain.Entities.BillOrderItem", "BillOrderItem")
                        .WithMany("ItemTransactions")
                        .HasForeignKey("BillOrderItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FalconInventorySystem.App.Domain.Entities.PurchaseOrderItem", "PurchaseOrderItem")
                        .WithMany("ItemTransactions")
                        .HasForeignKey("PurchaseOrderItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FalconInventorySystem.App.Domain.Entities.Warehouse", "Warehouse")
                        .WithMany("ItemTransactions")
                        .HasForeignKey("WarehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BillOrderItem");

                    b.Navigation("PurchaseOrderItem");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.Product", b =>
                {
                    b.HasOne("FalconInventorySystem.App.Domain.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FalconInventorySystem.App.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.PurchaseOrder", b =>
                {
                    b.HasOne("FalconInventorySystem.App.Domain.Entities.Supplier", "Supplier")
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.PurchaseOrderItem", b =>
                {
                    b.HasOne("FalconInventorySystem.App.Domain.Entities.Product", "Product")
                        .WithMany("PurchaseOrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FalconInventorySystem.App.Domain.Entities.PurchaseOrder", "PurchaseOrder")
                        .WithMany("PurchaseOrderItems")
                        .HasForeignKey("PurchaseOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FalconInventorySystem.App.Domain.Entities.State", "State")
                        .WithMany("PurchaseOrderItems")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("PurchaseOrder");

                    b.Navigation("State");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.BillOrder", b =>
                {
                    b.Navigation("BillOrderItems");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.BillOrderItem", b =>
                {
                    b.Navigation("ItemTransactions");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.Product", b =>
                {
                    b.Navigation("BillOrderItems");

                    b.Navigation("PurchaseOrderItems");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.PurchaseOrder", b =>
                {
                    b.Navigation("PurchaseOrderItems");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.PurchaseOrderItem", b =>
                {
                    b.Navigation("ItemTransactions");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.State", b =>
                {
                    b.Navigation("BillOrderItems");

                    b.Navigation("PurchaseOrderItems");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.Supplier", b =>
                {
                    b.Navigation("PurchaseOrders");
                });

            modelBuilder.Entity("FalconInventorySystem.App.Domain.Entities.Warehouse", b =>
                {
                    b.Navigation("ItemTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
