using Microsoft.EntityFrameworkCore;
using StockTrackerAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackerAPI.Contexts
{
    /**
     * Stock Entity Database Binding class. 
     * */
    public class StockInfoContext : DbContext
    {
        public DbSet<Stock> Stocks { get; set; }

        public StockInfoContext(DbContextOptions<StockInfoContext> options)
            : base(options)
        {
           // Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>()
                .HasData(new Stock() //Dummy Data
                {
                    Id = 1,
                    AlphaCode = "FGZMX",
                    Name = "Guzman Inc",
                    Price = 136.41M,
                    ClosingPrice = 178.24M,
                    Url = "https://www.nasdaq.com/market-activity/funds-and-etfs/fgzmx"
                },
                new Stock()
                {
                    Id = 2,
                    AlphaCode = "GOOGL",
                    Name = "Google",
                    Price = 3343.31M,
                    ClosingPrice = 2000.50M,
                    Url = "https://www.nasdaq.com/market-activity/stocks/goog"
                },
                new Stock()
                {
                    Id = 3,
                    AlphaCode = "AMZN",
                    Name = "Amazon",
                    Price = 287.81M,
                    ClosingPrice = 250.00M,
                    Url = "https://www.nasdaq.com/market-activity/stocks/amzn"
                },
                new Stock()
                {
                    Id = 4,
                    AlphaCode = "WMT",
                    Name = "Walmart Inc",
                    Price = 14.81M,
                    ClosingPrice = 14.60M,
                    Url = "https://www.nasdaq.com/market-activity/stocks/wmt"
                },
                new Stock()
                {
                    Id = 5,
                    AlphaCode = "AMD",
                    Name = "Advanced Micro Devices, Inc.",
                    Price = 14.64M,
                    ClosingPrice = 10.25M,
                    Url = "https://www.nasdaq.com/market-activity/stocks/amd"
                },
                new Stock()
                {
                    Id = 6,
                    AlphaCode = "ZNGA",
                    Name = "Zynga Inc.",
                    Price = 10.70M,
                    ClosingPrice = 8.62M,
                    Url = "https://www.nasdaq.com/market-activity/stocks/znga"
                });
                
                
            base.OnModelCreating(modelBuilder);
        }


    }
}
