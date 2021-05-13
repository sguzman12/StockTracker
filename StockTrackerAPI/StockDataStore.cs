using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackerAPI.Models
{
    public class StockDataStore
    {
        public static StockDataStore Current { get; } = new StockDataStore();
        public List<StockDto> Stocks { get; set; }

        public StockDataStore() 
        {
            // init dummy data
            Stocks = new List<StockDto>()
            {
                new StockDto() { Id = 1, AlphaCode = "GOOG", Name = "Google", Price = 122.45M},
                new StockDto() { Id = 2, AlphaCode = "APPE", Name = "Apple", Price = 1066.65M},
                new StockDto() { Id = 3, AlphaCode = "GE",   Name = "GE", Price = 45.22M},
                new StockDto() { Id = 4, AlphaCode = "TYTA",   Name = "Toyota", Price = 1233.78M},
                new StockDto() { Id = 5, AlphaCode = "VZE",   Name = "Verizon", Price = 3662.34M},
            };
        }
    }
}
