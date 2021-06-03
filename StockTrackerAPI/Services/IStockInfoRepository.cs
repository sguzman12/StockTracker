using StockTrackerAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackerAPI.Services
{
    /**
     * Used for implementation of the Repository Pattern
     * */
    public interface IStockInfoRepository
    {
        //Can also be IQueryable. Depends on the type of API built. Pros and Cons for both.
        IEnumerable<Stock> GetStocks();

        Stock GetStock(int stockId);

    }
}
