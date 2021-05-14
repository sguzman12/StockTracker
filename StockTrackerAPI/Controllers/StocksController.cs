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
        //[Produces("application/json", "application/xml")]
        public IActionResult GetStocks()
        {
            return Ok(StockDataStore.Current.Stocks);

        }

        [HttpGet("{id}")]
        //[Produces("application/json", "application/xml")]
        public IActionResult GetStock(long id)
        {
            var stock = StockDataStore.Current.Stocks.FirstOrDefault(s => s.Id == id);
            if (stock == null)
            {
                return NotFound();
            }

            return Ok(stock);

        }
    }
}
