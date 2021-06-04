using StockTrackerAPI.Contexts;
using StockTrackerAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackerAPI.Services
{
    public class StockInfoRepository : IStockInfoRepository
    {

        private readonly StockInfoContext context;

        public StockInfoRepository(StockInfoContext context)
        {
            this.context = context;
        }

        public Stock GetStock(long stockId)
        {
            return context.Stocks.Where(s => s.Id == stockId).FirstOrDefault();
        }

        public IEnumerable<Stock> GetStocks()
        {
            return context.Stocks.OrderBy(s => s.Name).ToList();
        }
    }
}
