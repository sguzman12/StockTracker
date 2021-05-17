using Microsoft.EntityFrameworkCore;
using StockTrackerAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackerAPI.Contexts
{
    public class StockInfoContext : DbContext
    {
        public DbSet<Stock> Stocks { get; set; }

        public StockInfoContext(DbContextOptions<StockInfoContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
