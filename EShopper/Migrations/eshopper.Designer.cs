﻿// <auto-generated />
using EShopper.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EShopper.Migrations
{
    [DbContext(typeof(EShopperContext))]
    [Migration("EShopper")]
    partial class EShopper
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EShopper.Models.Vegetables", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vegetables");
                });

            modelBuilder.Entity("EShopper.Models.Seeds", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("NumberOfPacket")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Address")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Kg")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");
                
                b.Property<string>("VegetableId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Seeds");
            });

            modelBuilder.Entity("EShopper.Models.Fruits", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Kg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fruits");
                });

            modelBuilder.Entity("EShopper.Models.Vegetables", b =>
            {
                b.HasOne("EShopper.Models.Seeds", "Seeds")
                    .WithMany()
                    .HasForeignKey("VegetableId");
            });

#pragma warning restore 612, 618
        }
    }
}