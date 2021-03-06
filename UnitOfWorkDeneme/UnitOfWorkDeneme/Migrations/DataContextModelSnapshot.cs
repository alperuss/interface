﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnitOfWorkDeneme;

namespace UnitOfWorkDeneme.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UnitOfWorkDeneme.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Description");

                    b.Property<byte[]>("Image");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasMaxLength(24);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.CustomerCustomerDemo", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasMaxLength(5);

                    b.Property<string>("CustomerTypeId")
                        .HasMaxLength(10);

                    b.HasKey("CustomerId", "CustomerTypeId");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.HasIndex("CustomerTypeId")
                        .IsUnique();

                    b.ToTable("CustomerCustomerDemos");
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.CustomerDemographic", b =>
                {
                    b.Property<string>("CustomerTypeId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("CustomerDesc");

                    b.HasKey("CustomerTypeId");

                    b.ToTable("CustomerDemographics");
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasMaxLength(4);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<DateTime>("HireDate");

                    b.Property<string>("HomePhone")
                        .IsRequired()
                        .HasMaxLength(24);

                    b.Property<byte[]>("Image");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Notes");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<int?>("ReportsTo");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("TitleOfCourtesy")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.HasIndex("ReportsTo");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.EmployeeTerritory", b =>
                {
                    b.Property<string>("TerritoryId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20);

                    b.Property<int>("EmployeeId");

                    b.Property<string>("TerritoryId1");

                    b.HasKey("TerritoryId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TerritoryId1");

                    b.ToTable("EmployeeTerritories");
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerId");

                    b.Property<int>("EmployeeId")
                        .HasMaxLength(5);

                    b.Property<decimal>("Freight");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("OrderDetailId");

                    b.Property<DateTime>("RequiredDate");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("ShipCity")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("ShipCountry")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ShipPostalCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("ShipRegion")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<int>("ShipVia");

                    b.Property<DateTime>("ShippedDate");

                    b.Property<int>("ShipperId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("OrderDetailId");

                    b.HasIndex("ShipperId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Discount");

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<short>("Quantity");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<bool>("Discontinued");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("QuantityPerUnit")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<short>("ReorderLevel");

                    b.Property<int>("SupplierId");

                    b.Property<decimal>("UnitPrice");

                    b.Property<short>("UnitsInStock");

                    b.Property<short>("UnitsOnOrder");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RegionDescription")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.Shipper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(24);

                    b.HasKey("Id");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasMaxLength(24);

                    b.Property<string>("HomePage");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.Territory", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20);

                    b.Property<int>("RegionId");

                    b.Property<string>("TerritoryDescription")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Territories");
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.CustomerCustomerDemo", b =>
                {
                    b.HasOne("UnitOfWorkDeneme.Models.Customer", "Customer")
                        .WithOne("CustomerCustomerDemo")
                        .HasForeignKey("UnitOfWorkDeneme.Models.CustomerCustomerDemo", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UnitOfWorkDeneme.Models.CustomerDemographic", "CustomerDemographic")
                        .WithOne("CustomerCustomerDemo")
                        .HasForeignKey("UnitOfWorkDeneme.Models.CustomerCustomerDemo", "CustomerTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.Employee", b =>
                {
                    b.HasOne("UnitOfWorkDeneme.Models.Employee", "ReportsToEmployee")
                        .WithMany()
                        .HasForeignKey("ReportsTo");
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.EmployeeTerritory", b =>
                {
                    b.HasOne("UnitOfWorkDeneme.Models.Employee", "Employee")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UnitOfWorkDeneme.Models.Territory", "Territory")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("TerritoryId1");
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.Order", b =>
                {
                    b.HasOne("UnitOfWorkDeneme.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("UnitOfWorkDeneme.Models.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UnitOfWorkDeneme.Models.OrderDetail", "OrderDetail")
                        .WithMany("Orders")
                        .HasForeignKey("OrderDetailId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UnitOfWorkDeneme.Models.Shipper", "Shipper")
                        .WithMany("Orders")
                        .HasForeignKey("ShipperId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.OrderDetail", b =>
                {
                    b.HasOne("UnitOfWorkDeneme.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.Product", b =>
                {
                    b.HasOne("UnitOfWorkDeneme.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UnitOfWorkDeneme.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UnitOfWorkDeneme.Models.Territory", b =>
                {
                    b.HasOne("UnitOfWorkDeneme.Models.Region", "Region")
                        .WithMany("Territories")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
