using Microsoft.AspNetCore.Mvc;
using StockTrackerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackerAPI.Controllers
{
    [ApiController]
    [Route("api/stocks")]
    public class StocksController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStocks()
        {
            return Ok(StockDataStore.Current.Stocks);

        }

        [HttpGet("{id}", Name = "GetStock")]
        public IActionResult GetStock(long id)
        {
            var stock = StockDataStore.Current.Stocks.FirstOrDefault(s => s.Id == id);
            if (stock == null)
            {
                return NotFound();
            }

            return Ok(stock);

        }

        [HttpPost]
        public IActionResult CreateStock(StockCreationDto stock)
        {
            if (stock == null)
            {
                return NotFound();
            }
            // InMemory Only 
            var nextID = StockDataStore.Current.Stocks.Count();
            
            var newStock = new StockDto()
            {
                Id = ++nextID,
                AlphaCode = stock.AlphaCode,
                Name = stock.Name,
                Price = stock.Price
            };

            StockDataStore.Current.Stocks.Add(newStock);

            return CreatedAtRoute("GetStock", new { id = newStock.Id }, newStock);
        }
    }
}
