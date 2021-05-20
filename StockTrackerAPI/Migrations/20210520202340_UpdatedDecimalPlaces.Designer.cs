﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockTrackerAPI.Contexts;

namespace StockTrackerAPI.Migrations
{
    [DbContext(typeof(StockInfoContext))]
    [Migration("20210520202340_UpdatedDecimalPlaces")]
    partial class UpdatedDecimalPlaces
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("StockTrackerAPI.Entities.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AlphaCode")
                        .IsRequired()
                        .HasColumnType("varchar(6) CHARACTER SET utf8mb4")
                        .HasMaxLength(6);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("closingPrice")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("url")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Stocks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlphaCode = "FGZMX",
                            Name = "Guzman Inc",
                            Price = 136.41m,
                            closingPrice = 178.24m,
                            url = "https://www.nasdaq.com/market-activity/funds-and-etfs/fgzmx"
                        },
                        new
                        {
                            Id = 2,
                            AlphaCode = "GOOGL",
                            Name = "Google",
                            Price = 3343.31m,
                            closingPrice = 2000.50m,
                            url = "https://www.nasdaq.com/market-activity/stocks/goog"
                        },
                        new
                        {
                            Id = 3,
                            AlphaCode = "AMZN",
                            Name = "Amazon",
                            Price = 287.81m,
                            closingPrice = 250.00m,
                            url = "https://www.nasdaq.com/market-activity/stocks/amzn"
                        },
                        new
                        {
                            Id = 4,
                            AlphaCode = "WMT",
                            Name = "Walmart Inc",
                            Price = 14.81m,
                            closingPrice = 14.60m,
                            url = "https://www.nasdaq.com/market-activity/stocks/wmt"
                        },
                        new
                        {
                            Id = 5,
                            AlphaCode = "AMD",
                            Name = "Advanced Micro Devices, Inc.",
                            Price = 14.64m,
                            closingPrice = 10.25m,
                            url = "https://www.nasdaq.com/market-activity/stocks/amd"
                        },
                        new
                        {
                            Id = 6,
                            AlphaCode = "ZNGA",
                            Name = "Zynga Inc.",
                            Price = 10.70m,
                            closingPrice = 8.62m,
                            url = "https://www.nasdaq.com/market-activity/stocks/znga"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
